using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CursoPemex.Data
{
    public class ApplicationDbContext : IdentityDbContext<employee>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<LeaveType> LeaveTypes{ get; set; }
        public DbSet<LeaveAllocation> LeaveAllocations { get; set; }
    }
}