using Microsoft.EntityFrameworkCore.Migrations;

namespace Kucni_poslovi.Migrations
{
    public partial class mssqllocal_migration_804 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7b5767d7-ba17-4f16-8b54-71c5431fc331");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "deb12b8d-32b6-4dd2-8a2b-d78ae7334df5");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1d6a5ca3-634c-4321-b6b9-ec26252f18d8", "f42d0e31-6255-4f0b-bcd7-0fc6823bd1a7", "KorisnikUsluge", "KORISNIKUSLUGE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8032a6e0-cb6b-49ed-9ef5-6359d955b705", "7667d89e-fac4-4373-95a8-a6e4213ee0e9", "PruzalacUsluge", "PRUZALACUSLUGE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "deb12b8d-32b6-4dd2-8a2b-d78ae7334df5", "43809918-b002-40b0-9077-b7ac8332c04e", "KorisnikUsluge", "KORISNIKUSLUGE" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7b5767d7-ba17-4f16-8b54-71c5431fc331", "88f8e77e-3164-42fc-adf2-97f905a99f16", "PruzalacUsluge", "PRUZALACUSLUGE" });
        }
    }
}
