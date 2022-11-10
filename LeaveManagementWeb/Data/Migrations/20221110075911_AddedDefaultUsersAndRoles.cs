using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementWeb.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "43383d91-4380-42d3-8220-16c2d6e72be8", "82b11dab-7170-4093-99d9-e5cbe2ad414d", "Administrator", "ADMINISTRATOR" },
                    { "53383a91-4380-42b3-8220-16a2d6d72be8", "cd991398-3716-4f94-84e5-68da3a66adb3", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "32517b00-6e34-411e-9644-10b401abc185", 0, "ba552033-7deb-4da0-a396-ac5a9b4824cf", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@localhost.com", false, "System", "User", false, null, "USER@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEL5/2W9KBHwVleMpVBBz7kmDcsObiJq+rDG9r8mQ1XP+MlffuJ2/AooYJXPTL7Mrbw==", null, false, "a3efb127-ef91-4185-9009-58ead6170450", null, false, null },
                    { "63383f91-4380-42e3-8220-16d2d6e72be8", 0, "de65d08a-4438-4ced-beda-d7f68e6d793b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEMmvxDMHyC73AGhKhgpvutTLltWZcBCd7n9uMCSVq1WzQb66ZbpvNYh13uxiiH62BQ==", null, false, "15006582-e592-4a68-b54f-ed356a80318a", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "53383a91-4380-42b3-8220-16a2d6d72be8", "32517b00-6e34-411e-9644-10b401abc185" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "43383d91-4380-42d3-8220-16c2d6e72be8", "63383f91-4380-42e3-8220-16d2d6e72be8" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "53383a91-4380-42b3-8220-16a2d6d72be8", "32517b00-6e34-411e-9644-10b401abc185" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "43383d91-4380-42d3-8220-16c2d6e72be8", "63383f91-4380-42e3-8220-16d2d6e72be8" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "43383d91-4380-42d3-8220-16c2d6e72be8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "53383a91-4380-42b3-8220-16a2d6d72be8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32517b00-6e34-411e-9644-10b401abc185");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "63383f91-4380-42e3-8220-16d2d6e72be8");
        }
    }
}
