using System.Text;
using Karartek.Business.Abstract;
using Karartek.Business.Concrete;
using Karartek.DataAccess.Abstract;
using Karartek.DataAccess.Concrete;
using Karartek.DataAccess.Concrete.EntityFramework;
using Karartek.DataAccess.Concrete.EntityFramework.Context;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Filters;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IUserService, UserService>();
builder.Services.AddSingleton<IUserDal, EfUserDal>();
builder.Services.AddSingleton<IJudgmentService, JudgmentService>();
builder.Services.AddSingleton<IJudgmentDal, EfJudgmentDal>();
builder.Services.AddSingleton<IUserTypeService, UserTypeService>();
builder.Services.AddSingleton<IUserTypeDal, EfUserTypeDal>();
builder.Services.AddSingleton<IJudgmentPoolDal, EfJudgmentPoolDal>();
builder.Services.AddSingleton<IJudgmentPoolService, JudgmentPoolService>();
builder.Services.AddSingleton<ILawyerDal, EfLawyerDal>();
builder.Services.AddSingleton<IStudentDal, EfStudentDal>();
builder.Services.AddSingleton<IJudgmentTypeService, JudgmentTypeService>();
builder.Services.AddSingleton<IJudgmentTypeDal, EfJudgmentTypeDal>();
builder.Services.AddSingleton<ISearchTypeService, SearchTypeService>();
builder.Services.AddSingleton<ISearchTypeDal, EfSearchTypeDal>();
builder.Services.AddSingleton<ILawyerJudgmentService, LawyerJudgmentService>();
builder.Services.AddSingleton<ILawyerJudgmentDal, EfLawyerJudgmentDal>();
builder.Services.AddSingleton<ILawyerJudgmentStateDal, EfLawyerJudgmentStateDal>();
builder.Services.AddSingleton<ILawyerJudgmentStateService, LawyerJudgmentStateService>();
builder.Services.AddSingleton<ICityService,CityService>();
builder.Services.AddSingleton<ICityDal,EfCityDal>();
builder.Services.AddSingleton<IDistrictService, DistrictService>();
builder.Services.AddSingleton<IDistrictDal,EfDistrictDal>();
builder.Services.AddSingleton<ICommissionService, CommissionService>();
builder.Services.AddSingleton<ICommissionDal, EfCommissionDal>();
builder.Services.AddSingleton<ICourtService, CourtService>();
builder.Services.AddSingleton<ICourtDal, EfCourtDal>();
builder.Services.AddSingleton<IUserJudgmentStatisticDal, EfUserJudgmentStatisticDal>();
builder.Services.AddSingleton<IUserJudgmentStatisticService, UserJudgmentStatisticService>();
builder.Services.AddSingleton<IUserLikeDal, EfUserLikeDal>();
builder.Services.AddSingleton<IUserLikeService, UserLikeService>();


builder.Services.AddSwaggerGen(options => {
    options.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
    {
        Description = "Standard Authorization header using the Bearer scheme (\"Bearer {token}\")",
        In = ParameterLocation.Header,
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey
    });



    options.OperationFilter<SecurityRequirementsOperationFilter>();
});
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8
                .GetBytes(builder.Configuration.GetSection("AppSettings:Token").Value)),
            ValidateIssuer = false,
            ValidateAudience = false
        };
    });

var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthentication();
app.UseAuthorization();


app.MapControllers();

app.Run();

//eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTUxMiIsInR5cCI6IkpXVCJ9.eyJleHAiOjE2NjU5MzE5ODF9.uM6k5FgBb-WuQkowtcCr117x3RcauM5kZSE7FrpMLBhqD4ctuagCOGa_MvoKlKM_CFauR-6f22FApeSesaQnSA