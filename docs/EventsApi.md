# DigitalFemsa.net.Api.EventsApi

All URIs are relative to *https://api.digitalfemsa.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetEvent**](EventsApi.md#getevent) | **GET** /events/{id} | Get Event |
| [**GetEvents**](EventsApi.md#getevents) | **GET** /events | Get list of Events |
| [**ResendEvent**](EventsApi.md#resendevent) | **POST** /events/{event_id}/webhook_logs/{webhook_log_id}/resend | Resend Event |

<a id="getevent"></a>
# **GetEvent**
> EventResponse GetEvent (string id, string acceptLanguage = null, string xChildCompanyId = null)

Get Event

Returns a single event

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DigitalFemsa.net.Api;
using DigitalFemsa.net.Client;
using DigitalFemsa.net.Model;

namespace Example
{
    public class GetEventExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.digitalfemsa.io";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new EventsApi(config);
            var id = 6307a60c41de27127515a575;  // string | Identifier of the resource
            var acceptLanguage = es;  // string | Use for knowing which language to use (optional)  (default to es)
            var xChildCompanyId = 6441b6376b60c3a638da80af;  // string | In the case of a holding company, the company id of the child company to which will process the request. (optional) 

            try
            {
                // Get Event
                EventResponse result = apiInstance.GetEvent(id, acceptLanguage, xChildCompanyId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventsApi.GetEvent: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEventWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Event
    ApiResponse<EventResponse> response = apiInstance.GetEventWithHttpInfo(id, acceptLanguage, xChildCompanyId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventsApi.GetEventWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Identifier of the resource |  |
| **acceptLanguage** | **string** | Use for knowing which language to use | [optional] [default to es] |
| **xChildCompanyId** | **string** | In the case of a holding company, the company id of the child company to which will process the request. | [optional]  |

### Return type

[**EventResponse**](EventResponse.md)

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

<a id="getevents"></a>
# **GetEvents**
> GetEventsResponse GetEvents (string acceptLanguage = null, string xChildCompanyId = null, int? limit = null, string search = null, string next = null, string previous = null)

Get list of Events

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DigitalFemsa.net.Api;
using DigitalFemsa.net.Client;
using DigitalFemsa.net.Model;

namespace Example
{
    public class GetEventsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.digitalfemsa.io";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new EventsApi(config);
            var acceptLanguage = es;  // string | Use for knowing which language to use (optional)  (default to es)
            var xChildCompanyId = 6441b6376b60c3a638da80af;  // string | In the case of a holding company, the company id of the child company to which will process the request. (optional) 
            var limit = 20;  // int? | The numbers of items to return, the maximum value is 250 (optional)  (default to 20)
            var search = "search_example";  // string | General order search, e.g. by mail, reference etc. (optional) 
            var next = "next_example";  // string | next page (optional) 
            var previous = "previous_example";  // string | previous page (optional) 

            try
            {
                // Get list of Events
                GetEventsResponse result = apiInstance.GetEvents(acceptLanguage, xChildCompanyId, limit, search, next, previous);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventsApi.GetEvents: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEventsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get list of Events
    ApiResponse<GetEventsResponse> response = apiInstance.GetEventsWithHttpInfo(acceptLanguage, xChildCompanyId, limit, search, next, previous);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventsApi.GetEventsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **acceptLanguage** | **string** | Use for knowing which language to use | [optional] [default to es] |
| **xChildCompanyId** | **string** | In the case of a holding company, the company id of the child company to which will process the request. | [optional]  |
| **limit** | **int?** | The numbers of items to return, the maximum value is 250 | [optional] [default to 20] |
| **search** | **string** | General order search, e.g. by mail, reference etc. | [optional]  |
| **next** | **string** | next page | [optional]  |
| **previous** | **string** | previous page | [optional]  |

### Return type

[**GetEventsResponse**](GetEventsResponse.md)

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

<a id="resendevent"></a>
# **ResendEvent**
> EventsResendResponse ResendEvent (string eventId, string webhookLogId, string acceptLanguage = null)

Resend Event

Try to send an event

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DigitalFemsa.net.Api;
using DigitalFemsa.net.Client;
using DigitalFemsa.net.Model;

namespace Example
{
    public class ResendEventExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.digitalfemsa.io";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new EventsApi(config);
            var eventId = 6463d6e35a4c3e001819e760;  // string | event identifier
            var webhookLogId = webhl_2tsv6NzWJHBWCkqGt;  // string | webhook log identifier
            var acceptLanguage = es;  // string | Use for knowing which language to use (optional)  (default to es)

            try
            {
                // Resend Event
                EventsResendResponse result = apiInstance.ResendEvent(eventId, webhookLogId, acceptLanguage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EventsApi.ResendEvent: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ResendEventWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Resend Event
    ApiResponse<EventsResendResponse> response = apiInstance.ResendEventWithHttpInfo(eventId, webhookLogId, acceptLanguage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling EventsApi.ResendEventWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **eventId** | **string** | event identifier |  |
| **webhookLogId** | **string** | webhook log identifier |  |
| **acceptLanguage** | **string** | Use for knowing which language to use | [optional] [default to es] |

### Return type

[**EventsResendResponse**](EventsResendResponse.md)

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
| **500** | internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

