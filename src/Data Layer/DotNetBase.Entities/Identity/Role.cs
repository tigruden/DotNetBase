﻿using DotNetBase.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBase.Entities.Identity
{
    public class Role : BaseEntity
    {
        public string Name { get; set; }


        // Navigation property
        public ICollection<User> Users { get; set; }

    }
}
