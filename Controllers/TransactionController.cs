using Microsoft.AspNetCore.Mvc;
using PatrahSave.Data;
using System;
using PatrahSave.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatrahSave.Controllers
{
    public class TransactionController : Controller
    {
        private readonly AppDbcontext _db;

        public TransactionController(AppDbcontext db)
        {
            _db = db;
        }
    

        
        public IActionResult Index()
        {
          IEnumerable<Transaction> objList = _db.Transactions;
        return View(objList);
        }

        public IActionResult Create()
        {

            return View();

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Transaction obj)
        {
            if(ModelState.IsValid)
            {


                _db.Transactions.Add(obj);
                _db.SaveChanges();
            }
                return RedirectToAction("index");
            
        }
        public IActionResult Delete(int?id)
        {
            var obj = _db.Transactions.Find(id);
            if (id == null||id==0) { return NotFound(); }
            _db.Transactions.Remove(obj);
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
            var obj = _db.Transactions.Find(id);
            if (obj == null)
            {

            }
            return View();
        }
        public IActionResult UpdatePost(Transaction obj)
        {
            if (ModelState.IsValid)
            {


                _db.Transactions.Add(obj);
                _db.SaveChanges();
            }
            return RedirectToAction("index");

        }
    }
}
        
    

