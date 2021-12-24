using coreproje.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coreproje.Controllers
{
    public class PersonelController : Controller
    {
        Context c = new Context();
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PersonelGetir()
        {
            var x = c.Personels.Include(x=>x.departman).ToList();
            return View(x);
        }

        public IActionResult PersonelSil(int id)
        {
            var x = c.Personels.FirstOrDefault(x=>x.Id==id);
            c.Personels.Remove(x);
            c.SaveChanges();
            return RedirectToAction("PersonelGetir");
        }

        [HttpGet]
        public IActionResult YeniPersonel()
        {
            List<SelectListItem> dep = (from x in c.Departmans.ToList()
                                        select new SelectListItem
                                        {
                                            Text = x.Ad,
                                            Value = x.ID.ToString()
                                        }).ToList();
            ViewBag.dp = dep;
            return View();
        }
        [HttpPost]
        public IActionResult YeniPersonel(Personel p)
        {
            c.Add(p);
            c.SaveChanges();
            return RedirectToAction("PersonelGetir");
        }

        public IActionResult PersonelBilgiGetir(int id)
        {
            var d = c.Personels.Find(id);
            return View("PersonelBilgiGetir", d);
        }

        public IActionResult PersonelGuncelle(Personel p)
        {
            var x = c.Personels.FirstOrDefault(x => x.Id == p.Id);
            x.Ad = p.Ad;
            x.Soyad = p.Soyad;
            x.Sehir = p.Sehir;
            x.departman = p.departman;
            c.SaveChanges();
            return RedirectToAction("PersonelGetir");
        }

    }
}
