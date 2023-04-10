using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CoffeeShop.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("5af7e850-75d0-42cf-aeba-996811fe6012"), "Finance" },
                    { new Guid("5af7e850-75d0-42cf-aeba-996811fe6013"), "Sales" },
                    { new Guid("5af7e850-75d0-42cf-aeba-996811fe6014"), "Marketing" },
                    { new Guid("5af7e850-75d0-42cf-aeba-996811fe6015"), "Human Resources" },
                    { new Guid("5af7e850-75d0-42cf-aeba-996811fe6016"), "IT" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DepartmentId", "FirstName", "IsDeveloper", "LastName" },
                values: new object[,]
                {
                    { new Guid("1b0e17a7-c0bf-4825-95c5-d338dda5f206"), new Guid("5af7e850-75d0-42cf-aeba-996811fe6013"), "Anna", false, "Rockstar" },
                    { new Guid("48570627-f4e7-45ee-9bf0-f37744eaa408"), new Guid("5af7e850-75d0-42cf-aeba-996811fe6013"), "Julien", false, "Russell" },
                    { new Guid("4e6ee4b6-2100-4e6e-a8fc-38c7b76d61be"), new Guid("5af7e850-75d0-42cf-aeba-996811fe6016"), "Thomas", true, "Huber" },
                    { new Guid("6e092e54-7b81-40b4-a28b-3150c308965a"), new Guid("5af7e850-75d0-42cf-aeba-996811fe6012"), "Jasmin", true, "Curtis" },
                    { new Guid("863e90b4-c76c-4cfc-8ff9-f502f3e9500d"), new Guid("5af7e850-75d0-42cf-aeba-996811fe6014"), "Alex", true, "Rider" },
                    { new Guid("8b573f2d-7d44-4ff6-903d-12a7ad6b2421"), new Guid("5af7e850-75d0-42cf-aeba-996811fe6015"), "Yvonne", false, "Snider" },
                    { new Guid("95501e22-6b9a-42c4-a25b-50c9491d678e"), new Guid("5af7e850-75d0-42cf-aeba-996811fe6016"), "Sophie", false, "Ramos" },
                    { new Guid("b79f809b-19a5-4f6a-a776-8141d04d4c57"), new Guid("5af7e850-75d0-42cf-aeba-996811fe6012"), "Sara", false, "Metroid" },
                    { new Guid("bb6309e8-e2e8-491e-9985-f70e4f4a87f7"), new Guid("5af7e850-75d0-42cf-aeba-996811fe6015"), "Ben", false, "Rockstar" },
                    { new Guid("cab67856-d3c5-4c03-bc26-f19683ff6666"), new Guid("5af7e850-75d0-42cf-aeba-996811fe6016"), "Julia", true, "Developer" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("1b0e17a7-c0bf-4825-95c5-d338dda5f206"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("48570627-f4e7-45ee-9bf0-f37744eaa408"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("4e6ee4b6-2100-4e6e-a8fc-38c7b76d61be"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("6e092e54-7b81-40b4-a28b-3150c308965a"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("863e90b4-c76c-4cfc-8ff9-f502f3e9500d"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("8b573f2d-7d44-4ff6-903d-12a7ad6b2421"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("95501e22-6b9a-42c4-a25b-50c9491d678e"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("b79f809b-19a5-4f6a-a776-8141d04d4c57"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("bb6309e8-e2e8-491e-9985-f70e4f4a87f7"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("cab67856-d3c5-4c03-bc26-f19683ff6666"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("5af7e850-75d0-42cf-aeba-996811fe6012"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("5af7e850-75d0-42cf-aeba-996811fe6013"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("5af7e850-75d0-42cf-aeba-996811fe6014"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("5af7e850-75d0-42cf-aeba-996811fe6015"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("5af7e850-75d0-42cf-aeba-996811fe6016"));
        }
    }
}
