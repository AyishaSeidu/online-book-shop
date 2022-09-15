using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineBookShop.Api.Migrations
{
    public partial class AddBookQuanties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                columns: new[] { "ImageURL", "Quantity" },
                values: new object[] { "Images/Playwrights/our_husband_has_gone_mad_again", 12 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImageURL", "Quantity" },
                values: new object[] { "/Images/Novels/americana", 7 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ImageURL", "Quantity" },
                values: new object[] { "/Images/Novels/pride_and_prejudice", 10 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ImageURL", "Quantity" },
                values: new object[] { "/Images/Documentaries/the_darwin_award", 8 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ImageURL", "Quantity" },
                values: new object[] { "/Images/Fantasies/harry_porter_and_the_sorcerers_stone", 50 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "GenreID", "ImageURL", "Quantity" },
                values: new object[] { 1, "/Images/Fantasies/fantastic_beasts", 100 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ImageURL", "Quantity" },
                values: new object[] { "/Images/Sciences/cosmos", 56 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ImageURL", "Quantity" },
                values: new object[] { "/Images/Sciences/the_demon_haunted_world", 10 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ImageURL", "Quantity" },
                values: new object[] { "/Images/Wealth/the_psychology_of_money", 37 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Books");

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
                columns: new[] { "GenreID", "ImageURL" },
                values: new object[] { 2, "/Images/Fantasies/fantastic_beasts.jpg" });

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
        }
    }
}
