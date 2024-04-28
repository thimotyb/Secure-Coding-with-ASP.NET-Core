using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Globomantics.Survey.Migrations.IdentityDb
{
    /// <inheritdoc />
    public partial class CreateUsersRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d3ae8a8f-8c40-4b35-b984-fdf8a915c692", "1", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "526521a2-bd56-4292-ab79-bf4ebd258812", 0, "f5b09051-b5d0-4058-9452-2d57b53ef69f", "SuperAdmin@globomantics.com", true, false, null, "SUPERADMIN@GLOBOMANTICS.COM", "SUPERADMIN@GLOBOMANTICS.COM", "AQAAAAIAAYagAAAAEADnJFygxl5+cmNz664eLg7usmhMqJEPwlrIk74lQhgY92MdWczi/6dITbRXLGYsvg==", null, false, "11f4e677-0a71-4a27-b9dd-6896889565b0", false, "SuperAdmin@globomantics.com" },
                    { "c259a6a4-83d2-4099-a072-41ffd4511ad7", 0, "eb8a9f13-a16a-4036-a13a-6c632ad353d6", "Admin@globomantics.com", true, false, null, "ADMIN@GLOBOMANTICS.COM", "ADMIN@GLOBOMANTICS.COM", "AQAAAAIAAYagAAAAEM0YTrBm98EBeMFfQ1XE0AqcA98Q/zpStDH//CoYiUoim5tiYk1/lpjnRXe/Kx1c2w==", null, false, "61e7ce12-f789-47a8-8e87-43bc5d0d9e95", false, "Admin@globomantics.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[] { 1, "IsManager", "true", "526521a2-bd56-4292-ab79-bf4ebd258812" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "d3ae8a8f-8c40-4b35-b984-fdf8a915c692", "526521a2-bd56-4292-ab79-bf4ebd258812" },
                    { "d3ae8a8f-8c40-4b35-b984-fdf8a915c692", "c259a6a4-83d2-4099-a072-41ffd4511ad7" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d3ae8a8f-8c40-4b35-b984-fdf8a915c692", "526521a2-bd56-4292-ab79-bf4ebd258812" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d3ae8a8f-8c40-4b35-b984-fdf8a915c692", "c259a6a4-83d2-4099-a072-41ffd4511ad7" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d3ae8a8f-8c40-4b35-b984-fdf8a915c692");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "526521a2-bd56-4292-ab79-bf4ebd258812");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c259a6a4-83d2-4099-a072-41ffd4511ad7");
        }
    }
}
