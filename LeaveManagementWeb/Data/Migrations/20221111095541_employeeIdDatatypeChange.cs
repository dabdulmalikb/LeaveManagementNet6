using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementWeb.Data.Migrations
{
    public partial class employeeIdDatatypeChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "EmployeeId",
                table: "LeaveAllocations",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "43383d91-4380-42d3-8220-16c2d6e72be8",
                column: "ConcurrencyStamp",
                value: "2c2044ff-8f93-483e-9702-c0596e05bb5e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "53383a91-4380-42b3-8220-16a2d6d72be8",
                column: "ConcurrencyStamp",
                value: "e0c6ce35-f54a-45c8-a3cd-2124dd4da48d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32517b00-6e34-411e-9644-10b401abc185",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f289a1b3-c0e7-4b76-b090-cd82283620c6", "AQAAAAEAACcQAAAAEIisUyIwnSowKx1m2GZ7+ADltqkDG4w37aLdBFP++22aPvRzjyYB56/meqIt3w4bnA==", "8ce3aeee-c2ec-45e9-be15-7cb63d4f7cdc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "63383f91-4380-42e3-8220-16d2d6e72be8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d83469a3-d87c-4c26-a96d-06f96e2adbbb", "AQAAAAEAACcQAAAAEA8chzeJlu5eGG0UqQIuGvx8toOVEgkShaLeZkWJ1MFx1n5qiLyBLyjo+Y9+WQYtVA==", "7b7a4289-fb48-4dfb-852c-288cf57dcbac" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
    }
}
