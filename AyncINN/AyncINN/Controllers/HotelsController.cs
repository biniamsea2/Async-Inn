using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AyncINN.Data;
using AyncINN.Models;
using AyncINN.Models.Interfaces;
using Microsoft.Extensions.Configuration;


namespace AyncINN.Controllers
{
    public class HotelsController : Controller
    {
        private readonly IHotelManager _context;

        public HotelsController(IHotelManager hotel)
        {
            _context = hotel;
        }

        /// <summary>
        /// grabs all the hotels that exists from the db
        /// </summary>
        /// <returns></returns>
        // GET: Hotels
        public async Task<IActionResult> Index()
        {
            return View(await _context.GetHotelsAsync());
        }

        /// <summary>
        /// method checks if the hotel exists first, if it doesn't return not found. Otherwise display the hotel's info.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET: Hotels/Details/5
        public async Task<IActionResult> Details(int id)
        {
            if (id <= 0)
            {
                return NotFound();
            }

            Hotel hotel = await _context.GetHotelByIDAsync(id);
           
            if (hotel == null)
            {
                return NotFound();
            }

            return View(hotel);
        }

        // GET: Hotels/Create
        public IActionResult Create()
        {
            return View();
        }

        /// <summary>
        /// method allows you to create a new hotel. And only allows you to input the info displayed in quotes in the Bind.
        /// </summary>
        /// <param name="hotel"></param>
        /// <returns></returns>
        // POST: Hotels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,StreetAddress,City,State,Phone")] Hotel hotel)
        {
            if (ModelState.IsValid)
            {
                await _context.CreateHotelAsync(hotel);
                return RedirectToAction(nameof(Index));
            }
            return View(hotel);
        }

        // GET: Hotels/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            if (id <=0)
            {
                return NotFound();
            }

            var hotel = await _context.GetHotelByIDAsync(id);
            if (hotel == null)
            {
                return NotFound();
            }
            return View(hotel);
        }


        /// <summary>
        /// allows you to edit the hotel that exists. It only allows you to edit the info in quotes. Once done it will
        /// redirect you to the index page of this controller.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="hotel"></param>
        /// <returns></returns>
        // POST: Hotels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,StreetAddress,City,State,Phone")] Hotel hotel)
        {
            if (id != hotel.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _context.UpdateHotelAsync(hotel);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await HotelExists(hotel.ID))
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
            return View(hotel);
        }

        /// <summary>
        /// use the id of the hotel you want to delete, if it exists then dispaly it.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET: Hotels/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            if (id <= 0)
            {
                return NotFound();
            }

            var room = await _context.GetHotelByIDAsync(id);
            return View(room);
        }

        /// <summary>
        /// confirm the hotel you want to delete. This page will appear after clicking 'delete' for the specific hotel you want to delete.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // POST: Hotels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _context.DeleteHotelAsync(id);
            return RedirectToAction(nameof(Index));
        }

        private async Task<bool> HotelExists(int id)
        {
            Hotel hotel = await _context.GetHotelByIDAsync(id);
            if (hotel != null)
            {
                return true;
            }
            return false;
        }
    }
}
