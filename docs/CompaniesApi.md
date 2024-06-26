# DigitalFemsa.net.Api.CompaniesApi

All URIs are relative to *https://api.digitalfemsa.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetCompanies**](CompaniesApi.md#getcompanies) | **GET** /companies | Get List of Companies |
| [**GetCompany**](CompaniesApi.md#getcompany) | **GET** /companies/{id} | Get Company |

<a id="getcompanies"></a>
# **GetCompanies**
> GetCompaniesResponse GetCompanies (string acceptLanguage = null, int? limit = null, string search = null, string next = null, string previous = null)

Get List of Companies

Consume the list of child companies.  This is used for holding companies with several child entities.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DigitalFemsa.net.Api;
using DigitalFemsa.net.Client;
using DigitalFemsa.net.Model;

namespace Example
{
    public class GetCompaniesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.digitalfemsa.io";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CompaniesApi(config);
            var acceptLanguage = es;  // string | Use for knowing which language to use (optional)  (default to es)
            var limit = 20;  // int? | The numbers of items to return, the maximum value is 250 (optional)  (default to 20)
            var search = "search_example";  // string | General order search, e.g. by mail, reference etc. (optional) 
            var next = "next_example";  // string | next page (optional) 
            var previous = "previous_example";  // string | previous page (optional) 

            try
            {
                // Get List of Companies
                GetCompaniesResponse result = apiInstance.GetCompanies(acceptLanguage, limit, search, next, previous);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CompaniesApi.GetCompanies: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCompaniesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get List of Companies
    ApiResponse<GetCompaniesResponse> response = apiInstance.GetCompaniesWithHttpInfo(acceptLanguage, limit, search, next, previous);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CompaniesApi.GetCompaniesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **acceptLanguage** | **string** | Use for knowing which language to use | [optional] [default to es] |
| **limit** | **int?** | The numbers of items to return, the maximum value is 250 | [optional] [default to 20] |
| **search** | **string** | General order search, e.g. by mail, reference etc. | [optional]  |
| **next** | **string** | next page | [optional]  |
| **previous** | **string** | previous page | [optional]  |

### Return type

[**GetCompaniesResponse**](GetCompaniesResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.app-v2.1.0+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful |  * Date - The date and time that the response was sent <br>  * Content-Type - The format of the response body <br>  * Content-Length - The length of the response body in bytes <br>  * Connection - The type of connection used to transfer the response <br>  |
| **401** | authentication error |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcompany"></a>
# **GetCompany**
> CompanyResponse GetCompany (string id, string acceptLanguage = null)

Get Company

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DigitalFemsa.net.Api;
using DigitalFemsa.net.Client;
using DigitalFemsa.net.Model;

namespace Example
{
    public class GetCompanyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.digitalfemsa.io";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new CompaniesApi(config);
            var id = 6307a60c41de27127515a575;  // string | Identifier of the resource
            var acceptLanguage = es;  // string | Use for knowing which language to use (optional)  (default to es)

            try
            {
                // Get Company
                CompanyResponse result = apiInstance.GetCompany(id, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CompaniesApi.GetCompany: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCompanyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Company
    ApiResponse<CompanyResponse> response = apiInstance.GetCompanyWithHttpInfo(id, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CompaniesApi.GetCompanyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Identifier of the resource |  |
| **acceptLanguage** | **string** | Use for knowing which language to use | [optional] [default to es] |

### Return type

[**CompanyResponse**](CompanyResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/vnd.app-v2.1.0+json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | successful |  * Date - The date and time that the response was sent <br>  * Content-Type - The format of the response body <br>  * Content-Length - The length of the response body in bytes <br>  * Connection - The type of connection used to transfer the response <br>  |
| **401** | authentication error |  -  |
| **404** | not found entity |  -  |
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

