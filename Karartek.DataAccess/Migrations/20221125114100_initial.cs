using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Karartek.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderIndex = table.Column<int>(type: "int", nullable: false),
                    PlateCode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Commisions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commisions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JudgmentTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeId = table.Column<int>(type: "int", nullable: false),
                    TypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JudgmentTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LawyerJudgmentState",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StateId = table.Column<int>(type: "int", nullable: false),
                    StateName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LawyerJudgmentState", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SearchTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeId = table.Column<int>(type: "int", nullable: false),
                    TypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SearchTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeId = table.Column<int>(type: "int", nullable: false),
                    TypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Districts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderIndex = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Districts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Districts_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Courts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommissionId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Courts_Commisions_CommissionId",
                        column: x => x.CommissionId,
                        principalTable: "Commisions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    UserTypeId = table.Column<int>(type: "int", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    DistrictId = table.Column<int>(type: "int", nullable: true),
                    IdentityNumber = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Users_Districts_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "Districts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Users_UserTypes_UserTypeId",
                        column: x => x.UserTypeId,
                        principalTable: "UserTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Judgments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JudgmentTypeId = table.Column<int>(type: "int", nullable: false),
                    CommissionId = table.Column<int>(type: "int", nullable: false),
                    CourtId = table.Column<int>(type: "int", nullable: false),
                    Decree = table.Column<string>(type: "nvarchar(max)", maxLength: 9999999, nullable: false),
                    DecreeType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MeritsYear = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MeritsNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DecreeYear = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DecreeNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Decision = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Likes = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Judgments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Judgments_Commisions_CommissionId",
                        column: x => x.CommissionId,
                        principalTable: "Commisions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Judgments_Courts_CourtId",
                        column: x => x.CourtId,
                        principalTable: "Courts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Judgments_JudgmentTypes_JudgmentTypeId",
                        column: x => x.JudgmentTypeId,
                        principalTable: "JudgmentTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LawyerJudgments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommissionId = table.Column<int>(type: "int", nullable: false),
                    CourtId = table.Column<int>(type: "int", nullable: false),
                    Decree = table.Column<string>(type: "nvarchar(max)", maxLength: 9999999, nullable: false),
                    LawyerAssessment = table.Column<string>(type: "nvarchar(max)", maxLength: 9999999, nullable: false),
                    DecreeType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MeritsYear = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MeritsNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DecreeYear = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DecreeNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Decision = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TBBComments = table.Column<string>(type: "nvarchar(max)", maxLength: 99999, nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    StateId = table.Column<int>(type: "int", nullable: false),
                    Likes = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LawyerJudgments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LawyerJudgments_Commisions_CommissionId",
                        column: x => x.CommissionId,
                        principalTable: "Commisions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LawyerJudgments_Courts_CourtId",
                        column: x => x.CourtId,
                        principalTable: "Courts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LawyerJudgments_LawyerJudgmentState_StateId",
                        column: x => x.StateId,
                        principalTable: "LawyerJudgmentState",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LawyerJudgments_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lawyers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    BarRegisterNo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lawyers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lawyers_Users_Id",
                        column: x => x.Id,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    University = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Faculty = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Grade = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    StudentNumber = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_Users_Id",
                        column: x => x.Id,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JudgmentPool",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    JudgmentId = table.Column<int>(type: "int", nullable: false),
                    SearchTypeId = table.Column<int>(type: "int", nullable: false),
                    LawyerJudgmentId = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JudgmentPool", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JudgmentPool_Judgments_JudgmentId",
                        column: x => x.JudgmentId,
                        principalTable: "Judgments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JudgmentPool_LawyerJudgments_LawyerJudgmentId",
                        column: x => x.LawyerJudgmentId,
                        principalTable: "LawyerJudgments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_JudgmentPool_SearchTypes_SearchTypeId",
                        column: x => x.SearchTypeId,
                        principalTable: "SearchTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JudgmentPool_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "Name", "OrderIndex", "PlateCode" },
                values: new object[,]
                {
                    { 1, "Adana", 1, "01" },
                    { 2, "Adıyaman", 2, "02" },
                    { 3, "Afyonkarahisar", 3, "03" },
                    { 4, "Ağrı", 4, "04" },
                    { 5, "Amasya", 5, "05" },
                    { 6, "Ankara", 6, "06" },
                    { 7, "Antalya", 7, "07" },
                    { 8, "Artvin", 8, "08" },
                    { 9, "Aydın", 9, "09" },
                    { 10, "Balıkesir", 10, "10" },
                    { 11, "Bilecik", 11, "11" },
                    { 12, "Bingöl", 12, "12" },
                    { 13, "Bitlis", 13, "13" },
                    { 14, "Bolu", 14, "14" },
                    { 15, "Burdur", 15, "15" },
                    { 16, "Bursa", 16, "16" },
                    { 17, "Çanakkale", 17, "17" },
                    { 18, "Çankırı", 18, "18" },
                    { 19, "Çorum", 19, "19" },
                    { 20, "Denizli", 20, "20" },
                    { 21, "Diyarbakır", 21, "21" },
                    { 22, "Edirne", 22, "22" },
                    { 23, "Elazığ", 23, "23" },
                    { 24, "Erzincan", 24, "24" },
                    { 25, "Erzurum", 25, "25" },
                    { 26, "Eskişehir", 26, "26" },
                    { 27, "Gaziantep", 27, "27" },
                    { 28, "Giresun", 28, "28" },
                    { 29, "Gümüşhane", 29, "29" },
                    { 30, "Hakkari", 30, "30" },
                    { 31, "Hatay", 31, "31" },
                    { 32, "Isparta", 32, "32" },
                    { 33, "Mersin", 33, "33" },
                    { 34, "İstanbul", 34, "34" },
                    { 35, "İzmir", 35, "35" },
                    { 36, "Kars", 36, "36" },
                    { 37, "Kastamonu", 37, "37" },
                    { 38, "Kayseri", 38, "38" },
                    { 39, "Kırklareli", 39, "39" },
                    { 40, "Kırşehir", 40, "40" },
                    { 41, "Kocaeli", 41, "41" },
                    { 42, "Konya", 42, "42" },
                    { 43, "Kütahya", 43, "43" },
                    { 44, "Malatya", 44, "44" },
                    { 45, "Manisa", 45, "45" },
                    { 46, "Kahramanmaraş", 46, "46" },
                    { 47, "Mardin", 47, "47" },
                    { 48, "Muğla", 48, "48" },
                    { 49, "Muş", 49, "49" },
                    { 50, "Nevşehir", 50, "50" },
                    { 51, "Niğde", 51, "51" },
                    { 52, "Ordu", 52, "52" },
                    { 53, "Rize", 53, "53" },
                    { 54, "Sakarya", 54, "54" },
                    { 55, "Samsun", 55, "55" },
                    { 56, "Siirt", 56, "56" },
                    { 57, "Sinop", 57, "57" },
                    { 58, "Sivas", 58, "58" },
                    { 59, "Tekirdağ", 59, "59" },
                    { 60, "Tokat", 60, "60" },
                    { 61, "Trabzon", 61, "61" },
                    { 62, "Tunceli", 62, "62" },
                    { 63, "Şanlıurfa", 63, "63" },
                    { 64, "Uşak", 64, "64" },
                    { 65, "Van", 65, "65" },
                    { 66, "Yozgat", 66, "66" },
                    { 67, "Zonguldak", 67, "67" },
                    { 68, "Aksaray", 68, "68" },
                    { 69, "Bayburt", 69, "69" },
                    { 70, "Karaman", 70, "70" },
                    { 71, "Kırıkkale", 71, "71" },
                    { 72, "Batman", 72, "72" },
                    { 73, "Şırnak", 73, "73" },
                    { 74, "Bartın", 74, "74" },
                    { 75, "Ardahan", 75, "75" },
                    { 76, "Iğdır", 76, "76" },
                    { 77, "Yalova", 77, "77" },
                    { 78, "Karabük", 78, "78" },
                    { 79, "Kilis", 79, "79" },
                    { 80, "Osmaniye", 80, "80" },
                    { 81, "Düzce", 81, "81" }
                });

            migrationBuilder.InsertData(
                table: "Commisions",
                columns: new[] { "Id", "CreateDate", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "1. Ceza Dairesi" },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "10. Ceza Dairesi" },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "8. Hukuk Dairesi" },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "9. Ceza Dairesi" }
                });

            migrationBuilder.InsertData(
                table: "Courts",
                columns: new[] { "Id", "CommissionId", "CreateDate", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "(BAKIRKÖY) DÖRDÜNCÜ AĞIR CEZA MAHKEMESİ" },
                    { 2, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "(BAKIRKÖY) İKİNCİ AĞIR CEZA MAHKEMESİ" },
                    { 3, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "(BAKIRKÖY) ONBİRİNCİ AĞIR CEZA MAHKEMESİ" }
                });

            migrationBuilder.InsertData(
                table: "JudgmentTypes",
                columns: new[] { "Id", "CreateDate", "TypeId", "TypeName" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 11, 25, 14, 40, 59, 66, DateTimeKind.Local).AddTicks(7660), 1, "Yargıtay" },
                    { 2, new DateTime(2022, 11, 25, 14, 40, 59, 66, DateTimeKind.Local).AddTicks(7690), 2, "Danıştay" },
                    { 3, new DateTime(2022, 11, 25, 14, 40, 59, 66, DateTimeKind.Local).AddTicks(7690), 3, "Anayasa Mahkemesi" }
                });

            migrationBuilder.InsertData(
                table: "LawyerJudgmentState",
                columns: new[] { "Id", "CreateDate", "StateId", "StateName" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 11, 25, 14, 40, 59, 54, DateTimeKind.Local).AddTicks(1140), 1, "Onaya Gönderildi" },
                    { 2, new DateTime(2022, 11, 25, 14, 40, 59, 63, DateTimeKind.Local).AddTicks(2190), 2, "Onay Bekliyor" },
                    { 3, new DateTime(2022, 11, 25, 14, 40, 59, 63, DateTimeKind.Local).AddTicks(2210), 3, "Reddedildi" },
                    { 4, new DateTime(2022, 11, 25, 14, 40, 59, 63, DateTimeKind.Local).AddTicks(2220), 4, "Onaylandı" }
                });

            migrationBuilder.InsertData(
                table: "SearchTypes",
                columns: new[] { "Id", "CreateDate", "TypeId", "TypeName" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 11, 25, 14, 40, 59, 66, DateTimeKind.Local).AddTicks(810), 1, "Avukatın Eklediği Kararlar" },
                    { 2, new DateTime(2022, 11, 25, 14, 40, 59, 66, DateTimeKind.Local).AddTicks(910), 2, "Yüksek Yargı Kararları" }
                });

            migrationBuilder.InsertData(
                table: "UserTypes",
                columns: new[] { "Id", "CreateDate", "TypeId", "TypeName" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 11, 25, 14, 40, 59, 65, DateTimeKind.Local).AddTicks(2020), 1, "Avukat-Avukat Stajyeri" },
                    { 2, new DateTime(2022, 11, 25, 14, 40, 59, 65, DateTimeKind.Local).AddTicks(2060), 2, "Öğrenci" },
                    { 3, new DateTime(2022, 11, 25, 14, 40, 59, 65, DateTimeKind.Local).AddTicks(2060), 3, "TBB Kullanıcısı" }
                });

            migrationBuilder.InsertData(
                table: "Courts",
                columns: new[] { "Id", "CommissionId", "CreateDate", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 4, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "ÇOCUK AĞIR CEZA MAHKEMESİ" },
                    { 5, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "SULH CEZA MAHKEMESİ" },
                    { 6, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "1- AKSEKİ ASLİYE CEZA MAHKEMESİ" },
                    { 7, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "3. İCRA HUKUK MAHKEMESİ" },
                    { 8, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "5. AİLE MAHKEMESİ" },
                    { 9, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "SULH CEZA MAHKEMESİ" }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "CityId", "Name", "OrderIndex" },
                values: new object[,]
                {
                    { 1, 1, "Aladağ", 1 },
                    { 2, 1, "Ceyhan", 2 },
                    { 3, 1, "Çukurova", 3 },
                    { 4, 1, "Feke", 4 },
                    { 5, 1, "İmamoğlu", 5 },
                    { 6, 1, "Karaisalı", 6 },
                    { 7, 1, "Karataş", 7 },
                    { 8, 1, "Kozan", 8 },
                    { 9, 1, "Pozantı", 9 },
                    { 10, 1, "Saimbeyli", 10 },
                    { 11, 1, "Sarıçam", 11 },
                    { 12, 1, "Tufanbeyli", 12 },
                    { 13, 1, "Yumurtalık", 13 },
                    { 14, 1, "Yüreğir", 14 },
                    { 15, 2, "Besni", 15 },
                    { 16, 2, "Çelikhan", 16 },
                    { 17, 2, "Gerger", 17 },
                    { 18, 2, "Gölbaşı", 18 },
                    { 19, 2, "Kahta", 19 },
                    { 20, 2, "Merkez", 20 },
                    { 21, 2, "Samsat", 21 },
                    { 22, 2, "Sincik", 22 },
                    { 23, 2, "Tut", 23 },
                    { 24, 3, "Başmakçı", 24 },
                    { 25, 3, "Bayat", 25 },
                    { 26, 3, "Bolvadin", 26 },
                    { 27, 3, "Çay", 27 },
                    { 28, 3, "Çobanlar", 28 },
                    { 29, 3, "Dazkırı", 29 },
                    { 30, 3, "Dinar", 30 },
                    { 31, 3, "Emirdağ", 31 },
                    { 32, 3, "Evciler", 32 },
                    { 33, 3, "Hocalar", 33 },
                    { 34, 3, "İhsaniye", 34 },
                    { 35, 3, "İscehisar", 35 },
                    { 36, 3, "Kızılören", 36 },
                    { 37, 3, "Merkez", 37 },
                    { 38, 3, "Sandıklı", 38 },
                    { 39, 3, "Sultandağı", 39 },
                    { 40, 3, "Şuhut", 40 },
                    { 41, 4, "Diyadin", 41 },
                    { 42, 4, "Doğubayazıt", 42 },
                    { 43, 4, "Eleşkirt", 43 },
                    { 44, 4, "Hamur", 44 },
                    { 45, 4, "Merkez", 45 },
                    { 46, 4, "Patnos", 46 },
                    { 47, 4, "Taşlıçay", 47 },
                    { 48, 4, "Tutak", 48 },
                    { 49, 5, "Göynücek", 49 },
                    { 50, 5, "Gümüşhacıköy", 50 },
                    { 51, 5, "Hamamözü", 51 },
                    { 52, 5, "Merkez", 52 },
                    { 53, 5, "Merzifon", 53 },
                    { 54, 5, "Suluova", 54 },
                    { 55, 5, "Taşova", 55 },
                    { 56, 6, "Akyurt", 56 },
                    { 57, 6, "Altındağ", 57 },
                    { 58, 6, "Ayaş", 58 },
                    { 59, 6, "Bala", 59 },
                    { 60, 6, "Beypazarı", 60 },
                    { 61, 6, "Çamlıdere", 61 },
                    { 62, 6, "Çankaya", 62 },
                    { 63, 6, "Çubuk", 63 },
                    { 64, 6, "Elmadağ", 64 },
                    { 65, 6, "Etimesgut", 65 },
                    { 66, 6, "Evren", 66 },
                    { 67, 6, "Gölbaşı", 67 },
                    { 68, 6, "Güdül", 68 },
                    { 69, 6, "Haymana", 69 },
                    { 70, 6, "Kalecik", 70 },
                    { 71, 6, "Kazan", 71 },
                    { 72, 6, "Keçiören", 72 },
                    { 73, 6, "Kızılcahamam", 73 },
                    { 74, 6, "Mamak", 74 },
                    { 75, 6, "Nallıhan", 75 },
                    { 76, 6, "Polatlı", 76 },
                    { 77, 6, "Pursaklar", 77 },
                    { 78, 6, "Sincan", 78 },
                    { 79, 6, "Şereflikoçhisar", 79 },
                    { 80, 6, "Yenimahalle", 80 },
                    { 81, 7, "Akseki", 81 },
                    { 82, 7, "Aksu", 82 },
                    { 83, 7, "Alanya", 83 },
                    { 84, 7, "Demre", 84 },
                    { 85, 7, "Döşemealtı", 85 },
                    { 86, 7, "Elmalı", 86 },
                    { 87, 7, "Finike", 87 },
                    { 88, 7, "Gazipaşa", 88 },
                    { 89, 7, "Gündoğmuş", 89 },
                    { 90, 7, "İbradı", 90 },
                    { 91, 7, "Kaş", 91 },
                    { 92, 7, "Kemer", 92 },
                    { 93, 7, "Kepez", 93 },
                    { 94, 7, "Konyaaltı", 94 },
                    { 95, 7, "Korkuteli", 95 },
                    { 96, 7, "Kumluca", 96 },
                    { 97, 7, "Manavgat", 97 },
                    { 98, 7, "Muratpaşa", 98 },
                    { 99, 7, "Serik", 99 },
                    { 100, 8, "Ardanuç", 100 },
                    { 101, 8, "Arhavi", 101 },
                    { 102, 8, "Borçka", 102 },
                    { 103, 8, "Hopa", 103 },
                    { 104, 8, "Merkez", 104 },
                    { 105, 8, "Murgul", 105 },
                    { 106, 8, "Şavşat", 106 },
                    { 107, 8, "Yusufeli", 107 },
                    { 108, 9, "Bozdoğan", 108 },
                    { 109, 9, "Buharkent", 109 },
                    { 110, 9, "Çine", 110 },
                    { 111, 9, "Didim", 111 },
                    { 112, 9, "Efeler", 112 },
                    { 113, 9, "Germencik", 113 },
                    { 114, 9, "İncirliova", 114 },
                    { 115, 9, "Karacasu", 115 },
                    { 116, 9, "Karpuzlu", 116 },
                    { 117, 9, "Koçarlı", 117 },
                    { 118, 9, "Köşk", 118 },
                    { 119, 9, "Kuşadası", 119 },
                    { 120, 9, "Kuyucak", 120 },
                    { 121, 9, "Nazilli", 121 },
                    { 122, 9, "Söke", 122 },
                    { 123, 9, "Sultanhisar", 123 },
                    { 124, 9, "Yenipazar", 124 },
                    { 125, 10, "Altıeylül", 125 },
                    { 126, 10, "Ayvalık", 126 },
                    { 127, 10, "Balya", 127 },
                    { 128, 10, "Bandırma", 128 },
                    { 129, 10, "Bigadiç", 129 },
                    { 130, 10, "Burhaniye", 130 },
                    { 131, 10, "Dursunbey", 131 },
                    { 132, 10, "Edremit", 132 },
                    { 133, 10, "Erdek", 133 },
                    { 134, 10, "Gömeç", 134 },
                    { 135, 10, "Gönen", 135 },
                    { 136, 10, "Havran", 136 },
                    { 137, 10, "İvrindi", 137 },
                    { 138, 10, "Karesi", 138 },
                    { 139, 10, "Kepsut", 139 },
                    { 140, 10, "Manyas", 140 },
                    { 141, 10, "Marmara", 141 },
                    { 142, 10, "Savaştepe", 142 },
                    { 143, 10, "Sındırgı", 143 },
                    { 144, 10, "Susurluk", 144 },
                    { 145, 11, "Bozüyük", 145 },
                    { 146, 11, "Gölpazarı", 146 },
                    { 147, 11, "İnhisar", 147 },
                    { 148, 11, "Merkez", 148 },
                    { 149, 11, "Osmaneli", 149 },
                    { 150, 11, "Pazaryeri", 150 },
                    { 151, 11, "Söğüt", 151 },
                    { 152, 11, "Yenipazar", 152 },
                    { 153, 12, "Adaklı", 153 },
                    { 154, 12, "Genç", 154 },
                    { 155, 12, "Karlıova", 155 },
                    { 156, 12, "Kiğı", 156 },
                    { 157, 12, "Merkez", 157 },
                    { 158, 12, "Solhan", 158 },
                    { 159, 12, "Yayladere", 159 },
                    { 160, 12, "Yedisu", 160 },
                    { 161, 13, "Adilcevaz", 161 },
                    { 162, 13, "Ahlat", 162 },
                    { 163, 13, "Güroymak", 163 },
                    { 164, 13, "Hizan", 164 },
                    { 165, 13, "Merkez", 165 },
                    { 166, 13, "Mutki", 166 },
                    { 167, 13, "Tatvan", 167 },
                    { 168, 14, "Dörtdivan", 168 },
                    { 169, 14, "Gerede", 169 },
                    { 170, 14, "Göynük", 170 },
                    { 171, 14, "Kıbrıscık", 171 },
                    { 172, 14, "Mengen", 172 },
                    { 173, 14, "Merkez", 173 },
                    { 174, 14, "Mudurnu", 174 },
                    { 175, 14, "Seben", 175 },
                    { 176, 14, "Yeniçağa", 176 },
                    { 177, 15, "Ağlasun", 177 },
                    { 178, 15, "Altınyayla", 178 },
                    { 179, 15, "Bucak", 179 },
                    { 180, 15, "Çavdır", 180 },
                    { 181, 15, "Çeltikçi", 181 },
                    { 182, 15, "Gölhisar", 182 },
                    { 183, 15, "Karamanlı", 183 },
                    { 184, 15, "Kemer", 184 },
                    { 185, 15, "Merkez", 185 },
                    { 186, 15, "Tefenni", 186 },
                    { 187, 15, "Yeşilova", 187 },
                    { 188, 16, "Büyükorhan", 188 },
                    { 189, 16, "Gemlik", 189 },
                    { 190, 16, "Gürsu", 190 },
                    { 191, 16, "Harmancık", 191 },
                    { 192, 16, "İnegöl", 192 },
                    { 193, 16, "İznik", 193 },
                    { 194, 16, "Karacabey", 194 },
                    { 195, 16, "Keles", 195 },
                    { 196, 16, "Kestel", 196 },
                    { 197, 16, "Mudanya", 197 },
                    { 198, 16, "Mustafa Kemal Paşa", 198 },
                    { 199, 16, "Nilüfer", 199 },
                    { 200, 16, "Orhaneli", 200 },
                    { 201, 16, "Orhangazi", 201 },
                    { 202, 16, "Osmangazi", 202 },
                    { 203, 16, "Yenişehir", 203 },
                    { 204, 16, "Yıldırım", 204 },
                    { 205, 17, "Ayvacık", 205 },
                    { 206, 17, "Bayramiç", 206 },
                    { 207, 17, "Biga", 207 },
                    { 208, 17, "Çan", 208 },
                    { 209, 17, "Eceabat", 209 },
                    { 210, 17, "Ezine", 210 },
                    { 211, 17, "Gelibolu", 211 },
                    { 212, 17, "Gökçeada", 212 },
                    { 213, 17, "Lapseki", 213 },
                    { 214, 17, "Merkez", 214 },
                    { 215, 17, "Yenice", 215 },
                    { 216, 18, "Atkaracalar", 216 },
                    { 217, 18, "Bayramören", 217 },
                    { 218, 18, "Çerkeş", 218 },
                    { 219, 18, "Eldivan", 219 },
                    { 220, 18, "Ilgaz", 220 },
                    { 221, 18, "Kızılırmak", 221 },
                    { 222, 18, "Korgun", 222 },
                    { 223, 18, "Kurşunlu", 223 },
                    { 224, 18, "Merkez", 224 },
                    { 225, 18, "Orta", 225 },
                    { 226, 18, "Şabanözü", 226 },
                    { 227, 18, "Yapraklı", 227 },
                    { 228, 19, "Alaca", 228 },
                    { 229, 19, "Bayat", 229 },
                    { 230, 19, "Boğazkale", 230 },
                    { 231, 19, "Dodurga", 231 },
                    { 232, 19, "İskilip", 232 },
                    { 233, 19, "Kargı", 233 },
                    { 234, 19, "Laçin", 234 },
                    { 235, 19, "Mecitözü", 235 },
                    { 236, 19, "Merkez", 236 },
                    { 237, 19, "Oğuzlar", 237 },
                    { 238, 19, "Ortaköy", 238 },
                    { 239, 19, "Osmancık", 239 },
                    { 240, 19, "Sungurlu", 240 },
                    { 241, 19, "Uğurludağ", 241 },
                    { 242, 20, "Acıpayam", 242 },
                    { 243, 20, "Babadağ", 243 },
                    { 244, 20, "Baklan", 244 },
                    { 245, 20, "Bekilli", 245 },
                    { 246, 20, "Beyağaç", 246 },
                    { 247, 20, "Bozkurt", 247 },
                    { 248, 20, "Buldan", 248 },
                    { 249, 20, "Çal", 249 },
                    { 250, 20, "Çameli", 250 },
                    { 251, 20, "Çardak", 251 },
                    { 252, 20, "Çivril", 252 },
                    { 253, 20, "Güney", 253 },
                    { 254, 20, "Honaz", 254 },
                    { 255, 20, "Kale", 255 },
                    { 256, 20, "Merkezefendi", 256 },
                    { 257, 20, "Pamukkale", 257 },
                    { 258, 20, "Sarayköy", 258 },
                    { 259, 20, "Serinhisar", 259 },
                    { 260, 20, "Tavas", 260 },
                    { 261, 21, "Bağlar", 261 },
                    { 262, 21, "Bismil", 262 },
                    { 263, 21, "Çermik", 263 },
                    { 264, 21, "Çınar", 264 },
                    { 265, 21, "Çüngüş", 265 },
                    { 266, 21, "Dicle", 266 },
                    { 267, 21, "Eğil", 267 },
                    { 268, 21, "Ergani", 268 },
                    { 269, 21, "Hani", 269 },
                    { 270, 21, "Hazro", 270 },
                    { 271, 21, "Kayapınar", 271 },
                    { 272, 21, "Kocaköy", 272 },
                    { 273, 21, "Kulp", 273 },
                    { 274, 21, "Lice", 274 },
                    { 275, 21, "Silvan", 275 },
                    { 276, 21, "Sur", 276 },
                    { 277, 21, "Yenişehir", 277 },
                    { 278, 22, "Enez", 278 },
                    { 279, 22, "Havsa", 279 },
                    { 280, 22, "İpsala", 280 },
                    { 281, 22, "Keşan", 281 },
                    { 282, 22, "Lalapaşa", 282 },
                    { 283, 22, "Meriç", 283 },
                    { 284, 22, "Merkez", 284 },
                    { 285, 22, "Süloğlu", 285 },
                    { 286, 22, "Uzunköprü", 286 },
                    { 287, 23, "Ağın", 287 },
                    { 288, 23, "Alacakaya", 288 },
                    { 289, 23, "Arıcak", 289 },
                    { 290, 23, "Baskil", 290 },
                    { 291, 23, "Karakoçan", 291 },
                    { 292, 23, "Keban", 292 },
                    { 293, 23, "Kovancılar", 293 },
                    { 294, 23, "Maden", 294 },
                    { 295, 23, "Merkez", 295 },
                    { 296, 23, "Palu", 296 },
                    { 297, 23, "Sivrice", 297 },
                    { 298, 24, "Çayırlı", 298 },
                    { 299, 24, "İliç", 299 },
                    { 300, 24, "Kemah", 300 },
                    { 301, 24, "Kemaliye", 301 },
                    { 302, 24, "Merkez", 302 },
                    { 303, 24, "Otlukbeli", 303 },
                    { 304, 24, "Refahiye", 304 },
                    { 305, 24, "Tercan", 305 },
                    { 306, 24, "Üzümlü", 306 },
                    { 307, 25, "Aşkale", 307 },
                    { 308, 25, "Aziziye", 308 },
                    { 309, 25, "Çat", 309 },
                    { 310, 25, "Hınıs", 310 },
                    { 311, 25, "Horasan", 311 },
                    { 312, 25, "İspir", 312 },
                    { 313, 25, "Karaçoban", 313 },
                    { 314, 25, "Karayazı", 314 },
                    { 315, 25, "Köprüköy", 315 },
                    { 316, 25, "Narman", 316 },
                    { 317, 25, "Oltu", 317 },
                    { 318, 25, "Olur", 318 },
                    { 319, 25, "Palandöken", 319 },
                    { 320, 25, "Pasinler", 320 },
                    { 321, 25, "Pazaryolu", 321 },
                    { 322, 25, "Şenkaya", 322 },
                    { 323, 25, "Tekman", 323 },
                    { 324, 25, "Tortum", 324 },
                    { 325, 25, "Uzundere", 325 },
                    { 326, 25, "Yakutiye", 326 },
                    { 327, 26, "Alpu", 327 },
                    { 328, 26, "Beylikova", 328 },
                    { 329, 26, "Çifteler", 329 },
                    { 330, 26, "Günyüzü", 330 },
                    { 331, 26, "Han", 331 },
                    { 332, 26, "İnönü", 332 },
                    { 333, 26, "Mahmudiye", 333 },
                    { 334, 26, "Mihalgazi", 334 },
                    { 335, 26, "Mihalıççık", 335 },
                    { 336, 26, "Odunpazarı", 336 },
                    { 337, 26, "Sarıcakaya", 337 },
                    { 338, 26, "Seyitgazi", 338 },
                    { 339, 26, "Sivrihisar", 339 },
                    { 340, 26, "Tepebaşı", 340 },
                    { 341, 27, "Araban", 341 },
                    { 342, 27, "İslahiye", 342 },
                    { 343, 27, "Karkamış", 343 },
                    { 344, 27, "Nizip", 344 },
                    { 345, 27, "Nurdağı", 345 },
                    { 346, 27, "Oğuzeli", 346 },
                    { 347, 27, "Şahinbey", 347 },
                    { 348, 27, "Şahinbey", 348 },
                    { 349, 27, "Şehitkamil", 349 },
                    { 350, 27, "Yavuzeli", 350 },
                    { 351, 28, "Alucra", 351 },
                    { 352, 28, "Bulancak", 352 },
                    { 353, 28, "Çamoluk", 353 },
                    { 354, 28, "Çanakçı", 354 },
                    { 355, 28, "Dereli", 355 },
                    { 356, 28, "Doğankent", 356 },
                    { 357, 28, "Espiye", 357 },
                    { 358, 28, "Eynesil", 358 },
                    { 359, 28, "Görele", 359 },
                    { 360, 28, "Güce", 360 },
                    { 361, 28, "Keşap", 361 },
                    { 362, 28, "Merkez", 362 },
                    { 363, 28, "Piraziz", 363 },
                    { 364, 28, "Şebinkarahisar", 364 },
                    { 365, 28, "Tirebolu", 365 },
                    { 366, 28, "Yağlıdere", 366 },
                    { 367, 29, "Kelkit", 367 },
                    { 368, 29, "Köse", 368 },
                    { 369, 29, "Kürtün", 369 },
                    { 370, 29, "Merkez", 370 },
                    { 371, 29, "Şiran", 371 },
                    { 372, 29, "Torul", 372 },
                    { 373, 30, "Çukurca", 373 },
                    { 374, 30, "Merkez", 374 },
                    { 375, 30, "Şemdinli", 375 },
                    { 376, 30, "Yüksekova", 376 },
                    { 377, 31, "Altınözü", 377 },
                    { 378, 31, "Antakya", 378 },
                    { 379, 31, "Arsuz", 379 },
                    { 380, 31, "Belen", 380 },
                    { 381, 31, "Defne", 381 },
                    { 382, 31, "Dörtyol", 382 },
                    { 383, 31, "Erzin", 383 },
                    { 384, 31, "Hassa", 384 },
                    { 385, 31, "İskenderun", 385 },
                    { 386, 31, "Kırıkhan", 386 },
                    { 387, 31, "Kumlu", 387 },
                    { 388, 31, "Payas", 388 },
                    { 389, 31, "Reyhanlı", 389 },
                    { 390, 31, "Samandağ", 390 },
                    { 391, 31, "Yayladağı", 391 },
                    { 392, 32, "Aksu", 392 },
                    { 393, 32, "Atabey", 393 },
                    { 394, 32, "Eğirdir", 394 },
                    { 395, 32, "Gelendost", 395 },
                    { 396, 32, "Gönen", 396 },
                    { 397, 32, "Keçiborlu", 397 },
                    { 398, 32, "Merkez", 398 },
                    { 399, 32, "Senirkent", 399 },
                    { 400, 32, "Sütçüler", 400 },
                    { 401, 32, "Şarkikaraağaç", 401 },
                    { 402, 32, "Uluborlu", 402 },
                    { 403, 32, "Yalvaç", 403 },
                    { 404, 32, "Yenişarbademli", 404 },
                    { 405, 33, "Akdeniz", 405 },
                    { 406, 33, "Anamur", 406 },
                    { 407, 33, "Aydıncık", 407 },
                    { 408, 33, "Bozyazı", 408 },
                    { 409, 33, "Çamlıyayla", 409 },
                    { 410, 33, "Erdemli", 410 },
                    { 411, 33, "Gülnar", 411 },
                    { 412, 33, "Mezitli", 412 },
                    { 413, 33, "Mut", 413 },
                    { 414, 33, "Silifke", 414 },
                    { 415, 33, "Tarsus", 415 },
                    { 416, 33, "Tarsus", 416 },
                    { 417, 33, "Yenişehir", 417 },
                    { 418, 34, "Adalar", 418 },
                    { 419, 34, "Arnavutköy", 419 },
                    { 420, 34, "Ataşehir", 420 },
                    { 421, 34, "Avcılar", 421 },
                    { 422, 34, "Bağcılar", 422 },
                    { 423, 34, "Bahçelievler", 423 },
                    { 424, 34, "Bakırköy", 424 },
                    { 425, 34, "Başakşehir", 425 },
                    { 426, 34, "Bayrampaşa", 426 },
                    { 427, 34, "Beşiktaş", 427 },
                    { 428, 34, "Beykoz", 428 },
                    { 429, 34, "Beylikdüzü", 429 },
                    { 430, 34, "Beyoğlu", 430 },
                    { 431, 34, "Büyükçekmece", 431 },
                    { 432, 34, "Çatalca", 432 },
                    { 433, 34, "Çekmeköy", 433 },
                    { 434, 34, "Esenler", 434 },
                    { 435, 34, "Esenyurt", 435 },
                    { 436, 34, "Eyüp", 436 },
                    { 437, 34, "Fatih", 437 },
                    { 438, 34, "Gaziosmanpaşa", 438 },
                    { 439, 34, "Güngören", 439 },
                    { 440, 34, "Kadıköy", 440 },
                    { 441, 34, "Kağıthane", 441 },
                    { 442, 34, "Kartal", 442 },
                    { 443, 34, "Küçükçekmece", 443 },
                    { 444, 34, "Maltepe", 444 },
                    { 445, 34, "Pendik", 445 },
                    { 446, 34, "Sancaktepe", 446 },
                    { 447, 34, "Sarıyer", 447 },
                    { 448, 34, "Silivri", 448 },
                    { 449, 34, "Sultanbeyli", 449 },
                    { 450, 34, "Sultangazi", 450 },
                    { 451, 34, "Şile", 451 },
                    { 452, 34, "Şişli", 452 },
                    { 453, 34, "Tuzla", 453 },
                    { 454, 34, "Ümraniye", 454 },
                    { 455, 34, "Üsküdar", 455 },
                    { 456, 34, "Zeytinburnu", 456 },
                    { 457, 35, "Aliağa", 457 },
                    { 458, 35, "Balçova", 458 },
                    { 459, 35, "Bayındır", 459 },
                    { 460, 35, "Bayraklı", 460 },
                    { 461, 35, "Bergama", 461 },
                    { 462, 35, "Beydağ", 462 },
                    { 463, 35, "Bornova", 463 },
                    { 464, 35, "Buca", 464 },
                    { 465, 35, "Çeşme", 465 },
                    { 466, 35, "Çiğli", 466 },
                    { 467, 35, "Dikili", 467 },
                    { 468, 35, "Foça", 468 },
                    { 469, 35, "Gaziemir", 469 },
                    { 470, 35, "Güzelbahçe", 470 },
                    { 471, 35, "Karabağlar", 471 },
                    { 472, 35, "Karaburun", 472 },
                    { 473, 35, "Karşıyaka", 473 },
                    { 474, 35, "Kemalpaşa", 474 },
                    { 475, 35, "Kınık", 475 },
                    { 476, 35, "Kiraz", 476 },
                    { 477, 35, "Konak", 477 },
                    { 478, 35, "Menderes", 478 },
                    { 479, 35, "Menemen", 479 },
                    { 480, 35, "Narlıdere", 480 },
                    { 481, 35, "Ödemiş", 481 },
                    { 482, 35, "Seferihisar", 482 },
                    { 483, 35, "Selçuk", 483 },
                    { 484, 35, "Tire", 484 },
                    { 485, 35, "Torbalı", 485 },
                    { 486, 35, "Urla", 486 },
                    { 487, 36, "Akyaka", 487 },
                    { 488, 36, "Arpaçay", 488 },
                    { 489, 36, "Digor", 489 },
                    { 490, 36, "Kağızman", 490 },
                    { 491, 36, "Merkez", 491 },
                    { 492, 36, "Sarıkamış", 492 },
                    { 493, 36, "Selim", 493 },
                    { 494, 36, "Susuz", 494 },
                    { 495, 37, "Abana", 495 },
                    { 496, 37, "Ağlı", 496 },
                    { 497, 37, "Araç", 497 },
                    { 498, 37, "Azdavay", 498 },
                    { 499, 37, "Bozkurt", 499 },
                    { 500, 37, "Cide", 500 },
                    { 501, 37, "Çatalzeytin", 501 },
                    { 502, 37, "Daday", 502 },
                    { 503, 37, "Devrekani", 503 },
                    { 504, 37, "Doğanyurt", 504 },
                    { 505, 37, "Hanönü", 505 },
                    { 506, 37, "İhsangazi", 506 },
                    { 507, 37, "İnebolu", 507 },
                    { 508, 37, "Küre", 508 },
                    { 509, 37, "Merkez", 509 },
                    { 510, 37, "Pınarbaşı", 510 },
                    { 511, 37, "Seydiler", 511 },
                    { 512, 37, "Şenpazar", 512 },
                    { 513, 37, "Taşköprü", 513 },
                    { 514, 37, "Tosya", 514 },
                    { 515, 38, "Akkışla", 515 },
                    { 516, 38, "Bünyan", 516 },
                    { 517, 38, "Develi", 517 },
                    { 518, 38, "Felahiye", 518 },
                    { 519, 38, "Hacılar", 519 },
                    { 520, 38, "İncesu", 520 },
                    { 521, 38, "Kocasinan", 521 },
                    { 522, 38, "Melikgazi", 522 },
                    { 523, 38, "Özvatan", 523 },
                    { 524, 38, "Pınarbaşı", 524 },
                    { 525, 38, "Sarıoğlan", 525 },
                    { 526, 38, "Sarız", 526 },
                    { 527, 38, "Talas", 527 },
                    { 528, 38, "Tomarza", 528 },
                    { 529, 38, "Yahyalı", 529 },
                    { 530, 38, "Yeşilhisar", 530 },
                    { 531, 39, "Babaeski", 531 },
                    { 532, 39, "Demirköy", 532 },
                    { 533, 39, "Kofçaz", 533 },
                    { 534, 39, "Lüleburgaz", 534 },
                    { 535, 39, "Merkez", 535 },
                    { 536, 39, "Pehlivanköy", 536 },
                    { 537, 39, "Pınarhisar", 537 },
                    { 538, 39, "Vize", 538 },
                    { 539, 40, "Akçakent", 539 },
                    { 540, 40, "Akpınar", 540 },
                    { 541, 40, "Boztepe", 541 },
                    { 542, 40, "Çiçekdağı", 542 },
                    { 543, 40, "Kaman", 543 },
                    { 544, 40, "Merkez", 544 },
                    { 545, 40, "Mucur", 545 },
                    { 546, 41, "Başiskele", 546 },
                    { 547, 41, "Çayırova", 547 },
                    { 548, 41, "Darıca", 548 },
                    { 549, 41, "Derince", 549 },
                    { 550, 41, "Dilovası", 550 },
                    { 551, 41, "Gebze", 551 },
                    { 552, 41, "Gölcük", 552 },
                    { 553, 41, "İzmit", 553 },
                    { 554, 41, "Kandıra", 554 },
                    { 555, 41, "Karamürsel", 555 },
                    { 556, 41, "Kartepe", 556 },
                    { 557, 41, "Körfez", 557 },
                    { 558, 42, "Ahırlı", 558 },
                    { 559, 42, "Akören", 559 },
                    { 560, 42, "Akşehir", 560 },
                    { 561, 42, "Altınekin", 561 },
                    { 562, 42, "Beyşehir", 562 },
                    { 563, 42, "Bozkır", 563 },
                    { 564, 42, "Cihanbeyli", 564 },
                    { 565, 42, "Çeltik", 565 },
                    { 566, 42, "Çumra", 566 },
                    { 567, 42, "Derbent", 567 },
                    { 568, 42, "Derebucak", 568 },
                    { 569, 42, "Doğanhisar", 569 },
                    { 570, 42, "Emirgazi", 570 },
                    { 571, 42, "Ereğli", 571 },
                    { 572, 42, "Güneysınır", 572 },
                    { 573, 42, "Hadim", 573 },
                    { 574, 42, "Halkapınar", 574 },
                    { 575, 42, "Hüyük", 575 },
                    { 576, 42, "Ilgın", 576 },
                    { 577, 42, "Kadınhanı", 577 },
                    { 578, 42, "Karapınar", 578 },
                    { 579, 42, "Karatay", 579 },
                    { 580, 42, "Kulu", 580 },
                    { 581, 42, "Meram", 581 },
                    { 582, 42, "Sarayönü", 582 },
                    { 583, 42, "Selçuklu", 583 },
                    { 584, 42, "Seydişehir", 584 },
                    { 585, 42, "Taşkent", 585 },
                    { 586, 42, "Tuzlukçu", 586 },
                    { 587, 42, "Yalıhüyük", 587 },
                    { 588, 42, "Yunak", 588 },
                    { 589, 43, "Altıntaş", 589 },
                    { 590, 43, "Aslanapa", 590 },
                    { 591, 43, "Çavdarhisar", 591 },
                    { 592, 43, "Domaniç", 592 },
                    { 593, 43, "Dumlupınar", 593 },
                    { 594, 43, "Emet", 594 },
                    { 595, 43, "Gediz", 595 },
                    { 596, 43, "Hisarcık", 596 },
                    { 597, 43, "Merkez", 597 },
                    { 598, 43, "Pazarlar", 598 },
                    { 599, 43, "Simav", 599 },
                    { 600, 43, "Şaphane", 600 },
                    { 601, 43, "Tavşanlı", 601 },
                    { 602, 44, "Akçadağ", 602 },
                    { 603, 44, "Arapgir", 603 },
                    { 604, 44, "Arguvan", 604 },
                    { 605, 44, "Battalgazi", 605 },
                    { 606, 44, "Darende", 606 },
                    { 607, 44, "Doğanşehir", 607 },
                    { 608, 44, "Doğanyol", 608 },
                    { 609, 44, "Hekimhan", 609 },
                    { 610, 44, "Kale", 610 },
                    { 611, 44, "Kuluncak", 611 },
                    { 612, 44, "Pütürge", 612 },
                    { 613, 44, "Yazıhan", 613 },
                    { 614, 44, "Yeşilyurt", 614 },
                    { 615, 45, "Ahmetli", 615 },
                    { 616, 45, "Akhisar", 616 },
                    { 617, 45, "Alaşehir", 617 },
                    { 618, 45, "Demirci", 618 },
                    { 619, 45, "Gölmarmara", 619 },
                    { 620, 45, "Gördes", 620 },
                    { 621, 45, "Kırkağaç", 621 },
                    { 622, 45, "Köprübaşı", 622 },
                    { 623, 45, "Kula", 623 },
                    { 624, 45, "Salihli", 624 },
                    { 625, 45, "Sarıgöl", 625 },
                    { 626, 45, "Saruhanlı", 626 },
                    { 627, 45, "Selendi", 627 },
                    { 628, 45, "Soma", 628 },
                    { 629, 45, "Şehzadeler", 629 },
                    { 630, 45, "Turgutlu", 630 },
                    { 631, 45, "Yunusemre", 631 },
                    { 632, 46, "Afşin", 632 },
                    { 633, 46, "Andırın", 633 },
                    { 634, 46, "Çağlayancerit", 634 },
                    { 635, 46, "Dulkadiroğlu", 635 },
                    { 636, 46, "Ekinözü", 636 },
                    { 637, 46, "Elbistan", 637 },
                    { 638, 46, "Göksun", 638 },
                    { 639, 46, "Nurhak", 639 },
                    { 640, 46, "Onikişubat", 640 },
                    { 641, 46, "Pazarcık", 641 },
                    { 642, 46, "Türkoğlu", 642 },
                    { 643, 47, "Artuklu", 643 },
                    { 644, 47, "Dargeçit", 644 },
                    { 645, 47, "Derik", 645 },
                    { 646, 47, "Kızıltepe", 646 },
                    { 647, 47, "Mazıdağı", 647 },
                    { 648, 47, "Midyat", 648 },
                    { 649, 47, "Nusaybin", 649 },
                    { 650, 47, "Ömerli", 650 },
                    { 651, 47, "Savur", 651 },
                    { 652, 47, "Yeşilli", 652 },
                    { 653, 48, "Bodrum", 653 },
                    { 654, 48, "Dalaman", 654 },
                    { 655, 48, "Datça", 655 },
                    { 656, 48, "Fethiye", 656 },
                    { 657, 48, "Kavaklıdere", 657 },
                    { 658, 48, "Köyceğiz", 658 },
                    { 659, 48, "Marmaris", 659 },
                    { 660, 48, "Menteşe", 660 },
                    { 661, 48, "Milas", 661 },
                    { 662, 48, "Ortaca", 662 },
                    { 663, 48, "Seydikemer", 663 },
                    { 664, 48, "Ula", 664 },
                    { 665, 48, "Yatağan", 665 },
                    { 666, 49, "Bulanık", 666 },
                    { 667, 49, "Hasköy", 667 },
                    { 668, 49, "Korkut", 668 },
                    { 669, 49, "Malazgirt", 669 },
                    { 670, 49, "Merkez", 670 },
                    { 671, 49, "Varto", 671 },
                    { 672, 50, "Acıgöl", 672 },
                    { 673, 50, "Avanos", 673 },
                    { 674, 50, "Derinkuyu", 674 },
                    { 675, 50, "Gülşehir", 675 },
                    { 676, 50, "Hacıbektaş", 676 },
                    { 677, 50, "Kozaklı", 677 },
                    { 678, 50, "Merkez", 678 },
                    { 679, 50, "Ürgüp", 679 },
                    { 680, 51, "Altunhisar", 680 },
                    { 681, 51, "Bor", 681 },
                    { 682, 51, "Çamardı", 682 },
                    { 683, 51, "Çiftlik", 683 },
                    { 684, 51, "Merkez", 684 },
                    { 685, 51, "Ulukışla", 685 },
                    { 686, 52, "Akkuş", 686 },
                    { 687, 52, "Altınordu", 687 },
                    { 688, 52, "Aybastı", 688 },
                    { 689, 52, "Çamaş", 689 },
                    { 690, 52, "Çatalpınar", 690 },
                    { 691, 52, "Çaybaşı", 691 },
                    { 692, 52, "Fatsa", 692 },
                    { 693, 52, "Gölköy", 693 },
                    { 694, 52, "Gülyalı", 694 },
                    { 695, 52, "Gürgentepe", 695 },
                    { 696, 52, "İkizce", 696 },
                    { 697, 52, "Kabadüz", 697 },
                    { 698, 52, "Kabataş", 698 },
                    { 699, 52, "Korgan", 699 },
                    { 700, 52, "Kumru", 700 },
                    { 701, 52, "Mesudiye", 701 },
                    { 702, 52, "Perşembe", 702 },
                    { 703, 52, "Ulubey", 703 },
                    { 704, 52, "Ünye", 704 },
                    { 705, 53, "Ardeşen", 705 },
                    { 706, 53, "Çamlıhemşin", 706 },
                    { 707, 53, "Çayeli", 707 },
                    { 708, 53, "Derepazarı", 708 },
                    { 709, 53, "Fındıklı", 709 },
                    { 710, 53, "Güneysu", 710 },
                    { 711, 53, "Hemşin", 711 },
                    { 712, 53, "İkizdere", 712 },
                    { 713, 53, "İyidere", 713 },
                    { 714, 53, "Kalkandere", 714 },
                    { 715, 53, "Merkez", 715 },
                    { 716, 53, "Pazar", 716 },
                    { 717, 54, "Adapazarı", 717 },
                    { 718, 54, "Akyazı", 718 },
                    { 719, 54, "Arifiye", 719 },
                    { 720, 54, "Erenler", 720 },
                    { 721, 54, "Ferizli", 721 },
                    { 722, 54, "Geyve", 722 },
                    { 723, 54, "Hendek", 723 },
                    { 724, 54, "Karapürçek", 724 },
                    { 725, 54, "Karasu", 725 },
                    { 726, 54, "Kaynarca", 726 },
                    { 727, 54, "Kocaali", 727 },
                    { 728, 54, "Pamukova", 728 },
                    { 729, 54, "Sapanca", 729 },
                    { 730, 54, "Serdivan", 730 },
                    { 731, 54, "Söğütlü", 731 },
                    { 732, 54, "Taraklı", 732 },
                    { 733, 55, "19 Mayıs", 733 },
                    { 734, 55, "Alaçam", 734 },
                    { 735, 55, "Asarcık", 735 },
                    { 736, 55, "Atakum", 736 },
                    { 737, 55, "Ayvacık", 737 },
                    { 738, 55, "Bafra", 738 },
                    { 739, 55, "Canik", 739 },
                    { 740, 55, "Çarşamba", 740 },
                    { 741, 55, "Havza", 741 },
                    { 742, 55, "İlkadım", 742 },
                    { 743, 55, "Kavak", 743 },
                    { 744, 55, "Ladik", 744 },
                    { 745, 55, "Salıpazarı", 745 },
                    { 746, 55, "Tekkeköy", 746 },
                    { 747, 55, "Terme", 747 },
                    { 748, 55, "Vezirköprü", 748 },
                    { 749, 55, "Yakakent", 749 },
                    { 750, 56, "Baykan", 750 },
                    { 751, 56, "Eruh", 751 },
                    { 752, 56, "Kurtalan", 752 },
                    { 753, 56, "Merkez", 753 },
                    { 754, 56, "Pervari", 754 },
                    { 755, 56, "Şirvan", 755 },
                    { 756, 56, "Tillo", 756 },
                    { 757, 57, "Ayancık", 757 },
                    { 758, 57, "Boyabat", 758 },
                    { 759, 57, "Dikmen", 759 },
                    { 760, 57, "Durağan", 760 },
                    { 761, 57, "Erfelek", 761 },
                    { 762, 57, "Gerze", 762 },
                    { 763, 57, "Merkez", 763 },
                    { 764, 57, "Saraydüzü", 764 },
                    { 765, 57, "Türkeli", 765 },
                    { 766, 58, "Akıncılar", 766 },
                    { 767, 58, "Altınyayla", 767 },
                    { 768, 58, "Divriği", 768 },
                    { 769, 58, "Doğanşar", 769 },
                    { 770, 58, "Gemerek", 770 },
                    { 771, 58, "Gölova", 771 },
                    { 772, 58, "Gürün", 772 },
                    { 773, 58, "Hafik", 773 },
                    { 774, 58, "İmranlı", 774 },
                    { 775, 58, "Kangal", 775 },
                    { 776, 58, "Koyulhisar", 776 },
                    { 777, 58, "Merkez", 777 },
                    { 778, 58, "Suşehri", 778 },
                    { 779, 58, "Şarkışla", 779 },
                    { 780, 58, "Ulaş", 780 },
                    { 781, 58, "Yıldızeli", 781 },
                    { 782, 58, "Zara", 782 },
                    { 783, 59, "Çerkezköy", 783 },
                    { 784, 59, "Çorlu", 784 },
                    { 785, 59, "Ergene", 785 },
                    { 786, 59, "Hayrabolu", 786 },
                    { 787, 59, "Malkara", 787 },
                    { 788, 59, "Marmaraereğlisi", 788 },
                    { 789, 59, "Muratlı", 789 },
                    { 790, 59, "Saray", 790 },
                    { 791, 59, "Süleymanpaşa", 791 },
                    { 792, 59, "Şarköy", 792 },
                    { 793, 60, "Almus", 793 },
                    { 794, 60, "Artova", 794 },
                    { 795, 60, "Başçiftlik", 795 },
                    { 796, 60, "Erbaa", 796 },
                    { 797, 60, "Merkez", 797 },
                    { 798, 60, "Niksar", 798 },
                    { 799, 60, "Pazar", 799 },
                    { 800, 60, "Reşadiye", 800 },
                    { 801, 60, "Sulusaray", 801 },
                    { 802, 60, "Turhal", 802 },
                    { 803, 60, "Yeşilyurt", 803 },
                    { 804, 60, "Zile", 804 },
                    { 805, 61, "Akçaabat", 805 },
                    { 806, 61, "Araklı", 806 },
                    { 807, 61, "Arsin", 807 },
                    { 808, 61, "Beşikdüzü", 808 },
                    { 809, 61, "Çarşıbaşı", 809 },
                    { 810, 61, "Çaykara", 810 },
                    { 811, 61, "Dernekpazarı", 811 },
                    { 812, 61, "Düzköy", 812 },
                    { 813, 61, "Hayrat", 813 },
                    { 814, 61, "Köprübaşı", 814 },
                    { 815, 61, "Maçka", 815 },
                    { 816, 61, "Of", 816 },
                    { 817, 61, "Ortahisar", 817 },
                    { 818, 61, "Sürmene", 818 },
                    { 819, 61, "Şalpazarı", 819 },
                    { 820, 61, "Tonya", 820 },
                    { 821, 61, "Vakfıkebir", 821 },
                    { 822, 61, "Yomra", 822 },
                    { 823, 62, "Çemişgezek", 823 },
                    { 824, 62, "Hozat", 824 },
                    { 825, 62, "Mazgirt", 825 },
                    { 826, 62, "Merkez", 826 },
                    { 827, 62, "Nazımiye", 827 },
                    { 828, 62, "Ovacık", 828 },
                    { 829, 62, "Pertek", 829 },
                    { 830, 62, "Pülümür", 830 },
                    { 831, 63, "Akçakale", 831 },
                    { 832, 63, "Birecik", 832 },
                    { 833, 63, "Bozova", 833 },
                    { 834, 63, "Ceylanpınar", 834 },
                    { 835, 63, "Eyyübiye", 835 },
                    { 836, 63, "Halfeti", 836 },
                    { 837, 63, "Haliliye", 837 },
                    { 838, 63, "Harran", 838 },
                    { 839, 63, "Hilvan", 839 },
                    { 840, 63, "Karaköprü", 840 },
                    { 841, 63, "Siverek", 841 },
                    { 842, 63, "Suruç", 842 },
                    { 843, 63, "Viranşehir", 843 },
                    { 844, 64, "Banaz", 844 },
                    { 845, 64, "Eşme", 845 },
                    { 846, 64, "Karahallı", 846 },
                    { 847, 64, "Merkez", 847 },
                    { 848, 64, "Sivaslı", 848 },
                    { 849, 64, "Ulubey", 849 },
                    { 850, 65, "Bahçesaray", 850 },
                    { 851, 65, "Başkale", 851 },
                    { 852, 65, "Çaldıran", 852 },
                    { 853, 65, "Çatak", 853 },
                    { 854, 65, "Edremit", 854 },
                    { 855, 65, "Erciş", 855 },
                    { 856, 65, "Gevaş", 856 },
                    { 857, 65, "Gürpınar", 857 },
                    { 858, 65, "İpekyolu", 858 },
                    { 859, 65, "Muradiye", 859 },
                    { 860, 65, "Özalp", 860 },
                    { 861, 65, "Saray", 861 },
                    { 862, 65, "Tuşba", 862 },
                    { 863, 66, "Akdağmadeni", 863 },
                    { 864, 66, "Aydıncık", 864 },
                    { 865, 66, "Boğazlıyan", 865 },
                    { 866, 66, "Çandır", 866 },
                    { 867, 66, "Çayıralan", 867 },
                    { 868, 66, "Çekerek", 868 },
                    { 869, 66, "Kadışehri", 869 },
                    { 870, 66, "Merkez", 870 },
                    { 871, 66, "Saraykent", 871 },
                    { 872, 66, "Sarıkaya", 872 },
                    { 873, 66, "Sorgun", 873 },
                    { 874, 66, "Şefaatli", 874 },
                    { 875, 66, "Yenifakılı", 875 },
                    { 876, 66, "Yerköy", 876 },
                    { 877, 67, "Alaplı", 877 },
                    { 878, 67, "Çaycuma", 878 },
                    { 879, 67, "Devrek", 879 },
                    { 880, 67, "Ereğli", 880 },
                    { 881, 67, "Gökçebey", 881 },
                    { 882, 67, "Merkez", 882 },
                    { 883, 68, "Ağaçören", 883 },
                    { 884, 68, "Eskil", 884 },
                    { 885, 68, "Gülağaç", 885 },
                    { 886, 68, "Güzelyurt", 886 },
                    { 887, 68, "Merkez", 887 },
                    { 888, 68, "Ortaköy", 888 },
                    { 889, 68, "Sarıyahşi", 889 },
                    { 890, 69, "Aydıntepe", 890 },
                    { 891, 69, "Demirözü", 891 },
                    { 892, 69, "Merkez", 892 },
                    { 893, 70, "Ayrancı", 893 },
                    { 894, 70, "Başyayla", 894 },
                    { 895, 70, "Ermenek", 895 },
                    { 896, 70, "Kazımkarabekir", 896 },
                    { 897, 70, "Merkez", 897 },
                    { 898, 70, "Sarıveliler", 898 },
                    { 899, 71, "Bahşili", 899 },
                    { 900, 71, "Balışeyh", 990 },
                    { 901, 71, "Çelebi", 991 },
                    { 902, 71, "Delice", 992 },
                    { 903, 71, "Karakeçili", 993 },
                    { 904, 71, "Keskin", 994 },
                    { 905, 71, "Merkez", 995 },
                    { 906, 71, "Sulakyurt", 996 },
                    { 907, 71, "Yahşihan", 997 },
                    { 908, 72, "Beşiri", 998 },
                    { 909, 72, "Gercüş", 999 },
                    { 910, 72, "Hasankeyf", 1000 },
                    { 911, 72, "Kozluk", 1001 },
                    { 912, 72, "Merkez", 1002 },
                    { 913, 72, "Sason", 1003 },
                    { 914, 73, "Beytüşşebap", 1004 },
                    { 915, 73, "Cizre", 1005 },
                    { 916, 73, "Güçlükonak", 1006 },
                    { 917, 73, "İdil", 1007 },
                    { 918, 73, "Merkez", 1008 },
                    { 919, 73, "Silopi", 1009 },
                    { 920, 73, "Uludere", 1010 },
                    { 921, 74, "Amasra", 1011 },
                    { 922, 74, "Kurucaşile", 1012 },
                    { 923, 74, "Merkez", 1013 },
                    { 924, 74, "Ulus", 1014 },
                    { 925, 75, "Çıldır", 1015 },
                    { 926, 75, "Damal", 1016 },
                    { 927, 75, "Göle", 1017 },
                    { 928, 75, "Hanak", 1018 },
                    { 929, 75, "Merkez", 1019 },
                    { 930, 75, "Posof", 1020 },
                    { 931, 76, "Aralık", 1021 },
                    { 932, 76, "Karakoyunlu", 1022 },
                    { 933, 76, "Merkez", 1023 },
                    { 934, 76, "Tuzluca", 1024 },
                    { 935, 77, "Altınova", 1025 },
                    { 936, 77, "Armutlu", 1026 },
                    { 937, 77, "Çınarcık", 1027 },
                    { 938, 77, "Çiftlikköy", 1028 },
                    { 939, 77, "Merkez", 1029 },
                    { 940, 77, "Termal", 1030 },
                    { 941, 78, "Eflani", 1031 },
                    { 942, 78, "Eskipazar", 1032 },
                    { 943, 78, "Merkez", 1033 },
                    { 944, 78, "Ovacık", 1034 },
                    { 945, 78, "Safranbolu", 1035 },
                    { 946, 78, "Yenice", 1036 },
                    { 947, 79, "Elbeyli", 1037 },
                    { 948, 79, "Merkez", 1038 },
                    { 949, 79, "Musabeyli", 1039 },
                    { 950, 79, "Polateli", 1040 },
                    { 951, 80, "Bahçe", 1041 },
                    { 952, 80, "Düziçi", 1042 },
                    { 953, 80, "Hasanbeyli", 1043 },
                    { 954, 80, "Kadirli", 1044 },
                    { 955, 80, "Merkez", 1045 },
                    { 956, 80, "Sumbas", 1046 },
                    { 957, 80, "Toprakkale", 1047 },
                    { 958, 81, "Akçakoca", 1048 },
                    { 959, 81, "Cumayeri", 1049 },
                    { 960, 81, "Çilimli", 1050 },
                    { 961, 81, "Gölyaka", 1051 },
                    { 962, 81, "Gümüşova", 1052 },
                    { 963, 81, "Kaynaşlı", 1053 },
                    { 964, 81, "Merkez", 1054 },
                    { 965, 81, "Yığılca", 1055 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courts_CommissionId",
                table: "Courts",
                column: "CommissionId");

            migrationBuilder.CreateIndex(
                name: "IX_Districts_CityId",
                table: "Districts",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_JudgmentPool_JudgmentId",
                table: "JudgmentPool",
                column: "JudgmentId");

            migrationBuilder.CreateIndex(
                name: "IX_JudgmentPool_LawyerJudgmentId",
                table: "JudgmentPool",
                column: "LawyerJudgmentId");

            migrationBuilder.CreateIndex(
                name: "IX_JudgmentPool_SearchTypeId",
                table: "JudgmentPool",
                column: "SearchTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_JudgmentPool_UserId",
                table: "JudgmentPool",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Judgments_CommissionId",
                table: "Judgments",
                column: "CommissionId");

            migrationBuilder.CreateIndex(
                name: "IX_Judgments_CourtId",
                table: "Judgments",
                column: "CourtId");

            migrationBuilder.CreateIndex(
                name: "IX_Judgments_JudgmentTypeId",
                table: "Judgments",
                column: "JudgmentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_LawyerJudgments_CommissionId",
                table: "LawyerJudgments",
                column: "CommissionId");

            migrationBuilder.CreateIndex(
                name: "IX_LawyerJudgments_CourtId",
                table: "LawyerJudgments",
                column: "CourtId");

            migrationBuilder.CreateIndex(
                name: "IX_LawyerJudgments_StateId",
                table: "LawyerJudgments",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_LawyerJudgments_UserId",
                table: "LawyerJudgments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CityId",
                table: "Users",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_DistrictId",
                table: "Users",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserTypeId",
                table: "Users",
                column: "UserTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JudgmentPool");

            migrationBuilder.DropTable(
                name: "Lawyers");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Judgments");

            migrationBuilder.DropTable(
                name: "LawyerJudgments");

            migrationBuilder.DropTable(
                name: "SearchTypes");

            migrationBuilder.DropTable(
                name: "JudgmentTypes");

            migrationBuilder.DropTable(
                name: "Courts");

            migrationBuilder.DropTable(
                name: "LawyerJudgmentState");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Commisions");

            migrationBuilder.DropTable(
                name: "Districts");

            migrationBuilder.DropTable(
                name: "UserTypes");

            migrationBuilder.DropTable(
                name: "City");
        }
    }
}
