
using Login.Models;
using Microsoft.EntityFrameworkCore;

namespace Login.Context
{
     public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { 
        
        }

        public DbSet<Person> Persons { get; set; }  
        public DbSet<Authentication> Authentications { get; set; }  
        public DbSet<Material> Materials { get; set; }  
    }
}