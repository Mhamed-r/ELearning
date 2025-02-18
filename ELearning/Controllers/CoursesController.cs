using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ELearning.Data;
using ELearning.Repository;

namespace ELearning.Controllers
{
    public class CoursesController : Controller
    {
     
        CourseRepository Reps;

        public CoursesController(CourseRepository Reps)
        {
            this.Reps = Reps;
        }

        // GET: Courses
        public IActionResult Index()
        {
            return View(Reps.Getall());
        }

        // GET: Courses/Details/5
        public IActionResult Details(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            var course = Reps.Getbyid(id);
            if (course == null)
            {
                return NotFound();
            }

            return View(course);
        }

        // GET: Courses/Create
        public IActionResult Create()
        {
           List<User> Instructor= Reps.GetCourseInstructor();
            ViewData["InstructorId"] = new SelectList(Instructor, "Id", "Name", Instructor.Select(I=>I.Name));
            return View();
        }

        // POST: Courses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,Title,Description,Price,Duration,InstructorId")] Course course)
        {
            if (ModelState.IsValid)
            {
                Reps.Add(course);
                Reps.save();
                return RedirectToAction(nameof(Index));
            }
            List<User> Instructor = Reps.GetCourseInstructor();
            ViewData["InstructorId"] = new SelectList(Instructor, "Id", "Name", Instructor.Select(I => I.Name));
            return View(course);
        }

        // GET: Courses/Edit/5
        public IActionResult Edit(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            var course = Reps.Getbyid(id);
            if (course == null)
            {
                return NotFound();
            }
            List<User> Instructor = Reps.GetCourseInstructor();
            ViewData["InstructorId"] = new SelectList(Instructor, "Id", "Name", Instructor.Select(I => I.Name));
            return View(course);
        }

        // POST: Courses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Description,Price,Duration,InstructorId")] Course course)
        {
            if (id != course.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                   course.UpdatedAt= DateTime.Now;
                   Reps.Edit(course);
                    Reps.save();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CourseExists(course.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            List<User> Instructor = Reps.GetCourseInstructor();
            ViewData["InstructorId"] = new SelectList(Instructor, "Id", "Name", Instructor.Select(I => I.Name));
            return View(course);
        }

      //  GET: Courses/Delete/5
        public IActionResult Delete(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            var course = Reps.Getbyid(id);

            if (course == null)
            {
                return NotFound();
            }

            return View(course);
        }

        // POST: Courses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var course = Reps.Getbyid(id);
            if (course != null)
            {
                Reps.delete(id);
            }

            Reps.save();
            return RedirectToAction(nameof(Index));
        }

        private bool CourseExists(int id)
        {
            return Reps.Exists(id);
        }
    }
}
