using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoviesWatchlist.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Actors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Nationality = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Directors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Nationality = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Directors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Writers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Nationality = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Writers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    ReleaseYear = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: false),
                    DirectorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movies_Directors_DirectorId",
                        column: x => x.DirectorId,
                        principalTable: "Directors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IdentityUsersMovies",
                columns: table => new
                {
                    CollectorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MovieId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityUsersMovies", x => new { x.MovieId, x.CollectorId });
                    table.ForeignKey(
                        name: "FK_IdentityUsersMovies_AspNetUsers_CollectorId",
                        column: x => x.CollectorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IdentityUsersMovies_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MoviesActors",
                columns: table => new
                {
                    MovieId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ActorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoviesActors", x => new { x.MovieId, x.ActorId });
                    table.ForeignKey(
                        name: "FK_MoviesActors_Actors_ActorId",
                        column: x => x.ActorId,
                        principalTable: "Actors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MoviesActors_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MoviesGenres",
                columns: table => new
                {
                    MovieId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GenreId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoviesGenres", x => new { x.MovieId, x.GenreId });
                    table.ForeignKey(
                        name: "FK_MoviesGenres_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MoviesGenres_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MoviesWriters",
                columns: table => new
                {
                    MovieId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WriterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoviesWriters", x => new { x.MovieId, x.WriterId });
                    table.ForeignKey(
                        name: "FK_MoviesWriters_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MoviesWriters_Writers_WriterId",
                        column: x => x.WriterId,
                        principalTable: "Writers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "FirstName", "LastName", "Nationality" },
                values: new object[,]
                {
                    { new Guid("09e9e00e-87b1-4ad5-a3f4-6656f4ef582f"), "Jacob", "Batalon", "American" },
                    { new Guid("0f9f5fba-7b14-495a-aac9-57c5a0f1617a"), "Tyrese", "Gibson", "American" },
                    { new Guid("102b6971-7278-471a-bee8-44976bc1616b"), "Hailee", "Steinfeld", "American" },
                    { new Guid("23e767cf-efd1-4407-a560-a52fddae07ca"), "Shia", "LaBeouf", "American" },
                    { new Guid("25a3f672-0ce0-4003-9583-e3d3654ad5da"), "John", "Cena", "American" },
                    { new Guid("2908138e-a1ef-489e-bde0-d805f1584e0e"), "Anthony", "Ramos", "American" },
                    { new Guid("3399ca51-6179-410b-88d9-a4bedcd24c96"), "Megan", "Fox", "American" },
                    { new Guid("3876aa34-f85c-417e-8744-9a0b18c73f5d"), "Mark", "Wahlberg", "American" },
                    { new Guid("4c900406-2962-4de1-a8c7-923b57dbe2f8"), "Dominique", "Fishback", "American" },
                    { new Guid("6bb7a659-6a82-45b1-903d-b089d228e699"), "Terrence", "Howard", "American" },
                    { new Guid("6e076de8-9235-4ab6-8f16-01e19f0b2d11"), "Michael", "Keaton", "American" },
                    { new Guid("857450bf-8ba2-4797-b83e-8253aac8a080"), "Zendaya", "Coleman", "American" },
                    { new Guid("9677782d-0580-4590-87bb-dca5a7df1898"), "Samuel", "Jackson", "American" },
                    { new Guid("989d0418-da25-474f-8d7d-0f6dfebf4263"), "John", "Ortiz", "American" },
                    { new Guid("a018cb3b-e630-437e-ab04-2488adfb2671"), "Robert", "Downey Jr.", "American" },
                    { new Guid("a145d6de-a56b-4212-948e-c91f3cd55739"), "Hugo", "Weaving", "British" },
                    { new Guid("a25d4265-618e-4207-8109-0d53f89653bf"), "Joshua", "Duhamel", "American" },
                    { new Guid("a76e3acb-eda2-44f8-8f0e-42c1fa2072cb"), "Scarlett", "Johansson", "American" },
                    { new Guid("aaff44cb-ae90-4fc5-a213-509103ee589d"), "John", "Turturro", "American" },
                    { new Guid("be066a1b-08d2-4e7b-b6c8-ec4a157cffb4"), "Gwyneth", "Paltrow", "American" },
                    { new Guid("c6d8ec2a-c52b-424d-a054-10d55f1c508f"), "Stanley", "Tucci", "American" },
                    { new Guid("d7498ede-dc2b-4cd0-a987-a0818c0653ee"), "Tom", "Holland", "English" },
                    { new Guid("fe0a8cbc-9e87-4257-8498-075e847e382a"), "Anthony", "Hopkins", "Welsh" }
                });

            migrationBuilder.InsertData(
                table: "Directors",
                columns: new[] { "Id", "FirstName", "LastName", "Nationality" },
                values: new object[,]
                {
                    { new Guid("3e88e0ab-1f41-4e29-a0a8-9187c65c969c"), "Jonathan", "Favreau", "American" },
                    { new Guid("75712a98-bb11-4db1-92e2-acc7a477c325"), "Michael", "Bay", "American" },
                    { new Guid("c0c98a54-6d27-4235-9e4f-87471195036a"), "Jonathan", "Watts", "American" },
                    { new Guid("c681c71b-638b-42bd-88a0-b3cd86525d4b"), "Travis", "Knight", "American" },
                    { new Guid("daa714f4-8da2-46a1-aaad-877b026865e5"), "Steven", "Caple Jr.", "American" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("06c946ea-f6c1-4210-b6c0-4546b113d468"), "Crime" },
                    { new Guid("0a06a66a-97c5-4ca8-ab0d-13eb9e190451"), "Thriller" },
                    { new Guid("2608eadc-f2e4-47e1-a97e-8cbb7b165f0a"), "Supernatural" },
                    { new Guid("2890ffb5-39c3-49c7-8ac2-d7c1596744ee"), "Drama" },
                    { new Guid("2cbd8fa3-04b2-4046-bf79-a2e3139499b1"), "Action" },
                    { new Guid("368f5f5b-2db5-4fe2-8d8e-acf599e7d0d7"), "Sci-Fi" },
                    { new Guid("3e491a9f-6ce9-4d83-b2c3-f3a594cb8b41"), "Western" },
                    { new Guid("457aa818-518f-4f5d-9aa7-989793c552f7"), "Martial arts" },
                    { new Guid("64508423-0ed3-4785-bfb2-6e21272d64a4"), "Horror" },
                    { new Guid("7d691aa7-1bfb-48bf-b0d3-8d826a39165e"), "Fantasy" },
                    { new Guid("991f5414-a73d-496e-8ad4-4dde92998825"), "War and military" },
                    { new Guid("b442dd64-5e1e-4feb-9846-152cb7a62571"), "Historical" },
                    { new Guid("bb47773a-700f-4be2-b0b4-25d7e646a248"), "Romance" },
                    { new Guid("c79dedde-fb6c-4678-8f2e-5f2be69998d8"), "Adventure" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("cf449426-3a0b-4a2a-954e-0be7a26286d3"), "Psychological" },
                    { new Guid("ec6947a1-331a-46fb-bf41-5ad7ea727d55"), "Sports" },
                    { new Guid("fc6067c6-093c-46ac-a31f-c9d4aeb61a15"), "Comedy" },
                    { new Guid("fd2c8902-5b6c-4b66-af01-8fc96d4c8379"), "Mystery" }
                });

            migrationBuilder.InsertData(
                table: "Writers",
                columns: new[] { "Id", "FirstName", "LastName", "Nationality" },
                values: new object[,]
                {
                    { new Guid("23de6343-2f1e-4cdf-8c5e-e1d533d3ce81"), "Christopher", "Ford", "American" },
                    { new Guid("37ceddb7-e7f3-4880-ae1b-96bae0af264c"), "Ehren", "Kruger", "American" },
                    { new Guid("4cb154ae-d288-48d9-a7a3-92201d556bb5"), "Hawk", "Ostby", "American" },
                    { new Guid("4dfb06c4-970f-4b9f-978a-10c86ad7d66b"), "Justin", "Theroux", "American" },
                    { new Guid("5ea8502b-87b8-43c6-b5dc-0eb60f1a13ac"), "Erik", "Sommers", "American" },
                    { new Guid("6dea9a15-fa05-4036-a679-85865dfba25d"), "John", "Rogers", "American" },
                    { new Guid("7d6b1565-bc84-4f2c-a34e-76c8e772e122"), "Roberto", "Orci", "Mexican-American" },
                    { new Guid("8249bb1f-c4e1-4c57-ae8b-c4c449cb9244"), "Christina", "Hodson", "British" },
                    { new Guid("9f4ccfd8-c068-426c-81b3-a4f03b163f8c"), "John", "Daley", "American" },
                    { new Guid("b0d1adb5-52c1-477e-b7fc-29db424bafdb"), "Mark", "Fergus", "American" },
                    { new Guid("d12b795a-c090-4bf5-90a3-9c7400f42b2e"), "Chris", "McKenna", "American" },
                    { new Guid("da41c8ec-a920-4739-a713-3e0fba894412"), "Joby", "Harold", "English" },
                    { new Guid("ebb5e25c-672e-4bcb-9fe4-a05c969571b5"), "Art", "Marcum", "American" },
                    { new Guid("efe82100-f4e7-465e-b77b-a40fa1858750"), "Ken", "Nolan", "American" },
                    { new Guid("f077230e-6c39-4c69-b7d5-e2fca1dc4910"), "Alex", "Kurtzman", "American" },
                    { new Guid("fa95a713-7d6d-47d0-b401-d9d3f4dbce3d"), "Jonathan", "Goldstein", "American" },
                    { new Guid("fbf45c67-ebb6-4f25-81ed-c3464a5717b8"), "Matt", "Holloway", "American" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_IdentityUsersMovies_CollectorId",
                table: "IdentityUsersMovies",
                column: "CollectorId");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_DirectorId",
                table: "Movies",
                column: "DirectorId");

            migrationBuilder.CreateIndex(
                name: "IX_MoviesActors_ActorId",
                table: "MoviesActors",
                column: "ActorId");

            migrationBuilder.CreateIndex(
                name: "IX_MoviesGenres_GenreId",
                table: "MoviesGenres",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_MoviesWriters_WriterId",
                table: "MoviesWriters",
                column: "WriterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "IdentityUsersMovies");

            migrationBuilder.DropTable(
                name: "MoviesActors");

            migrationBuilder.DropTable(
                name: "MoviesGenres");

            migrationBuilder.DropTable(
                name: "MoviesWriters");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Actors");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Writers");

            migrationBuilder.DropTable(
                name: "Directors");
        }
    }
}
