using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using director3.EntityFrameworkCore;

namespace director3.Web.Host
{
    [DependsOn(typeof(director3ApplicationModule), typeof(director3EntityFrameworkCoreModule), typeof(AbpAspNetCoreModule))]
    public class director3WebHostModule : AbpModule
    {
        public override void PreInitialize()
        {
            // Expose all AppServices as dynamic API controllers
            Configuration.Modules.AbpAspNetCore()
                .CreateControllersForAppServices(
                    typeof(director3ApplicationModule).GetAssembly(),
                    moduleName: "app",
                    useConventionalHttpVerbs: true
                );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(director3WebHostModule).GetAssembly());
        }
    }
}
