using System;

namespace IncomeExpense_WPF.Model
{
    public class IncomeExpense
    {
        public int Id { get; set; }
        public double? IncomeEveryTwoWeeks { get; set; }
        public string? ExpenseName { get; set; }
        public double? ExpenseSum { get; set; }
        public double? ExpenseSumTotalEveryTwoWeeks { get; set; }
        public double? TotalSavedMonth { get; set; }
        public double? TotalSaved { get; set; }
        public bool? IsMonthlyPayment { get; set; }
        public DateTime? StartDate { get; set; } = DateTime.Today;
        public DateTime RegistrationDay { get; set; } = DateTime.Today;
    }
}
