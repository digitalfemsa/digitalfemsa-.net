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
    ///  Class for testing ApiKeysApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ApiKeysApiTests : IDisposable
    {
        private ApiKeysApi instance;

        public ApiKeysApiTests()
        {
            instance = new ApiKeysApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ApiKeysApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ApiKeysApi
            //Assert.IsType<ApiKeysApi>(instance);
        }

        /// <summary>
        /// Test CreateApiKey
        /// </summary>
        [Fact]
        public void CreateApiKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ApiKeyRequest apiKeyRequest = null;
            //string acceptLanguage = null;
            //string xChildCompanyId = null;
            //var response = instance.CreateApiKey(apiKeyRequest, acceptLanguage, xChildCompanyId);
            //Assert.IsType<ApiKeyCreateResponse>(response);
        }

        /// <summary>
        /// Test DeleteApiKey
        /// </summary>
        [Fact]
        public void DeleteApiKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string acceptLanguage = null;
            //var response = instance.DeleteApiKey(id, acceptLanguage);
            //Assert.IsType<DeleteApiKeysResponse>(response);
        }

        /// <summary>
        /// Test GetApiKey
        /// </summary>
        [Fact]
        public void GetApiKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string acceptLanguage = null;
            //string xChildCompanyId = null;
            //var response = instance.GetApiKey(id, acceptLanguage, xChildCompanyId);
            //Assert.IsType<ApiKeyResponse>(response);
        }

        /// <summary>
        /// Test GetApiKeys
        /// </summary>
        [Fact]
        public void GetApiKeysTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptLanguage = null;
            //string xChildCompanyId = null;
            //int? limit = null;
            //string next = null;
            //string previous = null;
            //string search = null;
            //var response = instance.GetApiKeys(acceptLanguage, xChildCompanyId, limit, next, previous, search);
            //Assert.IsType<GetApiKeysResponse>(response);
        }

        /// <summary>
        /// Test UpdateApiKey
        /// </summary>
        [Fact]
        public void UpdateApiKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string acceptLanguage = null;
            //ApiKeyUpdateRequest apiKeyUpdateRequest = null;
            //var response = instance.UpdateApiKey(id, acceptLanguage, apiKeyUpdateRequest);
            //Assert.IsType<ApiKeyResponse>(response);
        }
    }
}
