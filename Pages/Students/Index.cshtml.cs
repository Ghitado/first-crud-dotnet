using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using crud_balta.Data;
using crud_balta.Models;

namespace crud_balta.Pages_Students
{
    public class IndexModel : PageModel
    {
        private readonly crud_balta.Data.ApplicationDbContext _context;

        public IndexModel(crud_balta.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Student = await _context.Students.ToListAsync();
        }
    }
}
