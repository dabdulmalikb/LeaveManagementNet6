using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementWeb.Data.Migrations
{
    public partial class addingPeriodColToAllocatgionTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "43383d91-4380-42d3-8220-16c2d6e72be8",
                column: "ConcurrencyStamp",
                value: "df3dd1d2-06b9-43ef-bd50-14d2abc14e43");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "53383a91-4380-42b3-8220-16a2d6d72be8",
                column: "ConcurrencyStamp",
                value: "ac415829-dad9-4f41-b818-03a566227361");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32517b00-6e34-411e-9644-10b401abc185",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5ec1f6e6-1099-4d86-ad37-21c29be0e9ba", "AQAAAAEAACcQAAAAEN5b2ZRdmD5iW3DATJcQeJf0j5Egsu+4L99E2UDfRV9geulqHl3TN+ZekbPiUDHFLQ==", "f9514368-4d1c-4c63-a5f8-0087399025ee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "63383f91-4380-42e3-8220-16d2d6e72be8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "edf48f06-b949-40e1-8f12-4c9ef30a36a7", "AQAAAAEAACcQAAAAENnycrXqv4Vx9Thezb9I6sIqeNYBGyr+7BumlfYmh5t7aXya5xpgwwgsdpieqOI44g==", "f6883be2-d7a7-490b-a154-85eab62ac1a9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "93c15dac-c8f5-4c73-bfdd-30b5e1b142d9", "AQAAAAEAACcQAAAAEL8Y15/c2rg5Gsdtgw5hwKd5TWclJuudb5csTmsB+bFlcnM9pp1oyQ312o3MArlE+A==", "8b617a9b-ccdb-4c70-babd-a874703b07fd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "63383f91-4380-42e3-8220-16d2d6e72be8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6e6464f3-f960-4bc5-b9d8-7a8f0b4b0724", "AQAAAAEAACcQAAAAEFESVuHwDEOxskDK3zdE4fED59MkuS2A8v7yi+Pok2p5pK/+u/Y25WtEocDa869vhA==", "2547e5cf-108b-4c03-a836-7d7010a16019" });
        }
    }
}
