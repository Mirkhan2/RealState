﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RealEstate.Data;
using RealEstate.Model;

namespace RealEstate.Pages.Panel.Admin.Categories
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public CreateModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public CategoryModel CategoryModel { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            await _context.Category.AddAsync(CategoryModel);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
