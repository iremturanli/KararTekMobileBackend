using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Karartek.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class changeDistric : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_City_CityId",
                table: "Users");

            migrationBuilder.AlterColumn<int>(
                name: "DistrictId",
                table: "Users",
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
                value: new DateTime(2022, 11, 23, 20, 27, 28, 680, DateTimeKind.Local).AddTicks(1593));

            migrationBuilder.UpdateData(
                table: "JudgmentTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 11, 23, 20, 27, 28, 680, DateTimeKind.Local).AddTicks(1640));

            migrationBuilder.UpdateData(
                table: "JudgmentTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 11, 23, 20, 27, 28, 680, DateTimeKind.Local).AddTicks(1643));

            migrationBuilder.UpdateData(
                table: "LawyerJudgmentState",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 11, 23, 20, 27, 28, 668, DateTimeKind.Local).AddTicks(6171));

            migrationBuilder.UpdateData(
                table: "LawyerJudgmentState",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 11, 23, 20, 27, 28, 674, DateTimeKind.Local).AddTicks(587));

            migrationBuilder.UpdateData(
                table: "LawyerJudgmentState",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 11, 23, 20, 27, 28, 674, DateTimeKind.Local).AddTicks(616));

            migrationBuilder.UpdateData(
                table: "LawyerJudgmentState",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2022, 11, 23, 20, 27, 28, 674, DateTimeKind.Local).AddTicks(619));

            migrationBuilder.UpdateData(
                table: "SearchTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 11, 23, 20, 27, 28, 678, DateTimeKind.Local).AddTicks(9517));

            migrationBuilder.UpdateData(
                table: "SearchTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 11, 23, 20, 27, 28, 678, DateTimeKind.Local).AddTicks(9552));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 11, 23, 20, 27, 28, 677, DateTimeKind.Local).AddTicks(8158));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 11, 23, 20, 27, 28, 677, DateTimeKind.Local).AddTicks(8211));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 11, 23, 20, 27, 28, 677, DateTimeKind.Local).AddTicks(8215));

            migrationBuilder.AddForeignKey(
                name: "FK_Users_City_CityId",
                table: "Users",
                column: "CityId",
                principalTable: "City",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_City_CityId",
                table: "Users");

            migrationBuilder.AlterColumn<int>(
                name: "DistrictId",
                table: "Users",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "JudgmentTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 11, 23, 18, 49, 50, 987, DateTimeKind.Local).AddTicks(9329));

            migrationBuilder.UpdateData(
                table: "JudgmentTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 11, 23, 18, 49, 50, 987, DateTimeKind.Local).AddTicks(9366));

            migrationBuilder.UpdateData(
                table: "JudgmentTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 11, 23, 18, 49, 50, 987, DateTimeKind.Local).AddTicks(9369));

            migrationBuilder.UpdateData(
                table: "LawyerJudgmentState",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 11, 23, 18, 49, 50, 981, DateTimeKind.Local).AddTicks(3283));

            migrationBuilder.UpdateData(
                table: "LawyerJudgmentState",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 11, 23, 18, 49, 50, 983, DateTimeKind.Local).AddTicks(3442));

            migrationBuilder.UpdateData(
                table: "LawyerJudgmentState",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 11, 23, 18, 49, 50, 983, DateTimeKind.Local).AddTicks(3458));

            migrationBuilder.UpdateData(
                table: "LawyerJudgmentState",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2022, 11, 23, 18, 49, 50, 983, DateTimeKind.Local).AddTicks(3460));

            migrationBuilder.UpdateData(
                table: "SearchTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 11, 23, 18, 49, 50, 986, DateTimeKind.Local).AddTicks(7524));

            migrationBuilder.UpdateData(
                table: "SearchTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 11, 23, 18, 49, 50, 986, DateTimeKind.Local).AddTicks(7566));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2022, 11, 23, 18, 49, 50, 985, DateTimeKind.Local).AddTicks(8928));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2022, 11, 23, 18, 49, 50, 985, DateTimeKind.Local).AddTicks(8979));

            migrationBuilder.UpdateData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2022, 11, 23, 18, 49, 50, 985, DateTimeKind.Local).AddTicks(8981));

            migrationBuilder.AddForeignKey(
                name: "FK_Users_City_CityId",
                table: "Users",
                column: "CityId",
                principalTable: "City",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
