using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace graphql.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Superheroes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Height = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Superheroes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Instructor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SuperheroId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movies_Superheroes_SuperheroId",
                        column: x => x.SuperheroId,
                        principalTable: "Superheroes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Superpowers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SuperPower = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SuperheroId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Superpowers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Superpowers_Superheroes_SuperheroId",
                        column: x => x.SuperheroId,
                        principalTable: "Superheroes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Superheroes",
                columns: new[] { "Id", "Description", "Height", "Name" },
                values: new object[] { new Guid("79f2dc56-e5b0-490c-b2bd-9acdd09cb954"), "Batman was originally introduced as a ruthless vigilante who frequently killed or maimed criminals, but evolved into a character with a stringent moral code and strong sense of justice. Unlike most superheroes, Batman does not possess any superpowers, instead relying on his intellect, fighting skills, and wealth.", 1.9299999999999999, "Batman" });

            migrationBuilder.InsertData(
                table: "Superheroes",
                columns: new[] { "Id", "Description", "Height", "Name" },
                values: new object[] { new Guid("a065dc4c-759a-4b30-8b2d-ee3e0a428609"), "Black Widow, real name Natasha Romanoff, is a trained female secret agent and superhero that appears in Marvel Comics. Associated with the superhero teams S.H.I.E.L.D. and the Avengers, Black Widow makes up for her lack of superpowers with world class training as an athlete, acrobat, and expert martial artist and weapon specialist.", 1.7, "Black Widow" });

            migrationBuilder.InsertData(
                table: "Superheroes",
                columns: new[] { "Id", "Description", "Height", "Name" },
                values: new object[] { new Guid("a64e038d-028a-4c98-b4fd-29f08bcdd473"), "Luke Skywalker was a Tatooine farmboy who rose from humble beginnings to become one of the greatest Jedi the galaxy has ever known. Along with his friends Princess Leia and Han Solo, Luke battled the evil Empire, discovered the truth of his parentage, and ended the tyranny of the Sith.", 1.7, "Luke Skywalker" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Instructor", "ReleaseDate", "SuperheroId", "Title" },
                values: new object[,]
                {
                    { new Guid("54b059dc-d98c-495b-b7b3-c68b16315d47"), "Black Widow is a 2021 American superhero film based on Marvel Comics featuring the character of the same name. Produced by Marvel Studios and distributed by Walt Disney Studios Motion Pictures, it is the 24th film in the Marvel Cinematic Universe (MCU).", "Cate Shortland", new DateTime(2021, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a065dc4c-759a-4b30-8b2d-ee3e0a428609"), "Black Widow" },
                    { new Guid("93be2564-253b-43fb-b1ed-4bc00affb9d9"), "Return of the Jedi (also known as Star Wars: Episode VI – Return of the Jedi) is a 1983 American epic space opera film directed by Richard Marquand. The screenplay is by Lawrence Kasdan and George Lucas from a story by Lucas, who was also the executive producer.", "Richard Marquand", new DateTime(1983, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a64e038d-028a-4c98-b4fd-29f08bcdd473"), "Star Wars: Episode VI – Return of the Jedi" },
                    { new Guid("bdcf546b-1d41-4d79-809e-647ccc1d98f4"), "The Empire Strikes Back (also known as Star Wars: Episode V – The Empire Strikes Back) is a 1980 American epic space opera film directed by Irvin Kershner and written by Leigh Brackett and Lawrence Kasdan, based on a story by George Lucas.", "Irvin Kershner", new DateTime(1980, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a64e038d-028a-4c98-b4fd-29f08bcdd473"), "Star Wars: Episode V – The Empire Strikes Back" },
                    { new Guid("be7bac3f-ea3f-4c26-a3b4-34960b13030e"), "The Dark Knight is a 2008 superhero film directed, produced, and co-written by Christopher Nolan. Based on the DC Comics character Batman, the film is the second installment of Nolan's The Dark Knight Trilogy and a sequel to 2005's Batman Begins, starring Christian Bale and supported by Michael Caine, Heath Ledger, Gary Oldman, Aaron Eckhart, Maggie Gyllenhaal, and Morgan Freeman.", "Christopher Nolan", new DateTime(2008, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("79f2dc56-e5b0-490c-b2bd-9acdd09cb954"), "The Dark Knight" },
                    { new Guid("c2849573-a709-44af-b0f2-20fe6569c687"), "The Dark Knight Rises is a 2012 superhero film directed by Christopher Nolan, who co-wrote the screenplay with his brother Jonathan Nolan, and the story with David S. Goyer.", "Christopher Nolan", new DateTime(2012, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("79f2dc56-e5b0-490c-b2bd-9acdd09cb954"), "The Dark Knight Rises" },
                    { new Guid("dc4822dd-7ac8-4d3f-bce4-1391366dcacf"), "Star Wars (retroactively titled Star Wars: Episode IV – A New Hope) is a 1977 American epic space opera film written and directed by George Lucas, produced by Lucasfilm and distributed by 20th Century Fox.", "George Lucas", new DateTime(1977, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a64e038d-028a-4c98-b4fd-29f08bcdd473"), "Star Wars: Episode IV – A New Hope" },
                    { new Guid("f82fb775-7e28-4c14-af8a-7b609a76587a"), "Batman Begins is a 2005 superhero film directed by Christopher Nolan and written by Nolan and David S. Goyer. Based on the DC Comics character Batman, it stars Christian Bale as Bruce Wayne / Batman, with Michael Caine, Liam Neeson, Katie Holmes, Gary Oldman,", "Christopher Nolan", new DateTime(2005, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("79f2dc56-e5b0-490c-b2bd-9acdd09cb954"), "Batman Begins" }
                });

            migrationBuilder.InsertData(
                table: "Superpowers",
                columns: new[] { "Id", "Description", "SuperPower", "SuperheroId" },
                values: new object[,]
                {
                    { new Guid("196cdef7-b15f-41ee-b701-fc2877d0b301"), "She knows how to infiltrate the enemy.", "Infiltration", new Guid("a065dc4c-759a-4b30-8b2d-ee3e0a428609") },
                    { new Guid("4b7cb49e-fe73-4330-8f4e-a3c48a1e9b17"), "He got a lot of money", "Wealth.", new Guid("79f2dc56-e5b0-490c-b2bd-9acdd09cb954") },
                    { new Guid("5b9d34cd-0b5a-4870-a223-fdd6b7ef8491"), "She's good at spying at people.", "Espionage", new Guid("a065dc4c-759a-4b30-8b2d-ee3e0a428609") },
                    { new Guid("5d708fdf-3c69-44d4-bbb6-baffb286d306"), "Skywalker is able to deflect fire from a blaster back at the opponent firing. This enables Luke to turn someone else's weapon against them.", "Deflect blaster power.", new Guid("a64e038d-028a-4c98-b4fd-29f08bcdd473") },
                    { new Guid("d8ceba03-8858-49c0-8898-e0224cc03554"), "Sublime fighting skills.", "Fighting", new Guid("79f2dc56-e5b0-490c-b2bd-9acdd09cb954") },
                    { new Guid("d9e598e1-b21e-42d3-949e-2ef70efa1ec6"), "The knowledge of how to undermine others.", "Subterfuge", new Guid("a065dc4c-759a-4b30-8b2d-ee3e0a428609") },
                    { new Guid("de3fdee7-0acd-485f-8138-982810e84244"), "He's always a step ahead.", "Intellect.", new Guid("79f2dc56-e5b0-490c-b2bd-9acdd09cb954") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movies_SuperheroId",
                table: "Movies",
                column: "SuperheroId");

            migrationBuilder.CreateIndex(
                name: "IX_Superpowers_SuperheroId",
                table: "Superpowers",
                column: "SuperheroId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Superpowers");

            migrationBuilder.DropTable(
                name: "Superheroes");
        }
    }
}
