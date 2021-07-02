using Microsoft.EntityFrameworkCore.Migrations;

namespace HS_Stat_Tracker_DAL.Migrations
{
    public partial class added_spell_type : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "spellSchool",
                table: "Cards",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "spellSchool",
                table: "Cards");
        }
    }
}
