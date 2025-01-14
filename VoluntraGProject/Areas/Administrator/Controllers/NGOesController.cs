using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VoluntraGProject.Data;
using VoluntraGProject.Models;

namespace VoluntraGProject.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    public class NGOesController : Controller
    {
        private readonly AppDbContext _context;

        public NGOesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Administrator/NGOes
        public async Task<IActionResult> Index()
        {
            return View(await _context.NGOs.ToListAsync());
        }

        // GET: Administrator/NGOes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nGO = await _context.NGOs
                .FirstOrDefaultAsync(m => m.NGOId == id);
            if (nGO == null)
            {
                return NotFound();
            }

            return View(nGO);
        }

        // GET: Administrator/NGOes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Administrator/NGOes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(NGO nGO)
        {
            if (ModelState.IsValid)
            {
                if (nGO.ImageFile != null && nGO.ImageFile.Length > 0)
                {
                    // Define the path to save the image
                    var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images");
                    var fileName = Path.GetFileName(nGO.ImageFile.FileName);
                    var filePath = Path.Combine(uploadsFolder, fileName);

                    // Ensure the uploads folder exists
                    if (!Directory.Exists(uploadsFolder))
                    {
                        Directory.CreateDirectory(uploadsFolder);
                    }

                    // Save the file to the server
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        await nGO.ImageFile.CopyToAsync(fileStream);
                    }

                    // Set the image path in the model (you may want to adjust this based on your requirements)
                    nGO.Image = $"/images/{fileName}";

                    _context.Add(nGO);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                _context.Add(nGO);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nGO);
        }

        // GET: Administrator/NGOes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nGO = await _context.NGOs.FindAsync(id);
            if (nGO == null)
            {
                return NotFound();
            }
            return View(nGO);
        }

        // POST: Administrator/NGOes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("NGOId,NGOName,Description,DetailedDescription,PhoneNumber,Address,Type,Image")] NGO nGO)
        {
            if (id != nGO.NGOId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nGO);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NGOExists(nGO.NGOId))
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
            return View(nGO);
        }

        // GET: Administrator/NGOes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nGO = await _context.NGOs
                .FirstOrDefaultAsync(m => m.NGOId == id);
            if (nGO == null)
            {
                return NotFound();
            }

            return View(nGO);
        }

        // POST: Administrator/NGOes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var nGO = await _context.NGOs.FindAsync(id);
            if (nGO != null)
            {
                _context.NGOs.Remove(nGO);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NGOExists(int id)
        {
            return _context.NGOs.Any(e => e.NGOId == id);
        }
    }
}
