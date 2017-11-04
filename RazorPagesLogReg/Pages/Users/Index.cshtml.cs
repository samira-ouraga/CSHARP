using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesLogReg.Models;

namespace RazorPagesLogReg.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesLogReg.Models.UserContext _context;

        public IndexModel(RazorPagesLogReg.Models.UserContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; }

        public async Task OnGetAsync()
        {
            User = await _context.User.ToListAsync();
        }
    }
}
