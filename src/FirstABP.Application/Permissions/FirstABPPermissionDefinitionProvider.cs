using FirstABP.Localization.FirstABP;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace FirstABP.Permissions
{
    public class FirstABPPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(FirstABPPermissions.GroupName);

            //Define your own permissions here. Examaple:
            //myGroup.AddPermission(FirstABPPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<FirstABPResource>(name);
        }
    }
}
