using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RealState.Data;
using RealState.Model;

namespace RealState.Pages.Admin.Estates
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }
        //Data Transfer Object = DTO
        public List<EstateModel> IndexDto { get; set; }
        public async Task<IActionResult> OnGet()
        {
            IndexDto = await _db.Estate.ToListAsync();
            return Page();
        }
    }
}
