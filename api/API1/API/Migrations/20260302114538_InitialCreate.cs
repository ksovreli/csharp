using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "author",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    first_name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    last_name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_author", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "books",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    author = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    price = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    release_date = table.Column<DateOnly>(type: "date", nullable: false),
                    genre = table.Column<int>(type: "int", nullable: false),
                    quantity = table.Column<long>(type: "bigint", nullable: false),
                    page_number = table.Column<long>(type: "bigint", nullable: false),
                    isbn = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    publisher = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    translator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    language = table.Column<int>(type: "int", nullable: false),
                    is_original = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_books", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "author");

            migrationBuilder.DropTable(
                name: "books");
        }
    }
}
