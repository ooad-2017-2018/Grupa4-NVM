﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    public abstract class  Osoba
    {
        private string ime;
        private string prezime;
        private string jmbg;
        public string fourSqaureId { get; set; }
        private string brTel;
        private string adresa;

        public Osoba(string ime, string prezime, string jMBG, string brTel, string adresa)
        {
            Ime = ime;
            Prezime = prezime;
            JMBG = jMBG;
            BrTel = brTel;
            Adresa = adresa;
        }
        public Osoba()
        {

        }
        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }
        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }
        public string JMBG
        {
            get { return jmbg; }
            set { jmbg = value; }
        }
        public string BrTel
        {
            get { return brTel; }
            set { brTel = value; }
        }

        public string Adresa
        {
            get { return adresa; }
            set { adresa = value; }
        }


   }
}
