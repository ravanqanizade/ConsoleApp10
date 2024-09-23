using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleApp1.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "_authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "_categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "_departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "_faculties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__faculties", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "_libs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__libs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "_press",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__press", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "_themes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__themes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AudioBook",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pages = table.Column<int>(type: "int", nullable: false),
                    Author_Id = table.Column<int>(type: "int", nullable: false),
                    AuthorsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AudioBook", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AudioBook__authors_AuthorsId",
                        column: x => x.AuthorsId,
                        principalTable: "_authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_teachers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id_Dep = table.Column<int>(type: "int", nullable: false),
                    DepartmentsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__teachers", x => x.Id);
                    table.ForeignKey(
                        name: "FK__teachers__departments_DepartmentsId",
                        column: x => x.DepartmentsId,
                        principalTable: "_departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_groups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id_Faculty = table.Column<int>(type: "int", nullable: false),
                    FacultiesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__groups", x => x.Id);
                    table.ForeignKey(
                        name: "FK__groups__faculties_FacultiesId",
                        column: x => x.FacultiesId,
                        principalTable: "_faculties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pages = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YearPress = table.Column<int>(type: "int", nullable: false),
                    Id_Themes = table.Column<int>(type: "int", nullable: false),
                    Id_Category = table.Column<int>(type: "int", nullable: false),
                    Id_Author = table.Column<int>(type: "int", nullable: false),
                    Id_Press = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    AuthorsId = table.Column<int>(type: "int", nullable: false),
                    PressId = table.Column<int>(type: "int", nullable: false),
                    ThemesId = table.Column<int>(type: "int", nullable: false),
                    CategoriesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__books", x => x.Id);
                    table.ForeignKey(
                        name: "FK__books__authors_AuthorsId",
                        column: x => x.AuthorsId,
                        principalTable: "_authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__books__categories_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "_categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__books__press_PressId",
                        column: x => x.PressId,
                        principalTable: "_press",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__books__themes_ThemesId",
                        column: x => x.ThemesId,
                        principalTable: "_themes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id_Group = table.Column<int>(type: "int", nullable: false),
                    Term = table.Column<int>(type: "int", nullable: false),
                    GroupsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__students", x => x.Id);
                    table.ForeignKey(
                        name: "FK__students__groups_GroupsId",
                        column: x => x.GroupsId,
                        principalTable: "_groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "T_Cards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Teacher = table.Column<int>(type: "int", nullable: false),
                    Id_Book = table.Column<int>(type: "int", nullable: false),
                    DateOut = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateIn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Id_Lib = table.Column<int>(type: "int", nullable: false),
                    BooksId = table.Column<int>(type: "int", nullable: false),
                    LibsId = table.Column<int>(type: "int", nullable: false),
                    TeachersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_Cards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_T_Cards__books_BooksId",
                        column: x => x.BooksId,
                        principalTable: "_books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_T_Cards__libs_LibsId",
                        column: x => x.LibsId,
                        principalTable: "_libs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_T_Cards__teachers_TeachersId",
                        column: x => x.TeachersId,
                        principalTable: "_teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_s_cards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Student = table.Column<int>(type: "int", nullable: false),
                    Id_Book = table.Column<int>(type: "int", nullable: false),
                    DateOut = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateIn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Id_Lib = table.Column<int>(type: "int", nullable: false),
                    BooksId = table.Column<int>(type: "int", nullable: false),
                    StudentsId = table.Column<int>(type: "int", nullable: false),
                    LibsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__s_cards", x => x.Id);
                    table.ForeignKey(
                        name: "FK__s_cards__books_BooksId",
                        column: x => x.BooksId,
                        principalTable: "_books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__s_cards__libs_LibsId",
                        column: x => x.LibsId,
                        principalTable: "_libs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__s_cards__students_StudentsId",
                        column: x => x.StudentsId,
                        principalTable: "_students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX__books_AuthorsId",
                table: "_books",
                column: "AuthorsId");

            migrationBuilder.CreateIndex(
                name: "IX__books_CategoriesId",
                table: "_books",
                column: "CategoriesId");

            migrationBuilder.CreateIndex(
                name: "IX__books_PressId",
                table: "_books",
                column: "PressId");

            migrationBuilder.CreateIndex(
                name: "IX__books_ThemesId",
                table: "_books",
                column: "ThemesId");

            migrationBuilder.CreateIndex(
                name: "IX__groups_FacultiesId",
                table: "_groups",
                column: "FacultiesId");

            migrationBuilder.CreateIndex(
                name: "IX__s_cards_BooksId",
                table: "_s_cards",
                column: "BooksId");

            migrationBuilder.CreateIndex(
                name: "IX__s_cards_LibsId",
                table: "_s_cards",
                column: "LibsId");

            migrationBuilder.CreateIndex(
                name: "IX__s_cards_StudentsId",
                table: "_s_cards",
                column: "StudentsId");

            migrationBuilder.CreateIndex(
                name: "IX__students_GroupsId",
                table: "_students",
                column: "GroupsId");

            migrationBuilder.CreateIndex(
                name: "IX__teachers_DepartmentsId",
                table: "_teachers",
                column: "DepartmentsId");

            migrationBuilder.CreateIndex(
                name: "IX_AudioBook_AuthorsId",
                table: "AudioBook",
                column: "AuthorsId");

            migrationBuilder.CreateIndex(
                name: "IX_T_Cards_BooksId",
                table: "T_Cards",
                column: "BooksId");

            migrationBuilder.CreateIndex(
                name: "IX_T_Cards_LibsId",
                table: "T_Cards",
                column: "LibsId");

            migrationBuilder.CreateIndex(
                name: "IX_T_Cards_TeachersId",
                table: "T_Cards",
                column: "TeachersId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "_s_cards");

            migrationBuilder.DropTable(
                name: "AudioBook");

            migrationBuilder.DropTable(
                name: "T_Cards");

            migrationBuilder.DropTable(
                name: "_students");

            migrationBuilder.DropTable(
                name: "_books");

            migrationBuilder.DropTable(
                name: "_libs");

            migrationBuilder.DropTable(
                name: "_teachers");

            migrationBuilder.DropTable(
                name: "_groups");

            migrationBuilder.DropTable(
                name: "_authors");

            migrationBuilder.DropTable(
                name: "_categories");

            migrationBuilder.DropTable(
                name: "_press");

            migrationBuilder.DropTable(
                name: "_themes");

            migrationBuilder.DropTable(
                name: "_departments");

            migrationBuilder.DropTable(
                name: "_faculties");
        }
    }
}
