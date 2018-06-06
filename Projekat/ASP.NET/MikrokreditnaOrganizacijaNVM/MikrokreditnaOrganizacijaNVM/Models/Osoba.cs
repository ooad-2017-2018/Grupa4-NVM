using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MikrokreditnaOrganizacijaNVM.Models
{
    public abstract class Osoba
    {
        private int id;
        [Required]
        //[DisplayName ("Ime osobe: ")]
        private string ime;
        [Required]
        private string prezime;
        [Required]
        private string username;
        [Required]
        private string password;
        private string jmbg;
        public string fourSqaureId { get; set; }
        private string brTel;
        private string adresa;

        public Osoba(string ime, string prezime, string jMBG, string brTel, string adresa, string un, string pass)
        {
            Ime = ime;
            Prezime = prezime;
            JMBG = jMBG;
            BrTel = brTel;
            Adresa = adresa;
            Username = un;
            Password = pass;
        }
        public Osoba()
        {

        }
        [Required]
        [DisplayName("Ime osobe: ")]
        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }
        [Required]
        [DisplayName("Prezime osobe: ")]
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
        [Required]
        [DisplayName("Username osobe: ")]
        public string Username { get => username; set => username = value; }
        [Required]
        [DisplayName("Password: ")]
        public string Password { get => password; set => password = value; }
        public int Id { get => id; set => id = value; }
    }
}