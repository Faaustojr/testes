using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using cointeste.Data;
using cointeste.Models;

namespace cointeste.Pages.Coins
{
    public class DetailsModel : PageModel
    {
        private readonly cointeste.Data.cointesteContext _context;

        public DetailsModel(cointeste.Data.cointesteContext context)
        {
            _context = context;
        }

      public Coin Coin { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Coin == null)
            {
                return NotFound();
            }

            var coin = await _context.Coin.FirstOrDefaultAsync(m => m.Id == id);
            if (coin == null)
            {
                return NotFound();
            }
            else 
            {
                Coin = coin;
            }
            return Page();
        }
    }
}
