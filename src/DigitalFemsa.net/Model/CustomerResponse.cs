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
    /// customer response
    /// </summary>
    [DataContract(Name = "customer_response")]
    public partial class CustomerResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CustomerResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerResponse" /> class.
        /// </summary>
        /// <param name="antifraudInfo">antifraudInfo.</param>
        /// <param name="corporate">true if the customer is a company.</param>
        /// <param name="createdAt">Creation date of the object (required).</param>
        /// <param name="customReference">Custom reference.</param>
        /// <param name="defaultFiscalEntityId">defaultFiscalEntityId.</param>
        /// <param name="defaultShippingContactId">defaultShippingContactId.</param>
        /// <param name="defaultPaymentSourceId">defaultPaymentSourceId.</param>
        /// <param name="email">email.</param>
        /// <param name="fiscalEntities">fiscalEntities.</param>
        /// <param name="id">Customer&#39;s ID (required).</param>
        /// <param name="livemode">true if the object exists in live mode or the value false if the object exists in test mode (required).</param>
        /// <param name="name">Customer&#39;s name (required).</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="varObject">varObject (required).</param>
        /// <param name="paymentSources">paymentSources.</param>
        /// <param name="phone">Customer&#39;s phone number.</param>
        /// <param name="shippingContacts">shippingContacts.</param>
        public CustomerResponse(CustomerAntifraudInfoResponse antifraudInfo = default(CustomerAntifraudInfoResponse), bool corporate = default(bool), long createdAt = default(long), string customReference = default(string), string defaultFiscalEntityId = default(string), string defaultShippingContactId = default(string), string defaultPaymentSourceId = default(string), string email = default(string), CustomerFiscalEntitiesResponse fiscalEntities = default(CustomerFiscalEntitiesResponse), string id = default(string), bool livemode = default(bool), string name = default(string), Dictionary<string, Object> metadata = default(Dictionary<string, Object>), string varObject = default(string), CustomerPaymentMethodsResponse paymentSources = default(CustomerPaymentMethodsResponse), string phone = default(string), CustomerResponseShippingContacts shippingContacts = default(CustomerResponseShippingContacts))
        {
            this.CreatedAt = createdAt;
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for CustomerResponse and cannot be null");
            }
            this.Id = id;
            this.Livemode = livemode;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for CustomerResponse and cannot be null");
            }
            this.Name = name;
            // to ensure "varObject" is required (not null)
            if (varObject == null)
            {
                throw new ArgumentNullException("varObject is a required property for CustomerResponse and cannot be null");
            }
            this.Object = varObject;
            this.AntifraudInfo = antifraudInfo;
            this.Corporate = corporate;
            this.CustomReference = customReference;
            this.DefaultFiscalEntityId = defaultFiscalEntityId;
            this.DefaultShippingContactId = defaultShippingContactId;
            this.DefaultPaymentSourceId = defaultPaymentSourceId;
            this.Email = email;
            this.FiscalEntities = fiscalEntities;
            this.Metadata = metadata;
            this.PaymentSources = paymentSources;
            this.Phone = phone;
            this.ShippingContacts = shippingContacts;
        }

        /// <summary>
        /// Gets or Sets AntifraudInfo
        /// </summary>
        [DataMember(Name = "antifraud_info", EmitDefaultValue = true)]
        public CustomerAntifraudInfoResponse AntifraudInfo { get; set; }

        /// <summary>
        /// true if the customer is a company
        /// </summary>
        /// <value>true if the customer is a company</value>
        [DataMember(Name = "corporate", EmitDefaultValue = true)]
        public bool Corporate { get; set; }

        /// <summary>
        /// Creation date of the object
        /// </summary>
        /// <value>Creation date of the object</value>
        /// <example>1485151007</example>
        [DataMember(Name = "created_at", IsRequired = true, EmitDefaultValue = true)]
        public long CreatedAt { get; set; }

        /// <summary>
        /// Custom reference
        /// </summary>
        /// <value>Custom reference</value>
        /// <example>custom_reference</example>
        [DataMember(Name = "custom_reference", EmitDefaultValue = false)]
        public string CustomReference { get; set; }

        /// <summary>
        /// Gets or Sets DefaultFiscalEntityId
        /// </summary>
        /// <example>fis_ent_2tKqqAfqPi21oCmEJ</example>
        [DataMember(Name = "default_fiscal_entity_id", EmitDefaultValue = true)]
        public string DefaultFiscalEntityId { get; set; }

        /// <summary>
        /// Gets or Sets DefaultShippingContactId
        /// </summary>
        /// <example>ship_cont_2tKZsTYcsryyu7Ah8</example>
        [DataMember(Name = "default_shipping_contact_id", EmitDefaultValue = false)]
        public string DefaultShippingContactId { get; set; }

        /// <summary>
        /// Gets or Sets DefaultPaymentSourceId
        /// </summary>
        /// <example>src_2tHJfJ79KyUwpxTio</example>
        [DataMember(Name = "default_payment_source_id", EmitDefaultValue = true)]
        public string DefaultPaymentSourceId { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        /// <example>Felipe@gmail.com</example>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets FiscalEntities
        /// </summary>
        [DataMember(Name = "fiscal_entities", EmitDefaultValue = false)]
        public CustomerFiscalEntitiesResponse FiscalEntities { get; set; }

        /// <summary>
        /// Customer&#39;s ID
        /// </summary>
        /// <value>Customer&#39;s ID</value>
        /// <example>cus_2tHJfJ79KyUwpxTik</example>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// true if the object exists in live mode or the value false if the object exists in test mode
        /// </summary>
        /// <value>true if the object exists in live mode or the value false if the object exists in test mode</value>
        /// <example>true</example>
        [DataMember(Name = "livemode", IsRequired = true, EmitDefaultValue = true)]
        public bool Livemode { get; set; }

        /// <summary>
        /// Customer&#39;s name
        /// </summary>
        /// <value>Customer&#39;s name</value>
        /// <example>Felipe</example>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public Dictionary<string, Object> Metadata { get; set; }

        /// <summary>
        /// Gets or Sets Object
        /// </summary>
        /// <example>customer</example>
        [DataMember(Name = "object", IsRequired = true, EmitDefaultValue = true)]
        public string Object { get; set; }

        /// <summary>
        /// Gets or Sets PaymentSources
        /// </summary>
        [DataMember(Name = "payment_sources", EmitDefaultValue = false)]
        public CustomerPaymentMethodsResponse PaymentSources { get; set; }

        /// <summary>
        /// Customer&#39;s phone number
        /// </summary>
        /// <value>Customer&#39;s phone number</value>
        /// <example>+5215555555555</example>
        [DataMember(Name = "phone", EmitDefaultValue = false)]
        public string Phone { get; set; }

        /// <summary>
        /// Gets or Sets ShippingContacts
        /// </summary>
        [DataMember(Name = "shipping_contacts", EmitDefaultValue = false)]
        public CustomerResponseShippingContacts ShippingContacts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CustomerResponse {\n");
            sb.Append("  AntifraudInfo: ").Append(AntifraudInfo).Append("\n");
            sb.Append("  Corporate: ").Append(Corporate).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  CustomReference: ").Append(CustomReference).Append("\n");
            sb.Append("  DefaultFiscalEntityId: ").Append(DefaultFiscalEntityId).Append("\n");
            sb.Append("  DefaultShippingContactId: ").Append(DefaultShippingContactId).Append("\n");
            sb.Append("  DefaultPaymentSourceId: ").Append(DefaultPaymentSourceId).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  FiscalEntities: ").Append(FiscalEntities).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Livemode: ").Append(Livemode).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
            sb.Append("  PaymentSources: ").Append(PaymentSources).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  ShippingContacts: ").Append(ShippingContacts).Append("\n");
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
            yield break;
        }
    }

}
