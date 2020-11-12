using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Core.Models.Business;

namespace Core.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }

        public string PictureUrl { get; set; }

        public virtual List<Business.Business> Businesses { get; set; }
    }
}
