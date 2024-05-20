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
    /// CustomerInfoJustCustomerId
    /// </summary>
    [DataContract(Name = "customer_info_just_customer_id")]
    public partial class CustomerInfoJustCustomerId : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerInfoJustCustomerId" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CustomerInfoJustCustomerId() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerInfoJustCustomerId" /> class.
        /// </summary>
        /// <param name="customerId">customerId (required).</param>
        public CustomerInfoJustCustomerId(string customerId = default(string))
        {
            // to ensure "customerId" is required (not null)
            if (customerId == null)
            {
                throw new ArgumentNullException("customerId is a required property for CustomerInfoJustCustomerId and cannot be null");
            }
            this.CustomerId = customerId;
        }

        /// <summary>
        /// Gets or Sets CustomerId
        /// </summary>
        /// <example>cus_23874283647</example>
        [DataMember(Name = "customer_id", IsRequired = true, EmitDefaultValue = true)]
        public string CustomerId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CustomerInfoJustCustomerId {\n");
            sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
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