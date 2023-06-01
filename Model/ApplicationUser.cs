using Microsoft.AspNetCore.Identity;

namespace Merchantdized.Model
{
    
        public class ApplicationUser : IdentityUser
        {
            public string Name { get; set; }
        }
    }

