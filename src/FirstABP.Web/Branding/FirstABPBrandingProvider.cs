using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace FirstABP.Branding
{
    [Dependency(ReplaceServices = true)]
    public class FirstABPBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "FirstABP";
    }
}
