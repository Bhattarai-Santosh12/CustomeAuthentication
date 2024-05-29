//using Microsoft.EntityFrameworkCore;

//namespace CustomeAuthentication.Entities
//{
//    public class AppDbContext : DbContext
//    {
//        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
//        {

//        }
//        public DbSet<UserAccount> UserAccounts { get; set; }

//    }
//}





using CustomeAuthentication.Entities;
using Microsoft.EntityFrameworkCore;

namespace CustomeAuthentication.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<UserAccount> UserAccounts { get; set; }
    }
}
