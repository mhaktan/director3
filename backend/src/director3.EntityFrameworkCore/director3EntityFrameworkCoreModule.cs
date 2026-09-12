using Abp.EntityFrameworkCore;
using Abp.EntityFrameworkCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace director3.EntityFrameworkCore
{
    [DependsOn(typeof(director3CoreModule), typeof(AbpEntityFrameworkCoreModule))]
    public class director3EntityFrameworkCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Modules.AbpEfCore().AddDbContext<director3DbContext>(options =>
            {
                // connStr ABP tarafından CoreModule.DefaultNameOrConnectionString'ten resolve edilir
                // (Railway'de ConnectionStrings__Default env var). Ekstra ConfigurationBuilder/paket
                // gerekmez. ExistingConnection = nested UnitOfWork bağlantı paylaşımı.
                if (options.ExistingConnection != null)
                {
                    options.DbContextOptions.UseNpgsql(options.ExistingConnection);
                }
                else
                {
                    options.DbContextOptions.UseNpgsql(options.ConnectionString);
                }
            });
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(director3EntityFrameworkCoreModule).GetAssembly());
        }
    }
}
