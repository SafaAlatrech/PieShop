using Microsoft.EntityFrameworkCore.Migrations;

namespace SafaPieShop.Migrations
{
    public partial class UpdateFeedback : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FeedBackId",
                table: "Feedbacks",
                newName: "FeedbackId");

            migrationBuilder.RenameColumn(
                name: "Mail",
                table: "Feedbacks",
                newName: "Email");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FeedbackId",
                table: "Feedbacks",
                newName: "FeedBackId");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Feedbacks",
                newName: "Mail");
        }
    }
}
