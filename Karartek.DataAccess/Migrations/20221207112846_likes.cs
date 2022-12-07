using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Karartek.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class likes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TBBComments",
                table: "LawyerJudgments",
                type: "nvarchar(max)",
                maxLength: 99999,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldMaxLength: 99999);

            migrationBuilder.AlterColumn<int>(
                name: "StateId",
                table: "LawyerJudgments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "UserLikes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LawyerJudgmentId = table.Column<int>(type: "int", nullable: false),
                    isLike = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLikes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserLikes_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "JudgmentTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 12, 7, 14, 28, 45, 3, DateTimeKind.Local).AddTicks(550));

            migrationBuilder.UpdateData(
                table: "JudgmentTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 12, 7, 14, 28, 45, 3, DateTimeKind.Local).AddTicks(620));

            migrationBuilder.UpdateData(
                table: "JudgmentTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 12, 7, 14, 28, 45, 3, DateTimeKind.Local).AddTicks(620));

            migrationBuilder.UpdateData(
                table: "LawyerJudgmentState",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 12, 7, 14, 28, 44, 981, DateTimeKind.Local).AddTicks(6390));

            migrationBuilder.UpdateData(
                table: "LawyerJudgmentState",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 12, 7, 14, 28, 44, 996, DateTimeKind.Local).AddTicks(7450));

            migrationBuilder.UpdateData(
                table: "LawyerJudgmentState",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 12, 7, 14, 28, 44, 996, DateTimeKind.Local).AddTicks(7490));

            migrationBuilder.UpdateData(
                table: "LawyerJudgmentState",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2022, 12, 7, 14, 28, 44, 996, DateTimeKind.Local).AddTicks(7500));

            migrationBuilder.UpdateData(
                table: "SearchTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 12, 7, 14, 28, 45, 1, DateTimeKind.Local).AddTicks(7100));

            migrationBuilder.UpdateData(
                table: "SearchTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 12, 7, 14, 28, 45, 1, DateTimeKind.Local).AddTicks(7160));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 12, 7, 14, 28, 45, 0, DateTimeKind.Local).AddTicks(3820));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 12, 7, 14, 28, 45, 0, DateTimeKind.Local).AddTicks(3880));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 12, 7, 14, 28, 45, 0, DateTimeKind.Local).AddTicks(3890));

            migrationBuilder.CreateIndex(
                name: "IX_UserLikes_UserId",
                table: "UserLikes",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserLikes");

            migrationBuilder.AlterColumn<string>(
                name: "TBBComments",
                table: "LawyerJudgments",
                type: "nvarchar(max)",
                maxLength: 99999,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldMaxLength: 99999,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "StateId",
                table: "LawyerJudgments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "JudgmentTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 12, 1, 18, 1, 55, 184, DateTimeKind.Local).AddTicks(7750));

            migrationBuilder.UpdateData(
                table: "JudgmentTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 12, 1, 18, 1, 55, 184, DateTimeKind.Local).AddTicks(7800));

            migrationBuilder.UpdateData(
                table: "JudgmentTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 12, 1, 18, 1, 55, 184, DateTimeKind.Local).AddTicks(7800));

            migrationBuilder.UpdateData(
                table: "LawyerJudgmentState",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 12, 1, 18, 1, 55, 168, DateTimeKind.Local).AddTicks(8470));

            migrationBuilder.UpdateData(
                table: "LawyerJudgmentState",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 12, 1, 18, 1, 55, 181, DateTimeKind.Local).AddTicks(160));

            migrationBuilder.UpdateData(
                table: "LawyerJudgmentState",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 12, 1, 18, 1, 55, 181, DateTimeKind.Local).AddTicks(180));

            migrationBuilder.UpdateData(
                table: "LawyerJudgmentState",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2022, 12, 1, 18, 1, 55, 181, DateTimeKind.Local).AddTicks(180));

            migrationBuilder.UpdateData(
                table: "SearchTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 12, 1, 18, 1, 55, 183, DateTimeKind.Local).AddTicks(9820));

            migrationBuilder.UpdateData(
                table: "SearchTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 12, 1, 18, 1, 55, 183, DateTimeKind.Local).AddTicks(9860));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 12, 1, 18, 1, 55, 183, DateTimeKind.Local).AddTicks(2530));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 12, 1, 18, 1, 55, 183, DateTimeKind.Local).AddTicks(2570));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 12, 1, 18, 1, 55, 183, DateTimeKind.Local).AddTicks(2570));
        }
    }
}
