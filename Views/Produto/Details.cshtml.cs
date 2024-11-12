using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SWII6.TP03.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SWII6.TP03.Data;

namespace SWII6.TP03.Views.Produto
{
    public class DetailsModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public DetailsModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public Produtos Produto { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

           Produto = await _context.Produtos.FirstOrDefaultAsync(m => m.Id == id);

            if (Produto == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}
