﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webAPI.Models
{
    public class OgretimUyesi:Kisi
    {
        public int persNo { get; set; }
        public List<Ders>verdigiDersler { get; set; }
    }
}
