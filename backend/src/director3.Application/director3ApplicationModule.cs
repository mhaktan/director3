using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace director3
{
    [DependsOn(typeof(director3CoreModule), typeof(AbpAutoMapperModule))]
    public class director3ApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Modules.AbpAutoMapper().Configurators.Add(cfg =>
            {
                cfg.AddMaps(typeof(director3ApplicationModule).GetAssembly());
            });
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(director3ApplicationModule).GetAssembly());
        }
    }
}
