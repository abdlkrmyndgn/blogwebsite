using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogSitesi.Models
{
    public class ModelManager
    {
        public List<MakaleMenu> makaleMenu  { get; set; }
        public List<KategoriMenu> KategoriMenu { get; set; }
        public List<Private> logininfo{ get; set; }

        public int makalesayisi { get;set; }
    }
}