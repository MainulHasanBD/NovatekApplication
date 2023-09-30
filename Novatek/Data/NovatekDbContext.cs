using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Novatek.Models.Entities;

namespace Novatek.Data
{
    public class NovatekDbContext: IdentityDbContext<IdentityCustomUser>
    {
        public NovatekDbContext(DbContextOptions<NovatekDbContext> options) : base(options) { }
        public DbSet<Company>? Companies { get; set; } 
        public DbSet<Department>? Departments { get; set; } 
        public DbSet<Designation>? Designations { get; set; } 
        public DbSet<Employee>? Employees { get; set; } 
        public DbSet<Increment>? Increments { get; set; } 
        public DbSet<Salary>? Salaries { get; set; } 
    }
}
