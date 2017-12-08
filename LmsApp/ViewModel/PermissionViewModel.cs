
using Lms.IdentityModel;
using Model;

namespace ViewModel
{
    public class PermissionViewModel : BaseViewModel<Permission>
    {
        public PermissionViewModel(Permission permission) : base(permission)
        {
            this.IsAllowed = permission.IsAllowed;
            this.IsDisabled = permission.IsDisabled;
        }
        public bool IsAllowed { get; set; }

        public bool IsDisabled { get; set; }
    }
}
