# DigitalFemsa.net.Model.UpdateCustomer
update customer

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AntifraudInfo** | [**UpdateCustomerAntifraudInfo**](UpdateCustomerAntifraudInfo.md) |  | [optional] 
**DefaultPaymentSourceId** | **string** | It is a parameter that allows to identify in the response, the Femsa ID of a payment method (payment_id) | [optional] 
**Email** | **string** | An email address is a series of customizable characters followed by a universal Internet symbol, the at symbol (@), the name of a host server, and a web domain ending (.mx, .com, .org, . net, etc). | [optional] 
**Name** | **string** | Client&#39;s name | [optional] 
**Phone** | **string** | Is the customer&#39;s phone number | [optional] 
**DefaultShippingContactId** | **string** | It is a parameter that allows to identify in the response, the Femsa ID of the shipping address (shipping_contact) | [optional] 
**Corporate** | **bool** | It is a value that allows identifying if the email is corporate or not. | [optional] [default to false]
**CustomReference** | **string** | It is an undefined value. | [optional] 
**FiscalEntities** | [**List&lt;CustomerFiscalEntitiesRequest&gt;**](CustomerFiscalEntitiesRequest.md) |  | [optional] 
**Metadata** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**PaymentSources** | [**List&lt;CustomerPaymentMethodsRequest&gt;**](CustomerPaymentMethodsRequest.md) | Contains details of the payment methods that the customer has active or has used in Femsa | [optional] 
**ShippingContacts** | [**List&lt;CustomerShippingContacts&gt;**](CustomerShippingContacts.md) | Contains the detail of the shipping addresses that the client has active or has used in Femsa | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

