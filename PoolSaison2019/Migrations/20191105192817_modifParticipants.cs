using Microsoft.EntityFrameworkCore.Migrations;

namespace PoolSaison2019.Migrations
{
    public partial class modifParticipants : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Gains_totaux",
                table: "Participant",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Points",
                table: "Participant",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Rang",
                table: "Participant",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Rang_semaine_passee",
                table: "Participant",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gains_totaux",
                table: "Participant");

            migrationBuilder.DropColumn(
                name: "Points",
                table: "Participant");

            migrationBuilder.DropColumn(
                name: "Rang",
                table: "Participant");

            migrationBuilder.DropColumn(
                name: "Rang_semaine_passee",
                table: "Participant");
        }
    }
}
