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
    /// balance common fields model
    /// </summary>
    [DataContract(Name = "balance_common_field")]
    public partial class BalanceCommonField : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BalanceCommonField" /> class.
        /// </summary>
        /// <param name="amount">The balance&#39;s amount.</param>
        /// <param name="currency">The balance&#39;s currency.</param>
        public BalanceCommonField(long amount = default(long), string currency = default(string))
        {
            this.Amount = amount;
            this.Currency = currency;
        }

        /// <summary>
        /// The balance&#39;s amount
        /// </summary>
        /// <value>The balance&#39;s amount</value>
        /// <example>100</example>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public long Amount { get; set; }

        /// <summary>
        /// The balance&#39;s currency
        /// </summary>
        /// <value>The balance&#39;s currency</value>
        /// <example>MXN</example>
        [DataMember(Name = "currency", EmitDefaultValue = false)]
        public string Currency { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BalanceCommonField {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
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