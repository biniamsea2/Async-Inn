﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AyncINN.Data;
using AyncINN.Models;
using AyncINN.Models.Interfaces;

namespace AyncINN.Controllers
{
    public class AmenitiesController : Controller
    {
        private readonly IAmenitiesManager _context;

        public AmenitiesController(IAmenitiesManager amenities)
        {
            _context = amenities;
        }

        // GET: Amenities
        public async Task<IActionResult> Index()
        {
            return View(await _context.GetAmenitiesAsync());
        }

        // GET: Amenities/Details/5
        public async Task<IActionResult> Details(int id)
        {
            if (id <= 0)
            {
                return NotFound();
            }

            Amenities amenities = await _context.GetAmenityByIDAsync(id);

            if (amenities == null)
            {
                return NotFound();
            }

            return View(amenities);
        }

        // GET: Amenities/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Amenities/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name")] Amenities amenities)
        {
            if (ModelState.IsValid)
            {
                await _context.CreateAmenityAsync(amenities);
                return RedirectToAction(nameof(Index));
            }
            return View(amenities);
        }

        // GET: Amenities/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            if (id <= 0)
            {
                return NotFound();
            }

            var amenities = await _context.GetAmenityByIDAsync(id);
            if (amenities == null)
            {
                return NotFound();
            }
            return View(amenities);
        }

        // POST: Amenities/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name")] Amenities amenities)
        {
            if (id != amenities.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _context.UpdateAmenititesAsync(amenities);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await AmenitiesExists(amenities.ID))
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
            return View(amenities);
        }

        // GET: Amenities/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            if (id <= 0)
            {
                return NotFound();
            }

            await _context.DeleteAmenitiesAsync(id);
            return RedirectToAction("Index");
        }

        // POST: Amenities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _context.DeleteAmenitiesAsync(id);
            return RedirectToAction(nameof(Index));
        }

        private async Task<bool> AmenitiesExists(int id)
        {
            Amenities amenities = await _context.GetAmenityByIDAsync(id);
            if (amenities != null)
            {
                return true;
            }
            return false;
        }
    }
}
