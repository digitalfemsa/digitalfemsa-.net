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
    /// page metadata
    /// </summary>
    [DataContract(Name = "page")]
    public partial class Page : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Page" /> class.
        /// </summary>
        /// <param name="nextPageUrl">URL of the next page..</param>
        /// <param name="previousPageUrl">Url of the previous page..</param>
        public Page(string nextPageUrl = default(string), string previousPageUrl = default(string))
        {
            this.NextPageUrl = nextPageUrl;
            this.PreviousPageUrl = previousPageUrl;
        }

        /// <summary>
        /// URL of the next page.
        /// </summary>
        /// <value>URL of the next page.</value>
        /// <example>https://api.femsa.io/resources?limit&#x3D;10&amp;next&#x3D;chrg_1</example>
        [DataMember(Name = "next_page_url", EmitDefaultValue = true)]
        public string NextPageUrl { get; set; }

        /// <summary>
        /// Url of the previous page.
        /// </summary>
        /// <value>Url of the previous page.</value>
        /// <example>https://api.femsa.io/resources?limit&#x3D;10&amp;previous&#x3D;chrg_1</example>
        [DataMember(Name = "previous_page_url", EmitDefaultValue = true)]
        public string PreviousPageUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Page {\n");
            sb.Append("  NextPageUrl: ").Append(NextPageUrl).Append("\n");
            sb.Append("  PreviousPageUrl: ").Append(PreviousPageUrl).Append("\n");
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
