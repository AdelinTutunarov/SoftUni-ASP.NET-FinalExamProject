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
                    ImageURL = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: false),
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
                    ImageURL = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: false),
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
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: false)
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
                    ImageURL = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: false),
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
                columns: new[] { "Id", "FirstName", "ImageURL", "LastName", "Nationality" },
                values: new object[,]
                {
                    { new Guid("0e52373c-d184-4fa2-9272-40b951e08515"), "Zendaya", "https://static.standard.co.uk/s3fs-public/thumbnails/image/2020/01/13/15/zendaya-130120-09.jpg?width=1200&height=900&fit=crop", "Coleman", "American" },
                    { new Guid("0f168ecd-c99a-4b5c-9574-78ff69aaa4ba"), "Shia", "https://variety.com/wp-content/uploads/2022/08/GettyImages-1185815950-e1661558394757.jpg", "LaBeouf", "American" },
                    { new Guid("13e39dc0-d4a7-49fc-b6fd-c8aac1eb9f11"), "Mark", "https://s.yimg.com/ny/api/res/1.2/Dv95XwJFZgODyyUkNF1j6A--/YXBwaWQ9aGlnaGxhbmRlcjt3PTY0MDtoPTQ4MA--/https://media.zenfs.com/en/people_218/5ace08f208b3ced146f0aefe54f840e8", "Wahlberg", "American" },
                    { new Guid("184ae901-e3cd-4708-b1de-8b448bfd9d70"), "Megan", "https://hips.hearstapps.com/hmg-prod/images/gettyimages-843456920.jpg?crop=1xw:0.75xh", "Fox", "American" },
                    { new Guid("2fab0047-2b3b-420d-82d0-4384be4ab156"), "Hailee", "https://m.media-amazon.com/images/M/MV5BZjNiZWZiMjYtNGI3Yy00NzdhLTk5YjEtZTQ2NGMzZmNlYTYxXkEyXkFqcGdeQWZlZGVyaWdh._V1_QL75_UX500_CR0,0,500,281_.jpg", "Steinfeld", "American" },
                    { new Guid("33fdff36-42d1-4c75-9af0-aadf003757f3"), "Anthony", "https://deadline.com/wp-content/uploads/2022/02/MEGA423535_079-e1644426414259.jpg", "Ramos", "American" },
                    { new Guid("37edbcb7-5c86-4cd7-8df4-59b5f56fcf2b"), "Stanley", "https://media.vanityfair.com/photos/6228f56c8e2d9f0117a49745/master/w_2560%2Cc_limit/1342262316", "Tucci", "American" },
                    { new Guid("448729e7-43f7-4025-aca0-d71aeda47e8e"), "Jacob", "https://s.abcnews.com/images/GMA/221207_gma_batalon1_hpMain_16x9_1600.jpg", "Batalon", "American" },
                    { new Guid("47dc4de9-09e6-4af1-8604-d40ab37f63ec"), "Scarlett", "https://nypost.com/wp-content/uploads/sites/2/2023/04/NYPICHPDPICT000007934275.jpg?quality=75&strip=all", "Johansson", "American" },
                    { new Guid("5291bc15-e662-4be8-8585-b50b163e985b"), "Gwyneth", "https://cdn.britannica.com/56/172456-050-F518B29E/Gwyneth-Paltrow-2013.jpg?w=400&h=300&c=crop", "Paltrow", "American" },
                    { new Guid("5c8577a9-3316-4c3f-a895-3f8f82afa83f"), "Samuel", "https://hips.hearstapps.com/hmg-prod/images/gettyimages-648731684.jpg", "Jackson", "American" },
                    { new Guid("6a1ca8fa-f8b6-4d79-a330-3ce66f9a1ea5"), "Hugo", "https://content.api.news/v3/images/bin/7a755d9f3876f67a85751897275918ac?width=2048", "Weaving", "British" },
                    { new Guid("6c6650f4-1be0-4cda-88cb-cfb1bb5d4b71"), "John", "https://deadline.com/wp-content/uploads/2017/02/john-ortiz-2.jpg?w=630&h=383&crop=1", "Ortiz", "American" },
                    { new Guid("a16f41c8-aa3d-49cb-a1e1-e0d58622638b"), "Terrence", "https://www.cheatsheet.com/wp-content/uploads/2021/03/Terrence-Howard.jpg", "Howard", "American" },
                    { new Guid("c96bdd38-32d3-4fd8-babc-bb5ec0d29d24"), "Dominique", "https://variety.com/wp-content/uploads/2022/03/Dominique-Fishbeck.jpg?w=1000", "Fishback", "American" },
                    { new Guid("cd8d2739-e131-4b60-b063-e53052a89764"), "John", "https://supersport-cms-prod.azureedge.net/media/vblpbdgz/john-cena-looks-on-c-wwe.jpg?width=2048&quality=100", "Cena", "American" },
                    { new Guid("df0a9927-953d-457c-8295-969f779fe630"), "Joshua", "https://pagesix.com/wp-content/uploads/sites/3/2018/12/josh-duhamel.jpg?quality=75&strip=all", "Duhamel", "American" },
                    { new Guid("eac6bd2a-43e9-4cb8-9ade-f0b37d7d271f"), "John", "https://www.goldderby.com/wp-content/uploads/2019/02/John-Turturro-movies-Ranked.jpg?w=620&h=360&crop=1", "Turturro", "American" },
                    { new Guid("efbff803-1ca3-472d-9061-66e21a5ad414"), "Tom", "https://e3.365dm.com/22/08/1600x900/skynews-tom-holland-spider-man_5865167.jpg?20220815095025", "Holland", "English" },
                    { new Guid("f0f3157d-c77f-4878-8e55-909f934b7620"), "Michael", "https://www.pittsburghmagazine.com/content/uploads/2022/09/j/t/keaton.jpg", "Keaton", "American" },
                    { new Guid("f127f714-3d21-4ad1-a7e0-8c821677b7b3"), "Anthony", "https://static01.nyt.com/images/2021/04/26/arts/26hopkins-oscars/merlin_186923745_91056fad-2aae-40f0-8552-d90324beedee-articleLarge.jpg?quality=75&auto=webp&disable=upscale", "Hopkins", "Welsh" },
                    { new Guid("f45428e7-bfd8-4504-9cf3-d7ee28012e7c"), "Tyrese", "https://img.buzzfeed.com/buzzfeed-static/complex/images/rfkcideekykilq6nxfdy/morbius-tyrese-gibson-interview.jpg", "Gibson", "American" },
                    { new Guid("fdbdb6bf-cc14-43df-845b-9f2033cf0dde"), "Robert", "https://people.com/thmb/TOOe_Ku31nqQx3va8hZa2EXAiU0=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc():focal(708x354:710x356)/Robert-Downey-Oppenheimer-071523-02-56152238e5064f8c954f688eb0b77cdc.jpg", "Downey Jr.", "American" }
                });

            migrationBuilder.InsertData(
                table: "Directors",
                columns: new[] { "Id", "FirstName", "ImageURL", "LastName", "Nationality" },
                values: new object[,]
                {
                    { new Guid("07fcb413-8124-4e86-8d1f-a14b904f20ce"), "Michael", "https://deadline.com/wp-content/uploads/2022/12/Michael-Bay.jpg", "Bay", "American" },
                    { new Guid("5132d3b6-fcf6-46ad-8f1b-7d553a472cf5"), "Jonathan", "https://lumiere-a.akamaihd.net/v1/images/jon-favreau-hollywood-walk-of-fame-feature_464fe901.jpeg", "Favreau", "American" },
                    { new Guid("8dbf2bbb-7f89-4c39-9fbe-4190a5eb414f"), "Travis", "https://deadline.com/wp-content/uploads/2020/01/shutterstock_editorial_10540803ev-e1580315841789.jpg", "Knight", "American" },
                    { new Guid("b8e683e4-eb4c-4aed-b3f7-1781f0f02c48"), "Steven", "https://images.bauerhosting.com/empire/2023/06/steven-caple-jr.jpg?format=jpg&quality=80&width=960&height=540&ratio=16-9&resize=aspectfill", "Caple Jr.", "American" },
                    { new Guid("fdefeec2-e3c2-433a-95ed-20c0a537f869"), "Jonathan", "https://variety.com/wp-content/uploads/2022/04/Jon-Watts.jpg?w=1000", "Watts", "American" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "ImageURL", "Name" },
                values: new object[,]
                {
                    { new Guid("0feb529d-abeb-4052-98c2-5a2c11e9a7c3"), "https://img.freepik.com/free-photo/cruel-war-scenes-digital-painting_456031-162.jpg?w=1380&t=st=1690645434~exp=1690646034~hmac=7f69427ebf3e600fb904d17b3bb3877d1a172ba7194cc4549977ccb61a43dcce", "War and military" },
                    { new Guid("11784f7f-23fb-4051-a9cc-13cb3ddee9b8"), "https://img.freepik.com/free-photo/small-skeleton-with-popcorn-tv_23-2147685634.jpg?w=996&t=st=1690645054~exp=1690645654~hmac=6445730adc22805a60813820dd00cc71499fd873cee682d3da6d3a5d19e05384", "Horror" },
                    { new Guid("12c7e3a9-4a53-468e-bd61-38ab0e82ddb3"), "https://img.freepik.com/free-photo/soccer-ball-white-line-stadium_1150-5285.jpg?w=996&t=st=1690645585~exp=1690646185~hmac=6116b95c4db3685731491d73b2eadef22128b617e906bbf22b1ef2f51b21bf2a", "Sports" },
                    { new Guid("34047d30-8e6a-44e2-8ea3-ea8c766449d4"), "https://img.freepik.com/free-photo/memory-loss-dementia-alzheimer-concept-created-with-generative-ai-technology_185193-110044.jpg?w=1060&t=st=1690645384~exp=1690645984~hmac=166a934cabdbc26d34996172eb3b0c404a6ceeb9159f36f15becbf8ca3969194", "Psychological" },
                    { new Guid("3c97ac09-5246-4496-8716-6984159fb171"), "https://img.freepik.com/free-photo/painting-spaceship-being-lifted-up-by-galaxy_123827-23492.jpg?w=996&t=st=1690645621~exp=1690646221~hmac=e753bce5031804d263d083eb6d69f24ca79a53bf2de5cf5b1c0f126c13ea5790", "Sci-Fi" },
                    { new Guid("48ea5fcb-88b3-4067-9f02-eacae8ddda61"), "https://img.freepik.com/free-photo/back-view-man-planning-hacker-attack-dark-room-man-writing-wall-with-stickers-photographs-red-threads-planning-conspiracy-hacking-concept_74855-24330.jpg?w=996&t=st=1690645169~exp=1690645769~hmac=bb30a31205ec715b8384815bcb7b2b46222b8dedb91e4d0040d7aa30fb9d967f", "Mystery" },
                    { new Guid("6a60182f-ac6f-49ca-a9a6-aa29e4535416"), "https://img.freepik.com/free-photo/silhouette-scary-zombie-with-dramatic-background_9083-8119.jpg?w=996&t=st=1690645242~exp=1690645842~hmac=3386ca0baa8ae3d240c321b480c46a262886ea6b850f5bfadd42af4ef54a2bdc", "Thriller" },
                    { new Guid("6f488002-65e0-4554-8e3f-ac27b925e007"), "https://img.freepik.com/free-photo/nighttime-nature-landscape-galaxy-mountain-water-star-beauty-generative-ai_188544-9736.jpg?w=1060&t=st=1690645132~exp=1690645732~hmac=033aa5f68de6924948adc05915d4f13d141706979dfa063f5bbd38d11c46f2a4", "Fantasy" },
                    { new Guid("72af5e85-177a-4abc-94ae-173e654d9f0e"), "https://img.freepik.com/free-photo/truth-concept-arrangement-crime-scene_23-2149051305.jpg?w=996&t=st=1690645266~exp=1690645866~hmac=2f1dc50b5128517c9d54fb98b7826ec6e5547fe1049f8a402264ecddbaab9c8d", "Crime" },
                    { new Guid("76850183-f027-4672-a5ce-8f4cfc9ac119"), "https://img.freepik.com/free-photo/photographer-hand-holding-camera-standing-viewpoint-clouds-panorama-viewpoint-sunrise_335224-1320.jpg?w=996&t=st=1690645725~exp=1690646325~hmac=fe9c6f2d727ddfadff01addb7c94e2cccc477fed176a493c19a4c4875f079963", "Adventure" },
                    { new Guid("81fa16ff-962d-4219-a072-b8d1611185dc"), "https://www.freepik.com/free-photo/muay-thai-thai-boxing-fighters_27883560.htm#query=fight%20film&position=9&from_view=search&track=ais", "Martial arts" },
                    { new Guid("9b64ca3e-2ddd-4242-862f-29cb5da93cb4"), "https://img.freepik.com/free-photo/silhouettes-wedding-couple-standing-evening-field_1304-5463.jpg?w=1060&t=st=1690645187~exp=1690645787~hmac=40a97b3583ac55b8ef09542220c23c7b1f8b0ea4c059daca4f0455702e9e6464", "Romance" },
                    { new Guid("9cd185f9-89f6-4cf1-b4d4-3e122bd20410"), "https://img.freepik.com/free-photo/sad-lady-silk-outfit-posing-with-clapperboard-black-background-portrait-blonde-woman-red-dress-crying-isolated-backdrop_197531-29087.jpg?w=996&t=st=1690645002~exp=1690645602~hmac=10686356bde52377f1f022d27be1880fc928717d6d10146a9d82037b199a7a4f", "Drama" },
                    { new Guid("9e9791d2-4fa0-4491-a4ce-f20a63764e95"), "https://img.freepik.com/free-photo/doomsday-scene-catastrophe-digital-illustration_456031-51.jpg?w=1380&t=st=1690645557~exp=1690646157~hmac=d0399ce74558d886a183733b8b081a544752c4b62b9716931f35d7341fd0c0c2", "Supernatural" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "ImageURL", "Name" },
                values: new object[,]
                {
                    { new Guid("b08f8244-c7a2-4da2-9a89-d2aa40e71481"), "https://img.freepik.com/free-photo/beautiful-shot-famous-roman-colosseum-amphitheater-breathtaking-sky-sunrise_181624-6998.jpg?w=900&t=st=1690645693~exp=1690646293~hmac=fadd42117ddd0daffd2e3b564aed50209b061edd15ce59d5f25ff711523a3db8", "Historical" },
                    { new Guid("b09a9747-5aba-46d2-8485-0e6951ab2eed"), "https://img.freepik.com/free-photo/dictatorship-oppression-collage-concept_23-2149711441.jpg?w=996&t=st=1690645532~exp=1690646132~hmac=8e2d8c552cc98f1c2997af989980015a2b12a42fc5a7a84d167908aeda7c1f4d", "Action" },
                    { new Guid("eef14cd1-7d77-4529-abdd-8c6e714be63d"), "https://img.freepik.com/free-photo/people-s-emotions-cinema_155003-15059.jpg?w=996&t=st=1690644907~exp=1690645507~hmac=50e982108c2b8eadb7aa524e605a844fc8e1e19a9bfefbceb26495a39c41a4df", "Comedy" },
                    { new Guid("f9bb0da8-c98e-4ade-8b32-f12bfaf534d4"), "https://img.freepik.com/free-photo/cowboy-background-with-hat_52683-87191.jpg?w=360&t=st=1690645411~exp=1690646011~hmac=e5b40854dc486b4d7c64ed41e7b3eda36131e28c6f73382e7e3834d9e08354e8", "Western" }
                });

            migrationBuilder.InsertData(
                table: "Writers",
                columns: new[] { "Id", "FirstName", "ImageURL", "LastName", "Nationality" },
                values: new object[,]
                {
                    { new Guid("00929bfe-d91c-42ab-a00e-30853db4c2d4"), "Justin", "https://media-cldnry.s-nbcnews.com/image/upload/rockcms/2023-05/justin-Theroux-Jennifer-Aniston-te-230501-5e6504.jpg", "Theroux", "American" },
                    { new Guid("0098875b-1320-44ec-882f-93d98eb06167"), "Joby", "https://www.comingsoon.net/wp-content/uploads/sites/3/2020/04/jobyharold.jpg?w=800", "Harold", "English" },
                    { new Guid("054b431b-2fa0-43d4-bb55-c5372b27e6e7"), "Art", "https://scriptmag.com/.image/t_share/MTg3Nzg2ODU1Nzc1NzQxMjcz/artmarcum.jpg", "Marcum", "American" },
                    { new Guid("15749759-d51c-43e5-8d83-faa74ad20889"), "Alex", "https://www.startrek.com/sites/default/files/styles/content_full/public/images/2019-07/b58f7d184743106a8a66028b7a28937c.jpg?itok=WAC4Y1l3", "Kurtzman", "American" },
                    { new Guid("2e1f12c1-e878-4a27-bc42-2dd87df329dc"), "Erik", "https://static.wikia.nocookie.net/marvelcinematicuniverse/images/7/7a/Erik_Sommers.png/revision/latest?cb=20210927114539", "Sommers", "American" },
                    { new Guid("3ac2ff72-1ab9-41d2-9e58-993fa4d19583"), "Chris", "https://1.bp.blogspot.com/-Hef2MXW2WhM/W-Es5fvF8eI/AAAAAAAALUo/9AvYphdbpUU5XHAJaMmIXiiKdj-FsuDwwCLcBGAs/s1600/ChrisMc.jpeg", "McKenna", "American" },
                    { new Guid("4556e232-df66-446c-8f8c-bdd1aa44592e"), "Roberto", "https://variety.com/wp-content/uploads/2014/05/roberto-orci.jpg", "Orci", "Mexican-American" },
                    { new Guid("47f37c3a-9854-4521-bf2b-020849d95b5f"), "Jonathan", "https://i.guim.co.uk/img/media/254c8463684b9022559adeffd4162424a52008d5/0_175_3456_2073/master/3456.jpg?width=1200&height=630&quality=85&auto=format&fit=crop&overlay-align=bottom%2Cleft&overlay-width=100p&overlay-base64=L2ltZy9zdGF0aWMvb3ZlcmxheXMvdGctZGVmYXVsdC5wbmc&s=d9f4c5375c148042bf815c6f09fd1ae6", "Goldstein", "American" },
                    { new Guid("81cb6c6c-e0cf-4c09-b72a-203227148b26"), "Christina", "https://i0.wp.com/geeksofcolor.co/wp-content/uploads/2018/04/1-ex0dre0izo58_qehqtglbw.jpg?resize=800%2C469&ssl=1", "Hodson", "British" },
                    { new Guid("8f3aaa87-a5ed-42bc-bd02-da83a543cfd9"), "Ken", "https://images.mubicdn.net/images/cast_member/16761/cache-259975-1506415601/image-w856.jpg?size=800x", "Nolan", "American" },
                    { new Guid("a1042920-81ce-4fe2-997b-911a35a1bd58"), "John", "https://flxt.tmsimg.com/assets/189544_v9_bb.jpg", "Daley", "American" },
                    { new Guid("be5410fc-ad0a-4cb8-a16c-7daf60eb6a39"), "Ehren", "https://m.media-amazon.com/images/M/MV5BMTc4Nzk4NTg2Nl5BMl5BanBnXkFtZTYwNTQ4OTU3._V1_.jpg", "Kruger", "American" },
                    { new Guid("c8bf8b48-e17e-47ff-a6c1-e845fb46e3b9"), "Christopher", "https://static.wikia.nocookie.net/marvelcinematicuniverse/images/c/c2/Christopher_Ford.jpg/revision/latest?cb=20210927095630", "Ford", "American" },
                    { new Guid("d5f2a46e-a3f0-4058-b631-36aae16bb1ef"), "Mark", "https://static.wikia.nocookie.net/marvelcinematicuniverse/images/4/47/Mark_Fergus.jpg/revision/latest?cb=20120922000533", "Fergus", "American" },
                    { new Guid("d79a88ec-20cd-4d97-8943-0afdd6ddab5e"), "Hawk", "https://variety.com/wp-content/uploads/2013/09/hawk-ostby-mark-fergus.jpg?w=1000", "Ostby", "American" },
                    { new Guid("f76bf173-97c2-4b0b-88e8-ec6b18fe3d26"), "Matt", "https://ausdrain.com/wp-content/uploads/2018/03/Matt-ausdain-tile-1-e1607646121344-576x380.jpg", "Holloway", "American" },
                    { new Guid("fd7c557a-a1e3-41f3-af8e-40ce4aa0a411"), "John", "https://bioelectronics.northwestern.edu/images/people/members/rogers-john.jpg", "Rogers", "American" }
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
