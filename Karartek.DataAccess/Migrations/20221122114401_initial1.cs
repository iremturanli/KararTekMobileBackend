using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Karartek.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class initial1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JudgmentPool_LawyerJudgments_LawyerJudgmentId",
                table: "JudgmentPool");

            migrationBuilder.DropIndex(
                name: "IX_JudgmentPool_LawyerJudgmentId",
                table: "JudgmentPool");

            migrationBuilder.DropColumn(
                name: "LawyerJudgmentId",
                table: "JudgmentPool");

            migrationBuilder.UpdateData(
                table: "JudgmentTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 11, 22, 14, 44, 0, 387, DateTimeKind.Local).AddTicks(3990));

            migrationBuilder.UpdateData(
                table: "JudgmentTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 11, 22, 14, 44, 0, 387, DateTimeKind.Local).AddTicks(4020));

            migrationBuilder.UpdateData(
                table: "JudgmentTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 11, 22, 14, 44, 0, 387, DateTimeKind.Local).AddTicks(4020));

            migrationBuilder.UpdateData(
                table: "LawyerJudgmentState",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 11, 22, 14, 44, 0, 374, DateTimeKind.Local).AddTicks(690));

            migrationBuilder.UpdateData(
                table: "LawyerJudgmentState",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 11, 22, 14, 44, 0, 383, DateTimeKind.Local).AddTicks(5600));

            migrationBuilder.UpdateData(
                table: "LawyerJudgmentState",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 11, 22, 14, 44, 0, 383, DateTimeKind.Local).AddTicks(5620));

            migrationBuilder.UpdateData(
                table: "LawyerJudgmentState",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2022, 11, 22, 14, 44, 0, 383, DateTimeKind.Local).AddTicks(5620));

            migrationBuilder.UpdateData(
                table: "SearchTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 11, 22, 14, 44, 0, 386, DateTimeKind.Local).AddTicks(7000));

            migrationBuilder.UpdateData(
                table: "SearchTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 11, 22, 14, 44, 0, 386, DateTimeKind.Local).AddTicks(7030));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 11, 22, 14, 44, 0, 385, DateTimeKind.Local).AddTicks(9070));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 11, 22, 14, 44, 0, 385, DateTimeKind.Local).AddTicks(9140));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 11, 22, 14, 44, 0, 385, DateTimeKind.Local).AddTicks(9140));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LawyerJudgmentId",
                table: "JudgmentPool",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "JudgmentTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 11, 22, 14, 42, 16, 141, DateTimeKind.Local).AddTicks(3680));

            migrationBuilder.UpdateData(
                table: "JudgmentTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 11, 22, 14, 42, 16, 141, DateTimeKind.Local).AddTicks(3710));

            migrationBuilder.UpdateData(
                table: "JudgmentTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 11, 22, 14, 42, 16, 141, DateTimeKind.Local).AddTicks(3720));

            migrationBuilder.UpdateData(
                table: "LawyerJudgmentState",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 11, 22, 14, 42, 16, 128, DateTimeKind.Local).AddTicks(6080));

            migrationBuilder.UpdateData(
                table: "LawyerJudgmentState",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 11, 22, 14, 42, 16, 137, DateTimeKind.Local).AddTicks(9070));

            migrationBuilder.UpdateData(
                table: "LawyerJudgmentState",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 11, 22, 14, 42, 16, 137, DateTimeKind.Local).AddTicks(9090));

            migrationBuilder.UpdateData(
                table: "LawyerJudgmentState",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2022, 11, 22, 14, 42, 16, 137, DateTimeKind.Local).AddTicks(9100));

            migrationBuilder.UpdateData(
                table: "SearchTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 11, 22, 14, 42, 16, 140, DateTimeKind.Local).AddTicks(6590));

            migrationBuilder.UpdateData(
                table: "SearchTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 11, 22, 14, 42, 16, 140, DateTimeKind.Local).AddTicks(6620));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 11, 22, 14, 42, 16, 139, DateTimeKind.Local).AddTicks(8010));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 11, 22, 14, 42, 16, 139, DateTimeKind.Local).AddTicks(8040));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 11, 22, 14, 42, 16, 139, DateTimeKind.Local).AddTicks(8040));

            migrationBuilder.CreateIndex(
                name: "IX_JudgmentPool_LawyerJudgmentId",
                table: "JudgmentPool",
                column: "LawyerJudgmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_JudgmentPool_LawyerJudgments_LawyerJudgmentId",
                table: "JudgmentPool",
                column: "LawyerJudgmentId",
                principalTable: "LawyerJudgments",
                principalColumn: "Id");
        }
    }
}
