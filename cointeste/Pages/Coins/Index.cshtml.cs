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
    public class IndexModel : PageModel
    {
        private readonly cointeste.Data.cointesteContext _context;

        public IndexModel(cointeste.Data.cointesteContext context)
        {
            _context = context;
        }

        public IList<Coin> Coin { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Coin != null)
            {
                Coin = await _context.Coin.ToListAsync();
            }
        }
    }
}
