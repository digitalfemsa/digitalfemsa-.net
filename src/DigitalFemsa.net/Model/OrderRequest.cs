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
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = DigitalFemsa.net.Client.OpenAPIDateConverter;

namespace DigitalFemsa.net.Model
{
    /// <summary>
    /// a order
    /// </summary>
    [DataContract(Name = "order_request")]
    public partial class OrderRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OrderRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderRequest" /> class.
        /// </summary>
        /// <param name="charges">List of [charges](https://developers.femsa.com/v2.1.0/reference/orderscreatecharge) that are applied to the order.</param>
        /// <param name="checkout">checkout.</param>
        /// <param name="currency">Currency with which the payment will be made. It uses the 3-letter code of the [International Standard ISO 4217.](https://es.wikipedia.org/wiki/ISO_4217) (required).</param>
        /// <param name="customerInfo">customerInfo (required).</param>
        /// <param name="discountLines">List of [discounts](https://developers.femsa.com/v2.1.0/reference/orderscreatediscountline) that are applied to the order. You must have at least one discount..</param>
        /// <param name="fiscalEntity">fiscalEntity.</param>
        /// <param name="lineItems">List of [products](https://developers.femsa.com/v2.1.0/reference/orderscreateproduct) that are sold in the order. You must have at least one product. (required).</param>
        /// <param name="metadata">Metadata associated with the order.</param>
        /// <param name="needsShippingContact">Allows you to fill out the shipping information at checkout.</param>
        /// <param name="processingMode">Indicates the processing mode for the order, either ecommerce, recurrent or validation..</param>
        /// <param name="returnUrl">Indicates the redirection callback upon completion of the 3DS2 flow..</param>
        /// <param name="shippingContact">shippingContact.</param>
        /// <param name="shippingLines">List of [shipping costs](https://developers.femsa.com/v2.1.0/reference/orderscreateshipping). If the online store offers digital products..</param>
        /// <param name="taxLines">List of [taxes](https://developers.femsa.com/v2.1.0/reference/orderscreatetaxes) that are applied to the order..</param>
        public OrderRequest(List<ChargeRequest> charges = default(List<ChargeRequest>), CheckoutRequest checkout = default(CheckoutRequest), string currency = default(string), OrderRequestCustomerInfo customerInfo = default(OrderRequestCustomerInfo), List<OrderDiscountLinesRequest> discountLines = default(List<OrderDiscountLinesRequest>), OrderFiscalEntityRequest fiscalEntity = default(OrderFiscalEntityRequest), List<Product> lineItems = default(List<Product>), Dictionary<string, Object> metadata = default(Dictionary<string, Object>), bool needsShippingContact = default(bool), string processingMode = default(string), string returnUrl = default(string), CustomerShippingContacts shippingContact = default(CustomerShippingContacts), List<ShippingRequest> shippingLines = default(List<ShippingRequest>), List<OrderTaxRequest> taxLines = default(List<OrderTaxRequest>))
        {
            // to ensure "currency" is required (not null)
            if (currency == null)
            {
                throw new ArgumentNullException("currency is a required property for OrderRequest and cannot be null");
            }
            this.Currency = currency;
            // to ensure "customerInfo" is required (not null)
            if (customerInfo == null)
            {
                throw new ArgumentNullException("customerInfo is a required property for OrderRequest and cannot be null");
            }
            this.CustomerInfo = customerInfo;
            // to ensure "lineItems" is required (not null)
            if (lineItems == null)
            {
                throw new ArgumentNullException("lineItems is a required property for OrderRequest and cannot be null");
            }
            this.LineItems = lineItems;
            this.Charges = charges;
            this.Checkout = checkout;
            this.DiscountLines = discountLines;
            this.FiscalEntity = fiscalEntity;
            this.Metadata = metadata;
            this.NeedsShippingContact = needsShippingContact;
            this.ProcessingMode = processingMode;
            this.ReturnUrl = returnUrl;
            this.ShippingContact = shippingContact;
            this.ShippingLines = shippingLines;
            this.TaxLines = taxLines;
        }

        /// <summary>
        /// List of [charges](https://developers.femsa.com/v2.1.0/reference/orderscreatecharge) that are applied to the order
        /// </summary>
        /// <value>List of [charges](https://developers.femsa.com/v2.1.0/reference/orderscreatecharge) that are applied to the order</value>
        [DataMember(Name = "charges", EmitDefaultValue = false)]
        public List<ChargeRequest> Charges { get; set; }

        /// <summary>
        /// Gets or Sets Checkout
        /// </summary>
        [DataMember(Name = "checkout", EmitDefaultValue = false)]
        public CheckoutRequest Checkout { get; set; }

