using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem.Infrastructure.Migrations
{
    public partial class UserExtended : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Agents_UserId",
                table: "Agents");

            migrationBuilder.AlterColumn<string>(
                name: "RenterId",
                table: "Houses",
                type: "nvarchar(450)",
                nullable: true,
                comment: "User id of the renterer",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldComment: "User id of the renterer");

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Houses",
                type: "nvarchar(max)",
                nullable: false,
                comment: "House image url",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldComment: "House image url");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Houses",
                type: "int",
                nullable: false,
                comment: "House Identifier",
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Category Identifier")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<bool>(
                name: "IsApproved",
                table: "Houses",
                type: "bit",
                nullable: false,
                defaultValue: false,
                comment: "Is house approved by admin");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(12)",
                maxLength: 12,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[,]
                {
                    { 1, "user:fullname", "Agent Agentov", "dea12856-c198-4129-b3f3-b893d8395082" },
                    { 2, "user:fullname", "Guest Guestov", "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "01b277b2-5bdb-429c-a362-79c72ee4c0ce", "Guest", "Guestov", "AQAAAAEAACcQAAAAEPiwogQ54xh11zn/ADA4h3EMTRBF5vAY2xCNi1CEAECnmcUoh/YINiPcsmk6OoNVPg==", "26493060-0baa-4be4-afba-4576fd1f99b1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "672388f2-d10b-45cf-8b92-71571779a76d", "Agent", "Agentov", "AQAAAAEAACcQAAAAEEZO1hj39q2QnmPPqKpxfHuP/FpWIsGFcx4aRPiPP11rViJhtVf/W0rdqS6mx/W1BA==", "286b7dc9-8e32-41bf-92ea-58f9fe7aa9d0" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e43ce836-997d-4927-ac59-74e8c41bbfd3", 0, "5426e08d-ae32-4347-822c-8273713598d0", "admin@mail.com", false, "Great", "Admin", false, null, "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAEKVcGNZwoVPlpyozV1c9gzpumXokrrUf2HuNi14ppEqYGotFmnb38zXkDvvaiiR8UA==", null, false, "01cc8245-f7bf-43c2-be56-69088396fa83", false, "admin@mail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[] { 3, "user:fullname", "Great Admin", "e43ce836-997d-4927-ac59-74e8c41bbfd3" });

            migrationBuilder.CreateIndex(
                name: "IX_Houses_RenterId",
                table: "Houses",
                column: "RenterId");

            migrationBuilder.CreateIndex(
                name: "IX_Agents_UserId",
                table: "Agents",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Houses_AspNetUsers_RenterId",
                table: "Houses",
                column: "RenterId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Houses_AspNetUsers_RenterId",
                table: "Houses");

            migrationBuilder.DropIndex(
                name: "IX_Houses_RenterId",
                table: "Houses");

            migrationBuilder.DropIndex(
                name: "IX_Agents_UserId",
                table: "Agents");

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e43ce836-997d-4927-ac59-74e8c41bbfd3");

            migrationBuilder.DropColumn(
                name: "IsApproved",
                table: "Houses");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "RenterId",
                table: "Houses",
                type: "nvarchar(max)",
                nullable: true,
                comment: "User id of the renterer",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true,
                oldComment: "User id of the renterer");

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Houses",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                comment: "House image url",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComment: "House image url");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Houses",
                type: "int",
                nullable: false,
                comment: "Category Identifier",
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "House Identifier")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

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
                name: "IX_Agents_UserId",
                table: "Agents",
                column: "UserId");
        }
    }
}
