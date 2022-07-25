﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ImageManager : IImageService
    {
        IImageDal _imageDal;

        public ImageManager(IImageDal imageDal)
        {
            _imageDal = imageDal;
        }

        public List<Image> GetAll()
        {
            return _imageDal.GetAll();
        }

        public List<Image> GetByTenderID(int TenderID)
        {
            return _imageDal.GetAll(i=>i.TenderID == TenderID);
        }
    }
}
