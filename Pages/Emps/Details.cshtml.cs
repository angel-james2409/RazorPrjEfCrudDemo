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
    public class DetailsModel : PageModel
    {
        private readonly WebApplication5.Data.EmpContext _context;

        public DetailsModel(WebApplication5.Data.EmpContext context)
        {
            _context = context;
        }

        public Emp Emp { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Emp = await _context.Emp.FirstOrDefaultAsync(m => m.Id == id);

            if (Emp == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
