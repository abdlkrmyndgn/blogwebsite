using BlogSitesi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogSitesi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Blog()
        {
            //Verileri Sunucudan Çekip Model olarak viewe gönderiyoruz...
            ModelManager modelManager = new ModelManager();
            DataContext dataContext = new DataContext();
            List<MakaleMenu> makaleler=dataContext.makaleMenus.ToList();
            modelManager.makalesayisi = dataContext.makaleMenus.Count();
            modelManager.makaleMenu = makaleler;
            return View(modelManager);
        }

        
    }
}