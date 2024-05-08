
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RealEstate.Data;
using RealEstate.Model;

namespace RealEstate.Pages.Panel.Admin.Categories
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<CategoryModel> CategoryModel { get;set; }

        public async Task OnGetAsync()
        {
            CategoryModel = await _context.Category.ToListAsync();
        }
    }
}
