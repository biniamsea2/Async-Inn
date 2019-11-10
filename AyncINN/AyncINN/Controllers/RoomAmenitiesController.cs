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
using AyncINN.Models.ViewModels;

namespace AyncINN.Controllers
{
    public class RoomAmenitiesController : Controller
    {
        private readonly IRoomManager _rooms;
        private readonly IAmenitiesManager _amenities;

        public RoomAmenitiesController(IRoomManager rooms, IAmenitiesManager amenities)
        {
            _rooms = rooms;
            _amenities = amenities;
        }



        // GET: RoomAmenities/Details/5
        public async Task<IActionResult> RoomDetails(int id)
        {
            var roomAmenities = _rooms.GetRoomAmenitiesByRoomID(id);

            if (roomAmenities == null)
            {
                return NotFound();
            }

            RoomAmenitiesViewModel ravm = new RoomAmenitiesViewModel();

            ravm.Room = await _rooms.GetRoomByIDAsync(id);
            ravm.RoomAmenities = roomAmenities;
            return View(ravm);
        }



        // GET: RoomAmenities/Create
        
        public async Task<IActionResult> Create()
        {
            ViewData["AmenitiesID"] = new SelectList(await _amenities.GetAmenitiesAsync(), "ID", "ID");
            ViewData["RoomID"] = new SelectList(await _rooms.GetRoomsAsync(), "ID", "ID");
            return View();
        }

        // POST: RoomAmenities/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AmenitiesID,RoomID")] RoomAmenities roomAmenities)
        {
            if (ModelState.IsValid)
            {
                Room test = await _rooms.GetRoomByIDAsync(roomAmenities.RoomID);
                return RedirectToAction(nameof(Index));
            }
            ViewData["AmenitiesID"] = new SelectList(await _amenities.GetAmenitiesAsync(), "ID", "ID", roomAmenities.AmenitiesID);
            ViewData["RoomID"] = new SelectList(await _rooms.GetRoomsAsync(), "ID", "ID", roomAmenities.RoomID);
            return View(roomAmenities);
        }

        //end

        // GET: RoomAmenities/Edit/5
        //start
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var roomAmenities = await _context.RoomAmenities.FindAsync(id);
        //    if (roomAmenities == null)
        //    {
        //        return NotFound();
        //    }
        //    ViewData["AmenitiesID"] = new SelectList(_context.Amenities, "ID", "ID", roomAmenities.AmenitiesID);
        //    ViewData["RoomID"] = new SelectList(_context.Room, "ID", "ID", roomAmenities.RoomID);
        //    return View(roomAmenities);
        //}
        //end

        // POST: RoomAmenities/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //start
        //public async Task<IActionResult> Edit(int id, [Bind("ID,AmenitiesID,RoomID")] RoomAmenities roomAmenities)
        //{
        //    if (id != roomAmenities.AmenitiesID)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(roomAmenities);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!RoomAmenitiesExists(roomAmenities.AmenitiesID))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["AmenitiesID"] = new SelectList(_context.Amenities, "ID", "ID", roomAmenities.AmenitiesID);
        //    ViewData["RoomID"] = new SelectList(_context.Room, "ID", "ID", roomAmenities.RoomID);
        //    return View(roomAmenities);
        //}

        //end


        // GET: RoomAmenities/Delete/5
        //start
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var roomAmenities = await _context.RoomAmenities
        //        .Include(r => r.Amenities)
        //        .Include(r => r.Room)
        //        .FirstOrDefaultAsync(m => m.AmenitiesID == id);
        //    if (roomAmenities == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(roomAmenities);
        //}

        //end

        // POST: RoomAmenities/Delete/5


        //start
        //    [HttpPost, ActionName("Delete")]
        //    [ValidateAntiForgeryToken]
        //    public async Task<IActionResult> DeleteConfirmed(int id)
        //    {
        //        var roomAmenities = await _context.RoomAmenities.FindAsync(id);
        //        _context.RoomAmenities.Remove(roomAmenities);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }

        //    private bool RoomAmenitiesExists(int id)
        //    {
        //        return _context.RoomAmenities.Any(e => e.AmenitiesID == id);
        //    }
        //}
    }
}
//end