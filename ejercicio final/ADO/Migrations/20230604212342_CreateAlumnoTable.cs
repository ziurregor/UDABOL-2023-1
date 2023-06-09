using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ADO.Migrations
{
    /// <inheritdoc />
    public partial class CreateAlumnoTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alumnos",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: true),
                    Codigo = table.Column<string>(type: "TEXT", nullable: true),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    Ex_GIT_6PTS = table.Column<int>(type: "INTEGER", nullable: false),
                    Ex_ADOO_8PTS = table.Column<int>(type: "INTEGER", nullable: false),
                    Ex_ScrumTra_41PTS = table.Column<int>(type: "INTEGER", nullable: false),
                    Ex_SOLID_8PTS = table.Column<int>(type: "INTEGER", nullable: false),
                    Ex_12FactApp_12PTS = table.Column<int>(type: "INTEGER", nullable: false),
                    Ex_Docker_5PTS = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alumnos", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alumnos");
        }
    }
}
