using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Webproje.Controllers
{
    public class TelefonController : Controller
    {
        // GET: Telefon
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Edit(int Id)
		{

            var Telefon = Models.TelefonVeri.VeriListe.Where(x => x.Id == Id).FirstOrDefault();
            return View();

		}
        [HttpPost]
        public ActionResult Edit(Models.TelefonVeri telefonVeri)
		{
            var Telefon = Models.TelefonVeri.VeriListe.FirstOrDefault(x => x.Id == telefonVeri.Id);
            Telefon.Telefon = telefonVeri.Telefon;
            Telefon.Model = telefonVeri.Model;
            Telefon.Fiyat = telefonVeri.Fiyat;
            return RedirectToAction("Listele");


		}
        public ActionResult Delete(int Id)
		{
            var Telefon = Models.TelefonVeri.VeriListe.Where(x => x.Id == Id).FirstOrDefault();
            return View(Telefon);
        }
        [HttpPost]
        public ActionResult Delete(Models.TelefonVeri telefonVeri)
		{
            var Telefon = Models.TelefonVeri.VeriListe.FirstOrDefault(x => x.Id == telefonVeri.Id);
            Models.TelefonVeri.VeriListe.Remove(Telefon);
            return RedirectToAction("Listele");
        }
        public ActionResult Listele()
		{
            return View(Models.TelefonVeri.VeriListe);
		}
        
    }
}