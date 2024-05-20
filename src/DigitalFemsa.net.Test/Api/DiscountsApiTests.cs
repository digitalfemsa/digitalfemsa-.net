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
    ///  Class for testing DiscountsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class DiscountsApiTests : IDisposable
    {
        private DiscountsApi instance;

        public DiscountsApiTests()
        {
            instance = new DiscountsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DiscountsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' DiscountsApi
            //Assert.IsType<DiscountsApi>(instance);
        }

        /// <summary>
        /// Test OrdersCreateDiscountLine
        /// </summary>
        [Fact]
        public void OrdersCreateDiscountLineTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //OrderDiscountLinesRequest orderDiscountLinesRequest = null;
            //string acceptLanguage = null;
            //string xChildCompanyId = null;
            //var response = instance.OrdersCreateDiscountLine(id, orderDiscountLinesRequest, acceptLanguage, xChildCompanyId);
            //Assert.IsType<DiscountLinesResponse>(response);
        }

        /// <summary>
        /// Test OrdersDeleteDiscountLines
        /// </summary>
        [Fact]
        public void OrdersDeleteDiscountLinesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string discountLinesId = null;
            //string acceptLanguage = null;
            //string xChildCompanyId = null;
            //var response = instance.OrdersDeleteDiscountLines(id, discountLinesId, acceptLanguage, xChildCompanyId);
            //Assert.IsType<DiscountLinesResponse>(response);
        }

        /// <summary>
        /// Test OrdersGetDiscountLine
        /// </summary>
        [Fact]
        public void OrdersGetDiscountLineTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string discountLinesId = null;
            //string acceptLanguage = null;
            //string xChildCompanyId = null;
            //var response = instance.OrdersGetDiscountLine(id, discountLinesId, acceptLanguage, xChildCompanyId);
            //Assert.IsType<DiscountLinesResponse>(response);
        }

        /// <summary>
        /// Test OrdersGetDiscountLines
        /// </summary>
        [Fact]
        public void OrdersGetDiscountLinesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string acceptLanguage = null;
            //string xChildCompanyId = null;
            //int? limit = null;
            //string search = null;
            //string next = null;
            //string previous = null;
            //var response = instance.OrdersGetDiscountLines(id, acceptLanguage, xChildCompanyId, limit, search, next, previous);
            //Assert.IsType<GetOrderDiscountLinesResponse>(response);
        }

        /// <summary>
        /// Test OrdersUpdateDiscountLines
        /// </summary>
        [Fact]
        public void OrdersUpdateDiscountLinesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string discountLinesId = null;
            //UpdateOrderDiscountLinesRequest updateOrderDiscountLinesRequest = null;
            //string acceptLanguage = null;
            //string xChildCompanyId = null;
            //var response = instance.OrdersUpdateDiscountLines(id, discountLinesId, updateOrderDiscountLinesRequest, acceptLanguage, xChildCompanyId);
            //Assert.IsType<DiscountLinesResponse>(response);
        }
    }
}
