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
    ///  Class for testing ShippingContactsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ShippingContactsApiTests : IDisposable
    {
        private ShippingContactsApi instance;

        public ShippingContactsApiTests()
        {
            instance = new ShippingContactsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ShippingContactsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ShippingContactsApi
            //Assert.IsType<ShippingContactsApi>(instance);
        }

        /// <summary>
        /// Test CreateCustomerShippingContacts
        /// </summary>
        [Fact]
        public void CreateCustomerShippingContactsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //CustomerShippingContacts customerShippingContacts = null;
            //string acceptLanguage = null;
            //string xChildCompanyId = null;
            //var response = instance.CreateCustomerShippingContacts(id, customerShippingContacts, acceptLanguage, xChildCompanyId);
            //Assert.IsType<CustomerShippingContactsResponse>(response);
        }

        /// <summary>
        /// Test DeleteCustomerShippingContacts
        /// </summary>
        [Fact]
        public void DeleteCustomerShippingContactsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string shippingContactsId = null;
            //string acceptLanguage = null;
            //string xChildCompanyId = null;
            //var response = instance.DeleteCustomerShippingContacts(id, shippingContactsId, acceptLanguage, xChildCompanyId);
            //Assert.IsType<CustomerShippingContactsResponse>(response);
        }

        /// <summary>
        /// Test UpdateCustomerShippingContacts
        /// </summary>
        [Fact]
        public void UpdateCustomerShippingContactsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string shippingContactsId = null;
            //CustomerUpdateShippingContacts customerUpdateShippingContacts = null;
            //string acceptLanguage = null;
            //string xChildCompanyId = null;
            //var response = instance.UpdateCustomerShippingContacts(id, shippingContactsId, customerUpdateShippingContacts, acceptLanguage, xChildCompanyId);
            //Assert.IsType<CustomerShippingContactsResponse>(response);
        }
    }
}