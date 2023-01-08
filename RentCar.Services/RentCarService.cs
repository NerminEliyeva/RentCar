﻿using Microsoft.AspNetCore.Http;
using RentCar.DAL.Abstract.IRepository;
using RentCar.Models.Entities;
using RentCar.Models.Models;
using RentCar.Models.ViewModels;
using RentCar.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace RentCar.Services
{
    public class RentCarService : IRentCarService
    {
        private readonly ICarsRepository _carsRepository;
        public RentCarService(ICarsRepository carsRepository)
        {
            _carsRepository = carsRepository;
        }
        public CarsViewModel GetCardsAndFilterInfo()
        {
            #region Kartlar

            List<CardsInfo> cardsInfos = new List<CardsInfo>();

            var cars = _carsRepository.GetCars();
            var markas = _carsRepository.GetMarks();
            var models = _carsRepository.GetModels();
            var engientypes = _carsRepository.GetEngineTypes();
            var categories = _carsRepository.GetCategories();

            foreach (var car in cars)
            {
                string fullPath = _carsRepository.GetMainImageByCarId(car.CarId);
                byte[] imageArray = System.IO.File.ReadAllBytes(fullPath);
                string image = Convert.ToBase64String(imageArray);
                string imgDataURL = string.Format("data:image/jpeg;base64,{0}", image);
                CardsInfo onecardInfo = new CardsInfo()
                {
                    CarId = car.CarId,
                    Year = car.Year,
                    Price = car.Price,
                    Volume = car.EngineVolume,
                    Marka = markas.Where(x => x.MarkId == car.MarkId).FirstOrDefault().MarkName,
                    Model = models.Where(x => x.ModelId == car.ModelId).FirstOrDefault().ModelName,
                    EngineType = engientypes.Where(x => x.EngineTypeId == car.EngineTypeId).FirstOrDefault().EngineTypeName,
                    Category = categories.Where(x => x.CategoryId == car.CategoryId).FirstOrDefault().CategoryName,
                    ImageBase64 = imgDataURL
                };
                cardsInfos.Add(onecardInfo);
            }
            #endregion

            #region Filterim

            FilterData filterData = new FilterData()
            {
                FilterMarks = markas,
                FilterModels = models,
                FilterCategories = categories,
                FilterYears = cars.Select(x => x.Year).Distinct().ToList(),
            };

            #endregion

            CarsViewModel viewModel = new CarsViewModel()
            {
                CardsInfo = cardsInfos,
                FilterData = filterData
            };
            return viewModel;
        }

        public List<Models.Entities.Models> GetModels(int id)
        {
            return _carsRepository.GetModelsById(id);
        }
        public NewCarData GetDataForAddingNewCar()
        {
            var markas = _carsRepository.GetMarks();
            var engientypes = _carsRepository.GetEngineTypes();
            var categories = _carsRepository.GetCategories();

            NewCarData newCarData = new NewCarData()
            {
                Marks = markas,
                EngineTypes = engientypes,
                Categories = categories,
            };
            return newCarData;
        }

        public bool SaveNewCarService(SaveNewCarModel model)
        {
            var cars = new Cars()
            {
                CreatedDate = DateTime.Now,
                CreatedUser = "Nermin",
                EngineTypeId = model.EngineTypeId,
                EngineVolume = model.Volume,
                MarkId = model.MarkId,
                ModelId = model.ModelId,
                CategoryId = model.CaregoryId,
                Price = model.Price,
                Year = model.Year,
                Status = 1
            };
            _carsRepository.SaveCar(cars);
            int carId = cars.CarId;

            List<Images> images = new List<Images>();

            var myMark = _carsRepository.GetMarks().Where(x => x.MarkId == cars.MarkId).FirstOrDefault().MarkName;
            var myModel = _carsRepository.GetModels().Where(x => x.ModelId == cars.MarkId).FirstOrDefault().ModelName;

            IFormFile esasSekil = model.MainImage;
            string mainFilePath = @$"C:/ServerFiles/{myMark}_{myModel}_esas_sekil_{DateTime.Now.ToString("yyyy_MM_dd") + Path.GetExtension(esasSekil.FileName)}";

            using (Stream fileStream = new FileStream(mainFilePath, FileMode.Create))
            {
                esasSekil.CopyTo(fileStream);
            }

            Images oneMainImage = new Images()
            {
                CreatedDate = DateTime.Now,
                CreatedUser = "Nermin",
                ImageCarId = carId,
                MainImage = 1,
                FullPath = mainFilePath
            };
            images.Add(oneMainImage);
            int say = 1;
            foreach (IFormFile iformFileImage in model.Images)
            {
                string smallFilePath = @$"C:/ServerFiles/{myMark}_{myModel}_elave_sekil_{(say++).ToString()+ DateTime.Now.ToString("yyyy_MM_dd") + Path.GetExtension(esasSekil.FileName)}";
                using (Stream fileStream = new FileStream(smallFilePath, FileMode.Create))
                {
                    iformFileImage.CopyTo(fileStream);
                }
                Images oneImage = new Images()
                {
                    CreatedDate = DateTime.Now,
                    CreatedUser = "Nermin",
                    ImageCarId = carId,
                    MainImage = 0,
                    FullPath = smallFilePath
                };
                images.Add(oneImage);
            }

            _carsRepository.SaveImage(images);
            return true;
        }

        public bool SaveNewMarkService(string markName)
        {
            var marks = new Marks()
            {
                CreatedDate = DateTime.Now,
                MarkName = markName
            };
           // _carsRepository.SaveNewMark(marks); 
            return true;
        }

        public CarDetails GetCarDetails(int id)
        {
            var rowCar = _carsRepository.GetCarById(id);

            var markas = _carsRepository.GetMarks();
            var models = _carsRepository.GetModels();
            var engientypes = _carsRepository.GetEngineTypes();
            var categories = _carsRepository.GetCategories();

            string mainfullPath = _carsRepository.GetMainImageByCarId(rowCar.CarId);
            var mainImgDataURL = GetImageBase64FromPath(mainfullPath);

            List<string> multFullPath = _carsRepository.GetMultImageByCarId(rowCar.CarId);

            List<string> multImgDataURLList = new List<string>();
            foreach (var onemultimgFullPath in multFullPath)
            {
                multImgDataURLList.Add(GetImageBase64FromPath(onemultimgFullPath));
            }

            CarDetails carDetails = new CarDetails()
            {
                CarId = id,
                Marka = markas.Where(x => x.MarkId == rowCar.MarkId).FirstOrDefault().MarkName,
                Model = models.Where(x => x.ModelId == rowCar.ModelId).FirstOrDefault().ModelName,
                EngineType = engientypes.Where(x => x.EngineTypeId == rowCar.EngineTypeId).FirstOrDefault().EngineTypeName,
                Category = categories.Where(x => x.CategoryId == rowCar.CategoryId).FirstOrDefault().CategoryName,
                Price = rowCar.Price,
                Volume = rowCar.EngineVolume,
                Year = rowCar.Year,
                ImageBase64 = mainImgDataURL,
                MultImageBase64 = multImgDataURLList
            };
            return carDetails;
        }

        public string GetImageBase64FromPath(string fullPath)
        {
            byte[] imageArray = System.IO.File.ReadAllBytes(fullPath);
            string image = Convert.ToBase64String(imageArray);
            string extention = Path.GetExtension(fullPath);
            string imgDataURL = string.Format("data:image/{0};base64,{1}", extention, image);
            return imgDataURL;
        }
    }
}
