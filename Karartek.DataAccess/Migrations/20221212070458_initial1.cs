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
                name: "FK_JudgmentPool_Judgments_JudgmentId",
                table: "JudgmentPool");

            migrationBuilder.AlterColumn<int>(
                name: "JudgmentId",
                table: "JudgmentPool",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DecisionId",
                table: "JudgmentPool",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "JudgmentTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 12, 12, 10, 4, 57, 284, DateTimeKind.Local).AddTicks(630));

            migrationBuilder.UpdateData(
                table: "JudgmentTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 12, 12, 10, 4, 57, 284, DateTimeKind.Local).AddTicks(670));

            migrationBuilder.UpdateData(
                table: "JudgmentTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 12, 12, 10, 4, 57, 284, DateTimeKind.Local).AddTicks(680));

            migrationBuilder.UpdateData(
                table: "LawyerJudgmentState",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 12, 12, 10, 4, 57, 271, DateTimeKind.Local).AddTicks(9480));

            migrationBuilder.UpdateData(
                table: "LawyerJudgmentState",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 12, 12, 10, 4, 57, 280, DateTimeKind.Local).AddTicks(5210));

            migrationBuilder.UpdateData(
                table: "LawyerJudgmentState",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 12, 12, 10, 4, 57, 280, DateTimeKind.Local).AddTicks(5230));

            migrationBuilder.UpdateData(
                table: "LawyerJudgmentState",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2022, 12, 12, 10, 4, 57, 280, DateTimeKind.Local).AddTicks(5240));

            migrationBuilder.UpdateData(
                table: "SearchTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 12, 12, 10, 4, 57, 283, DateTimeKind.Local).AddTicks(3000));

            migrationBuilder.UpdateData(
                table: "SearchTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 12, 12, 10, 4, 57, 283, DateTimeKind.Local).AddTicks(3040));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 12, 12, 10, 4, 57, 282, DateTimeKind.Local).AddTicks(5710));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 12, 12, 10, 4, 57, 282, DateTimeKind.Local).AddTicks(5750));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 12, 12, 10, 4, 57, 282, DateTimeKind.Local).AddTicks(5760));

            migrationBuilder.AddForeignKey(
                name: "FK_JudgmentPool_Judgments_JudgmentId",
                table: "JudgmentPool",
                column: "JudgmentId",
                principalTable: "Judgments",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JudgmentPool_Judgments_JudgmentId",
                table: "JudgmentPool");

            migrationBuilder.DropColumn(
                name: "DecisionId",
                table: "JudgmentPool");

            migrationBuilder.AlterColumn<int>(
                name: "JudgmentId",
                table: "JudgmentPool",
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
                value: new DateTime(2022, 12, 12, 9, 40, 32, 465, DateTimeKind.Local).AddTicks(7570));

            migrationBuilder.UpdateData(
                table: "JudgmentTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 12, 12, 9, 40, 32, 465, DateTimeKind.Local).AddTicks(7600));

            migrationBuilder.UpdateData(
                table: "JudgmentTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 12, 12, 9, 40, 32, 465, DateTimeKind.Local).AddTicks(7600));

            migrationBuilder.UpdateData(
                table: "LawyerJudgmentState",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 12, 12, 9, 40, 32, 452, DateTimeKind.Local).AddTicks(6580));

            migrationBuilder.UpdateData(
                table: "LawyerJudgmentState",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 12, 12, 9, 40, 32, 461, DateTimeKind.Local).AddTicks(2040));

            migrationBuilder.UpdateData(
                table: "LawyerJudgmentState",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 12, 12, 9, 40, 32, 461, DateTimeKind.Local).AddTicks(2060));

            migrationBuilder.UpdateData(
                table: "LawyerJudgmentState",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2022, 12, 12, 9, 40, 32, 461, DateTimeKind.Local).AddTicks(2070));

            migrationBuilder.UpdateData(
                table: "SearchTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 12, 12, 9, 40, 32, 464, DateTimeKind.Local).AddTicks(9480));

            migrationBuilder.UpdateData(
                table: "SearchTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 12, 12, 9, 40, 32, 464, DateTimeKind.Local).AddTicks(9520));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 12, 12, 9, 40, 32, 463, DateTimeKind.Local).AddTicks(9690));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 12, 12, 9, 40, 32, 463, DateTimeKind.Local).AddTicks(9790));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 12, 12, 9, 40, 32, 463, DateTimeKind.Local).AddTicks(9790));

            migrationBuilder.AddForeignKey(
                name: "FK_JudgmentPool_Judgments_JudgmentId",
                table: "JudgmentPool",
                column: "JudgmentId",
                principalTable: "Judgments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
