using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplication5.Data;
using WebApplication5.Models;

namespace WebApplication5.Pages.Emps
{
    public class CreateModel : PageModel
    {
        private readonly WebApplication5.Data.EmpContext _context;

        public CreateModel(WebApplication5.Data.EmpContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Emp Emp { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Emp.Add(Emp);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
