using Interview.Models;
using Microsoft.EntityFrameworkCore;

namespace Interview.Data
{
    public class BillContext:DbContext
    {
        public BillContext(DbContextOptions options): base(options) {

        
        } 
        public DbSet<BillData> BillData { get; set; }
        
    }
}
