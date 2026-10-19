using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Kurumsal.WebUI.Context
{
    public class IdentityContext : IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
          //  optionsBuilder.UseSqlServer(@"Server=data.kurumsalfabrika.com.tr; Database = KIRILMAZLAR2025; User Id = KIRILMAZLAR2025; Password = fc263066K!;TrustServerCertificate=true");
        //    optionsBuilder.UseSqlServer(@"Server=data.kurumsalfabrika.com.tr; Database = 3ASOSGB; User Id = 3ASOSGB; Password = fc263066K!;TrustServerCertificate=true");
         //   optionsBuilder.UseSqlServer(@"Server=data.kurumsalfabrika.com.tr; Database = ARIKVIDANJOR; User Id = ARIKVIDANJOR; Password = fc263066K!;TrustServerCertificate=true");
        //     optionsBuilder.UseSqlServer(@"Server=data.kurumsalfabrika.com.tr; Database = CARITA; User Id = CARITA; Password = fc263066K!;TrustServerCertificate=true");
             optionsBuilder.UseSqlServer(@"Server=data.kurumsalfabrika.com.tr; Database = GOKHANERASLAN; User Id = GOKHANERASLAN; Password = fc263066K!;TrustServerCertificate=true");

            // optionsBuilder.UseSqlServer(@"Server=.;DataBase=Test;Trusted_Connection=true;TrustServerCertificate=true");
            //     optionsBuilder.UseSqlServer(@"Server=www.kurumsalfabrika.com.tr\MSSQLSERVER2017; Database = KURUMSAL; User Id = KURUMSAL; Password = fc263066K!;");
            base.OnConfiguring(optionsBuilder);
        }

        
    }
}
