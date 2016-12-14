﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WindowsOpendeurdagAppWeb.Models
{
    public class Gebouw
    {
        public int GebouwId { get; set; }

        public string Name { get; set; }

        public string Afkorting { get; set; }

        /*
        [ForeignKey("CampusId")]
        public int CampusId { get; set; }
        */

        public virtual ICollection<Campus> Campussen { get; set; }
    }
}