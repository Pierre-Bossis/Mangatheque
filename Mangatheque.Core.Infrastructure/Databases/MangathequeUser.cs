﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mangatheque.Core.Models;
using Microsoft.AspNetCore.Identity;

namespace Mangatheque.Core.Infrastructure.Databases;

// Add profile data for application users by adding properties to the MangathequeWebUIUser class
public class MangathequeUser : IdentityUser
{
    public virtual ICollection<MangaUser> MesMangas { get; set; }
}

