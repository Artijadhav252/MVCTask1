using Microsoft.AspNetCore.Mvc;
using MVCTask1.Models;

namespace MVCTask1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            Mvctask1Context db = new Mvctask1Context();
            var Student = db.Students.ToList();
            return View(Student);
        }
        [HttpGet]
        public IActionResult Create()
        {

            Student student = new Student();
            return View(student);
        }
        [HttpPost]
        public IActionResult Create(Student student)
        {
            if (ModelState.IsValid == true)
            {
                Mvctask1Context db = new Mvctask1Context();
                db.Students.Add(student);
                db.SaveChanges();

            }
            return View(student);
        }
        [HttpGet]
        public IActionResult Update(int Id)
        {
            Mvctask1Context db = new Mvctask1Context();
            var student = db.Students.Find(Id);


            return View(student);
        }

        [HttpPost]
        public IActionResult Update(Student student)
        {

            Mvctask1Context db = new Mvctask1Context();
            db.Students.Update(student);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int Id)
        {

            Mvctask1Context db = new Mvctask1Context();
            var student = db.Students.Find(Id);

            if (student != null)
            {
                db.Students.Remove(student);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

    }
}
