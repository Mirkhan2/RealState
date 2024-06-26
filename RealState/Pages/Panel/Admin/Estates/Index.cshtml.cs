using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RealEstate.Data;
using RealEstate.Model;

namespace RealEstate.Pages.Panel.Admin.Estates
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public List<EstateModel> IndexDto { get; set; }
        public async Task<IActionResult> OnGet()
        {
            IndexDto = await _db.Estate
                .Include(c=>c.Category)
                .ToListAsync();
            return Page();
        }
    }
}
