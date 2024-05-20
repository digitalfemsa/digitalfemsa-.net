/*
 * Femsa API
 *
 * Femsa sdk
 *
 * The version of the OpenAPI document: 2.1.0
 * Contact: engineering@femsa.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using DigitalFemsa.net.Client;
using DigitalFemsa.net.Api;
// uncomment below to import models
//using DigitalFemsa.net.Model;

namespace DigitalFemsa.net.Test.Api
{
    /// <summary>
    ///  Class for testing TransactionsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class TransactionsApiTests : IDisposable
    {
        private TransactionsApi instance;

        public TransactionsApiTests()
        {
            instance = new TransactionsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TransactionsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' TransactionsApi
            //Assert.IsType<TransactionsApi>(instance);
        }

        /// <summary>
        /// Test GetTransaction
        /// </summary>
        [Fact]
        public void GetTransactionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string acceptLanguage = null;
            //string xChildCompanyId = null;
            //var response = instance.GetTransaction(id, acceptLanguage, xChildCompanyId);
            //Assert.IsType<TransactionResponse>(response);
        }

        /// <summary>
        /// Test GetTransactions
        /// </summary>
        [Fact]
        public void GetTransactionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptLanguage = null;
            //string xChildCompanyId = null;
            //int? limit = null;
            //string next = null;
            //string previous = null;
            //string id = null;
            //string chargeId = null;
            //string type = null;
            //string currency = null;
            //var response = instance.GetTransactions(acceptLanguage, xChildCompanyId, limit, next, previous, id, chargeId, type, currency);
            //Assert.IsType<GetTransactionsResponse>(response);
        }
    }
}