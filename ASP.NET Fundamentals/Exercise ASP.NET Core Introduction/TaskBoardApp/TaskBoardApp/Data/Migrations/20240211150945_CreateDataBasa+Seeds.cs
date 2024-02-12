using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskBoardApp.Data.Migrations
{
    public partial class CreateDataBasaSeeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Boards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Board indetifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, comment: "Board name")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Task identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false, comment: "Task title"),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false, comment: "Task Description"),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "Date of creation"),
                    BoardId = table.Column<int>(type: "int", nullable: true, comment: "Board identifier"),
                    OwnerId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Application user identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tasks_AspNetUsers_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tasks_Boards_BoardId",
                        column: x => x.BoardId,
                        principalTable: "Boards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "Board Task");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "ec274a58-f250-4e4c-82ab-3dbd0a49c928", 0, "d33b9a06-d261-467e-9318-1fbb3de33be1", null, false, false, null, null, "TEST@SOFTUNI.BG", "AQAAAAEAACcQAAAAEOz1jG163LtxKAb6xZYUPopwit6Qf8j/tthmmLtzuc2e6muvYNs8N6FQ3RpqNtF5+g==", null, false, "9636f887-8760-42ca-8b9b-38cb3cbcc5dd", false, "test@softuni.bg" });

            migrationBuilder.InsertData(
                table: "Boards",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Open" },
                    { 2, "In Progress" },
                    { 3, "Done" }
                });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "BoardId", "CreatedOn", "Description", "OwnerId", "Title" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 7, 26, 17, 9, 45, 623, DateTimeKind.Local).AddTicks(1493), "Implement better styling for all public pages", "ec274a58-f250-4e4c-82ab-3dbd0a49c928", "Improve CCS style" },
                    { 2, 1, new DateTime(2023, 9, 11, 17, 9, 45, 623, DateTimeKind.Local).AddTicks(1549), "Create Android client app for the TaskBoard RESTful API", "ec274a58-f250-4e4c-82ab-3dbd0a49c928", "Android Client App" },
                    { 3, 2, new DateTime(2024, 1, 11, 17, 9, 45, 623, DateTimeKind.Local).AddTicks(1553), "Create Windows Forms desktop app client for the TaskBoard RESTful API", "ec274a58-f250-4e4c-82ab-3dbd0a49c928", "Desktop Client App" },
                    { 4, 3, new DateTime(2023, 2, 11, 17, 9, 45, 623, DateTimeKind.Local).AddTicks(1556), "Implement [Create Task] page for adding new tasks", "ec274a58-f250-4e4c-82ab-3dbd0a49c928", "Create Tasks" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_BoardId",
                table: "Tasks",
                column: "BoardId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_OwnerId",
                table: "Tasks",
                column: "OwnerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.DropTable(
                name: "Boards");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ec274a58-f250-4e4c-82ab-3dbd0a49c928");
        }
    }
}
