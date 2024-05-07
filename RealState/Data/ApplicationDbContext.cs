using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RealEstate.Model;

namespace RealEstate.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<UserModel> ApplicationUser { get; set; }
        public DbSet<EstateModel> Estate { get; set; }
        public DbSet<CategoryModel> Category { get; set; }
        //Cascade manager cat dell all produckt

    }
}