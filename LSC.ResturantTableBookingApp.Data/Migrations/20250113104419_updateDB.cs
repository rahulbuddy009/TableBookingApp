using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LSC.ResturantTableBookingApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class updateDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DiningTable_RestaurantBranch_RestaurantBranchId",
                table: "DiningTable");

            migrationBuilder.DropForeignKey(
                name: "FK_RestaurantBranch_Restaurant_RestaurantId",
                table: "RestaurantBranch");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RestaurantBranch",
                table: "RestaurantBranch");

            migrationBuilder.RenameTable(
                name: "RestaurantBranch",
                newName: "RestaurantBranches");

            migrationBuilder.RenameColumn(
                name: "SeatsName",
                table: "DiningTable",
                newName: "TableName");

            migrationBuilder.RenameIndex(
                name: "IX_RestaurantBranch_RestaurantId",
                table: "RestaurantBranches",
                newName: "IX_RestaurantBranches_RestaurantId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RestaurantBranches",
                table: "RestaurantBranches",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DiningTable_RestaurantBranches_RestaurantBranchId",
                table: "DiningTable",
                column: "RestaurantBranchId",
                principalTable: "RestaurantBranches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RestaurantBranches_Restaurant_RestaurantId",
                table: "RestaurantBranches",
                column: "RestaurantId",
                principalTable: "Restaurant",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DiningTable_RestaurantBranches_RestaurantBranchId",
                table: "DiningTable");

            migrationBuilder.DropForeignKey(
                name: "FK_RestaurantBranches_Restaurant_RestaurantId",
                table: "RestaurantBranches");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RestaurantBranches",
                table: "RestaurantBranches");

            migrationBuilder.RenameTable(
                name: "RestaurantBranches",
                newName: "RestaurantBranch");

            migrationBuilder.RenameColumn(
                name: "TableName",
                table: "DiningTable",
                newName: "SeatsName");

            migrationBuilder.RenameIndex(
                name: "IX_RestaurantBranches_RestaurantId",
                table: "RestaurantBranch",
                newName: "IX_RestaurantBranch_RestaurantId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RestaurantBranch",
                table: "RestaurantBranch",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DiningTable_RestaurantBranch_RestaurantBranchId",
                table: "DiningTable",
                column: "RestaurantBranchId",
                principalTable: "RestaurantBranch",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RestaurantBranch_Restaurant_RestaurantId",
                table: "RestaurantBranch",
                column: "RestaurantId",
                principalTable: "Restaurant",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
