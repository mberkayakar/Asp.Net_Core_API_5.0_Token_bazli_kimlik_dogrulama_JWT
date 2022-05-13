using AKAR.AuthServer.EntityLayer;
using AKAR.AuthServer.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AKAR.AuthServer.DataAccess.Concrete.EntityFramework
{
    public class MyDbContext:IdentityDbContext<UserApp,IdentityRole,string>
    {
        public MyDbContext(DbContextOptions<MyDbContext> options):base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<UserRefreshToken> UserRefreshTokens { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            // belirtilen lokasyondaki (configuration klasörü altındaki Data Annodation lar ın hepsini el ile eklemek yerine bu klasör vasıtası ile )
            // direkt elle ekleme yaparak ve sınırlamalarını belirterek işleyeebilmektedir. 

            builder.ApplyConfigurationsFromAssembly(GetType().Assembly);

        }
    }
}
