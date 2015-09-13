﻿using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FazBem.Models
{
    public class User
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public EnumProfile Profiles { get; set; }
    }
}
