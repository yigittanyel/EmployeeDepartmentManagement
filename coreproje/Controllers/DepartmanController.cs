using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using coreproje.Models;
using Microsoft.AspNetCore.Authorization;

namespace coreproje.Controllers
{
    public class DepartmanController : Controller
    {
        Context c = new Context();
        [Authorize]
        public IActionResult Index()
        {
            var deger = c.Departmans.ToList();
            return View(deger);
        }
        public IActionResult YeniDepartman()
        {
            return View();
        }
        [HttpPost]
        public IActionResult YeniDepartman(Departman d)
        {
            c.Add(d);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DepartmanSil(int id)
        {
            var d = c.Departmans.FirstOrDefault(x => x.ID == id);
            c.Departmans.Remove(d);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DepartmanGetir(int id)
        {
            var d = c.Departmans.Find(id);
            return View("DepartmanGetir",d);
        }

        public IActionResult DepartmanGuncelle(Departman d) //BURADA KALDIK!!!
        {
            var deg = c.Departmans.Find(d.ID);
            deg.Ad = d.Ad;
            c.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpPost]
        public ActionResult BirimDetayi(int id)
        {
            var x = c.Personels.Where(x => x.Id== id).ToList();
            var brmad = c.Departmans.Where(x => x.ID == id).Select(y => y.Ad).FirstOrDefault();
            ViewBag.brm = brmad;
            return View(x);
        }
    }
}
