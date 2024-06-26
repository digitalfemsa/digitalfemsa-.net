# DigitalFemsa.net.Api.ShippingContactsApi

All URIs are relative to *https://api.digitalfemsa.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateCustomerShippingContacts**](ShippingContactsApi.md#createcustomershippingcontacts) | **POST** /customers/{id}/shipping_contacts | Create a shipping contacts |
| [**DeleteCustomerShippingContacts**](ShippingContactsApi.md#deletecustomershippingcontacts) | **DELETE** /customers/{id}/shipping_contacts/{shipping_contacts_id} | Delete shipping contacts |
| [**UpdateCustomerShippingContacts**](ShippingContactsApi.md#updatecustomershippingcontacts) | **PUT** /customers/{id}/shipping_contacts/{shipping_contacts_id} | Update shipping contacts |

<a id="createcustomershippingcontacts"></a>
# **CreateCustomerShippingContacts**
> CustomerShippingContactsResponse CreateCustomerShippingContacts (string id, CustomerShippingContacts customerShippingContacts, string acceptLanguage = null, string xChildCompanyId = null)

Create a shipping contacts

Create a shipping contacts for a customer.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DigitalFemsa.net.Api;
using DigitalFemsa.net.Client;
using DigitalFemsa.net.Model;

namespace Example
{
    public class CreateCustomerShippingContactsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.digitalfemsa.io";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ShippingContactsApi(config);
            var id = 6307a60c41de27127515a575;  // string | Identifier of the resource
            var customerShippingContacts = new CustomerShippingContacts(); // CustomerShippingContacts | requested field for customer shippings contacts
            var acceptLanguage = es;  // string | Use for knowing which language to use (optional)  (default to es)
            var xChildCompanyId = 6441b6376b60c3a638da80af;  // string | In the case of a holding company, the company id of the child company to which will process the request. (optional) 

            try
            {
                // Create a shipping contacts
                CustomerShippingContactsResponse result = apiInstance.CreateCustomerShippingContacts(id, customerShippingContacts, acceptLanguage, xChildCompanyId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShippingContactsApi.CreateCustomerShippingContacts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateCustomerShippingContactsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a shipping contacts
    ApiResponse<CustomerShippingContactsResponse> response = apiInstance.CreateCustomerShippingContactsWithHttpInfo(id, customerShippingContacts, acceptLanguage, xChildCompanyId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ShippingContactsApi.CreateCustomerShippingContactsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Identifier of the resource |  |
| **customerShippingContacts** | [**CustomerShippingContacts**](CustomerShippingContacts.md) | requested field for customer shippings contacts |  |
| **acceptLanguage** | **string** | Use for knowing which language to use | [optional] [default to es] |
| **xChildCompanyId** | **string** | In the case of a holding company, the company id of the child company to which will process the request. | [optional]  |

### Return type

[**CustomerShippingContactsResponse**](CustomerShippingContactsResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.app-v2.1.0+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **401** | authentication error |  -  |
| **404** | not found entity |  -  |
| **422** | parameter validation error |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletecustomershippingcontacts"></a>
# **DeleteCustomerShippingContacts**
> CustomerShippingContactsResponse DeleteCustomerShippingContacts (string id, string shippingContactsId, string acceptLanguage = null, string xChildCompanyId = null)

Delete shipping contacts

Delete shipping contact that corresponds to a customer ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DigitalFemsa.net.Api;
using DigitalFemsa.net.Client;
using DigitalFemsa.net.Model;

namespace Example
{
    public class DeleteCustomerShippingContactsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.digitalfemsa.io";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ShippingContactsApi(config);
            var id = 6307a60c41de27127515a575;  // string | Identifier of the resource
            var shippingContactsId = 6307a60c41de27127515a575;  // string | identifier
            var acceptLanguage = es;  // string | Use for knowing which language to use (optional)  (default to es)
            var xChildCompanyId = 6441b6376b60c3a638da80af;  // string | In the case of a holding company, the company id of the child company to which will process the request. (optional) 

            try
            {
                // Delete shipping contacts
                CustomerShippingContactsResponse result = apiInstance.DeleteCustomerShippingContacts(id, shippingContactsId, acceptLanguage, xChildCompanyId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShippingContactsApi.DeleteCustomerShippingContacts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteCustomerShippingContactsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete shipping contacts
    ApiResponse<CustomerShippingContactsResponse> response = apiInstance.DeleteCustomerShippingContactsWithHttpInfo(id, shippingContactsId, acceptLanguage, xChildCompanyId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ShippingContactsApi.DeleteCustomerShippingContactsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Identifier of the resource |  |
| **shippingContactsId** | **string** | identifier |  |
| **acceptLanguage** | **string** | Use for knowing which language to use | [optional] [default to es] |
| **xChildCompanyId** | **string** | In the case of a holding company, the company id of the child company to which will process the request. | [optional]  |

### Return type

[**CustomerShippingContactsResponse**](CustomerShippingContactsResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.app-v2.1.0+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **401** | authentication error |  -  |
| **404** | not found entity |  -  |
| **422** | parameter validation error |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatecustomershippingcontacts"></a>
# **UpdateCustomerShippingContacts**
> CustomerShippingContactsResponse UpdateCustomerShippingContacts (string id, string shippingContactsId, CustomerUpdateShippingContacts customerUpdateShippingContacts, string acceptLanguage = null, string xChildCompanyId = null)

Update shipping contacts

Update shipping contact that corresponds to a customer ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DigitalFemsa.net.Api;
using DigitalFemsa.net.Client;
using DigitalFemsa.net.Model;

namespace Example
{
    public class UpdateCustomerShippingContactsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.digitalfemsa.io";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ShippingContactsApi(config);
            var id = 6307a60c41de27127515a575;  // string | Identifier of the resource
            var shippingContactsId = 6307a60c41de27127515a575;  // string | identifier
            var customerUpdateShippingContacts = new CustomerUpdateShippingContacts(); // CustomerUpdateShippingContacts | requested field for customer update shippings contacts
            var acceptLanguage = es;  // string | Use for knowing which language to use (optional)  (default to es)
            var xChildCompanyId = 6441b6376b60c3a638da80af;  // string | In the case of a holding company, the company id of the child company to which will process the request. (optional) 

            try
            {
                // Update shipping contacts
                CustomerShippingContactsResponse result = apiInstance.UpdateCustomerShippingContacts(id, shippingContactsId, customerUpdateShippingContacts, acceptLanguage, xChildCompanyId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShippingContactsApi.UpdateCustomerShippingContacts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateCustomerShippingContactsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update shipping contacts
    ApiResponse<CustomerShippingContactsResponse> response = apiInstance.UpdateCustomerShippingContactsWithHttpInfo(id, shippingContactsId, customerUpdateShippingContacts, acceptLanguage, xChildCompanyId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ShippingContactsApi.UpdateCustomerShippingContactsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Identifier of the resource |  |
| **shippingContactsId** | **string** | identifier |  |
| **customerUpdateShippingContacts** | [**CustomerUpdateShippingContacts**](CustomerUpdateShippingContacts.md) | requested field for customer update shippings contacts |  |
| **acceptLanguage** | **string** | Use for knowing which language to use | [optional] [default to es] |
| **xChildCompanyId** | **string** | In the case of a holding company, the company id of the child company to which will process the request. | [optional]  |

### Return type

[**CustomerShippingContactsResponse**](CustomerShippingContactsResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.app-v2.1.0+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful operation |  -  |
| **401** | authentication error |  -  |
| **404** | not found entity |  -  |
| **422** | parameter validation error |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

