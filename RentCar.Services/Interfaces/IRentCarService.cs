using RentCar.Models.Entities;
using RentCar.Models.Models;
using RentCar.Models.ViewModels;
using System.Collections.Generic;

namespace RentCar.Services.Interfaces
{
    public interface IRentCarService
    {
        CarsViewModel GetCardsAndFilterInfo();
        List<Models.Entities.Models> GetModels(int id);
        NewCarData GetDataForAddingNewCar();
        bool SaveNewCarService(SaveNewCarModel model);
        CarDetails GetCarDetails(int id);
        bool SaveNewMarkService(string markName);
        bool SaveNewEngineTypeService(string engineTypeName);
        bool SaveNewCategoryService(string categoryName);
        bool SaveNewModelService(string modelName, int markId);
        List<Marks> GetMarks();
        List<CardsInfo> GetListCarData();
        List<CardsInfo> FilterDataService(ShowFilteredData model);
    }
}
