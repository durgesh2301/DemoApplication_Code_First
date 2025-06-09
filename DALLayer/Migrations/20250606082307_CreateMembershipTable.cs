using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DALLayer.Migrations
{
    /// <inheritdoc />
    public partial class CreateMembershipTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Memberships",
                columns: table => new
                {
                    MembershipId = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    EmailId = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CreditPoints = table.Column<int>(type: "int", nullable: false),
                    MembershipCardType = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Memberships", x => x.MembershipId);
                    table.ForeignKey(
                        name: "FK_Memberships_Users_EmailId",
                        column: x => x.EmailId,
                        principalTable: "Users",
                        principalColumn: "EmailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Memberships_EmailId",
                table: "Memberships",
                column: "EmailId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Memberships");
        }
    }
}
