using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using KoiPondConstruct.Data.Models;
using KoiPondConstruction.Service;

namespace KoiPondConstruction.RazorWebApp.Pages.DemoKoiPondConstruct
{
    public class IndexModel : PageModel

        //TODO: can use singleton OR DI also
    {
        private readonly KoiPondConstruct.Data.Models.FA24_SE1702_PRN221_G2_KoiPondConstructContext _context;
        private readonly ImgReferService _imgReferService;
        //TODO remove dbcontext -> service

        public IndexModel(KoiPondConstruct.Data.Models.FA24_SE1702_PRN221_G2_KoiPondConstructContext context)
        {
            //inject dependencies here
            _imgReferService ??= new ImgReferService();
            _context = context;
        }

        public IList<TblImgRefer> TblImgRefer { get;set; } = default!;

        public async Task OnGetAsync()
        {
            foreach(var item in _imgReferService.GetAll().Result)
            {
                Console.WriteLine(item.Id + " " + item.ImgUrl);
            }
            TblImgRefer = await _context.TblImgRefers.ToListAsync();
        }
    }
}
