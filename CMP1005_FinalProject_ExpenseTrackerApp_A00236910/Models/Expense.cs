using System;
namespace CMP1005_FinalProject_ExpenseTrackerApp_A00236910.Models
{
    public class Expense
    {
        public int Id { get; set; }
        public string ExpenseTitle { get; set; }
        public string ExpenseDetails { get; set; }
        public DateTime DateTime { get; set; }

        public Expense()
        {

        }
    }
}
