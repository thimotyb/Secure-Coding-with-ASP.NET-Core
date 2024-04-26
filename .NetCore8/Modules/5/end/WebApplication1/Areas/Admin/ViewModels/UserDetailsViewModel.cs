using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization

namespace Globomantics.Survey.Areas.Admin.ViewModels
{
    public class UserDetailsViewModel
    {
        public IdentityUser User { get; set; }

        public bool IsAdmin { get; set; }

        public UserDetailsViewModel(IdentityUser user, bool isAdmin)
        {
            User = user;
            IsAdmin = isAdmin;
        }

    }
}
