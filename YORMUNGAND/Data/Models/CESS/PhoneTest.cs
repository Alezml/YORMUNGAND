﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace YORMUNGAND.Data.Models
{
    public class PricePosition
    {
        //Неисправность
        public string Problem { get; set; }

        //Стоимость ремонта
        public string Price { get; set; }
    }

    public class PhoneModel
    {
        public PhoneModel()
        {
            PricePositions = new List<PricePosition>();
        }

        //Название модели телефона
        public string Title { get; set; }

        public List<PricePosition> PricePositions { get; set; }
    }

    public class PhoneBrand
    {
        public PhoneBrand()
        {
            PhoneModels = new List<PhoneModel>();
        }

        //Название бренда
        public string Title { get; set; }

        public List<PhoneModel> PhoneModels { get; set; }
    }
}
