using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Authorization.Permissions;

namespace diplez.test1.Providers
{
    public class SystemAdminPermissionValueProvider : PermissionValueProvider
    {
        public SystemAdminPermissionValueProvider(IPermissionStore permissionStore)
            : base(permissionStore)
        {
        }

        public override string Name => "SystemAdmin";

        public async override Task<PermissionGrantResult>
               CheckAsync(PermissionValueCheckContext context)
        {
            System.Diagnostics.Debug.WriteLine(" Object is not valid for this category. "+ String.Join("-", context.Principal.Identities.Select(x=>x.Name)));

            if (context.Principal?.FindFirst("User_Type")?.Value == "SystemAdmin")
            {
                return PermissionGrantResult.Granted;
            }

            return PermissionGrantResult.Granted;
        }

        public override Task<MultiplePermissionGrantResult> CheckAsync(PermissionValuesCheckContext context)
        {
            var permissionNames = "AbpIdentity.Users,AbpIdentity.Users.ManagePermissions,AbpIdentity.Users.Create,AbpIdentity.Users.Update,AbpIdentity.Users.Delete".Split(",").ToArray();

            /**if (CheckAsync(context.Principal))
            {
                return Task.FromResult(new MultiplePermissionGrantResult(permissionNames, PermissionGrantResult.Granted));
            }*/

            return Task.FromResult(new MultiplePermissionGrantResult(permissionNames, PermissionGrantResult.Granted));
        }

        private bool CheckAsync(ClaimsPrincipal principal)
        {
            return principal?.FindFirst("User_Type")?.Value == "SystemAdmin";
        }
    }

}
