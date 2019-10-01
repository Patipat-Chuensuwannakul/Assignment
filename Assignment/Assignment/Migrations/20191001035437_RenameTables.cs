using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment.Migrations
{
    public partial class RenameTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TransactionsDbSet_CustomersDbSet_CustomerId",
                table: "TransactionsDbSet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TransactionsDbSet",
                table: "TransactionsDbSet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CustomersDbSet",
                table: "CustomersDbSet");

            migrationBuilder.RenameTable(
                name: "TransactionsDbSet",
                newName: "Transaction");

            migrationBuilder.RenameTable(
                name: "CustomersDbSet",
                newName: "Customer");

            migrationBuilder.RenameIndex(
                name: "IX_TransactionsDbSet_CustomerId",
                table: "Transaction",
                newName: "IX_Transaction_CustomerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Transaction",
                table: "Transaction",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customer",
                table: "Customer",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Transaction_Customer_CustomerId",
                table: "Transaction",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transaction_Customer_CustomerId",
                table: "Transaction");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Transaction",
                table: "Transaction");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customer",
                table: "Customer");

            migrationBuilder.RenameTable(
                name: "Transaction",
                newName: "TransactionsDbSet");

            migrationBuilder.RenameTable(
                name: "Customer",
                newName: "CustomersDbSet");

            migrationBuilder.RenameIndex(
                name: "IX_Transaction_CustomerId",
                table: "TransactionsDbSet",
                newName: "IX_TransactionsDbSet_CustomerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TransactionsDbSet",
                table: "TransactionsDbSet",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CustomersDbSet",
                table: "CustomersDbSet",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionsDbSet_CustomersDbSet_CustomerId",
                table: "TransactionsDbSet",
                column: "CustomerId",
                principalTable: "CustomersDbSet",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
