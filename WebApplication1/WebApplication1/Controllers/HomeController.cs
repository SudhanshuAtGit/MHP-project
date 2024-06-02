using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.custommodel;

namespace WebApplication1.Controllers
{
   
    public class HomeController : Controller
    {
         Model_hiringEntities db = new Model_hiringEntities();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult MaleRegister()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        [HttpPost]
        public ActionResult registerpage(register987 model)
        {

            
                C_register1234 rgint = new C_register1234();
                rgint.fname = model.ffname;
                rgint.lname = model.llname;
                rgint.email = model.Eemail;
                rgint.gender = model.fav_language;
                rgint.password = model.pass;
                rgint.npassword = model.conpass;
                db.C_register1234.Add(rgint);


                db.SaveChanges();
                Login1123 ll = new Login1123();
                ll.password = model.conpass;
                ll.Username = model.ffname;
                ll.USERROLL = "model";
                db.Login1123.Add(ll);
                db.SaveChanges();

                //var url = string.Format("/Home/MaleRegister");
            // return View(url);



            return RedirectToAction("MaleRegister");
        }

        [HttpGet]
        public ActionResult login()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpPost]
        public ActionResult loginpage(login800 model)
        {
            string url = "";

            var result = db.Login1123.Where(x => x.Username == model.UserN && x.password == model.UserP ).FirstOrDefault();
            if(result != null && result.USERROLL == "model")
            {

                url = string.Format("/Home/MaleRegister");
            }
            if(result != null && result.USERROLL == "Admin")
            {
               
                url = string.Format("/Admin/Index");
            }
            if(result == null)
            {
                url = string.Format("/Home/login");
            }
            return Redirect(url);
        }
        public ActionResult profile()
        {
            

            return View();
        }
    }
}