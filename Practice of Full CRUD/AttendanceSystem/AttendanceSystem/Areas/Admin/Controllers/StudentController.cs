using AttendanceSystem.Areas.Admin.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AttendanceSystem.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class StudentController : Controller
    {
        // GET: StudentController
        public IActionResult ShowAllStudents()
        {
           var model = new StudentListModel();
            model.LoadModelData();
            return View(model);
        }

        // GET: StudentController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StudentController/Create
        public IActionResult Create()
        {
            var model = new CreateStudentModel();
            return View(model);
        }

        // POST: StudentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateStudentModel model)
        {
            if(ModelState.IsValid)
            {
                try
                {
                    model.CreateStudent();
                }
                catch
                {
                    ModelState.AddModelError("", "Soory..Create Student Failed");
                }
            }
            return View();
        }

        // GET: StudentController/Edit/5
        public IActionResult Edit(int id)
        {
            var model = new EditStudentModel();
            model.LoadModelData(id);
            return View(model);
        }

        // POST: StudentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(EditStudentModel model)
        {
            if(ModelState.IsValid)
            {
                model.Update();
            }
            return View(model);
        }

        // GET: StudentController/Delete/5
        public ActionResult Delete(int id)
        {
            var model = new DeleteStudentModel();
            model.DeleteStudent(id);
            return RedirectToAction(nameof(ShowAllStudents));
        }

        // POST: StudentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
