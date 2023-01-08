using RentCar.Models.Entities;
using System.Collections.Generic;

namespace RentCar.DAL.Abstract.IRepository
{
    public interface ICarsRepository
    {
        List<Cars> GetCars();
        List<Marks> GetMarks();
        List<Models.Entities.Models> GetModels();
        List<Models.Entities.Models> GetModelsById(int MarkId);
        List<EngineTypes> GetEngineTypes();
        List<Categories> GetCategories();
        string GetMainImageByCarId(int id);
        List<string> GetMultImageByCarId(int id);
        Cars GetCarById(int id);
        bool SaveCar(Cars cars);
        bool SaveImage(List<Images> images);
        bool SaveNewMark(Marks mark);
        bool SaveNewEngineType(EngineTypes engineType);
        bool SaveNewCategory(Categories category);
    }
}
