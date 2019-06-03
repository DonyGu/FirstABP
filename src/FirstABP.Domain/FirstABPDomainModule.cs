using FirstABP.Localization.FirstABP;
using Volo.Abp.Auditing;
using Volo.Abp.AuditLogging;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Localization;
using Volo.Abp.Localization.Resources.AbpValidation;
using Volo.Abp.Modularity;
using Volo.Abp.MultiTenancy;
using Volo.Abp.PermissionManagement.Identity;
using Volo.Abp.TenantManagement;
using Volo.Abp.VirtualFileSystem;

namespace FirstABP
{
    [DependsOn(
        typeof(AbpIdentityDomainModule),
        typeof(AbpPermissionManagementDomainIdentityModule),
        typeof(AbpAuditingModule),
        typeof(BackgroundJobsDomainModule),
        typeof(AbpAuditLoggingDomainModule),
        typeof(AbpTenantManagementDomainModule),
        typeof(AbpFeatureManagementDomainModule)
        )]
    public class FirstABPDomainModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<VirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<FirstABPDomainModule>("FirstABP");
            });

            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Add<FirstABPResource>("en")
                    .AddBaseTypes(typeof(AbpValidationResource))
                    .AddVirtualJson("/Localization/FirstABP");
            });

            Configure<MultiTenancyOptions>(options =>
            {
                options.IsEnabled = FirstABPConsts.IsMultiTenancyEnabled;
            });
        }
    }
}
