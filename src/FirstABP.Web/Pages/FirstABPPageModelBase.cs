using FirstABP.Localization.FirstABP;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace FirstABP.Pages
{
    public abstract class FirstABPPageModelBase : AbpPageModel
    {
        protected FirstABPPageModelBase()
        {
            LocalizationResourceType = typeof(FirstABPResource);
        }
    }
}