        /// <summary>
        /// Currency with which the payment will be made. It uses the 3-letter code of the [International Standard ISO 4217.](https://es.wikipedia.org/wiki/ISO_4217)
        /// </summary>
        /// <value>Currency with which the payment will be made. It uses the 3-letter code of the [International Standard ISO 4217.](https://es.wikipedia.org/wiki/ISO_4217)</value>
        /// <example>MXN</example>
        [DataMember(Name = "currency", IsRequired = true, EmitDefaultValue = true)]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or Sets CustomerInfo
        /// </summary>
        [DataMember(Name = "customer_info", IsRequired = true, EmitDefaultValue = true)]
        public OrderRequestCustomerInfo CustomerInfo { get; set; }

        /// <summary>
        /// List of [discounts](https://developers.femsa.com/v2.1.0/reference/orderscreatediscountline) that are applied to the order. You must have at least one discount.
        /// </summary>
        /// <value>List of [discounts](https://developers.femsa.com/v2.1.0/reference/orderscreatediscountline) that are applied to the order. You must have at least one discount.</value>
        [DataMember(Name = "discount_lines", EmitDefaultValue = false)]
        public List<OrderDiscountLinesRequest> DiscountLines { get; set; }

        /// <summary>
        /// Gets or Sets FiscalEntity
        /// </summary>
        [DataMember(Name = "fiscal_entity", EmitDefaultValue = false)]
        public OrderFiscalEntityRequest FiscalEntity { get; set; }

        /// <summary>
        /// List of [products](https://developers.femsa.com/v2.1.0/reference/orderscreateproduct) that are sold in the order. You must have at least one product.
        /// </summary>
        /// <value>List of [products](https://developers.femsa.com/v2.1.0/reference/orderscreateproduct) that are sold in the order. You must have at least one product.</value>
        [DataMember(Name = "line_items", IsRequired = true, EmitDefaultValue = true)]
        public List<Product> LineItems { get; set; }

        /// <summary>
        /// Metadata associated with the order
        /// </summary>
        /// <value>Metadata associated with the order</value>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public Dictionary<string, Object> Metadata { get; set; }

        /// <summary>
        /// Allows you to fill out the shipping information at checkout
        /// </summary>
        /// <value>Allows you to fill out the shipping information at checkout</value>
        /// <example>false</example>
        [DataMember(Name = "needs_shipping_contact", EmitDefaultValue = true)]
        public bool NeedsShippingContact { get; set; }

        /// <summary>
        /// Indicates the processing mode for the order, either ecommerce, recurrent or validation.
        /// </summary>
        /// <value>Indicates the processing mode for the order, either ecommerce, recurrent or validation.</value>
        /// <example>ecommerce</example>
        [DataMember(Name = "processing_mode", EmitDefaultValue = false)]
        public string ProcessingMode { get; set; }

        /// <summary>
        /// Indicates the redirection callback upon completion of the 3DS2 flow.
        /// </summary>
        /// <value>Indicates the redirection callback upon completion of the 3DS2 flow.</value>
        /// <example>https://my-website.com</example>
        [DataMember(Name = "return_url", EmitDefaultValue = false)]
        public string ReturnUrl { get; set; }

        /// <summary>
        /// Gets or Sets ShippingContact
        /// </summary>
        [DataMember(Name = "shipping_contact", EmitDefaultValue = false)]
        public CustomerShippingContacts ShippingContact { get; set; }

        /// <summary>
        /// List of [shipping costs](https://developers.femsa.com/v2.1.0/reference/orderscreateshipping). If the online store offers digital products.
        /// </summary>
        /// <value>List of [shipping costs](https://developers.femsa.com/v2.1.0/reference/orderscreateshipping). If the online store offers digital products.</value>
        [DataMember(Name = "shipping_lines", EmitDefaultValue = false)]
        public List<ShippingRequest> ShippingLines { get; set; }

        /// <summary>
        /// List of [taxes](https://developers.femsa.com/v2.1.0/reference/orderscreatetaxes) that are applied to the order.
        /// </summary>
        /// <value>List of [taxes](https://developers.femsa.com/v2.1.0/reference/orderscreatetaxes) that are applied to the order.</value>
        [DataMember(Name = "tax_lines", EmitDefaultValue = false)]
        public List<OrderTaxRequest> TaxLines { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderRequest {\n");
            sb.Append("  Charges: ").Append(Charges).Append("\n");
            sb.Append("  Checkout: ").Append(Checkout).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  CustomerInfo: ").Append(CustomerInfo).Append("\n");
            sb.Append("  DiscountLines: ").Append(DiscountLines).Append("\n");
            sb.Append("  FiscalEntity: ").Append(FiscalEntity).Append("\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  NeedsShippingContact: ").Append(NeedsShippingContact).Append("\n");
            sb.Append("  ProcessingMode: ").Append(ProcessingMode).Append("\n");
            sb.Append("  ReturnUrl: ").Append(ReturnUrl).Append("\n");
            sb.Append("  ShippingContact: ").Append(ShippingContact).Append("\n");
            sb.Append("  ShippingLines: ").Append(ShippingLines).Append("\n");
            sb.Append("  TaxLines: ").Append(TaxLines).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // Currency (string) maxLength
            if (this.Currency != null && this.Currency.Length > 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Currency, length must be less than 3.", new [] { "Currency" });
            }

            yield break;
        }
    }

}