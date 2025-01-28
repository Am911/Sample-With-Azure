using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestWithAzure.Migrations
{
    /// <inheritdoc />
    public partial class Azure_UserBankDetails_Mst_addnew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Azure_UserBankDetails_Mst",
                columns: table => new
                {
                    Pk_BankDetailsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BankName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IFSC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountNumber = table.Column<long>(type: "bigint", nullable: false),
                    Fk_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Azure_UserBankDetails_Mst", x => x.Pk_BankDetailsId);
                    table.ForeignKey(
                        name: "FK_Azure_UserBankDetails_Mst_Azure_UserInformation_Mst_Fk_Id",
                        column: x => x.Fk_Id,
                        principalTable: "Azure_UserInformation_Mst",
                        principalColumn: "Pk_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Azure_UserBankDetails_Mst_Fk_Id",
                table: "Azure_UserBankDetails_Mst",
                column: "Fk_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Azure_UserBankDetails_Mst");
        }
    }
}
