using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KoiPondConstruct.Data.Models;

namespace KoiPondConstruction.RazorWebApp.Pages.DemoKoiPondConstruct
{
    public class EditModel : PageModel
    {
        private readonly KoiPondConstruct.Data.Models.FA24_SE1702_PRN221_G2_KoiPondConstructContext _context;

        public EditModel(KoiPondConstruct.Data.Models.FA24_SE1702_PRN221_G2_KoiPondConstructContext context)
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

            var tblimgrefer =  await _context.TblImgRefers.FirstOrDefaultAsync(m => m.Id == id);
            if (tblimgrefer == null)
            {
                return NotFound();
            }
            TblImgRefer = tblimgrefer;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(TblImgRefer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblImgReferExists(TblImgRefer.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool TblImgReferExists(long id)
        {
            return _context.TblImgRefers.Any(e => e.Id == id);
        }
    }
}
