using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineBookShop.Api.Migrations
{
    public partial class correctBookDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageURL", "Quantity" },
                values: new object[] { "/Images/Playwrights/the_gods_are_not_to_blame.jpg", 17 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageURL",
                value: "Images/Playwrights/our_husband_has_gone_mad_again.jpg");

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
                columns: new[] { "GenreID", "ImageURL" },
                values: new object[] { 2, "/Images/Fantasies/harry_porter_and_the_sorcerers_stone.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "GenreID", "ImageURL" },
                values: new object[] { 2, "/Images/Fantasies/fantastic_beasts.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorID", "ImageURL" },
                values: new object[] { 2, "/Images/Sciences/cosmos.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorID", "ImageURL" },
                values: new object[] { 2, "/Images/Sciences/the_demon_haunted_world.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageURL",
                value: "/Images/Wealth/the_psychology_of_money.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageURL", "Quantity" },
                values: new object[] { "/Images/Playwrights/the_gods_are_not_to_blame", 0 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageURL",
                value: "Images/Playwrights/our_husband_has_gone_mad_again");

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
                columns: new[] { "GenreID", "ImageURL" },
                values: new object[] { 1, "/Images/Fantasies/harry_porter_and_the_sorcerers_stone" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "GenreID", "ImageURL" },
                values: new object[] { 1, "/Images/Fantasies/fantastic_beasts" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorID", "ImageURL" },
                values: new object[] { 3, "/Images/Sciences/cosmos" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorID", "ImageURL" },
                values: new object[] { 3, "/Images/Sciences/the_demon_haunted_world" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageURL",
                value: "/Images/Wealth/the_psychology_of_money");
        }
    }
}
