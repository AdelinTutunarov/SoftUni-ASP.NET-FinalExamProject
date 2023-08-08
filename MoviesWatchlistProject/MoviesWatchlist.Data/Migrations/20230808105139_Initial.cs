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
                    { new Guid("11e73643-1c5a-4060-8448-d7b8bf501aad"), "Stanley", "https://en.wikipedia.org/wiki/Stanley_Tucci#/media/File:Stanley_Tucci_2017_Berlinale.jpg", "Tucci", "American" },
                    { new Guid("15dd8482-e5b9-4a76-b5c3-74fa8c8a3550"), "Megan", "https://en.wikipedia.org/wiki/Megan_Fox#/media/File:Machine_Gun_Kelly_and_Megan_Fox_(51914406561)_(cropped2).jpg", "Fox", "American" },
                    { new Guid("19f5a00d-8362-4d8a-9cb6-c45af591c564"), "Terrence", "https://en.wikipedia.org/wiki/Terrence_Howard#/media/File:Terrence_Howard.jpg", "Howard", "American" },
                    { new Guid("2774c1be-c671-4d4b-98c0-418d2c029b5e"), "John", "https://en.wikipedia.org/wiki/John_Cena#/media/File:John_Cena_July_2018.jpg", "Cena", "American" },
                    { new Guid("2796f2df-a7bd-4202-8145-9f5a9239bf71"), "Zendaya", "https://en.wikipedia.org/wiki/Zendaya#/media/File:Zendaya_-_2019_by_Glenn_Francis.jpg", "Coleman", "American" },
                    { new Guid("2b2a06a6-de9f-48ab-b0e3-a9257fbf430e"), "John", "https://en.wikipedia.org/wiki/John_Turturro#/media/File:John_Turturro_2017.jpg", "Turturro", "American" },
                    { new Guid("41a8fa16-0c31-43bb-9c55-bcb581dc844a"), "Shia", "https://en.wikipedia.org/wiki/Shia_LaBeouf#/media/File:Shia_LaBeouf_2022.jpg", "LaBeouf", "American" },
                    { new Guid("52ffb7a3-eb8d-4ad2-901a-4f81ef2e233b"), "Gwyneth", "https://en.wikipedia.org/wiki/Gwyneth_Paltrow#/media/File:GwynethPaltrowByAndreaRaffin2011.jpg", "Paltrow", "American" },
                    { new Guid("65b0a01f-d609-4d38-88f2-82910940344c"), "Tom", "https://en.wikipedia.org/wiki/Tom_Holland#/media/File:Tom_Holland_by_Gage_Skidmore.jpg", "Holland", "English" },
                    { new Guid("686abbba-4b69-426b-81dc-393a0a8ea3f8"), "John", "https://en.wikipedia.org/wiki/John_Ortiz#/media/File:John_Ortiz_2019.jpg", "Ortiz", "American" },
                    { new Guid("68a328d8-b219-4da8-beec-ed29bf9c0c1d"), "Hailee", "https://en.wikipedia.org/wiki/Hailee_Steinfeld#/media/File:Hailee_Steinfeld_by_Gage_Skidmore.jpg", "Steinfeld", "American" },
                    { new Guid("6bd0dc16-af95-47dc-80c4-7e40b22cb7d3"), "Dominique", "https://en.wikipedia.org/wiki/Dominique_Fishback#/media/File:TIFF_2018_Dominique_Fishback_(1_of_1)-2.jpg", "Fishback", "American" },
                    { new Guid("8d4d5fd3-c2ba-4b58-9184-95ef67571d2a"), "Scarlett", "https://en.wikipedia.org/wiki/Scarlett_Johansson#/media/File:Scarlett_Johansson_by_Gage_Skidmore_2_(cropped,_2).jpg", "Johansson", "American" },
                    { new Guid("a5db8241-9f16-4e50-9fbb-e54b7afee878"), "Robert", "https://en.wikipedia.org/wiki/Robert_Downey_Jr.#/media/File:Robert_Downey_Jr_2014_Comic_Con_(cropped).jpg", "Downey Jr.", "American" },
                    { new Guid("b0bf16e6-8236-49b6-812d-82c72b86c03a"), "Anthony", "https://en.wikipedia.org/wiki/Anthony_Hopkins#/media/File:AnthonyHopkins10TIFF.jpg", "Hopkins", "Welsh" },
                    { new Guid("bbd43335-ff35-488a-b07a-0cfd429c456c"), "Mark", "https://en.wikipedia.org/wiki/Mark_Wahlberg#/media/File:Mark_Wahlberg_2021.jpg", "Wahlberg", "American" },
                    { new Guid("c1ba6031-8a0e-4552-a41b-a027ca58d028"), "Tyrese", "https://en.wikipedia.org/wiki/Tyrese_Gibson#/media/File:TyreseGibsonDec08.jpg", "Gibson", "American" },
                    { new Guid("d4d0f99b-d71b-4578-bccc-b156014b4ee1"), "Michael", "https://en.wikipedia.org/wiki/Michael_Keaton#/media/File:Michael_Keaton_(NYCC_2014)_(cropped).JPG", "Keaton", "American" },
                    { new Guid("d7614191-1c4e-4188-a708-25a1038b236a"), "Hugo", "https://en.wikipedia.org/wiki/Hugo_Weaving#/media/File:MJK_08925_Hugo_Weaving_(Berlinale_2018)_bw43.jpg", "Weaving", "British" },
                    { new Guid("d8217b07-28a8-4ecb-b7f1-5209a2147aab"), "Samuel", "https://en.wikipedia.org/wiki/Samuel_L._Jackson", "Jackson", "American" },
                    { new Guid("db10b49c-234d-4ec7-9605-15113fc60a7c"), "Joshua", "https://en.wikipedia.org/wiki/Josh_Duhamel#/media/File:Josh_Duhamel_SXSW_2017_(cropped).jpg", "Duhamel", "American" },
                    { new Guid("de041239-3e88-4cfd-a840-b8c1ffb83e4c"), "Anthony", "https://en.wikipedia.org/wiki/Anthony_Ramos#/media/File:Anthony_Ramos_(cropped).jpg", "Ramos", "American" },
                    { new Guid("ea28c665-a5d0-4407-a190-07509313c616"), "Jacob", "https://en.wikipedia.org/wiki/Jacob_Batalon#/media/File:Jacob_Batalon_(28035642754)_(cropped).jpg", "Batalon", "American" }
                });

            migrationBuilder.InsertData(
                table: "Directors",
                columns: new[] { "Id", "FirstName", "ImageURL", "LastName", "Nationality" },
                values: new object[,]
                {
                    { new Guid("18fb4cdd-ebae-4e5a-9bbe-f0799ff2d0a6"), "Jonathan", "https://en.wikipedia.org/wiki/Jon_Favreau#/media/File:Jon_Favreau_2016.jpeg", "Favreau", "American" },
                    { new Guid("2b93c574-532c-43d1-b0fe-58b78ec6fefe"), "Steven", "https://www.freepik.com/free-photo/user-profile-icon-front-side_41949685.htm#query=default%20avatar%20profile&position=3&from_view=search&track=ais", "Caple Jr.", "American" },
                    { new Guid("6e916c4a-68b5-44a8-827a-6663edc2acb9"), "Michael", "https://en.wikipedia.org/wiki/Michael_Bay_filmography#/media/File:Michael.bay.png", "Bay", "American" },
                    { new Guid("8c001b75-77c1-40bf-ac38-13f805ff3656"), "Travis", "https://en.wikipedia.org/wiki/Travis_Knight#/media/File:Travis_Knight_(30000495292).jpg", "Knight", "American" },
                    { new Guid("9e30050f-1a89-475f-97f5-23d2c370e6c4"), "Jonathan", "https://en.wikipedia.org/wiki/Jon_Watts#/media/File:Jon_Watts_by_Gage_Skidmore_2.jpg", "Watts", "American" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "ImageURL", "Name" },
                values: new object[,]
                {
                    { new Guid("155d8c42-4ddc-406c-a547-4e61c33da659"), "https://img.freepik.com/free-photo/back-view-man-planning-hacker-attack-dark-room-man-writing-wall-with-stickers-photographs-red-threads-planning-conspiracy-hacking-concept_74855-24330.jpg?w=996&t=st=1690645169~exp=1690645769~hmac=bb30a31205ec715b8384815bcb7b2b46222b8dedb91e4d0040d7aa30fb9d967f", "Mystery" },
                    { new Guid("2d5f3a39-53b8-4720-bd51-b8bae354998f"), "https://www.freepik.com/free-photo/muay-thai-thai-boxing-fighters_27883560.htm#query=fight%20film&position=9&from_view=search&track=ais", "Martial arts" },
                    { new Guid("3dcdb030-8a0e-4980-a7b5-b32c9cd5e322"), "https://img.freepik.com/free-photo/silhouettes-wedding-couple-standing-evening-field_1304-5463.jpg?w=1060&t=st=1690645187~exp=1690645787~hmac=40a97b3583ac55b8ef09542220c23c7b1f8b0ea4c059daca4f0455702e9e6464", "Romance" },
                    { new Guid("4094003e-31ff-4f20-952d-91d9c13b41cb"), "https://img.freepik.com/free-photo/sad-lady-silk-outfit-posing-with-clapperboard-black-background-portrait-blonde-woman-red-dress-crying-isolated-backdrop_197531-29087.jpg?w=996&t=st=1690645002~exp=1690645602~hmac=10686356bde52377f1f022d27be1880fc928717d6d10146a9d82037b199a7a4f", "Drama" },
                    { new Guid("5518011e-7a03-4c71-bae5-7d7db676f702"), "https://img.freepik.com/free-photo/soccer-ball-white-line-stadium_1150-5285.jpg?w=996&t=st=1690645585~exp=1690646185~hmac=6116b95c4db3685731491d73b2eadef22128b617e906bbf22b1ef2f51b21bf2a", "Sports" },
                    { new Guid("8067cb10-6632-43d2-a512-94aa8178863e"), "https://img.freepik.com/free-photo/cowboy-background-with-hat_52683-87191.jpg?w=360&t=st=1690645411~exp=1690646011~hmac=e5b40854dc486b4d7c64ed41e7b3eda36131e28c6f73382e7e3834d9e08354e8", "Western" },
                    { new Guid("8a77cebc-c18f-4ef8-bd86-2a6ceaee2297"), "https://img.freepik.com/free-photo/photographer-hand-holding-camera-standing-viewpoint-clouds-panorama-viewpoint-sunrise_335224-1320.jpg?w=996&t=st=1690645725~exp=1690646325~hmac=fe9c6f2d727ddfadff01addb7c94e2cccc477fed176a493c19a4c4875f079963", "Adventure" },
                    { new Guid("99ca4a8c-4e23-4b24-bcf0-1fcbd5d5eef1"), "https://img.freepik.com/free-photo/dictatorship-oppression-collage-concept_23-2149711441.jpg?w=996&t=st=1690645532~exp=1690646132~hmac=8e2d8c552cc98f1c2997af989980015a2b12a42fc5a7a84d167908aeda7c1f4d", "Action" },
                    { new Guid("9dd532f1-9f91-4079-9615-f8f2ada8272a"), "https://img.freepik.com/free-photo/silhouette-scary-zombie-with-dramatic-background_9083-8119.jpg?w=996&t=st=1690645242~exp=1690645842~hmac=3386ca0baa8ae3d240c321b480c46a262886ea6b850f5bfadd42af4ef54a2bdc", "Thriller" },
                    { new Guid("b34e6611-8f6d-4421-8a96-74dda0d9fce3"), "https://img.freepik.com/free-photo/cruel-war-scenes-digital-painting_456031-162.jpg?w=1380&t=st=1690645434~exp=1690646034~hmac=7f69427ebf3e600fb904d17b3bb3877d1a172ba7194cc4549977ccb61a43dcce", "War and military" },
                    { new Guid("c358f1e4-6758-4dd8-96cc-1ea38d627ee9"), "https://img.freepik.com/free-photo/painting-spaceship-being-lifted-up-by-galaxy_123827-23492.jpg?w=996&t=st=1690645621~exp=1690646221~hmac=e753bce5031804d263d083eb6d69f24ca79a53bf2de5cf5b1c0f126c13ea5790", "Sci-Fi" },
                    { new Guid("d0b57ac9-cf00-499f-b508-2a608a5f9044"), "https://img.freepik.com/free-photo/memory-loss-dementia-alzheimer-concept-created-with-generative-ai-technology_185193-110044.jpg?w=1060&t=st=1690645384~exp=1690645984~hmac=166a934cabdbc26d34996172eb3b0c404a6ceeb9159f36f15becbf8ca3969194", "Psychological" },
                    { new Guid("d85f391a-d6e7-4edb-af71-552427ceec8f"), "https://img.freepik.com/free-photo/people-s-emotions-cinema_155003-15059.jpg?w=996&t=st=1690644907~exp=1690645507~hmac=50e982108c2b8eadb7aa524e605a844fc8e1e19a9bfefbceb26495a39c41a4df", "Comedy" },
                    { new Guid("d8f668b6-880a-421a-9793-1fdfd8292f04"), "https://img.freepik.com/free-photo/doomsday-scene-catastrophe-digital-illustration_456031-51.jpg?w=1380&t=st=1690645557~exp=1690646157~hmac=d0399ce74558d886a183733b8b081a544752c4b62b9716931f35d7341fd0c0c2", "Supernatural" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "ImageURL", "Name" },
                values: new object[,]
                {
                    { new Guid("e88ca03e-a630-4b03-a650-cccaeb2d9354"), "https://img.freepik.com/free-photo/truth-concept-arrangement-crime-scene_23-2149051305.jpg?w=996&t=st=1690645266~exp=1690645866~hmac=2f1dc50b5128517c9d54fb98b7826ec6e5547fe1049f8a402264ecddbaab9c8d", "Crime" },
                    { new Guid("ed1f220c-f93b-4a03-bac2-4c629310cea8"), "https://img.freepik.com/free-photo/beautiful-shot-famous-roman-colosseum-amphitheater-breathtaking-sky-sunrise_181624-6998.jpg?w=900&t=st=1690645693~exp=1690646293~hmac=fadd42117ddd0daffd2e3b564aed50209b061edd15ce59d5f25ff711523a3db8", "Historical" },
                    { new Guid("efdf3761-311f-4675-b33c-463a71b8b48f"), "https://img.freepik.com/free-photo/nighttime-nature-landscape-galaxy-mountain-water-star-beauty-generative-ai_188544-9736.jpg?w=1060&t=st=1690645132~exp=1690645732~hmac=033aa5f68de6924948adc05915d4f13d141706979dfa063f5bbd38d11c46f2a4", "Fantasy" },
                    { new Guid("fb6c8590-ebb7-432e-a189-3e2096c034cf"), "https://img.freepik.com/free-photo/small-skeleton-with-popcorn-tv_23-2147685634.jpg?w=996&t=st=1690645054~exp=1690645654~hmac=6445730adc22805a60813820dd00cc71499fd873cee682d3da6d3a5d19e05384", "Horror" }
                });

            migrationBuilder.InsertData(
                table: "Writers",
                columns: new[] { "Id", "FirstName", "ImageURL", "LastName", "Nationality" },
                values: new object[,]
                {
                    { new Guid("0a89d160-c317-49bd-9f62-39e458aedc9e"), "Roberto", "https://en.wikipedia.org/wiki/Roberto_Orci#/media/File:Roberto_Orci_by_Gage_Skidmore.jpg", "Orci", "Mexican-American" },
                    { new Guid("10da71f4-4a38-4778-90d3-ddae68e4f529"), "Chris", "https://en.wikipedia.org/wiki/Chris_McKenna_(writer)#/media/File:Chris_McKenna_(14584155278).jpg", "McKenna", "American" },
                    { new Guid("17a1390a-9640-4ed7-9bfd-8d43788714dc"), "Joby", "https://en.wikipedia.org/wiki/Joby_Harold#/media/File:Joby_Harold_on_Sidewalks_Entertainment.jpg", "Harold", "English" },
                    { new Guid("234bd740-3561-4aa4-adce-1cb6b876388d"), "Justin", "https://en.wikipedia.org/wiki/Justin_Theroux#/media/File:Maniac_UK_premiere_(Theroux).jpg", "Theroux", "American" },
                    { new Guid("41043cb3-c754-4b02-8947-e87962541ef5"), "Jonathan", "https://www.freepik.com/free-photo/user-profile-icon-front-side_41949685.htm#query=default%20avatar%20profile&position=3&from_view=search&track=ais", "Goldstein", "American" },
                    { new Guid("690dcf82-1de8-4eec-8712-a89bdfc9b03d"), "Hawk", "https://en.wikipedia.org/wiki/Mark_Fergus_and_Hawk_Ostby#/media/File:Hawk_Ostby,_at_the_Hugo_Awards_Ceremony,_Worldcon,_Helsinki.jpg", "Ostby", "American" },
                    { new Guid("782eb1b7-0ed8-443c-abc4-cc80836dc7f3"), "Erik", "https://www.freepik.com/free-photo/user-profile-icon-front-side_41949685.htm#query=default%20avatar%20profile&position=3&from_view=search&track=ais", "Sommers", "American" },
                    { new Guid("84f01c04-1107-4c95-adab-b521a5681870"), "Alex", "https://en.wikipedia.org/wiki/Alex_Kurtzman#/media/File:Alex_Kurtzman_San_Diego_Comic_Con_2019.jpg", "Kurtzman", "American" },
                    { new Guid("8cade6f7-f715-4ed6-a7f6-a1cf34f9895c"), "Mark", "https://www.freepik.com/free-photo/user-profile-icon-front-side_41949685.htm#query=default%20avatar%20profile&position=3&from_view=search&track=ais", "Fergus", "American" },
                    { new Guid("9054085e-f624-44f2-982f-14788ee31600"), "Ken", "https://www.freepik.com/free-photo/user-profile-icon-front-side_41949685.htm#query=default%20avatar%20profile&position=3&from_view=search&track=ais", "Nolan", "American" },
                    { new Guid("aa5def6f-6348-4f23-bb28-b2029a8f16a9"), "John", "https://en.wikipedia.org/wiki/John_Rogers_(writer)#/media/File:John_Rogers_(971464822)_(cropped).jpg", "Rogers", "American" },
                    { new Guid("d9b387dc-068f-44eb-aa95-a972bf1e6087"), "Christina", "https://en.wikipedia.org/wiki/Christina_Hodson#/media/File:Christina_Hodson.jpg", "Hodson", "British" },
                    { new Guid("ee404ee7-b730-4fa4-9250-d28d96931267"), "John", "https://en.wikipedia.org/wiki/John_Francis_Daley#/media/File:John_Francis_Daley_in_March_2012.jpg", "Daley", "American" },
                    { new Guid("eec89fad-d7bd-4fd2-bff4-1c6625e87705"), "Matt", "https://www.freepik.com/free-photo/user-profile-icon-front-side_41949685.htm#query=default%20avatar%20profile&position=3&from_view=search&track=ais", "Holloway", "American" },
                    { new Guid("f18c95c7-771d-4b5d-956c-8d2ad11367f0"), "Ehren", "https://www.freepik.com/free-photo/user-profile-icon-front-side_41949685.htm#query=default%20avatar%20profile&position=3&from_view=search&track=ais", "Kruger", "American" },
                    { new Guid("f63182b8-7214-46ba-b0b9-ac6fa6525894"), "Christopher", "https://www.freepik.com/free-photo/user-profile-icon-front-side_41949685.htm#query=default%20avatar%20profile&position=3&from_view=search&track=ais", "Ford", "American" },
                    { new Guid("fff151d2-f85b-43fd-9ec6-6e6c01057706"), "Art", "https://www.freepik.com/free-photo/user-profile-icon-front-side_41949685.htm#query=default%20avatar%20profile&position=3&from_view=search&track=ais", "Marcum", "American" }
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
