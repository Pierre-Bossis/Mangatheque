﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mangatheque.Core.Models
{
    public class User : IdentityUser
    {
        public List<MangasUser>? MangasUser { get; set; }
    }
}
