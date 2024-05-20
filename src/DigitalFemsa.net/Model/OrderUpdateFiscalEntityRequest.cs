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
    /// Fiscal entity of the order, Currently it is a purely informative field
    /// </summary>
    [DataContract(Name = "order_update_fiscal_entity_request")]
    public partial class OrderUpdateFiscalEntityRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderUpdateFiscalEntityRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OrderUpdateFiscalEntityRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderUpdateFiscalEntityRequest" /> class.
        /// </summary>
        /// <param name="address">address (required).</param>
        /// <param name="email">Email of the fiscal entity.</param>
        /// <param name="name">Name of the fiscal entity.</param>
        /// <param name="metadata">Metadata associated with the fiscal entity.</param>
        /// <param name="phone">Phone of the fiscal entity.</param>
        /// <param name="taxId">Tax ID of the fiscal entity.</param>
        public OrderUpdateFiscalEntityRequest(FiscalEntityAddress address = default(FiscalEntityAddress), string email = default(string), string name = default(string), Dictionary<string, Object> metadata = default(Dictionary<string, Object>), string phone = default(string), string taxId = default(string))
        {
            // to ensure "address" is required (not null)
            if (address == null)
            {
                throw new ArgumentNullException("address is a required property for OrderUpdateFiscalEntityRequest and cannot be null");
            }
            this.Address = address;
            this.Email = email;
            this.Name = name;
            this.Metadata = metadata;
            this.Phone = phone;
            this.TaxId = taxId;
        }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name = "address", IsRequired = true, EmitDefaultValue = true)]
        public FiscalEntityAddress Address { get; set; }

        /// <summary>
        /// Email of the fiscal entity
        /// </summary>
        /// <value>Email of the fiscal entity</value>
        /// <example>test@gmail.com</example>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// Name of the fiscal entity
        /// </summary>
        /// <value>Name of the fiscal entity</value>
        /// <example>Femsa Inc</example>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Metadata associated with the fiscal entity
        /// </summary>
        /// <value>Metadata associated with the fiscal entity</value>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public Dictionary<string, Object> Metadata { get; set; }

        /// <summary>
        /// Phone of the fiscal entity
        /// </summary>
        /// <value>Phone of the fiscal entity</value>
        /// <example>+525511223344</example>
        [DataMember(Name = "phone", EmitDefaultValue = false)]
        public string Phone { get; set; }

        /// <summary>
        /// Tax ID of the fiscal entity
        /// </summary>
        /// <value>Tax ID of the fiscal entity</value>
        /// <example>AAA010101AAA</example>
        [DataMember(Name = "tax_id", EmitDefaultValue = true)]
        public string TaxId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderUpdateFiscalEntityRequest {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  TaxId: ").Append(TaxId).Append("\n");
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