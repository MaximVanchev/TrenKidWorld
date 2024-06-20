using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrenKidWorld.Infrastructure.Data.Constants;

namespace TrenKidWorld.Infrastructure.Data.Identity
{
    public class TrenKidWorldUser : IdentityUser
    {
        public TrenKidWorldUser()
        {
            LikedProducts = new List<Product>();
            CartProducts = new List<CartProduct>();
        }

        [StringLength(DatabaseConstants.ProfilePicture_Max_Length)]
        public string? ProfilePicture { get; set; }

        public IList<Product> LikedProducts { get; set; }

        public IList<CartProduct> CartProducts { get; set; }
    }
}
