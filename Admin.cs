﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ISE309_ProjeOdev_B181200028_B181200039.Models.Sınıflar
{
    public class Admin
    {
        [Key]
        public int ID { get; set; }
        public string Kullanici { get; set; }

        public string Sifre { get; set; }
    }
}