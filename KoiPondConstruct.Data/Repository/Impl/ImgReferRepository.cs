using KoiPondConstruct.Data.Base;
using KoiPondConstruct.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoiPondConstruct.Data.Repository.Impl
{
    public class ImgReferRepository : BaseRepository<TblImgRefer>
    {
        public ImgReferRepository()
        {
        }

        public ImgReferRepository(FA24_SE1702_PRN221_G2_KoiPondConstructContext context) : base(context)
        {
        }

    }
}
