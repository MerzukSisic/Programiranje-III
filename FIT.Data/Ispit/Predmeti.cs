﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.Ispit
{
    public class Predmeti
    {
        public int Id { get; set; }
        public string Naziv {  get; set; }
        public Semestri Semestar { get; set; }
        public int SemestarId { get; set; }
    }
}
