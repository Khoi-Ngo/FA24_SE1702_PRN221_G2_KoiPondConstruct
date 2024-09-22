using KoiPondConstruct.Data;
using KoiPondConstruct.Data.Models;
using KoiPondConstruction.Service.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoiPondConstruction.Service
{
    public interface IImgReferService
    {
        //Can return ServiceResult
        Task<List<TblImgRefer>> GetAll();
        Task<TblImgRefer> GetById(int id);
        void createNewImgRefer(TblImgRefer imgRefer);
        Task delete(int id);
    }
    public class ImgReferService : IImgReferService
    {
        private readonly UnitOfWork _unitOfWork;

        //Dependency Injection UnitOfWork

        public ImgReferService() {
            _unitOfWork = new UnitOfWork();
        }



        public async void createNewImgRefer(TblImgRefer imgRefer)
        {
            //call UnitOfWork.Repo -> call Dbcontext -> DB
            //throw new NotImplementedException();

            //TODO: Validation new record

            await Task.Run(() =>
            {
                _unitOfWork.ImgReferRepository.Create(imgRefer);
            });
        }

        public Task delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<TblImgRefer>> GetAll()
        {
            //return (Task<TblImgRefer>)
            List<TblImgRefer> res = _unitOfWork.ImgReferRepository.GetAll();
            return Task.FromResult<List<TblImgRefer>>(res);
        }

        public Task<TblImgRefer> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}



//public interface IAnimalService
//{
//    Task<ServiceResult> GetAll();
//    Task<ServiceResult> GetById(int AnimalId);
//    Task<ServiceResult> Save(Animal animal);
//    Task<ServiceResult> DeleteById(int AnimalId);
//}
//public class AnimalService : IAnimalService
//{
//    private readonly UnitOfWork _unitOfWork;

//    public AnimalService() => _unitOfWork ??= new UnitOfWork();

//    //public AnimalService() 
//    //{        
//    //    _unitOfWork ??= new UnitOfWork();
//    //    if (_unitOfWork == null)
//    //    {
//    //
//    //    }
//    //}

//    public async Task<ServiceResult> GetAll()
//    {
//        #region Business Rule

//        #endregion Business Rule

//        var animals = await _unitOfWork.AnimalRepository.GetAllAsync();

//        if (animals == null)
//        {
//            return new ServiceResult(Const.WARNING_NO_DATA_CODE, Const.WARNING_NO_DATA_MSG);
//        }
//        else
//        {
//            return new ServiceResult(Const.SUCCESS_READ_CODE, Const.SUCCESS_READ_MSG, animals);
//        }
//    }

//    public async Task<ServiceResult> GetById(int AnimalId)
//    {
//        #region Business Rule

//        #endregion Business Rule

//        var animal = await _unitOfWork.AnimalRepository.GetByIdAsync(AnimalId);
//        if (animal == null)
//        {
//            return new ServiceResult(Const.WARNING_NO_DATA_CODE, Const.WARNING_NO_DATA_MSG);
//        }
//        else
//        {
//            return new ServiceResult(Const.SUCCESS_READ_CODE, Const.SUCCESS_READ_MSG, animal);
//        }
//    }

//    public async Task<ServiceResult> Save(Animal animal)
//    {
//        try
//        {
//            #region Business Rule

//            #endregion Business Rule

//            int result = -1;

//            var animalTmp = this.GetById(animal.AnimalId);

//            if (animalTmp.Result.Status == Const.SUCCESS_READ_CODE)
//            {
//                result = await _unitOfWork.AnimalRepository.UpdateAsync(animal);

//                if (result > 0)
//                {
//                    return new ServiceResult(Const.SUCCESS_UPDATE_CODE, Const.SUCCESS_UPDATE_MSG, animal);
//                }
//                else
//                {
//                    return new ServiceResult(Const.FAIL_UPDATE_CODE, Const.FAIL_UPDATE_MSG);
//                }
//            }
//            else
//            {
//                result = await _unitOfWork.AnimalRepository.CreateAsync(animal);

//                if (result > 0)
//                {
//                    return new ServiceResult(Const.SUCCESS_CREATE_CODE, Const.SUCCESS_CREATE_MSG, animal);
//                }
//                else
//                {
//                    return new ServiceResult(Const.FAIL_CREATE_CODE, Const.FAIL_CREATE_MSG);
//                }
//            }
//        }
//        catch (Exception ex)
//        {
//            return new ServiceResult(Const.ERROR_EXCEPTION, ex.ToString());
//        }
//    }

//    public async Task<ServiceResult> DeleteById(int AnimalId)
//    {
//        try
//        {
//            var result = false;
//            var animalResult = this.GetById(AnimalId);

//            if (animalResult != null && animalResult.Result.Status == Const.SUCCESS_READ_CODE)
//            {
//                result = await _unitOfWork.AnimalRepository.RemoveAsync((Animal)animalResult.Result.Data);

//                if (result)
//                {
//                    return new ServiceResult(Const.SUCCESS_DELETE_CODE, Const.SUCCESS_DELETE_MSG, result);
//                }
//                else
//                {
//                    return new ServiceResult(Const.FAIL_DELETE_CODE, Const.FAIL_DELETE_MSG, animalResult.Result.Data);
//                }
//            }
//            else
//            {
//                return new ServiceResult(Const.WARNING_NO_DATA_CODE, Const.WARNING_NO_DATA_MSG);
//            }
//        }
//        catch (Exception ex)
//        {
//            return new ServiceResult(Const.ERROR_EXCEPTION, ex.ToString());
//        }
//    }
//}
