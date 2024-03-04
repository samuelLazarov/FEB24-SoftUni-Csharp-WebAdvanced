using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem.Infrastructure.Migrations
{
    public partial class UniqueConstraintForPhoneNumberAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2e6aa51a-98cf-4349-8eef-a21d7173ca16", "AQAAAAEAACcQAAAAEDPi3G8MSys9coHlfpjnx6P9fbMj2hfipkugZxC0jyq+3hTAMcLt/nsF7DBc5KtUIQ==", "df3c337b-4024-4fba-9aa0-e702a8fcdeae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "05292601-83c0-404d-a7e8-322f3eb45e4c", "AQAAAAEAACcQAAAAEPNedq8umBcqfgcwUHNrSGcjq8SbI5HhOkH3bTCPa68v4RC9AZJezaYU4nNVVBrptQ==", "21415f3f-6745-48ec-b4ce-e4b9b1fa4dbb" });

            migrationBuilder.CreateIndex(
                name: "IX_Agents_PhoneNumber",
                table: "Agents",
                column: "PhoneNumber",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Agents_PhoneNumber",
                table: "Agents");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0be85bfb-3968-4133-abe9-3257bdf6e94a", "AQAAAAEAACcQAAAAEJvy2q6LYxL93y17t6D8x+1Bp0bdMCNdHI9mk8bPTcG8gQ4lvQMgymUMKlOLexv2qQ==", "e7f781d6-2a36-419a-8c8d-f7ac783f0ca2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f9e31510-4759-47d4-95ab-3a68cb3fb46e", "AQAAAAEAACcQAAAAEMqrnBn+1tT9aKWyhoANP9WFCbbI1P0YwlAoW/T6RH9kdHQM4lK97x0wHaRV8o67Yw==", "d307794d-6bdf-4a30-bf29-4ebdadc01546" });
        }
    }
}
