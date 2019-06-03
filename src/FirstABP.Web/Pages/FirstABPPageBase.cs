using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using FirstABP.Localization.FirstABP;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace FirstABP.Pages
{
    public abstract class FirstABPPageBase : AbpPage
    {
        [RazorInject]
        public IHtmlLocalizer<FirstABPResource> L { get; set; }
    }
}
