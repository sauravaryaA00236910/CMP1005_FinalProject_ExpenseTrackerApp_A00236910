using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CMP1005_FinalProject_ExpenseTrackerApp_A00236910.Models;

namespace CMP1005_FinalProject_ExpenseTrackerApp_A00236910.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<CMP1005_FinalProject_ExpenseTrackerApp_A00236910.Models.Expense> Expense { get; set; }
    }
}
