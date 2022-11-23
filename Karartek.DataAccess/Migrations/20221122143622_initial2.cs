using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Karartek.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class initial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TypeName",
                table: "LawyerJudgmentState",
                newName: "StateName");

            migrationBuilder.RenameColumn(
                name: "TypeId",
                table: "LawyerJudgmentState",
                newName: "StateId");

            migrationBuilder.AddColumn<int>(
                name: "LawyerJudgmentId",
                table: "JudgmentPool",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "JudgmentTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 11, 22, 17, 36, 21, 626, DateTimeKind.Local).AddTicks(3970));

            migrationBuilder.UpdateData(
                table: "JudgmentTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 11, 22, 17, 36, 21, 626, DateTimeKind.Local).AddTicks(4000));

            migrationBuilder.UpdateData(
                table: "JudgmentTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 11, 22, 17, 36, 21, 626, DateTimeKind.Local).AddTicks(4000));

            migrationBuilder.UpdateData(
                table: "LawyerJudgmentState",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 11, 22, 17, 36, 21, 613, DateTimeKind.Local).AddTicks(1940));

            migrationBuilder.UpdateData(
                table: "LawyerJudgmentState",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 11, 22, 17, 36, 21, 622, DateTimeKind.Local).AddTicks(8800));

            migrationBuilder.UpdateData(
                table: "LawyerJudgmentState",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 11, 22, 17, 36, 21, 622, DateTimeKind.Local).AddTicks(8820));

            migrationBuilder.UpdateData(
                table: "LawyerJudgmentState",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2022, 11, 22, 17, 36, 21, 622, DateTimeKind.Local).AddTicks(8820));

            migrationBuilder.UpdateData(
                table: "SearchTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 11, 22, 17, 36, 21, 625, DateTimeKind.Local).AddTicks(7280));

            migrationBuilder.UpdateData(
                table: "SearchTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 11, 22, 17, 36, 21, 625, DateTimeKind.Local).AddTicks(7310));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 11, 22, 17, 36, 21, 625, DateTimeKind.Local).AddTicks(450));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 11, 22, 17, 36, 21, 625, DateTimeKind.Local).AddTicks(490));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 11, 22, 17, 36, 21, 625, DateTimeKind.Local).AddTicks(490));

            migrationBuilder.CreateIndex(
                name: "IX_JudgmentPool_LawyerJudgmentId",
                table: "JudgmentPool",
                column: "LawyerJudgmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_JudgmentPool_LawyerJudgments_LawyerJudgmentId",
                table: "JudgmentPool",
                column: "LawyerJudgmentId",
                principalTable: "LawyerJudgments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "StateName",
                table: "LawyerJudgmentState",
                newName: "TypeName");

            migrationBuilder.RenameColumn(
                name: "StateId",
                table: "LawyerJudgmentState",
                newName: "TypeId");

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
    }
}
