using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Mangatheque.Core.Models
{
    // Add profile data for application users by adding properties to the MangathequeWebUIUser class
    public class MangathequeUser : IdentityUser
    {
        public virtual List<Manga_MangathequeUser>? UserMangas { get; set; }
    }

}
