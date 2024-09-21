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
    public class IndexModel : PageModel
    {
        private readonly KoiPondConstruct.Data.Models.FA24_SE1702_PRN221_G2_KoiPondConstructContext _context;
        //TODO remove dbcontext -> service

        public IndexModel(KoiPondConstruct.Data.Models.FA24_SE1702_PRN221_G2_KoiPondConstructContext context)
        {
            //inject dependencies here
            _context = context;
        }

        public IList<TblImgRefer> TblImgRefer { get;set; } = default!;

        public async Task OnGetAsync()
        {
            TblImgRefer = await _context.TblImgRefers.ToListAsync();
        }
    }
}
