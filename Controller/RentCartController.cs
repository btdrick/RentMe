﻿using RentMe.DAL;
using RentMe.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentMe.Controller
{
    public class RentCartController
    {


        public void AddFurnituresToRent(List<RentFurniture> rentFurnitureList)
        {
            if (rentFurnitureList.Any())
            {
                RentCartDAL.AddCartItems(rentFurnitureList);
            }

        }


        public List<RentFurniture> GetRentItem()
        {

            return RentCartDAL.GetCartItems();
        }

    }
}