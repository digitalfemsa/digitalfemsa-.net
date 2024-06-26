# DigitalFemsa.net.Model.OrderUpdateRequest
a order

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Charges** | [**List&lt;ChargeRequest&gt;**](ChargeRequest.md) |  | [optional] 
**Checkout** | [**CheckoutRequest**](CheckoutRequest.md) |  | [optional] 
**Currency** | **string** | Currency with which the payment will be made. It uses the 3-letter code of the [International Standard ISO 4217.](https://es.wikipedia.org/wiki/ISO_4217) | [optional] 
**CustomerInfo** | [**OrderUpdateRequestCustomerInfo**](OrderUpdateRequestCustomerInfo.md) |  | [optional] 
**DiscountLines** | [**List&lt;OrderDiscountLinesRequest&gt;**](OrderDiscountLinesRequest.md) | List of [discounts](https://developers.femsa.com/v2.1.0/reference/orderscreatediscountline) that are applied to the order. You must have at least one discount. | [optional] 
**FiscalEntity** | [**OrderUpdateFiscalEntityRequest**](OrderUpdateFiscalEntityRequest.md) |  | [optional] 
**LineItems** | [**List&lt;Product&gt;**](Product.md) | List of [products](https://developers.femsa.com/v2.1.0/reference/orderscreateproduct) that are sold in the order. You must have at least one product. | [optional] 
**Metadata** | **Dictionary&lt;string, string&gt;** |  | [optional] 
**PreAuthorize** | **bool** | Indicates whether the order charges must be preauthorized | [optional] [default to false]
**ShippingContact** | [**CustomerShippingContacts**](CustomerShippingContacts.md) |  | [optional] 
**ShippingLines** | [**List&lt;ShippingRequest&gt;**](ShippingRequest.md) | List of [shipping costs](https://developers.femsa.com/v2.1.0/reference/orderscreateshipping). If the online store offers digital products. | [optional] 
**TaxLines** | [**List&lt;OrderTaxRequest&gt;**](OrderTaxRequest.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

