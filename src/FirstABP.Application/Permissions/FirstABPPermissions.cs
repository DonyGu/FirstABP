using System;
using Volo.Abp.Reflection;

namespace FirstABP.Permissions
{
    public static class FirstABPPermissions
    {
        public const string GroupName = "FirstABP";

        //Add your own permission names. Example:
        //public const string MyPermission1 = GroupName + ".MyPermission1";

        public static string[] GetAll()
        {
            //Return an array of all permissions
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(FirstABPPermissions));
        }
    }
}