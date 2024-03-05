using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SeminarHub.Data.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seminar_AspNetUsers_OrganizerId",
                table: "Seminar");

            migrationBuilder.DropForeignKey(
                name: "FK_Seminar_Category_CategoryId",
                table: "Seminar");

            migrationBuilder.DropForeignKey(
                name: "FK_SeminarParticipant_AspNetUsers_ParticipantId",
                table: "SeminarParticipant");

            migrationBuilder.DropForeignKey(
                name: "FK_SeminarParticipant_Seminar_SeminarId",
                table: "SeminarParticipant");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SeminarParticipant",
                table: "SeminarParticipant");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Seminar",
                table: "Seminar");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.RenameTable(
                name: "SeminarParticipant",
                newName: "SeminarParticipants");

            migrationBuilder.RenameTable(
                name: "Seminar",
                newName: "Seminars");

            migrationBuilder.RenameTable(
                name: "Category",
                newName: "Categories");

            migrationBuilder.RenameIndex(
                name: "IX_SeminarParticipant_ParticipantId",
                table: "SeminarParticipants",
                newName: "IX_SeminarParticipants_ParticipantId");

            migrationBuilder.RenameIndex(
                name: "IX_Seminar_OrganizerId",
                table: "Seminars",
                newName: "IX_Seminars_OrganizerId");

            migrationBuilder.RenameIndex(
                name: "IX_Seminar_CategoryId",
                table: "Seminars",
                newName: "IX_Seminars_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SeminarParticipants",
                table: "SeminarParticipants",
                columns: new[] { "SeminarId", "ParticipantId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Seminars",
                table: "Seminars",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SeminarParticipants_AspNetUsers_ParticipantId",
                table: "SeminarParticipants",
                column: "ParticipantId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SeminarParticipants_Seminars_SeminarId",
                table: "SeminarParticipants",
                column: "SeminarId",
                principalTable: "Seminars",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Seminars_AspNetUsers_OrganizerId",
                table: "Seminars",
                column: "OrganizerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Seminars_Categories_CategoryId",
                table: "Seminars",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SeminarParticipants_AspNetUsers_ParticipantId",
                table: "SeminarParticipants");

            migrationBuilder.DropForeignKey(
                name: "FK_SeminarParticipants_Seminars_SeminarId",
                table: "SeminarParticipants");

            migrationBuilder.DropForeignKey(
                name: "FK_Seminars_AspNetUsers_OrganizerId",
                table: "Seminars");

            migrationBuilder.DropForeignKey(
                name: "FK_Seminars_Categories_CategoryId",
                table: "Seminars");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Seminars",
                table: "Seminars");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SeminarParticipants",
                table: "SeminarParticipants");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "Seminars",
                newName: "Seminar");

            migrationBuilder.RenameTable(
                name: "SeminarParticipants",
                newName: "SeminarParticipant");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Category");

            migrationBuilder.RenameIndex(
                name: "IX_Seminars_OrganizerId",
                table: "Seminar",
                newName: "IX_Seminar_OrganizerId");

            migrationBuilder.RenameIndex(
                name: "IX_Seminars_CategoryId",
                table: "Seminar",
                newName: "IX_Seminar_CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_SeminarParticipants_ParticipantId",
                table: "SeminarParticipant",
                newName: "IX_SeminarParticipant_ParticipantId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Seminar",
                table: "Seminar",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SeminarParticipant",
                table: "SeminarParticipant",
                columns: new[] { "SeminarId", "ParticipantId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Seminar_AspNetUsers_OrganizerId",
                table: "Seminar",
                column: "OrganizerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Seminar_Category_CategoryId",
                table: "Seminar",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SeminarParticipant_AspNetUsers_ParticipantId",
                table: "SeminarParticipant",
                column: "ParticipantId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SeminarParticipant_Seminar_SeminarId",
                table: "SeminarParticipant",
                column: "SeminarId",
                principalTable: "Seminar",
                principalColumn: "Id");
        }
    }
}
