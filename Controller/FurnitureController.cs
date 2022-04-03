﻿using RentMe.DAL;
using RentMe.Model;
using System;
using System.Collections.Generic;

namespace RentMe.Controller
{
    /// <summary>
    /// This class serves as the controller,
    /// mediator between the RentMe application
    /// and the FurnitureDAL.
    /// </summary>
    public class FurnitureController
    {

        private readonly FurnitureDAL furniture_DBresource;
        /// <summary>
        /// 0-param constructor.
        /// </summary>
        public FurnitureController()
        {
            this.furniture_DBresource = new FurnitureDAL();
        }

        /// <summary>
        /// Return furniture using search input.
        /// </summary>
        /// <param name="furniture"></param>
        /// <returns>Searched furniture</returns>
        public List<Furniture> GetFurnitureDetails(Furniture furniture)
        {
            if (furniture == null)
            {
                throw new ArgumentException("The furniture cannot be null");
            }
            else if (!(furniture.FurnitureID > 0) || string.IsNullOrEmpty(furniture.Style) || string.IsNullOrEmpty(furniture.Category))
            {
                throw new ArgumentException("Please check the value entered. Furniture ID should be greater than 0.");
            }
            else if (string.IsNullOrEmpty(furniture.Style) )
            {
                throw new ArgumentException("Please check the value entered. Furniture Style cannot be empty");
            }
            else if (string.IsNullOrEmpty(furniture.Category))
            {
                throw new ArgumentException("Please check the value entered. Furniture Category cannot be empty.");
            }
                return this.furniture_DBresource.GetFurniture(furniture);
        }


        /// <summary>
        /// Return furniture style
        /// </summary>      
        /// <returns>List of style</returns>
        public List<string> GetFurnituresStyle()
        {
           
            return this.furniture_DBresource.GetFurnitureStyles();
        }

        /// <summary>
        /// Return furniture Category
        /// </summary>      
        /// <returns>List of Category</returns>
        public List<string> GetFurnituresCategory()
        {

            return this.furniture_DBresource.GetFurnitureCategories();
        }
    }
}
