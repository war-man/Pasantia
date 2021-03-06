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
    public class ProvidersController : Controller
    {
        private readonly ApplicationDbContext _context;
        protected readonly IToastNotification _toastNotification;
        public ProvidersController(ApplicationDbContext context, IToastNotification toastNotification)
        {
            _context = context;
            _toastNotification = toastNotification;
        }

        // GET: Providers
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Provider.Include(p => p.Contact);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Providers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var provider = await _context.Provider
                .Include(p => p.Contact)
                .SingleOrDefaultAsync(m => m.ProviderID == id);
            if (provider == null)
            {
                return NotFound();
            }

            return View(provider);
        }

        // GET: Providers/Create
        public IActionResult Create()
        {
            ViewData["ContactID"] = new SelectList(_context.Contact, "ContactID", "CompleteName");
            return View();
        }

        // POST: Providers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProviderID,ContactID,Name,Address,City")] Provider provider)
        {
            if (ModelState.IsValid)
            {
                _context.Add(provider);
                await _context.SaveChangesAsync();
                _toastNotification.AddSuccessToastMessage("Proveedor creado exitosamente");
                return RedirectToAction(nameof(Index));
            }
            ViewData["ContactID"] = new SelectList(_context.Contact, "ContactID", "CompleteName", provider.ContactID);
            return View(provider);
        }

        // GET: Providers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var provider = await _context.Provider.SingleOrDefaultAsync(m => m.ProviderID == id);
            if (provider == null)
            {
                return NotFound();
            }
            ViewData["ContactID"] = new SelectList(_context.Contact, "ContactID", "CompleteName", provider.ContactID);
            return View(provider);
        }

        // POST: Providers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProviderID,ContactID,Name,Address,City")] Provider provider)
        {
            if (id != provider.ProviderID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(provider);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProviderExists(provider.ProviderID))
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
            ViewData["ContactID"] = new SelectList(_context.Contact, "ContactID", "CompleteName", provider.ContactID);
            return View(provider);
        }

        // GET: Providers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var provider = await _context.Provider
                .Include(p => p.Contact)
                .SingleOrDefaultAsync(m => m.ProviderID == id);
            if (provider == null)
            {
                return NotFound();
            }

            return View(provider);
        }

        // POST: Providers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var provider = await _context.Provider.SingleOrDefaultAsync(m => m.ProviderID == id);
            _context.Provider.Remove(provider);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProviderExists(int id)
        {
            return _context.Provider.Any(e => e.ProviderID == id);
        }
    }
}
