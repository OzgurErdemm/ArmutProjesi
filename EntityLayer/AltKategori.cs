﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class AltKategori
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(250)]
        public string AltKategoriAdi { get; set; }
        public bool Aktif { get; set; }


        //*****
        public virtual Kategori Kategori { get; set; }
    }
}
