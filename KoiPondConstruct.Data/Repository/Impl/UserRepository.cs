using KoiPondConstruct.Data.Base;
using KoiPondConstruct.Data.Models;

namespace KoiPondConstruct.Data.Repository.Impl
{
    public class UserRepository : BaseRepository<TblUser>
    {
        public UserRepository() { }

        public UserRepository(FA24_SE1702_PRN221_G2_KoiPondConstructContext context) : base(context)
        {
            _context = context;
        }
    }
}
