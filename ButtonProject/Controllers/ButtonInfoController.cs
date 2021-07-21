using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ButtonProject.Models;

namespace ButtonProject.Controllers
{
    public class ButtonInfoController : Controller
    {
        private readonly CustomerInfoContext _context;

        public ButtonInfoController(CustomerInfoContext context)
        {
            _context = context;
        }

        // GET: ButtonInfo
        public async Task<IActionResult> Index()
        {
            return View(await _context.Customers.ToListAsync());
        }

        // GET: ButtonInfo/Create
        public IActionResult AddorEdit(int id=0)
        {
            if(id==0)
            return View(new ButtonInfo());
            else
                return View(_context.Customers.Find(id));
        }

        // POST: ButtonInfo/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult>AddorEdit([Bind("CustomerId,FirstName,LastName,Address,State,Country")] ButtonInfo buttonInfo)
        {
            if (ModelState.IsValid)
            {
                if(buttonInfo.CustomerId==0)
                _context.Add(buttonInfo);
                else
                    _context.Update(buttonInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(buttonInfo);
        }


        // GET: ButtonInfo/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            var buttonInfo = await _context.Customers.FindAsync(id);
            _context.Customers.Remove(buttonInfo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        
    }
}
