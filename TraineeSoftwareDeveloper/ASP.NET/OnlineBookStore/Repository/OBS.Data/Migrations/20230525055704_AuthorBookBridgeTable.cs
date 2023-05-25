using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OBS.Data.Migrations
{
    /// <inheritdoc />
    public partial class AuthorBookBridgeTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AuthorBook_Author_AuthorsID",
                table: "AuthorBook");

            migrationBuilder.DropForeignKey(
                name: "FK_AuthorBook_Book_BooksID",
                table: "AuthorBook");

            migrationBuilder.RenameColumn(
                name: "BooksID",
                table: "AuthorBook",
                newName: "BookID");

            migrationBuilder.RenameColumn(
                name: "AuthorsID",
                table: "AuthorBook",
                newName: "AuthorID");

            migrationBuilder.RenameIndex(
                name: "IX_AuthorBook_BooksID",
                table: "AuthorBook",
                newName: "IX_AuthorBook_BookID");

            migrationBuilder.AddForeignKey(
                name: "FK_AuthorBook_Author_AuthorID",
                table: "AuthorBook",
                column: "AuthorID",
                principalTable: "Author",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AuthorBook_Book_BookID",
                table: "AuthorBook",
                column: "BookID",
                principalTable: "Book",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AuthorBook_Author_AuthorID",
                table: "AuthorBook");

            migrationBuilder.DropForeignKey(
                name: "FK_AuthorBook_Book_BookID",
                table: "AuthorBook");

            migrationBuilder.RenameColumn(
                name: "BookID",
                table: "AuthorBook",
                newName: "BooksID");

            migrationBuilder.RenameColumn(
                name: "AuthorID",
                table: "AuthorBook",
                newName: "AuthorsID");

            migrationBuilder.RenameIndex(
                name: "IX_AuthorBook_BookID",
                table: "AuthorBook",
                newName: "IX_AuthorBook_BooksID");

            migrationBuilder.AddForeignKey(
                name: "FK_AuthorBook_Author_AuthorsID",
                table: "AuthorBook",
                column: "AuthorsID",
                principalTable: "Author",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AuthorBook_Book_BooksID",
                table: "AuthorBook",
                column: "BooksID",
                principalTable: "Book",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
