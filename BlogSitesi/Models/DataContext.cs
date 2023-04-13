using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogSitesi.Models
{
    public class DataContext:DbContext
    {
        //public DataContext():base("BlogDatabase") { }
        //Veritabanı işlemlerinde Kullanılacak veriler
        public DbSet<Private> admin { get; set; }

        public DbSet<MakaleMenu> makaleMenus { get; set; }
    }
}