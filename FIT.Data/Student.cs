﻿using FIT.Data.Ispit;
using System.Drawing;

namespace FIT.Data
{
    public class Student
    {
        public int Id { get; set; }
        public string Indeks { get; set; }
        public string Lozinka { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public byte[] Slika { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public bool Aktivan { get; set; }        
        public Semestri Semestar {  get; set; }
        public int SemestarId { get; set; }
        public Gradovi Grad {  get; set; }
        public int GradId { get; set; }
        public override string ToString()
        {
            return $"{Indeks} {Ime} {Prezime}";
        }
    }
}