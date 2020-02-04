using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication18.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    MoodStatus = table.Column<int>(nullable: false),
                    Tired = table.Column<bool>(nullable: false),
                    Sad = table.Column<bool>(nullable: false),
                    Bored = table.Column<bool>(nullable: false),
                    Happy = table.Column<bool>(nullable: false),
                    Joyous = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "People");
        }
    }
}
