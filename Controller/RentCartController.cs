﻿using RentMe.DAL;
using RentMe.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RentMe.Controller
{
    /// <summary>
    /// This class serves as the controller,
    /// mediator between the RentMe application
    /// and the in memory list to view rental items.
    /// </summary>
    public class RentCartController
    {
        /// <summary>
        /// Adds the furnitures to rent.
        /// </summary>
        /// <param name="rentFurnitureList">The rent furniture list.</param>
        public void AddFurnituresToRent(List<RentFurniture> rentFurnitureList)
        {
            if (rentFurnitureList.Any())
            {
                RentCartDAL.AddCartItems(rentFurnitureList);
            }
        }

        /// <summary>
        /// Gets the rent item.
        /// </summary>
        /// <param name="memberID">The member identifier.</param>
        /// <returns>List of items in cart</returns>
        public List<RentFurniture> GetRentItem(Member memberID)
        {
            if (memberID == null)
            {
                throw new ArgumentException("Member cannot be null");
            }
            return RentCartDAL.GetCartItems(memberID);
        }

        /// <summary>
        /// Updates the rental cart.
        /// </summary>
        /// <param name="member">The member.</param>
        public void UpdateRentalCart(Member member)
        {
            if (member == null)
            {
                throw new ArgumentException("Member cannot be null");
            }
            RentCartDAL.UpdateCartItems(member);
        }

        /// <summary>
        /// Deletes the cart item.
        /// </summary>
        /// <param name="index">The index.</param>
        public void DeleteCartItem(int index)
        {
            RentCartDAL.RemoveCartItem(index);
        }

        /// <summary>
        /// Updates the cart item.
        /// </summary>
        /// <param name="index">The index.</param>
        public void UpdateCartItem(int index, RentFurniture updateFurniture)

        {
            if (updateFurniture == null)
            {
                throw new ArgumentException("Furniture details cannot be null");
            }
            RentCartDAL.UpdateCartItem(index, updateFurniture);
        }
    }
}
