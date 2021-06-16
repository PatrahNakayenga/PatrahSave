using Microsoft.AspNetCore.Mvc;
using System;
using PatrahSave.Models;
using System.Collections.Generic;
using System.Linq;
using PatrahSave.Data;
using System.Threading.Tasks;

namespace PatrahSave.Controllers
{
    public class MembersController : Controller
    {
        private readonly AppDbcontext _db;

        public MembersController(AppDbcontext db)
        {
            _db = db;
        }


        public IActionResult Index()
        {
            IEnumerable<Members> objList = _db.Member;
            return View(objList);
        }

        public IActionResult Create()
        {

            return View();

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Member obj)
        {
            
            
                _db.Members.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("index");
            

        }
        public IActionResult Delete(int? id)
        {

            if (id == null || id == 0) { return NotFound(); }

            var obj = _db.Members.Find(id);
            if (obj == null)
            {

            }
            _db.Members.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("index");

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {

            if (id == null || id == 0) { return NotFound(); }

            var obj = _db.Transactions.Find(id);
            if (obj == null)
            {

            }
            _db.Transactions.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("index");

        }
        public IActionResult Update(int? id)
        {

            if (id == null || id == 0)
            {

                return NotFound();
            }
            var obj = _db.Members.Find(id);
            if (obj == null)
            {

            }
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdatePost(Member obj)
        {
           
            {
                _db.Members.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("index");
            }

        }
    }

}