using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ManMinusData.Migrations
{
    public partial class FixUserId1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Order");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("96d5afdc-18bd-4d01-9ecb-0b8ba81db4e6"),
                column: "ConcurrencyStamp",
                value: "048c52bb-ccb1-4e9d-8b84-201a5dd2f29a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("592fdcb8-75a3-4f4d-afe8-c5c8648b3026"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e4948460-1331-4581-a0f7-25e35caedbfa", "AQAAAAEAACcQAAAAEGOIqaAP/GudPhQpmhaAzV4dGdLZJR2Em7zUQV2Lys+r06O3H6jL4Mp1FvIajk2ncw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Order",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("96d5afdc-18bd-4d01-9ecb-0b8ba81db4e6"),
                column: "ConcurrencyStamp",
                value: "cb091fc2-d1ac-4c5a-9bef-1ec2c2799c64");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("592fdcb8-75a3-4f4d-afe8-c5c8648b3026"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "82ab52b2-6312-44e2-9261-d5263c94a865", "AQAAAAEAACcQAAAAEG+Sda4Fzd5FF4S6Y39sa9jwjRgLTauKSq6xjfs4KBDJ5R3QIcB4d1dF9SdhBtfCxA==" });
        }
    }
}
