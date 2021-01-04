using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication5.Data;
using WebApplication5.Models;

namespace WebApplication5.Pages.Emps
{
    public class IndexModel : PageModel
    {
        private readonly WebApplication5.Data.EmpContext _context;

        public IndexModel(WebApplication5.Data.EmpContext context)
        {
            _context = context;
        }

        public IList<Emp> Emp { get;set; }

        public async Task OnGetAsync()
        {
            Emp = await _context.Emp.ToListAsync();
        }
    }
}
