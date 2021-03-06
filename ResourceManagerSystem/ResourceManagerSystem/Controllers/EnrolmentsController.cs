﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NToastNotify;
using ResourceManagerSystem.Data;
using ResourceManagerSystem.Models;

namespace ResourceManagerSystem.Controllers
{
    public class EnrolmentsController : Controller
    {
        private readonly ApplicationDbContext _context;
        protected readonly IToastNotification _toastNotification;
        public EnrolmentsController(ApplicationDbContext context, IToastNotification toastNotification)
        {
            _context = context;
            _toastNotification = toastNotification;
        }

        // GET: Enrolments
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Enrolment.Include(e => e.Courses).Include(e => e.Employee);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Enrolments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enrolment = await _context.Enrolment
                .Include(e => e.Courses)
                .Include(e => e.Employee)
                .SingleOrDefaultAsync(m => m.CourseID == id);
            if (enrolment == null)
            {
                return NotFound();
            }

            return View(enrolment);
        }

        // GET: Enrolments/Create
        public IActionResult Create()
        {
            ViewData["CourseID"] = new SelectList(_context.Course, "CourseID", "Name");
            ViewData["CI"] = new SelectList(_context.Employee, "CI", "CI");
            return View();
        }

        // POST: Enrolments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CourseID,CI,Date")] Enrolment enrolment)
        {
            if (ModelState.IsValid)
            {
                _context.Add(enrolment);
                await _context.SaveChangesAsync();
                _toastNotification.AddSuccessToastMessage("Se inscribio al empleado a curso exitosamente");
                return RedirectToAction(nameof(Index));
            }
            ViewData["CourseID"] = new SelectList(_context.Course, "CourseID", "Name", enrolment.CourseID);
            ViewData["CI"] = new SelectList(_context.Employee, "CI", "CI", enrolment.CI);
            return View(enrolment);
        }

        // GET: Enrolments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enrolment = await _context.Enrolment.SingleOrDefaultAsync(m => m.CourseID == id);
            if (enrolment == null)
            {
                return NotFound();
            }
            ViewData["CourseID"] = new SelectList(_context.Course, "CourseID", "Name", enrolment.CourseID);
            ViewData["CI"] = new SelectList(_context.Employee, "CI", "CI", enrolment.CI);
            return View(enrolment);
        }

        // POST: Enrolments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CourseID,CI,Date")] Enrolment enrolment)
        {
            if (id != enrolment.CourseID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(enrolment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EnrolmentExists(enrolment.CourseID))
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
            ViewData["CourseID"] = new SelectList(_context.Course, "CourseID", "Name", enrolment.CourseID);
            ViewData["CI"] = new SelectList(_context.Employee, "CI", "CI", enrolment.CI);
            return View(enrolment);
        }

        // GET: Enrolments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enrolment = await _context.Enrolment
                .Include(e => e.Courses)
                .Include(e => e.Employee)
                .SingleOrDefaultAsync(m => m.CourseID == id);
            if (enrolment == null)
            {
                return NotFound();
            }

            return View(enrolment);
        }

        // POST: Enrolments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var enrolment = await _context.Enrolment.SingleOrDefaultAsync(m => m.CourseID == id);
            _context.Enrolment.Remove(enrolment);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EnrolmentExists(int id)
        {
            return _context.Enrolment.Any(e => e.CourseID == id);
        }
    }
}
