using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementWeb.Data.Migrations
{
    public partial class AddedDefaultUsersAndRolesupdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "43383d91-4380-42d3-8220-16c2d6e72be8",
                column: "ConcurrencyStamp",
                value: "1d29a7cc-72a1-4fb4-97cc-5ebcf8534738");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "53383a91-4380-42b3-8220-16a2d6d72be8",
                column: "ConcurrencyStamp",
                value: "c630f67f-5902-48c7-a1d0-d54c2e83e658");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32517b00-6e34-411e-9644-10b401abc185",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "93c15dac-c8f5-4c73-bfdd-30b5e1b142d9", true, "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEL8Y15/c2rg5Gsdtgw5hwKd5TWclJuudb5csTmsB+bFlcnM9pp1oyQ312o3MArlE+A==", "8b617a9b-ccdb-4c70-babd-a874703b07fd", "user@localhost.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "63383f91-4380-42e3-8220-16d2d6e72be8",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "6e6464f3-f960-4bc5-b9d8-7a8f0b4b0724", true, "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEFESVuHwDEOxskDK3zdE4fED59MkuS2A8v7yi+Pok2p5pK/+u/Y25WtEocDa869vhA==", "2547e5cf-108b-4c03-a836-7d7010a16019", "admin@localhost.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "43383d91-4380-42d3-8220-16c2d6e72be8",
                column: "ConcurrencyStamp",
                value: "82b11dab-7170-4093-99d9-e5cbe2ad414d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "53383a91-4380-42b3-8220-16a2d6d72be8",
                column: "ConcurrencyStamp",
                value: "cd991398-3716-4f94-84e5-68da3a66adb3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32517b00-6e34-411e-9644-10b401abc185",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "ba552033-7deb-4da0-a396-ac5a9b4824cf", false, null, "AQAAAAEAACcQAAAAEL5/2W9KBHwVleMpVBBz7kmDcsObiJq+rDG9r8mQ1XP+MlffuJ2/AooYJXPTL7Mrbw==", "a3efb127-ef91-4185-9009-58ead6170450", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "63383f91-4380-42e3-8220-16d2d6e72be8",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "de65d08a-4438-4ced-beda-d7f68e6d793b", false, null, "AQAAAAEAACcQAAAAEMmvxDMHyC73AGhKhgpvutTLltWZcBCd7n9uMCSVq1WzQb66ZbpvNYh13uxiiH62BQ==", "15006582-e592-4a68-b54f-ed356a80318a", null });
        }
    }
}
