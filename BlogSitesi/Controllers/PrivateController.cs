using BlogSitesi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogSitesi.Controllers
{
    public class PrivateController : Controller
    {
        [HttpGet]
        public ActionResult AdminPanel() {
        return View();
        }

        [HttpPost]
        public ActionResult AdminPanel(Private entity)
        {
            DataContext database = new DataContext();
            
            if (database.admin.Find(1)!= null)
            {
                var account = database.admin.Find(1);
                if (account.Username == entity.Username && account.Password == entity.Password)
                {
                    //Şifre Doğru girildiğinde gerçekleşicek
                    return View("Panel");
                }
                else
                {
                    //Şifre Yanlış Girildiğinde Gerçekleşecekler
                    return RedirectToAction("Blog", "Home");//Bu komut sayesinde ana dizine dönmek mümkün
                }
            }
            else
            {
                database.admin.Add(entity);
                database.SaveChanges();
                return View();
            }
            
        }

        [HttpPost]
        public ActionResult Panelveri(MakaleMenu entity)
        {
            DataContext database=new DataContext();
            database.makaleMenus.Add(entity);
            database.SaveChanges();
            return View("Panel");
        }
        
    }
}