using Microsoft.EntityFrameworkCore.Migrations;

namespace Segfy.Repository.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Youtube",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    Kind = table.Column<int>(nullable: false),
                    PublishedAt = table.Column<string>(maxLength: 50, nullable: true),
                    ChannelId = table.Column<string>(maxLength: 200, nullable: true),
                    Title = table.Column<string>(maxLength: 200, nullable: true),
                    Description = table.Column<string>(maxLength: 200, nullable: true),
                    DefaultUrl = table.Column<string>(maxLength: 2000, nullable: true),
                    DefaultWidth = table.Column<int>(nullable: false),
                    DefaultHeight = table.Column<int>(nullable: false),
                    MediumUrl = table.Column<string>(maxLength: 2000, nullable: true),
                    MediumWidth = table.Column<int>(nullable: false),
                    MediumHeight = table.Column<int>(nullable: false),
                    HighUrl = table.Column<string>(maxLength: 2000, nullable: true),
                    HighWidth = table.Column<int>(nullable: false),
                    HighHeight = table.Column<int>(nullable: false),
                    ChannelTitle = table.Column<string>(maxLength: 200, nullable: true),
                    LiveBroadcastContent = table.Column<string>(maxLength: 2000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Youtube", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Youtube");
        }
    }
}
