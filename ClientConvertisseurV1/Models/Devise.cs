﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientConvertisseurV1.Models
{
    public class Devise
    {
        private int id;

        [Required]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string? nomDevise;
        [Required]
        public string? NomDevise
        {
            get { return nomDevise; }
            set { nomDevise = value; }
        }

        private double taux;
        [Required]
        public double Taux
        {
            get { return taux; }
            set { taux = value; }
        }

        public Devise() { }

        public Devise(int id, string? nomDevise, double taux)
        {
            this.Id = id;
            this.NomDevise = nomDevise;
            this.Taux = taux;
        }
    }
}
