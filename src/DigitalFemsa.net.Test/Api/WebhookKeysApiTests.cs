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
    ///  Class for testing WebhookKeysApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class WebhookKeysApiTests : IDisposable
    {
        private WebhookKeysApi instance;

        public WebhookKeysApiTests()
        {
            instance = new WebhookKeysApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of WebhookKeysApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' WebhookKeysApi
            //Assert.IsType<WebhookKeysApi>(instance);
        }

        /// <summary>
        /// Test CreateWebhookKey
        /// </summary>
        [Fact]
        public void CreateWebhookKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptLanguage = null;
            //WebhookKeyRequest webhookKeyRequest = null;
            //var response = instance.CreateWebhookKey(acceptLanguage, webhookKeyRequest);
            //Assert.IsType<WebhookKeyCreateResponse>(response);
        }

        /// <summary>
        /// Test DeleteWebhookKey
        /// </summary>
        [Fact]
        public void DeleteWebhookKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string acceptLanguage = null;
            //var response = instance.DeleteWebhookKey(id, acceptLanguage);
            //Assert.IsType<WebhookKeyDeleteResponse>(response);
        }

        /// <summary>
        /// Test GetWebhookKey
        /// </summary>
        [Fact]
        public void GetWebhookKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string acceptLanguage = null;
            //string xChildCompanyId = null;
            //var response = instance.GetWebhookKey(id, acceptLanguage, xChildCompanyId);
            //Assert.IsType<WebhookKeyResponse>(response);
        }

        /// <summary>
        /// Test GetWebhookKeys
        /// </summary>
        [Fact]
        public void GetWebhookKeysTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string acceptLanguage = null;
            //string xChildCompanyId = null;
            //int? limit = null;
            //string search = null;
            //string next = null;
            //string previous = null;
            //var response = instance.GetWebhookKeys(acceptLanguage, xChildCompanyId, limit, search, next, previous);
            //Assert.IsType<GetWebhookKeysResponse>(response);
        }

        /// <summary>
        /// Test UpdateWebhookKey
        /// </summary>
        [Fact]
        public void UpdateWebhookKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string acceptLanguage = null;
            //WebhookKeyUpdateRequest webhookKeyUpdateRequest = null;
            //var response = instance.UpdateWebhookKey(id, acceptLanguage, webhookKeyUpdateRequest);
            //Assert.IsType<WebhookKeyResponse>(response);
        }
    }
}