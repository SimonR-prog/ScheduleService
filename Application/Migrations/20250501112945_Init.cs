using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Application.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Schedules",
                columns: table => new
                {
                    EventId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GateOpenStart = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GateOpenEnd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PreShowStart = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreShowEnd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CeremonyStart = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CeremonyEnd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcertStart = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedules", x => x.EventId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Schedules");
        }
    }
}
