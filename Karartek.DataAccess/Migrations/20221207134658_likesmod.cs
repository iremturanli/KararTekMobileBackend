using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Karartek.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class likesmod : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SearchTypeId",
                table: "UserLikes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TypeId",
                table: "UserLikes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "JudgmentTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 12, 7, 16, 46, 56, 997, DateTimeKind.Local).AddTicks(1550));

            migrationBuilder.UpdateData(
                table: "JudgmentTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 12, 7, 16, 46, 56, 997, DateTimeKind.Local).AddTicks(1580));

            migrationBuilder.UpdateData(
                table: "JudgmentTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 12, 7, 16, 46, 56, 997, DateTimeKind.Local).AddTicks(1580));

            migrationBuilder.UpdateData(
                table: "LawyerJudgmentState",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 12, 7, 16, 46, 56, 983, DateTimeKind.Local).AddTicks(2750));

            migrationBuilder.UpdateData(
                table: "LawyerJudgmentState",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 12, 7, 16, 46, 56, 993, DateTimeKind.Local).AddTicks(3420));

            migrationBuilder.UpdateData(
                table: "LawyerJudgmentState",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 12, 7, 16, 46, 56, 993, DateTimeKind.Local).AddTicks(3440));

            migrationBuilder.UpdateData(
                table: "LawyerJudgmentState",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2022, 12, 7, 16, 46, 56, 993, DateTimeKind.Local).AddTicks(3450));

            migrationBuilder.UpdateData(
                table: "SearchTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 12, 7, 16, 46, 56, 996, DateTimeKind.Local).AddTicks(4430));

            migrationBuilder.UpdateData(
                table: "SearchTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 12, 7, 16, 46, 56, 996, DateTimeKind.Local).AddTicks(4460));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 12, 7, 16, 46, 56, 995, DateTimeKind.Local).AddTicks(6520));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 12, 7, 16, 46, 56, 995, DateTimeKind.Local).AddTicks(6570));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 12, 7, 16, 46, 56, 995, DateTimeKind.Local).AddTicks(6570));

            migrationBuilder.CreateIndex(
                name: "IX_UserLikes_SearchTypeId",
                table: "UserLikes",
                column: "SearchTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserLikes_SearchTypes_SearchTypeId",
                table: "UserLikes",
                column: "SearchTypeId",
                principalTable: "SearchTypes",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserLikes_SearchTypes_SearchTypeId",
                table: "UserLikes");

            migrationBuilder.DropIndex(
                name: "IX_UserLikes_SearchTypeId",
                table: "UserLikes");

            migrationBuilder.DropColumn(
                name: "SearchTypeId",
                table: "UserLikes");

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "UserLikes");

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
        }
    }
}
