﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RealEstate.Model;
using RealEstate.Data;

namespace RealEstate.Pages.Panel.Admin.Categories
{
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public EditModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public CategoryModel CategoryModel { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CategoryModel = await _context.Category.FirstOrDefaultAsync(m => m.Id == id);

            if (CategoryModel == null)
            {
                return NotFound();
            }
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Update(CategoryModel);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }

    }
}
