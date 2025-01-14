﻿using RentMe.DAL;
using RentMe.Model;
using RentMe.Model.Validators;
using System;
using System.Collections.Generic;

namespace RentMe.Controller
{
    /// <summary>
    /// This class serves as the controller,
    /// mediator between the RentMe application
    /// and the TransactionsDAL.
    /// </summary>
    public class TransactionsController
    {
        /// <summary>
        /// Gets all Transactions from RentalTransactions table.
        /// </summary>
        /// <returns>List of all RentMe Transactions</returns>
        public List<Transaction> GetTransactions()
        {
            return TransactionsDAL.GetTransactions();
        }

        /// <summary>
        /// Gets all RentMe Rental Transactions.
        /// </summary>
        /// <returns>List of RentMe Rental Transactions</returns>
        public List<Transaction> GetRentalTransactions()
        {
            return TransactionsDAL.GetRentalTransactions();
        }

        /// <summary>
        /// Gets all RentMe Return Transactions.
        /// </summary>
        /// <returns>List of RentMe Return Transactions</returns>
        public List<Transaction> GetReturnTransactions()
        {
            return TransactionsDAL.GetReturnTransactions();
        }

        /// <summary>
        /// Return true if Transaction
        /// exists based on search criteria.
        /// </summary>
        /// <param name="transaction"></param>
        /// <returns>True if valid search</returns>
        public bool ValidTransactionSearch(Transaction transaction)
        {
            TransactionValidator.ValidateTransactionNotNull(transaction);
            return TransactionsDAL.ValidTransactionSearch(transaction);
        }

        /// <summary>
        /// Returns Transaction list
        /// based on search input.
        /// </summary>
        /// <param name="transaction"></param>
        /// <returns>List of searched RentMe transactions</returns>
        public List<Transaction> SearchTransactions(Transaction transaction, string searchFilter)
        {
            TransactionValidator.ValidateTransactionNotNull(transaction);
            return TransactionsDAL.SearchTransactions(transaction, searchFilter);
        }

        /// <summary>
        /// Returns the earliest RentMe rental transaction.
        /// </summary>
        /// <returns>Earliest RentMe rental transaction</returns>
        public DateTime GetEarliestRentalTransaction()
        {
            return TransactionsDAL.GetEarliestRentalTransaction();
        }
    }
}
