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
                    TypeId = table.Column<int>(type: "int", nullable: false),
                    TypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                name: "Judgments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JudgmentTypeId = table.Column<int>(type: "int", nullable: false),
                    CommisionName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Court = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
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
                    CommisionName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Court = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Decree = table.Column<string>(type: "nvarchar(max)", maxLength: 9999999, nullable: false),
                    LawyerAssessment = table.Column<string>(type: "nvarchar(max)", maxLength: 9999999, nullable: false),
                    DecreeType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MeritsYear = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MeritsNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DecreeYear = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DecreeNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Decision = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TBBComments = table.Column<string>(type: "nvarchar(max)", maxLength: 99999, nullable: false),
                    StateId = table.Column<int>(type: "int", nullable: false),
                    Likes = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LawyerJudgments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LawyerJudgments_LawyerJudgmentState_StateId",
                        column: x => x.StateId,
                        principalTable: "LawyerJudgmentState",
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
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                        name: "FK_Users_UserTypes_UserTypeId",
                        column: x => x.UserTypeId,
                        principalTable: "UserTypes",
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

            migrationBuilder.InsertData(
                table: "JudgmentTypes",
                columns: new[] { "Id", "CreateDate", "TypeId", "TypeName" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 11, 22, 14, 42, 16, 141, DateTimeKind.Local).AddTicks(3680), 1, "Yargıtay" },
                    { 2, new DateTime(2022, 11, 22, 14, 42, 16, 141, DateTimeKind.Local).AddTicks(3710), 2, "Danıştay" },
                    { 3, new DateTime(2022, 11, 22, 14, 42, 16, 141, DateTimeKind.Local).AddTicks(3720), 3, "Anayasa Mahkemesi" }
                });

            migrationBuilder.InsertData(
                table: "LawyerJudgmentState",
                columns: new[] { "Id", "CreateDate", "TypeId", "TypeName" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 11, 22, 14, 42, 16, 128, DateTimeKind.Local).AddTicks(6080), 1, "Onaya Gönderildi" },
                    { 2, new DateTime(2022, 11, 22, 14, 42, 16, 137, DateTimeKind.Local).AddTicks(9070), 2, "Onay Bekliyor" },
                    { 3, new DateTime(2022, 11, 22, 14, 42, 16, 137, DateTimeKind.Local).AddTicks(9090), 3, "Reddedildi" },
                    { 4, new DateTime(2022, 11, 22, 14, 42, 16, 137, DateTimeKind.Local).AddTicks(9100), 4, "Onaylandı" }
                });

            migrationBuilder.InsertData(
                table: "SearchTypes",
                columns: new[] { "Id", "CreateDate", "TypeId", "TypeName" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 11, 22, 14, 42, 16, 140, DateTimeKind.Local).AddTicks(6590), 1, "Avukatın Eklediği Kararlar" },
                    { 2, new DateTime(2022, 11, 22, 14, 42, 16, 140, DateTimeKind.Local).AddTicks(6620), 2, "Yüksek Yargı Kararları" }
                });

            migrationBuilder.InsertData(
                table: "UserTypes",
                columns: new[] { "Id", "CreateDate", "TypeId", "TypeName" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 11, 22, 14, 42, 16, 139, DateTimeKind.Local).AddTicks(8010), 1, "Avukat-Avukat Stajyeri" },
                    { 2, new DateTime(2022, 11, 22, 14, 42, 16, 139, DateTimeKind.Local).AddTicks(8040), 2, "Öğrenci" },
                    { 3, new DateTime(2022, 11, 22, 14, 42, 16, 139, DateTimeKind.Local).AddTicks(8040), 3, "TBB Kullanıcısı" }
                });

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
                name: "IX_Judgments_JudgmentTypeId",
                table: "Judgments",
                column: "JudgmentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_LawyerJudgments_StateId",
                table: "LawyerJudgments",
                column: "StateId");

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
                name: "Users");

            migrationBuilder.DropTable(
                name: "JudgmentTypes");

            migrationBuilder.DropTable(
                name: "LawyerJudgmentState");

            migrationBuilder.DropTable(
                name: "UserTypes");
        }
    }
}
