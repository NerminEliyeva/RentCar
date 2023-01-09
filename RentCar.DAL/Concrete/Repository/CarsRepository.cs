using RentCar.DAL.Abstract.IRepository;
using RentCar.DAL.Concrete.EntityFramework;
using RentCar.Models.Entities;
using System.Collections.Generic;
using System.Linq;

namespace RentCar.DAL.Concrete.Repository
{
    public class CarsRepository : ICarsRepository
    {
        private readonly RentCarDbContext _dbcontext;
        public CarsRepository(RentCarDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public List<Cars> GetCars()
        {
            return (_dbcontext.Cars.ToList());
        }
        public List<Marks> GetMarks()
        {
            return (_dbcontext.Marks.ToList());
        }
        public List<Models.Entities.Models> GetModels()
        {
            return (_dbcontext.Models.ToList());
        }
        public List<Models.Entities.Models> GetModelsById(int MarkId)
        {
            return (_dbcontext.Models.Where(x => x.ModelMarkId == MarkId).ToList());
        }
        public string GetMainImageByCarId(int id)
        {
            return (_dbcontext.Images.Where(x => x.ImageCarId == id && x.MainImage == 1).FirstOrDefault().FullPath);
        }
        public List<string> GetMultImageByCarId(int id)
        {
            return (_dbcontext.Images.Where(x => x.ImageCarId == id && x.MainImage == 0).Select(x => x.FullPath).ToList());
        }
        public List<EngineTypes> GetEngineTypes()
        {
            return (_dbcontext.EngineTypes.ToList());
        }
        public List<Categories> GetCategories()
        {
            return (_dbcontext.Categories.ToList());
        }
        public Cars GetCarById(int id)
        {
            return _dbcontext.Cars.Where(x => x.CarId == id).FirstOrDefault();
        }
        public bool SaveCar(Cars cars)
        {
            try
            {
                _dbcontext.Cars.Add(cars);
                _dbcontext.SaveChanges();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        public bool SaveImage(List<Images> images)
        {
            try
            {
                _dbcontext.Images.AddRange(images);
                _dbcontext.SaveChanges();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        public bool SaveNewMark(Marks mark)
        {
            try
            {
                _dbcontext.Marks.Add(mark);
                _dbcontext.SaveChanges();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        public bool SaveNewEngineType(EngineTypes engineType)
        {
            try
            {
                _dbcontext.EngineTypes.Add(engineType);
                _dbcontext.SaveChanges();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        public bool SaveNewCategory(Categories category)
        {
            try
            {
                _dbcontext.Categories.Add(category);
                _dbcontext.SaveChanges();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
        public bool SaveNewModel(Models.Entities.Models model)
        {
            try
            {
                _dbcontext.Models.Add(model);
                _dbcontext.SaveChanges();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
    }
}
