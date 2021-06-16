using Microsoft.AspNetCore.Mvc;
using System;
using PatrahSave.Data;
using PatrahSave.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatrahSave.Controllers
{
    public class AccounttypeController : Controller
    {

        private readonly AppDbcontext _db;

        public AccounttypeController(AppDbcontext db)
        {
            _db = db;
        }





        public IActionResult Index()
        {
            IEnumerable<Accounttype> objList = _db.Accounttypes;
            return View(objList);
        }

        public IActionResult Create()
        {

            return View();

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreatePost(Accounttype obj)
        {
            _db.Accounttypes.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("index");

        }
        public IActionResult Delete(int? id)
        {
            var obj = _db.Accounttypes.Find(id);
            if (id == null || id == 0) { return NotFound(); }
            _db.Accounttypes.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("index");

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {

            if (id == null || id == 0) { return NotFound(); }

            var obj = _db.Accounttypes.Find(id);
            if (obj == null)
            {

            }
            _db.Accounttypes.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("index");

        }
        public IActionResult Update(int? id)
        {

            if (id == null || id == 0)
            {

                return NotFound();
            }
            var obj = _db.Accounttypes.Find(id);
            if (obj == null)
            {

            }
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdatePost(Accounttype obj)
        {
            
            _db.Accounttypes.Update(obj);
            _db.SaveChanges();
            return RedirectToAction("index");

        }
       
    }
}
    


    

    