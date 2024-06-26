# DigitalFemsa.net.Api.TaxesApi

All URIs are relative to *https://api.digitalfemsa.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**OrdersCreateTaxes**](TaxesApi.md#orderscreatetaxes) | **POST** /orders/{id}/tax_lines | Create Tax |
| [**OrdersDeleteTaxes**](TaxesApi.md#ordersdeletetaxes) | **DELETE** /orders/{id}/tax_lines/{tax_id} | Delete Tax |
| [**OrdersUpdateTaxes**](TaxesApi.md#ordersupdatetaxes) | **PUT** /orders/{id}/tax_lines/{tax_id} | Update Tax |

<a id="orderscreatetaxes"></a>
# **OrdersCreateTaxes**
> UpdateOrderTaxResponse OrdersCreateTaxes (string id, OrderTaxRequest orderTaxRequest, string acceptLanguage = null, string xChildCompanyId = null)

Create Tax

Create new taxes for an existing orden

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DigitalFemsa.net.Api;
using DigitalFemsa.net.Client;
using DigitalFemsa.net.Model;

namespace Example
{
    public class OrdersCreateTaxesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.digitalfemsa.io";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TaxesApi(config);
            var id = 6307a60c41de27127515a575;  // string | Identifier of the resource
            var orderTaxRequest = new OrderTaxRequest(); // OrderTaxRequest | requested field for a taxes
            var acceptLanguage = es;  // string | Use for knowing which language to use (optional)  (default to es)
            var xChildCompanyId = 6441b6376b60c3a638da80af;  // string | In the case of a holding company, the company id of the child company to which will process the request. (optional) 

            try
            {
                // Create Tax
                UpdateOrderTaxResponse result = apiInstance.OrdersCreateTaxes(id, orderTaxRequest, acceptLanguage, xChildCompanyId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaxesApi.OrdersCreateTaxes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OrdersCreateTaxesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Tax
    ApiResponse<UpdateOrderTaxResponse> response = apiInstance.OrdersCreateTaxesWithHttpInfo(id, orderTaxRequest, acceptLanguage, xChildCompanyId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TaxesApi.OrdersCreateTaxesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Identifier of the resource |  |
| **orderTaxRequest** | [**OrderTaxRequest**](OrderTaxRequest.md) | requested field for a taxes |  |
| **acceptLanguage** | **string** | Use for knowing which language to use | [optional] [default to es] |
| **xChildCompanyId** | **string** | In the case of a holding company, the company id of the child company to which will process the request. | [optional]  |

### Return type

[**UpdateOrderTaxResponse**](UpdateOrderTaxResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.app-v2.1.0+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful |  -  |
| **401** | authentication error |  -  |
| **404** | not found entity |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ordersdeletetaxes"></a>
# **OrdersDeleteTaxes**
> UpdateOrderTaxResponse OrdersDeleteTaxes (string id, string taxId, string acceptLanguage = null, string xChildCompanyId = null)

Delete Tax

Delete taxes for an existing orden

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DigitalFemsa.net.Api;
using DigitalFemsa.net.Client;
using DigitalFemsa.net.Model;

namespace Example
{
    public class OrdersDeleteTaxesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.digitalfemsa.io";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TaxesApi(config);
            var id = 6307a60c41de27127515a575;  // string | Identifier of the resource
            var taxId = tax_lin_2tQ974hSHcsdeSZHG;  // string | identifier
            var acceptLanguage = es;  // string | Use for knowing which language to use (optional)  (default to es)
            var xChildCompanyId = 6441b6376b60c3a638da80af;  // string | In the case of a holding company, the company id of the child company to which will process the request. (optional) 

            try
            {
                // Delete Tax
                UpdateOrderTaxResponse result = apiInstance.OrdersDeleteTaxes(id, taxId, acceptLanguage, xChildCompanyId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaxesApi.OrdersDeleteTaxes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OrdersDeleteTaxesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Tax
    ApiResponse<UpdateOrderTaxResponse> response = apiInstance.OrdersDeleteTaxesWithHttpInfo(id, taxId, acceptLanguage, xChildCompanyId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TaxesApi.OrdersDeleteTaxesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Identifier of the resource |  |
| **taxId** | **string** | identifier |  |
| **acceptLanguage** | **string** | Use for knowing which language to use | [optional] [default to es] |
| **xChildCompanyId** | **string** | In the case of a holding company, the company id of the child company to which will process the request. | [optional]  |

### Return type

[**UpdateOrderTaxResponse**](UpdateOrderTaxResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.app-v2.1.0+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful |  -  |
| **401** | authentication error |  -  |
| **422** | parameter validation error |  -  |
| **404** | not found entity |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="ordersupdatetaxes"></a>
# **OrdersUpdateTaxes**
> UpdateOrderTaxResponse OrdersUpdateTaxes (string id, string taxId, UpdateOrderTaxRequest updateOrderTaxRequest, string acceptLanguage = null, string xChildCompanyId = null)

Update Tax

Update taxes for an existing orden

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DigitalFemsa.net.Api;
using DigitalFemsa.net.Client;
using DigitalFemsa.net.Model;

namespace Example
{
    public class OrdersUpdateTaxesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.digitalfemsa.io";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new TaxesApi(config);
            var id = 6307a60c41de27127515a575;  // string | Identifier of the resource
            var taxId = tax_lin_2tQ974hSHcsdeSZHG;  // string | identifier
            var updateOrderTaxRequest = new UpdateOrderTaxRequest(); // UpdateOrderTaxRequest | requested field for taxes
            var acceptLanguage = es;  // string | Use for knowing which language to use (optional)  (default to es)
            var xChildCompanyId = 6441b6376b60c3a638da80af;  // string | In the case of a holding company, the company id of the child company to which will process the request. (optional) 

            try
            {
                // Update Tax
                UpdateOrderTaxResponse result = apiInstance.OrdersUpdateTaxes(id, taxId, updateOrderTaxRequest, acceptLanguage, xChildCompanyId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaxesApi.OrdersUpdateTaxes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OrdersUpdateTaxesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Tax
    ApiResponse<UpdateOrderTaxResponse> response = apiInstance.OrdersUpdateTaxesWithHttpInfo(id, taxId, updateOrderTaxRequest, acceptLanguage, xChildCompanyId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TaxesApi.OrdersUpdateTaxesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Identifier of the resource |  |
| **taxId** | **string** | identifier |  |
| **updateOrderTaxRequest** | [**UpdateOrderTaxRequest**](UpdateOrderTaxRequest.md) | requested field for taxes |  |
| **acceptLanguage** | **string** | Use for knowing which language to use | [optional] [default to es] |
| **xChildCompanyId** | **string** | In the case of a holding company, the company id of the child company to which will process the request. | [optional]  |

### Return type

[**UpdateOrderTaxResponse**](UpdateOrderTaxResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/vnd.app-v2.1.0+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful |  -  |
| **401** | authentication error |  -  |
| **422** | parameter validation error |  -  |
| **404** | not found entity |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

