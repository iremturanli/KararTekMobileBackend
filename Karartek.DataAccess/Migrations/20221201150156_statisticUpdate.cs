using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Karartek.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class statisticUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateIndex(
                name: "IX_UserJudgmentStatistics_UserId",
                table: "UserJudgmentStatistics",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_UserJudgmentStatistics_Users_UserId",
                table: "UserJudgmentStatistics",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserJudgmentStatistics_Users_UserId",
                table: "UserJudgmentStatistics");

            migrationBuilder.DropIndex(
                name: "IX_UserJudgmentStatistics_UserId",
                table: "UserJudgmentStatistics");

            migrationBuilder.UpdateData(
                table: "JudgmentTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 12, 1, 17, 5, 4, 553, DateTimeKind.Local).AddTicks(1630));

            migrationBuilder.UpdateData(
                table: "JudgmentTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 12, 1, 17, 5, 4, 553, DateTimeKind.Local).AddTicks(1660));

            migrationBuilder.UpdateData(
                table: "JudgmentTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 12, 1, 17, 5, 4, 553, DateTimeKind.Local).AddTicks(1660));

            migrationBuilder.UpdateData(
                table: "LawyerJudgmentState",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 12, 1, 17, 5, 4, 539, DateTimeKind.Local).AddTicks(7050));

            migrationBuilder.UpdateData(
                table: "LawyerJudgmentState",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 12, 1, 17, 5, 4, 549, DateTimeKind.Local).AddTicks(5520));

            migrationBuilder.UpdateData(
                table: "LawyerJudgmentState",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 12, 1, 17, 5, 4, 549, DateTimeKind.Local).AddTicks(5540));

            migrationBuilder.UpdateData(
                table: "LawyerJudgmentState",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2022, 12, 1, 17, 5, 4, 549, DateTimeKind.Local).AddTicks(5550));

            migrationBuilder.UpdateData(
                table: "SearchTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 12, 1, 17, 5, 4, 552, DateTimeKind.Local).AddTicks(4320));

            migrationBuilder.UpdateData(
                table: "SearchTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 12, 1, 17, 5, 4, 552, DateTimeKind.Local).AddTicks(4350));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 12, 1, 17, 5, 4, 551, DateTimeKind.Local).AddTicks(6810));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 12, 1, 17, 5, 4, 551, DateTimeKind.Local).AddTicks(6910));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 12, 1, 17, 5, 4, 551, DateTimeKind.Local).AddTicks(6920));
        }
    }
}
