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
    /// create new taxes for an existing order
    /// </summary>
    [DataContract(Name = "update_order_tax_request")]
    public partial class UpdateOrderTaxRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateOrderTaxRequest" /> class.
        /// </summary>
        /// <param name="amount">The amount to be collected for tax in cents.</param>
        /// <param name="description">description or tax&#39;s name.</param>
        /// <param name="metadata">metadata.</param>
        public UpdateOrderTaxRequest(long amount = default(long), string description = default(string), Dictionary<string, Object> metadata = default(Dictionary<string, Object>))
        {
            this.Amount = amount;
            this.Description = description;
            this.Metadata = metadata;
        }

        /// <summary>
        /// The amount to be collected for tax in cents
        /// </summary>
        /// <value>The amount to be collected for tax in cents</value>
        /// <example>100</example>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public long Amount { get; set; }

        /// <summary>
        /// description or tax&#39;s name
        /// </summary>
        /// <value>description or tax&#39;s name</value>
        /// <example>testing</example>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public Dictionary<string, Object> Metadata { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateOrderTaxRequest {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
            // Amount (long) minimum
            if (this.Amount < (long)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Amount, must be a value greater than or equal to 0.", new [] { "Amount" });
            }

            // Description (string) minLength
            if (this.Description != null && this.Description.Length < 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be greater than 2.", new [] { "Description" });
            }

            yield break;
        }
    }

}
