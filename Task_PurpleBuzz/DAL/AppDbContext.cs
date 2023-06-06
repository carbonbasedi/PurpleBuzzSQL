using Microsoft.EntityFrameworkCore;
using Task_PurpleBuzz.Models;

namespace Task_PurpleBuzz.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {

        }

        public DbSet<AboutBannerComponent> AboutBannerComponent{ get; set; }
        public DbSet<ContactsBannerComponent> ContactsBannerComponents { get; set; }
        public DbSet<ContactsSuccessComponent> ContactsSuccessComponents { get; set; }
    }
}
