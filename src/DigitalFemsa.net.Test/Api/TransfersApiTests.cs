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
    ///  Class for testing TransfersApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class TransfersApiTests : IDisposable
    {
        private TransfersApi instance;

        public TransfersApiTests()
        {
            instance = new TransfersApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TransfersApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' TransfersApi
            //Assert.IsType<TransfersApi>(instance);
        }

        /// <summary>
        /// Test GetTransfer
        /// </summary>
        [Fact]
        public void GetTransferTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string acceptLanguage = null;
            //string xChildCompanyId = null;
            //var response = instance.GetTransfer(id, acceptLanguage, xChildCompanyId);
            //Assert.IsType<TransferResponse>(response);
        }

        /// <summary>
        /// Test GetTransfers
        /// </summary>
        [Fact]
        public void GetTransfersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptLanguage = null;
            //string xChildCompanyId = null;
            //int? limit = null;
            //string search = null;
            //string next = null;
            //string previous = null;
            //var response = instance.GetTransfers(acceptLanguage, xChildCompanyId, limit, search, next, previous);
            //Assert.IsType<GetTransfersResponse>(response);
        }
    }
}
