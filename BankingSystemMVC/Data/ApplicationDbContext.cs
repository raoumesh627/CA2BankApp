using BankingSystemMVC_Umesh_yadav_25327.Models;
using Microsoft.EntityFrameworkCore;

namespace BankingSystemMVC_Umesh_yadav_25327.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        { 
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
    }
}
