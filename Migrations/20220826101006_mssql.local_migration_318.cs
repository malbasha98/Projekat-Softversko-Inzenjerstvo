using Microsoft.EntityFrameworkCore.Migrations;

namespace Kucni_poslovi.Migrations
{
    public partial class mssqllocal_migration_318 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1d6a5ca3-634c-4321-b6b9-ec26252f18d8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8032a6e0-cb6b-49ed-9ef5-6359d955b705");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b226a08d-0dbe-4262-9954-e0f6692aad99", "1efd39f6-0a61-4785-8d68-219bf7b24197", "KorisnikUsluge", "KORISNIKUSLUGE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e2dcaa85-0ab5-4b92-9cc8-7a7e537c6cd6", "eab927ac-c69d-448c-ab5e-3e373ee9e063", "PruzalacUsluge", "PRUZALACUSLUGE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b226a08d-0dbe-4262-9954-e0f6692aad99");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e2dcaa85-0ab5-4b92-9cc8-7a7e537c6cd6");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1d6a5ca3-634c-4321-b6b9-ec26252f18d8", "f42d0e31-6255-4f0b-bcd7-0fc6823bd1a7", "KorisnikUsluge", "KORISNIKUSLUGE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8032a6e0-cb6b-49ed-9ef5-6359d955b705", "7667d89e-fac4-4373-95a8-a6e4213ee0e9", "PruzalacUsluge", "PRUZALACUSLUGE" });
        }
    }
}
