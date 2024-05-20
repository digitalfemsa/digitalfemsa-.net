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
    /// DiscountLinesDataResponse
    /// </summary>
    [DataContract(Name = "discount_lines_data_response")]
    public partial class DiscountLinesDataResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DiscountLinesDataResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DiscountLinesDataResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DiscountLinesDataResponse" /> class.
        /// </summary>
        /// <param name="amount">The amount to be deducted from the total sum of all payments, in cents. (required).</param>
        /// <param name="code">Discount code. (required).</param>
        /// <param name="type">It can be &#39;loyalty&#39;, &#39;campaign&#39;, &#39;coupon&#39; o &#39;sign&#39; (required).</param>
        /// <param name="id">The discount line id (required).</param>
        /// <param name="varObject">The object name (required).</param>
        /// <param name="parentId">The order id (required).</param>
        public DiscountLinesDataResponse(long amount = default(long), string code = default(string), string type = default(string), string id = default(string), string varObject = default(string), string parentId = default(string))
        {
            this.Amount = amount;
            // to ensure "code" is required (not null)
            if (code == null)
            {
                throw new ArgumentNullException("code is a required property for DiscountLinesDataResponse and cannot be null");
            }
            this.Code = code;
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new ArgumentNullException("type is a required property for DiscountLinesDataResponse and cannot be null");
            }
            this.Type = type;
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for DiscountLinesDataResponse and cannot be null");
            }
            this.Id = id;
            // to ensure "varObject" is required (not null)
            if (varObject == null)
            {
                throw new ArgumentNullException("varObject is a required property for DiscountLinesDataResponse and cannot be null");
            }
            this.Object = varObject;
            // to ensure "parentId" is required (not null)
            if (parentId == null)
            {
                throw new ArgumentNullException("parentId is a required property for DiscountLinesDataResponse and cannot be null");
            }
            this.ParentId = parentId;
        }

        /// <summary>
        /// The amount to be deducted from the total sum of all payments, in cents.
        /// </summary>
        /// <value>The amount to be deducted from the total sum of all payments, in cents.</value>
        /// <example>500</example>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = true)]
        public long Amount { get; set; }

        /// <summary>
        /// Discount code.
        /// </summary>
        /// <value>Discount code.</value>
        /// <example>123</example>
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = true)]
        public string Code { get; set; }

        /// <summary>
        /// It can be &#39;loyalty&#39;, &#39;campaign&#39;, &#39;coupon&#39; o &#39;sign&#39;
        /// </summary>
        /// <value>It can be &#39;loyalty&#39;, &#39;campaign&#39;, &#39;coupon&#39; o &#39;sign&#39;</value>
        /// <example>loyalty</example>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// The discount line id
        /// </summary>
        /// <value>The discount line id</value>
        /// <example>dis_lin_2tQQ58HPgPw7StE8z</example>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The object name
        /// </summary>
        /// <value>The object name</value>
        /// <example>discount_line</example>
        [DataMember(Name = "object", IsRequired = true, EmitDefaultValue = true)]
        public string Object { get; set; }

        /// <summary>
        /// The order id
        /// </summary>
        /// <value>The order id</value>
        /// <example>ord_2tPAmKCEJqh8RE6nY</example>
        [DataMember(Name = "parent_id", IsRequired = true, EmitDefaultValue = true)]
        public string ParentId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DiscountLinesDataResponse {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
            sb.Append("  ParentId: ").Append(ParentId).Append("\n");
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

            yield break;
        }
    }

}
