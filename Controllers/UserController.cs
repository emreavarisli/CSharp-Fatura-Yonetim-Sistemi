using FaturaYönetimSistemleri.Models.DB;
using FaturaYönetimSistemleri.Models.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FaturaYönetimSistemleri.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        Context c = new Context();

        // GET: User
        public ActionResult Index()
        {
            var values = c.Users.Where(x => x.IsDelete == false).ToList();
            return View(values);
        }

        [HttpPost]
        public ActionResult Index(User user)
        {

            c.Users.Add(user);
            c.SaveChanges();

            return RedirectToAction("Index");

        }

        [HttpGet]
        public ActionResult UserAdd()
        {
            List<SelectListItem> daires = (from x in c.Daire.Where(x => x.UserId == null).ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.DaireId + " Daire",
                                               Value = x.DaireId.ToString()
                                           }).ToList();
            ViewBag.VDaireler = daires;

            return View();

        }

        [HttpPost]
        public ActionResult UserAdd(User user)
        {
            c.Users.Add(user);
            c.SaveChanges();

            return RedirectToAction("Index");

        }

        public ActionResult UserDetay(int id)
        {
            var values = c.Apartments.Where(x => x.UserId == id).ToList();

            var userName = c.Users.Where(x => x.UserId == id).Select(y => y.FirstName + " " + y.LastName).FirstOrDefault();
            ViewBag.VuserName = userName;

            return View(values);

        }

        public ActionResult UserInvoice(int id)
        {
            var values = c.Invoice.Where(x => x.UserID == id).ToList();

            var userName = c.Users.Where(x => x.UserId == id).Select(y => y.FirstName + " " + y.LastName).FirstOrDefault();
            ViewBag.VuserName = userName;

            return View(values);

        }

        public ActionResult UserUpdate(int id)
        {
            List<SelectListItem> daires = (from x in c.Daire.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.DaireId + " Daire",
                                               Value = x.DaireId.ToString()
                                           }).ToList();
            ViewBag.VDaireler = daires;

            var value = c.Users.Find(id);

            return View("UserUpdate", value);


        }

        [HttpPost]
        public ActionResult UserUpdated(User user)
        {

            var value = c.Users.Find(user.UserId);

            value.FirstName = user.FirstName;
            value.LastName = user.LastName;
            value.Email = user.Email;
            value.Password = user.Password;

            value.TCNo = user.TCNo;
            value.Phone = user.Phone;

            value.ApartmentOwner = user.ApartmentOwner;
            value.IsDelete = user.IsDelete;
            value.DaireId = user.DaireId;


            c.SaveChanges();

            return RedirectToAction("Index");


        }

    }
}