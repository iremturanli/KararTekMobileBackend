using Karartek.Business.Abstract;
using Karartek.Business.Concrete;
using Karartek.DataAccess.Abstract;
using Karartek.DataAccess.Concrete.EntityFramework;


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

var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();

//eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTUxMiIsInR5cCI6IkpXVCJ9.eyJleHAiOjE2NjU5MzE5ODF9.uM6k5FgBb-WuQkowtcCr117x3RcauM5kZSE7FrpMLBhqD4ctuagCOGa_MvoKlKM_CFauR-6f22FApeSesaQnSA