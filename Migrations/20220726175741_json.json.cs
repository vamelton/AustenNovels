using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AustenNovels.Migrations
{
    public partial class jsonjson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    PublishedYear = table.Column<double>(type: "REAL", nullable: false),
                    Characters = table.Column<string>(type: "TEXT", nullable: false),
                    Summary = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "ID", "Characters", "PublishedYear", "Summary", "Title" },
                values: new object[] { 1, "Elinor Dashwood, Marianne Dashwood, Edward Ferrars, Colonel Christopher Brandon, John Willoughby, Mrs. Jennings, Lucy Steele", 1811.0, "Sisters Elinor and Marianne Dashwood along with their mother and younger sister find themselves borderline penniless and homeless once their father dies.  His estate is left to his first wife's son instead. A relative provides a cottage away from what they know for the family to move into.  As the sister begin settling into their new lives they learn about love, happiness, and life.", "Sense and Sensibility" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "ID", "Characters", "PublishedYear", "Summary", "Title" },
                values: new object[] { 2, "Fitzwilliam Darcy, Elizabeth Bennet, Charles Bingley, Jane Bennet, Caroline Bingley, George Wickham, Lydia Bennet, Mr. Bennet, Mrs. Bennet", 1813.0, "Eilizabeth Bennet's first impression of Fitzwilliam Darcy is an arrogant and snob of a man.  However, as Darcy becomes more acquainted with Elizabeth he begins to fall for her wit and intelligence. Between false accusations and possible scandal, Elizabeth's wonders if her first impressions were too harsh. Has her pride gotten in the way of her true feelings for Darcy?  Is it too late to tell Darcy how she really feels?", "Pride and Prejudice" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "ID", "Characters", "PublishedYear", "Summary", "Title" },
                values: new object[] { 3, "Fanny Price, Edmund Bertram, Mary Crawford, Henry Crawford", 1814.0, "Fanny Price was ten years old when she moved from poverty to live with her wealthy aunt and cousins at Mansfield Park. Allowed to not forget her humble beginnings, Fanny does not have allies at Mansfield Park outside her cousin, Edmund. Henry and Mary Crawford arrive in the neighborhood from London and stir a series of acts that lead to scandal and heartbreak. During this period, will Fanny stand her ground and protect her heart for Edmund?", "Mansfield Park" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "ID", "Characters", "PublishedYear", "Summary", "Title" },
                values: new object[] { 4, "Emma Woodhouse, George Knightley, Harriet Smith, Frank Churchill, Jane Fairfax", 1815.0, "Emma Woodhouse loves to play match maker when given the opportunity.  Emma is beautiful, witty, aggrogant and believes things will go her way. However when her match matching skills begin to fail, will she be able to rise above?  Will she find love herself?", "Emma" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "ID", "Characters", "PublishedYear", "Summary", "Title" },
                values: new object[] { 5, "Anne Elliot, Captain Frederick Wentworth, Lady Russell, William Elliot, Lousia Musgrove", 1817.0, "Anne Elliot is a sweet tempered young woman who is persuaded to end her engagement with Frederick Wentworth over his lack of fortune. Eight years later, Captain Wentworth has returned to England rich and successful however has not forgiven Anne.  Anne has since matured and become more independent, and still in love with him. As Captain Wentworth and Anne Elliot become more and more in each others circles, will their love resurface?", "Persuasion" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "ID", "Characters", "PublishedYear", "Summary", "Title" },
                values: new object[] { 6, "Catherine Morland, Henry Tilney, James Morland, Isabella Thorpe, John Thorpe, Eleanor Tilney", 1817.0, "Catherine Morland's first journey away from home is to Bath with family friends.  While in Bath she meets Isabella Thorpe amd Henry Tilney. This new friendship leads to an invitiatoin to vist the Tilney's home at Northanger Abbey.  While staying with the Tilney's, Catherine learns of their families past and makes some wild accusations. Will Catherine and Henry be able to mend their relationship after such false claims?", "Northanger Abbey" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
