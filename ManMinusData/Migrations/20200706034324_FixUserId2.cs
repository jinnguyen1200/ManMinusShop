using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ManMinusData.Migrations
{
    public partial class FixUserId2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_AspNetUsers_UserId1",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_UserId1",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Order");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Order",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("96d5afdc-18bd-4d01-9ecb-0b8ba81db4e6"),
                column: "ConcurrencyStamp",
                value: "16ecb6a7-6091-452d-8a76-b755f62c3033");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("592fdcb8-75a3-4f4d-afe8-c5c8648b3026"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "110feff6-3f9f-467d-b3a6-a6bb6cf4a205", "AQAAAAEAACcQAAAAEEAXBAx7aWQFW0MX0co3bzn9rBW5If7PoUjh7s+M5McS9t8e1GrXk64tDFjOGjYoKQ==" });

            migrationBuilder.CreateIndex(
                name: "IX_Order_UserId",
                table: "Order",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_AspNetUsers_UserId",
                table: "Order",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_AspNetUsers_UserId",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_UserId",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Order");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId1",
                table: "Order",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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

            migrationBuilder.CreateIndex(
                name: "IX_Order_UserId1",
                table: "Order",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_AspNetUsers_UserId1",
                table: "Order",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
