using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IncomeExpense_WPF.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "incomeExpense",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IncomeEveryTwoWeeks = table.Column<double>(type: "float", nullable: true),
                    ExpenseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpenseSum = table.Column<double>(type: "float", nullable: true),
                    ExpenseSumTotalEveryTwoWeeks = table.Column<double>(type: "float", nullable: true),
                    TotalSavedMonth = table.Column<double>(type: "float", nullable: true),
                    TotalSaved = table.Column<double>(type: "float", nullable: true),
                    IsMonthlyPayment = table.Column<bool>(type: "bit", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RegistrationDay = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_incomeExpense", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "incomeExpense");
        }
    }
}
