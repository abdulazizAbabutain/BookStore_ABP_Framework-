using BookStoreLap.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace BookStoreLap.Permissions
{
    public class BookStoreLapPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(BookStoreLapPermissions.GroupName);
            //Define your own permissions here. Example:
            //myGroup.AddPermission(BookStoreLapPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<BookStoreLapResource>(name);
        }
    }
}
