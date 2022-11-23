using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Karartek.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class userid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "LawyerJudgments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "JudgmentTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 11, 23, 17, 2, 37, 747, DateTimeKind.Local).AddTicks(5160));

            migrationBuilder.UpdateData(
                table: "JudgmentTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 11, 23, 17, 2, 37, 747, DateTimeKind.Local).AddTicks(5190));

            migrationBuilder.UpdateData(
                table: "JudgmentTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 11, 23, 17, 2, 37, 747, DateTimeKind.Local).AddTicks(5200));

            migrationBuilder.UpdateData(
                table: "LawyerJudgmentState",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 11, 23, 17, 2, 37, 734, DateTimeKind.Local).AddTicks(9510));

            migrationBuilder.UpdateData(
                table: "LawyerJudgmentState",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 11, 23, 17, 2, 37, 743, DateTimeKind.Local).AddTicks(8470));

            migrationBuilder.UpdateData(
                table: "LawyerJudgmentState",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 11, 23, 17, 2, 37, 743, DateTimeKind.Local).AddTicks(8490));

            migrationBuilder.UpdateData(
                table: "LawyerJudgmentState",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2022, 11, 23, 17, 2, 37, 743, DateTimeKind.Local).AddTicks(8490));

            migrationBuilder.UpdateData(
                table: "SearchTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 11, 23, 17, 2, 37, 746, DateTimeKind.Local).AddTicks(7610));

            migrationBuilder.UpdateData(
                table: "SearchTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 11, 23, 17, 2, 37, 746, DateTimeKind.Local).AddTicks(7650));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 11, 23, 17, 2, 37, 745, DateTimeKind.Local).AddTicks(9120));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 11, 23, 17, 2, 37, 745, DateTimeKind.Local).AddTicks(9160));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 11, 23, 17, 2, 37, 745, DateTimeKind.Local).AddTicks(9160));

            migrationBuilder.CreateIndex(
                name: "IX_LawyerJudgments_UserId",
                table: "LawyerJudgments",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_LawyerJudgments_Users_UserId",
                table: "LawyerJudgments",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LawyerJudgments_Users_UserId",
                table: "LawyerJudgments");

            migrationBuilder.DropIndex(
                name: "IX_LawyerJudgments_UserId",
                table: "LawyerJudgments");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "LawyerJudgments");

            migrationBuilder.UpdateData(
                table: "JudgmentTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 11, 23, 9, 53, 40, 447, DateTimeKind.Local).AddTicks(910));

            migrationBuilder.UpdateData(
                table: "JudgmentTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 11, 23, 9, 53, 40, 447, DateTimeKind.Local).AddTicks(940));

            migrationBuilder.UpdateData(
                table: "JudgmentTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 11, 23, 9, 53, 40, 447, DateTimeKind.Local).AddTicks(950));

            migrationBuilder.UpdateData(
                table: "LawyerJudgmentState",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 11, 23, 9, 53, 40, 434, DateTimeKind.Local).AddTicks(3570));

            migrationBuilder.UpdateData(
                table: "LawyerJudgmentState",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 11, 23, 9, 53, 40, 443, DateTimeKind.Local).AddTicks(4740));

            migrationBuilder.UpdateData(
                table: "LawyerJudgmentState",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 11, 23, 9, 53, 40, 443, DateTimeKind.Local).AddTicks(4760));

            migrationBuilder.UpdateData(
                table: "LawyerJudgmentState",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2022, 11, 23, 9, 53, 40, 443, DateTimeKind.Local).AddTicks(4770));

            migrationBuilder.UpdateData(
                table: "SearchTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 11, 23, 9, 53, 40, 446, DateTimeKind.Local).AddTicks(3190));

            migrationBuilder.UpdateData(
                table: "SearchTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 11, 23, 9, 53, 40, 446, DateTimeKind.Local).AddTicks(3230));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 11, 23, 9, 53, 40, 445, DateTimeKind.Local).AddTicks(5160));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 11, 23, 9, 53, 40, 445, DateTimeKind.Local).AddTicks(5200));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 11, 23, 9, 53, 40, 445, DateTimeKind.Local).AddTicks(5200));
        }
    }
}
