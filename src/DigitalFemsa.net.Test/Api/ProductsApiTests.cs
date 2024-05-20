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
    ///  Class for testing ProductsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ProductsApiTests : IDisposable
    {
        private ProductsApi instance;

        public ProductsApiTests()
        {
            instance = new ProductsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ProductsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ProductsApi
            //Assert.IsType<ProductsApi>(instance);
        }

        /// <summary>
        /// Test OrdersCreateProduct
        /// </summary>
        [Fact]
        public void OrdersCreateProductTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //Product product = null;
            //string acceptLanguage = null;
            //string xChildCompanyId = null;
            //var response = instance.OrdersCreateProduct(id, product, acceptLanguage, xChildCompanyId);
            //Assert.IsType<ProductOrderResponse>(response);
        }

        /// <summary>
        /// Test OrdersDeleteProduct
        /// </summary>
        [Fact]
        public void OrdersDeleteProductTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string lineItemId = null;
            //string acceptLanguage = null;
            //string xChildCompanyId = null;
            //var response = instance.OrdersDeleteProduct(id, lineItemId, acceptLanguage, xChildCompanyId);
            //Assert.IsType<ProductOrderResponse>(response);
        }

        /// <summary>
        /// Test OrdersUpdateProduct
        /// </summary>
        [Fact]
        public void OrdersUpdateProductTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string lineItemId = null;
            //UpdateProduct updateProduct = null;
            //string acceptLanguage = null;
            //string xChildCompanyId = null;
            //var response = instance.OrdersUpdateProduct(id, lineItemId, updateProduct, acceptLanguage, xChildCompanyId);
            //Assert.IsType<ProductOrderResponse>(response);
        }
    }
}
