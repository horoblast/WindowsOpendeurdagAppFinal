﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WindowsOpendeurdagAppWeb.Models
{
    public class GebruikerFormulier
    {
        public int GebruikerFormulierId { get; set; }

        public string Voornaam { get; set; }

        public string Achternaam { get; set; }

        public string Geboortedatum { get; set; }

        public string Straat { get; set; }

        public string Email { get; set; }

        public int Telnr { get; set; }

        public string Campus { get; set; }

        public string Richting { get; set; }
    }
}