using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Localization;
using FirstABP.Localization.FirstABP;
using Volo.Abp.TenantManagement.Web.Navigation;
using Volo.Abp.UI.Navigation;

namespace FirstABP.Menus
{
    public class FirstABPMenuContributor : IMenuContributor
    {
        public async Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if (context.Menu.Name == StandardMenus.Main)
            {
                await ConfigureMainMenuAsync(context);
            }
        }

        private async Task ConfigureMainMenuAsync(MenuConfigurationContext context)
        {
            if (!FirstABPConsts.IsMultiTenancyEnabled)
            {
                ApplicationMenuItem administration = context.Menu.GetAdministration();
                administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
            }

            var l = context.ServiceProvider.GetRequiredService<IStringLocalizer<FirstABPResource>>();

            context.Menu.Items.Insert(0, new ApplicationMenuItem("FirstABP.Home", l["Menu:Home"], "/"));
            context.Menu.AddItem(new ApplicationMenuItem("BooksStore", l["Menu:BookStore"])
                .AddItem(new ApplicationMenuItem("FirstABP.Books", l["Menu:Books"], url: "/Books"))
);
        }
    }
}
