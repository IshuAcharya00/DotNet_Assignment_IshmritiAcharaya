using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Ishmirt_Acharya_Dot_Net_Assignment.Models;

namespace Ishmirt_Acharya_Dot_Net_Assignment.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Ishmirt_Acharya_Dot_Net_Assignment.Models.Admin> Admin { get; set; } = default!;
        public DbSet<Ishmirt_Acharya_Dot_Net_Assignment.Models.Student> Student { get; set; } = default!;
        public DbSet<Ishmirt_Acharya_Dot_Net_Assignment.Models.Manage> Manage { get; set; } = default!;
        public DbSet<Ishmirt_Acharya_Dot_Net_Assignment.Models.Teacher> Teacher { get; set; } = default!;
    }
}
