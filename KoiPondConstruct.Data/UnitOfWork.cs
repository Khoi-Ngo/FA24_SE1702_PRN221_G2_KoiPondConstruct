using KoiPondConstruct.Data.Models;
using KoiPondConstruct.Data.Repository.Impl;


namespace KoiPondConstruct.Data
{
    public class UnitOfWork
    {
        private FA24_SE1702_PRN221_G2_KoiPondConstructContext _context;
        private UserRepository _userRepository;
        private ImgReferRepository _imgReferRepository;

        public UnitOfWork()
        {
            _context ??= new FA24_SE1702_PRN221_G2_KoiPondConstructContext();// ??= meaning created new instance only if null

        }

        public UserRepository UserRepository
        {
            get
            {
                return _userRepository ??= new UserRepository(_context);

            }
        }
        public ImgReferRepository ImgReferRepository
        {
            get
            {
                return _imgReferRepository ??= new ImgReferRepository(_context);
            }
        }
    }
}
