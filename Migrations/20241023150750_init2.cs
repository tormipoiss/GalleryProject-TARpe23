using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GalleryProject.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Galleries",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArtistName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArtistGender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArtistAge = table.Column<int>(type: "int", nullable: false),
                    ArtistAlive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Galleries", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "WorksOfArt",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkOfArtName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MadeByArtist = table.Column<bool>(type: "bit", nullable: false),
                    MadeByArtistID = table.Column<int>(type: "int", nullable: false),
                    MadeBySomoneElseName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkOfArtGroup = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorksOfArt", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "WorksOfArtGroups",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Painting = table.Column<bool>(type: "bit", nullable: false),
                    Sculpture = table.Column<bool>(type: "bit", nullable: false),
                    Literature = table.Column<bool>(type: "bit", nullable: false),
                    Music = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorksOfArtGroups", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Galleries");

            migrationBuilder.DropTable(
                name: "WorksOfArt");

            migrationBuilder.DropTable(
                name: "WorksOfArtGroups");
        }
    }
}
