using Microsoft.EntityFrameworkCore.Migrations;

namespace Pw2doufamzenaposled.Data.Migrations
{
    public partial class SeedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0062e652-cd28-430a-98b9-20be1b3bff8f", "e0d13a1a-9be4-4632-aadc-b753af657a55", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "240c1af1-e28e-406a-8116-657a3acf5d17", "d0258150-54e0-4dc5-b97f-0651e8a2035d", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0062e652-cd28-430a-98b9-20be1b3bff8f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "240c1af1-e28e-406a-8116-657a3acf5d17");
        }
    }
}
