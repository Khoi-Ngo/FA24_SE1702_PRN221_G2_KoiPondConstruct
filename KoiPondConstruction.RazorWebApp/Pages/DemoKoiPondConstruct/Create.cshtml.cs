using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using KoiPondConstruct.Data.Models;

namespace KoiPondConstruction.RazorWebApp.Pages.DemoKoiPondConstruct
{
    public class CreateModel : PageModel
    {
        private readonly KoiPondConstruct.Data.Models.FA24_SE1702_PRN221_G2_KoiPondConstructContext _context;

        public CreateModel(KoiPondConstruct.Data.Models.FA24_SE1702_PRN221_G2_KoiPondConstructContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public TblImgRefer TblImgRefer { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.TblImgRefers.Add(TblImgRefer);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
