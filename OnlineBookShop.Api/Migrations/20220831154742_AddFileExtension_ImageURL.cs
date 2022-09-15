using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineBookShop.Api.Migrations
{
    public partial class AddFileExtension_ImageURL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageURL",
                value: "/Images/Playwrights/the_gods_are_not_to_blame.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageURL",
                value: "/Images/Playwrights/our_husband_has_gone_mad_again.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageURL",
                value: "/Images/Novels/americana.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageURL",
                value: "/Images/Novels/pride_and_prejudice.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageURL",
                value: "/Images/Documentaries/the_darwin_award.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageURL",
                value: "/Images/Fantasies/harry_porter_and_the_sorcerers_stone.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageURL",
                value: "/Images/Fantasies/fantastic_beasts.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageURL",
                value: "/Images/Sciences/cosmos.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageURL",
                value: "/Images/Sciences/the_demon_haunted_world.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageURL",
                value: "/Images/Wealth/the_psychology_of_money.jpg");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_BookID",
                table: "CartItems",
                column: "BookID");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_CartID",
                table: "CartItems",
                column: "CartID");

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorID",
                table: "Books",
                column: "AuthorID");

            migrationBuilder.CreateIndex(
                name: "IX_Books_GenreID",
                table: "Books",
                column: "GenreID");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Authors_AuthorID",
                table: "Books",
                column: "AuthorID",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Genres_GenreID",
                table: "Books",
                column: "GenreID",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_Books_BookID",
                table: "CartItems",
                column: "BookID",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_Carts_CartID",
                table: "CartItems",
                column: "CartID",
                principalTable: "Carts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Authors_AuthorID",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Genres_GenreID",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_Books_BookID",
                table: "CartItems");

            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_Carts_CartID",
                table: "CartItems");

            migrationBuilder.DropIndex(
                name: "IX_CartItems_BookID",
                table: "CartItems");

            migrationBuilder.DropIndex(
                name: "IX_CartItems_CartID",
                table: "CartItems");

            migrationBuilder.DropIndex(
                name: "IX_Books_AuthorID",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_GenreID",
                table: "Books");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageURL",
                value: "/Images/Playwrights/the_gods_are_not_to_blame");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageURL",
                value: "/Images/Playwrights/our_husband_has_gone_mad_again");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageURL",
                value: "/Images/Novels/americana");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageURL",
                value: "/Images/Novels/pride_and_prejudice");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageURL",
                value: "/Images/Documentaries/the_darwin_award");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageURL",
                value: "/Images/Fantasies/harry_porter_and_the_sorcerers_stone");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageURL",
                value: "/Images/Fantasies/fantastic_beasts");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageURL",
                value: "/Images/Sciences/cosmos");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageURL",
                value: "/Images/Sciences/the_demon_haunted_world");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageURL",
                value: "/Images/Wealth/the_psychology_of_money");
        }
    }
}
