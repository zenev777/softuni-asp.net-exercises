using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskBoardApp.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "81c522e8-333f-4f79-8cfa-124d6cafb293");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "7ce104e4-9308-4b52-9856-8ec0eba413bf", 0, "2388a399-166f-4b54-8332-9bdaeb11f49d", null, false, false, null, null, "TEST@SOFTUNI.BG", "AQAAAAEAACcQAAAAEG7hQVvOhVV0aPck4bl3biPW4WD5kms3KA8FSIupRTv6X6BjsD5kpbBXEjyI4pqcuQ==", null, false, "49c149da-abae-43cd-b07f-9e0bbfbce584", false, "test@softuni.bg" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "OwnerId" },
                values: new object[] { new DateTime(2023, 7, 29, 15, 49, 43, 609, DateTimeKind.Utc).AddTicks(7652), "7ce104e4-9308-4b52-9856-8ec0eba413bf" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "OwnerId" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 49, 43, 609, DateTimeKind.Utc).AddTicks(7661), "7ce104e4-9308-4b52-9856-8ec0eba413bf" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "OwnerId" },
                values: new object[] { new DateTime(2023, 12, 26, 15, 49, 43, 609, DateTimeKind.Utc).AddTicks(7662), "7ce104e4-9308-4b52-9856-8ec0eba413bf" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "OwnerId" },
                values: new object[] { new DateTime(2024, 2, 14, 15, 49, 43, 609, DateTimeKind.Utc).AddTicks(7663), "7ce104e4-9308-4b52-9856-8ec0eba413bf" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7ce104e4-9308-4b52-9856-8ec0eba413bf");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "81c522e8-333f-4f79-8cfa-124d6cafb293", 0, "3fb99bcc-ce7d-49c6-9a4a-52d17f198057", null, false, false, null, null, "TEST@SOFTUNI.BG", "AQAAAAEAACcQAAAAEGbVUm7NkNOQIgAPhR1fiPPvnQHv96/boPuDg/KGQVQM7m+oaPn1TC1s3+2hJZwcDg==", null, false, "7db6e585-5d19-4af4-8318-c48456eccabf", false, "test@softuni.bg" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "OwnerId" },
                values: new object[] { new DateTime(2023, 7, 29, 15, 47, 16, 496, DateTimeKind.Utc).AddTicks(5829), "81c522e8-333f-4f79-8cfa-124d6cafb293" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "OwnerId" },
                values: new object[] { new DateTime(2023, 11, 6, 15, 47, 16, 496, DateTimeKind.Utc).AddTicks(5867), "81c522e8-333f-4f79-8cfa-124d6cafb293" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "OwnerId" },
                values: new object[] { new DateTime(2023, 12, 26, 15, 47, 16, 496, DateTimeKind.Utc).AddTicks(5869), "81c522e8-333f-4f79-8cfa-124d6cafb293" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "OwnerId" },
                values: new object[] { new DateTime(2024, 2, 14, 15, 47, 16, 496, DateTimeKind.Utc).AddTicks(5870), "81c522e8-333f-4f79-8cfa-124d6cafb293" });
        }
    }
}
