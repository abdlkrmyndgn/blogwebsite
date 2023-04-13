using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogSitesi.Models
{
    public class MakaleMenu
    {
        public int Id { get; set; }
        public string image { get; set; }
        public string makaleBaslik { get; set; }
        public string altBaslik { get;set; }

        public string makaleTarih { get; set; }
        public string makaleIcerik { get; set; }

        public bool makaleButonIceriyormu { get; set; }
        public string buttonText { get; set; }
        public string buttonLink { get; set; }
    }
}