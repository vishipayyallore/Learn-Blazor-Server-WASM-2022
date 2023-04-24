using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CoffeeShop.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddedTimeStamp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<byte[]>(
                name: "Timestamp",
                table: "Employees",
                type: "rowversion",
                rowVersion: true,
                nullable: true);

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DepartmentId", "FirstName", "IsDeveloper", "LastName" },
                values: new object[,]
                {
                    { new Guid("044ccb1c-5703-4896-a95e-93b1ea6b6bd2"), new Guid("5af7e850-75d0-42cf-aeba-996811fe6015"), "Yvonne", true, "Snider" },
                    { new Guid("09c21161-f816-4866-8edf-1527c62aa5d6"), new Guid("5af7e850-75d0-42cf-aeba-996811fe6014"), "Alex", true, "Rider" },
                    { new Guid("0d50fea4-0275-497d-a110-f6cf601bd069"), new Guid("5af7e850-75d0-42cf-aeba-996811fe6015"), "Sophie", false, "Ramos" },
                    { new Guid("0f126378-3c29-4760-b511-f83c41617f01"), new Guid("5af7e850-75d0-42cf-aeba-996811fe6016"), "Iii", false, "Developer" },
                    { new Guid("208c4a40-579c-4137-8e2f-defe6301097f"), new Guid("5af7e850-75d0-42cf-aeba-996811fe6015"), "Hhh", true, "Snider" },
                    { new Guid("52355a13-481f-4332-877d-b202b9a77e4a"), new Guid("5af7e850-75d0-42cf-aeba-996811fe6014"), "Fff", true, "Rider" },
                    { new Guid("61a880ab-c659-47c6-81c7-15dd9ade5776"), new Guid("5af7e850-75d0-42cf-aeba-996811fe6016"), "Jjj", true, "Huber" },
                    { new Guid("671b3a77-e0cc-4c96-ad4e-247b7e5f202e"), new Guid("5af7e850-75d0-42cf-aeba-996811fe6015"), "Ggg", false, "Ramos" },
                    { new Guid("6a252fc9-4acc-4c15-8ada-3a07d944379a"), new Guid("5af7e850-75d0-42cf-aeba-996811fe6013"), "Anna", false, "Rockstar" },
                    { new Guid("80dfa629-37c9-4e67-b974-3cd7d9fa0e98"), new Guid("5af7e850-75d0-42cf-aeba-996811fe6014"), "Ben", false, "Rockstar" },
                    { new Guid("86e42885-ed16-4e98-907e-0e65caf482d4"), new Guid("5af7e850-75d0-42cf-aeba-996811fe6016"), "Julia", false, "Developer" },
                    { new Guid("898e6eae-4022-4e70-ba62-6b0dc11410ed"), new Guid("5af7e850-75d0-42cf-aeba-996811fe6013"), "Ccc", false, "Rockstar" },
                    { new Guid("8b97a7a0-3c9f-40b0-9bce-48671c4d2038"), new Guid("5af7e850-75d0-42cf-aeba-996811fe6013"), "Ddd", true, "Russell" },
                    { new Guid("8eb682f4-01a0-478e-95ac-047928f41eae"), new Guid("5af7e850-75d0-42cf-aeba-996811fe6013"), "Julien", true, "Russell" },
                    { new Guid("913dc0cc-cf3c-4682-9785-a1ac663e977f"), new Guid("5af7e850-75d0-42cf-aeba-996811fe6012"), "Sara", false, "Metroid" },
                    { new Guid("996d0449-e96b-4a79-883c-d6bb7be82e74"), new Guid("5af7e850-75d0-42cf-aeba-996811fe6016"), "Thomas", true, "Huber" },
                    { new Guid("b499b4ac-4882-489f-bf9d-b6c40699e36f"), new Guid("5af7e850-75d0-42cf-aeba-996811fe6014"), "Eee", false, "Rockstar" },
                    { new Guid("c535b761-0a98-4756-a5a8-b6bbf982c18f"), new Guid("5af7e850-75d0-42cf-aeba-996811fe6012"), "Aaa", false, "Metroid" },
                    { new Guid("cf90f97c-9e84-4d3c-a0cd-9db1292eb361"), new Guid("5af7e850-75d0-42cf-aeba-996811fe6012"), "Bbb", true, "Curtis" },
                    { new Guid("fc129ad8-158f-492a-8042-9c01af85df4b"), new Guid("5af7e850-75d0-42cf-aeba-996811fe6012"), "Jasmin", true, "Curtis" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("044ccb1c-5703-4896-a95e-93b1ea6b6bd2"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("09c21161-f816-4866-8edf-1527c62aa5d6"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("0d50fea4-0275-497d-a110-f6cf601bd069"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("0f126378-3c29-4760-b511-f83c41617f01"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("208c4a40-579c-4137-8e2f-defe6301097f"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("52355a13-481f-4332-877d-b202b9a77e4a"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("61a880ab-c659-47c6-81c7-15dd9ade5776"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("671b3a77-e0cc-4c96-ad4e-247b7e5f202e"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("6a252fc9-4acc-4c15-8ada-3a07d944379a"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("80dfa629-37c9-4e67-b974-3cd7d9fa0e98"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("86e42885-ed16-4e98-907e-0e65caf482d4"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("898e6eae-4022-4e70-ba62-6b0dc11410ed"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("8b97a7a0-3c9f-40b0-9bce-48671c4d2038"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("8eb682f4-01a0-478e-95ac-047928f41eae"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("913dc0cc-cf3c-4682-9785-a1ac663e977f"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("996d0449-e96b-4a79-883c-d6bb7be82e74"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("b499b4ac-4882-489f-bf9d-b6c40699e36f"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("c535b761-0a98-4756-a5a8-b6bbf982c18f"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("cf90f97c-9e84-4d3c-a0cd-9db1292eb361"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("fc129ad8-158f-492a-8042-9c01af85df4b"));

            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "Employees");

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
    }
}
