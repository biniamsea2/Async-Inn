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

namespace AyncINN.Controllers
{
    public class RoomsController : Controller
    {
        private readonly IRoomManager _context;

        public RoomsController(IRoomManager room)
        {
            _context = room;
        }


        /// <summary>
        /// display all rooms that exits from our db.
        /// </summary>
        /// <returns></returns>
        // GET: Rooms
        public async Task<IActionResult> Index()
        {
            return View(await _context.GetRoomsAsync());
        }

        /// <summary>
        /// use the id of the room the user wants more details on, then display it.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET: Rooms/Details/5
        public async Task<IActionResult> Details(int id)
        {
            if (id <=0)
            {
                return NotFound();
            }

            Room room = await _context.GetRoomByIDAsync(id);

            if (room == null)
            {
                return NotFound();
            }

            return View(room);
        }

        // GET: Rooms/Create
        public IActionResult Create()
        {
            return View();
        }

        /// <summary>
        /// once you click create new on the room's index page, it will allow you to create a new room with the info
        /// needed which, is displayed below in the 'Bind'. It will then return to that index page to allow you to see the 
        /// new room that was added.
        /// </summary>
        /// <param name="room"></param>
        /// <returns></returns>
        // POST: Rooms/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Layout")] Room room)
        {
            if (ModelState.IsValid)
            {
                await _context.CreateRoomAsync(room);
                return RedirectToAction(nameof(Index));
            }
            return View(room);
        }

        // GET: Rooms/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            if (id <=0)
            {
                return NotFound();
            }

            var room = await _context.GetRoomByIDAsync(id);
            if (room == null)
            {
                return NotFound();
            }
            return View(room);
        }


        /// <summary>
        /// use the room id, if it exists, to allow the user to edit the room. Once completed method will redirect you to
        /// the index page.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="room"></param>
        /// <returns></returns>
        // POST: Rooms/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Layout")] Room room)
        {
            if (id != room.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _context.UpdateRoomAsync(room);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await RoomExists(room.ID))
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
            return View(room);
        }

        /// <summary>
        /// use id, if id exists to delete the room.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET: Rooms/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            if (id <=0)
            {
                return NotFound();
            }

            var room = await _context.GetRoomByIDAsync(id);
            return View(room);
        }

        /// <summary>
        /// before deleting, confirm this is the room you would like to delete. Once confirmed it will rediect you to th index page.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // POST: Rooms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _context.DeleteRoomAsync(id);
            return RedirectToAction(nameof(Index));
        }

        private async Task<bool> RoomExists(int id)
        {
            Room room = await _context.GetRoomByIDAsync(id);
            if (room != null)
            {
                return true;
            }
            return false;
        }
    }
}
