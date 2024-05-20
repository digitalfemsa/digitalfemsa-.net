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
    [DataContract(Name = "order_update_request")]
    public partial class OrderUpdateRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderUpdateRequest" /> class.
        /// </summary>
        /// <param name="charges">charges.</param>
        /// <param name="checkout">checkout.</param>
        /// <param name="currency">Currency with which the payment will be made. It uses the 3-letter code of the [International Standard ISO 4217.](https://es.wikipedia.org/wiki/ISO_4217).</param>
        /// <param name="customerInfo">customerInfo.</param>
        /// <param name="discountLines">List of [discounts](https://developers.femsa.com/v2.1.0/reference/orderscreatediscountline) that are applied to the order. You must have at least one discount..</param>
        /// <param name="fiscalEntity">fiscalEntity.</param>
        /// <param name="lineItems">List of [products](https://developers.femsa.com/v2.1.0/reference/orderscreateproduct) that are sold in the order. You must have at least one product..</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="preAuthorize">Indicates whether the order charges must be preauthorized (default to false).</param>
        /// <param name="shippingContact">shippingContact.</param>
        /// <param name="shippingLines">List of [shipping costs](https://developers.femsa.com/v2.1.0/reference/orderscreateshipping). If the online store offers digital products..</param>
        /// <param name="taxLines">taxLines.</param>
        public OrderUpdateRequest(List<ChargeRequest> charges = default(List<ChargeRequest>), CheckoutRequest checkout = default(CheckoutRequest), string currency = default(string), OrderUpdateRequestCustomerInfo customerInfo = default(OrderUpdateRequestCustomerInfo), List<OrderDiscountLinesRequest> discountLines = default(List<OrderDiscountLinesRequest>), OrderUpdateFiscalEntityRequest fiscalEntity = default(OrderUpdateFiscalEntityRequest), List<Product> lineItems = default(List<Product>), Dictionary<string, string> metadata = default(Dictionary<string, string>), bool preAuthorize = false, CustomerShippingContacts shippingContact = default(CustomerShippingContacts), List<ShippingRequest> shippingLines = default(List<ShippingRequest>), List<OrderTaxRequest> taxLines = default(List<OrderTaxRequest>))
        {
            this.Charges = charges;
            this.Checkout = checkout;
            this.Currency = currency;
            this.CustomerInfo = customerInfo;
            this.DiscountLines = discountLines;
            this.FiscalEntity = fiscalEntity;
            this.LineItems = lineItems;
            this.Metadata = metadata;
            this.PreAuthorize = preAuthorize;
            this.ShippingContact = shippingContact;
            this.ShippingLines = shippingLines;
            this.TaxLines = taxLines;
        }

        /// <summary>
        /// Gets or Sets Charges
        /// </summary>
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
        [DataMember(Name = "currency", EmitDefaultValue = false)]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or Sets CustomerInfo
        /// </summary>
        [DataMember(Name = "customer_info", EmitDefaultValue = false)]
        public OrderUpdateRequestCustomerInfo CustomerInfo { get; set; }

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
        public OrderUpdateFiscalEntityRequest FiscalEntity { get; set; }

        /// <summary>
        /// List of [products](https://developers.femsa.com/v2.1.0/reference/orderscreateproduct) that are sold in the order. You must have at least one product.
        /// </summary>
        /// <value>List of [products](https://developers.femsa.com/v2.1.0/reference/orderscreateproduct) that are sold in the order. You must have at least one product.</value>
        [DataMember(Name = "line_items", EmitDefaultValue = false)]
        public List<Product> LineItems { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Indicates whether the order charges must be preauthorized
        /// </summary>
        /// <value>Indicates whether the order charges must be preauthorized</value>
        [DataMember(Name = "pre_authorize", EmitDefaultValue = true)]
        public bool PreAuthorize { get; set; }

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
        /// Gets or Sets TaxLines
        /// </summary>
        [DataMember(Name = "tax_lines", EmitDefaultValue = false)]
        public List<OrderTaxRequest> TaxLines { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderUpdateRequest {\n");
            sb.Append("  Charges: ").Append(Charges).Append("\n");
            sb.Append("  Checkout: ").Append(Checkout).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  CustomerInfo: ").Append(CustomerInfo).Append("\n");
            sb.Append("  DiscountLines: ").Append(DiscountLines).Append("\n");
            sb.Append("  FiscalEntity: ").Append(FiscalEntity).Append("\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  PreAuthorize: ").Append(PreAuthorize).Append("\n");
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
