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
    /// OrderCaptureRequest
    /// </summary>
    [DataContract(Name = "order_capture_request")]
    public partial class OrderCaptureRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderCaptureRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OrderCaptureRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderCaptureRequest" /> class.
        /// </summary>
        /// <param name="amount">Amount to capture (required).</param>
        public OrderCaptureRequest(long amount = default(long))
        {
            this.Amount = amount;
        }

        /// <summary>
        /// Amount to capture
        /// </summary>
        /// <value>Amount to capture</value>
        /// <example>500</example>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = true)]
        public long Amount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderCaptureRequest {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
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
            if (this.Amount < (long)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Amount, must be a value greater than or equal to 1.", new [] { "Amount" });
            }

            yield break;
        }
    }

}
