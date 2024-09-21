using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using KoiPondConstruct.Data.Models;

namespace KoiPondConstruction.RazorWebApp.Pages.DemoKoiPondConstruct
{
    public class DeleteModel : PageModel
    {
        private readonly KoiPondConstruct.Data.Models.FA24_SE1702_PRN221_G2_KoiPondConstructContext _context;

        public DeleteModel(KoiPondConstruct.Data.Models.FA24_SE1702_PRN221_G2_KoiPondConstructContext context)
        {
            _context = context;
        }

        [BindProperty]
        public TblImgRefer TblImgRefer { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblimgrefer = await _context.TblImgRefers.FirstOrDefaultAsync(m => m.Id == id);

            if (tblimgrefer == null)
            {
                return NotFound();
            }
            else
            {
                TblImgRefer = tblimgrefer;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblimgrefer = await _context.TblImgRefers.FindAsync(id);
            if (tblimgrefer != null)
            {
                TblImgRefer = tblimgrefer;
                _context.TblImgRefers.Remove(TblImgRefer);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
