﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace acr_main_api.Models
{
    public class Domain
    {
        public int Id { get; set; }
        public string Name { get; set; }

        List<Significative> Significatives { get; set; }
    }
}