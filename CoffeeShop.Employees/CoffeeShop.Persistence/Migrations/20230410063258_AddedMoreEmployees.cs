using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CoffeeShop.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddedMoreEmployees : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DepartmentId", "FirstName", "IsDeveloper", "LastName" },
                values: new object[,]
                {
                    { new Guid("02ad0d59-5b78-4338-b0f6-b66cb71be4b1"), new Guid("5af7e850-75d0-42cf-aeba-996811fe6014"), "Ben", false, "Rockstar" },
                    { new Guid("34b8e70c-6a74-4af5-94d7-ac20b9817ef3"), new Guid("5af7e850-75d0-42cf-aeba-996811fe6013"), "Julien", true, "Russell" },
                    { new Guid("38d0787c-489d-4168-ba63-294882ed8808"), new Guid("5af7e850-75d0-42cf-aeba-996811fe6015"), "Sophie", false, "Ramos" },
                    { new Guid("4d9fdefc-9bf8-469f-b4e9-3baf250ab0be"), new Guid("5af7e850-75d0-42cf-aeba-996811fe6012"), "Bbb", true, "Curtis" },
                    { new Guid("5139920d-d071-4809-aa9a-07a7ffb4cc98"), new Guid("5af7e850-75d0-42cf-aeba-996811fe6016"), "Iii", false, "Developer" },
                    { new Guid("595310ca-b66d-419b-964d-e73e1bf4a3b3"), new Guid("5af7e850-75d0-42cf-aeba-996811fe6015"), "Yvonne", true, "Snider" },
                    { new Guid("5963b3dc-18bb-4ac5-a3dc-05630f069098"), new Guid("5af7e850-75d0-42cf-aeba-996811fe6013"), "Ddd", true, "Russell" },
                    { new Guid("69589598-33c0-4593-9792-4219e0fe553f"), new Guid("5af7e850-75d0-42cf-aeba-996811fe6012"), "Jasmin", true, "Curtis" },
                    { new Guid("6fd18729-26df-4c99-ae01-dcfdc5810239"), new Guid("5af7e850-75d0-42cf-aeba-996811fe6014"), "Eee", false, "Rockstar" },
                    { new Guid("7ac281aa-3289-45af-baa6-dbffeec37e0b"), new Guid("5af7e850-75d0-42cf-aeba-996811fe6015"), "Hhh", true, "Snider" },
                    { new Guid("7d7f81c9-63cf-4aa4-a90c-70ca08d890e2"), new Guid("5af7e850-75d0-42cf-aeba-996811fe6013"), "Ccc", false, "Rockstar" },
                    { new Guid("7d8d3542-8e85-4b0d-9d43-9fdaf5b858fa"), new Guid("5af7e850-75d0-42cf-aeba-996811fe6016"), "Julia", false, "Developer" },
                    { new Guid("900217bf-931e-4fb8-acdf-c21a54c0de5a"), new Guid("5af7e850-75d0-42cf-aeba-996811fe6016"), "Jjj", true, "Huber" },
                    { new Guid("9b2fb5c9-0cfb-4bb3-8a28-45ef4a424f5c"), new Guid("5af7e850-75d0-42cf-aeba-996811fe6015"), "Ggg", false, "Ramos" },
                    { new Guid("b1ba54a4-690a-4419-b28b-90bcec91f64d"), new Guid("5af7e850-75d0-42cf-aeba-996811fe6012"), "Aaa", false, "Metroid" },
                    { new Guid("c4ce122c-d991-4474-a6ad-7fa7a52866f3"), new Guid("5af7e850-75d0-42cf-aeba-996811fe6014"), "Alex", true, "Rider" },
                    { new Guid("c617b0d8-3c2c-40eb-a233-3f561828634e"), new Guid("5af7e850-75d0-42cf-aeba-996811fe6016"), "Thomas", true, "Huber" },
                    { new Guid("d01e1d6b-3ff2-49e3-af9d-867e76c7f9c4"), new Guid("5af7e850-75d0-42cf-aeba-996811fe6014"), "Fff", true, "Rider" },
                    { new Guid("f256d5b7-7846-429f-9a92-0fd8716c7562"), new Guid("5af7e850-75d0-42cf-aeba-996811fe6012"), "Sara", false, "Metroid" },
                    { new Guid("fab82060-46dd-43f9-bb31-ffc57afc1c4e"), new Guid("5af7e850-75d0-42cf-aeba-996811fe6013"), "Anna", false, "Rockstar" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("02ad0d59-5b78-4338-b0f6-b66cb71be4b1"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("34b8e70c-6a74-4af5-94d7-ac20b9817ef3"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("38d0787c-489d-4168-ba63-294882ed8808"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("4d9fdefc-9bf8-469f-b4e9-3baf250ab0be"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("5139920d-d071-4809-aa9a-07a7ffb4cc98"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("595310ca-b66d-419b-964d-e73e1bf4a3b3"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("5963b3dc-18bb-4ac5-a3dc-05630f069098"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("69589598-33c0-4593-9792-4219e0fe553f"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("6fd18729-26df-4c99-ae01-dcfdc5810239"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("7ac281aa-3289-45af-baa6-dbffeec37e0b"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("7d7f81c9-63cf-4aa4-a90c-70ca08d890e2"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("7d8d3542-8e85-4b0d-9d43-9fdaf5b858fa"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("900217bf-931e-4fb8-acdf-c21a54c0de5a"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("9b2fb5c9-0cfb-4bb3-8a28-45ef4a424f5c"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("b1ba54a4-690a-4419-b28b-90bcec91f64d"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("c4ce122c-d991-4474-a6ad-7fa7a52866f3"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("c617b0d8-3c2c-40eb-a233-3f561828634e"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("d01e1d6b-3ff2-49e3-af9d-867e76c7f9c4"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("f256d5b7-7846-429f-9a92-0fd8716c7562"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("fab82060-46dd-43f9-bb31-ffc57afc1c4e"));

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
    }
}
