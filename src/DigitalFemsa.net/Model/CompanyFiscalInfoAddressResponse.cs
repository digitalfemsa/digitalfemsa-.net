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
    /// Company fiscal info address model
    /// </summary>
    [DataContract(Name = "company_fiscal_info_address_response")]
    public partial class CompanyFiscalInfoAddressResponse : IValidatableObject
    {
        /// <summary>
        /// The resource&#39;s type
        /// </summary>
        /// <value>The resource&#39;s type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ObjectEnum
        {
            /// <summary>
            /// Enum Address for value: address
            /// </summary>
            [EnumMember(Value = "address")]
            Address = 1
        }


        /// <summary>
        /// The resource&#39;s type
        /// </summary>
        /// <value>The resource&#39;s type</value>
        [DataMember(Name = "object", EmitDefaultValue = false)]
        public ObjectEnum? Object { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyFiscalInfoAddressResponse" /> class.
        /// </summary>
        /// <param name="varObject">The resource&#39;s type.</param>
        /// <param name="street1">Street Address.</param>
        /// <param name="street2">Colonia.</param>
        /// <param name="city">City.</param>
        /// <param name="state">State.</param>
        /// <param name="country">Country.</param>
        /// <param name="postalCode">Postal code.</param>
        /// <param name="externalNumber">Street number.</param>
        /// <param name="internalNumber">Unit / apartment number.</param>
        public CompanyFiscalInfoAddressResponse(ObjectEnum? varObject = default(ObjectEnum?), string street1 = default(string), string street2 = default(string), string city = default(string), string state = default(string), string country = default(string), string postalCode = default(string), string externalNumber = default(string), string internalNumber = default(string))
        {
            this.Object = varObject;
            this.Street1 = street1;
            this.Street2 = street2;
            this.City = city;
            this.State = state;
            this.Country = country;
            this.PostalCode = postalCode;
            this.ExternalNumber = externalNumber;
            this.InternalNumber = internalNumber;
        }

        /// <summary>
        /// Street Address
        /// </summary>
        /// <value>Street Address</value>
        /// <example>Calle 13</example>
        [DataMember(Name = "street1", EmitDefaultValue = false)]
        public string Street1 { get; set; }

        /// <summary>
        /// Colonia
        /// </summary>
        /// <value>Colonia</value>
        /// <example>Navarte</example>
        [DataMember(Name = "street2", EmitDefaultValue = false)]
        public string Street2 { get; set; }

        /// <summary>
        /// City
        /// </summary>
        /// <value>City</value>
        /// <example>Cuauhtémoc</example>
        [DataMember(Name = "city", EmitDefaultValue = false)]
        public string City { get; set; }

        /// <summary>
        /// State
        /// </summary>
        /// <value>State</value>
        /// <example>Ciudad de México</example>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public string State { get; set; }

        /// <summary>
        /// Country
        /// </summary>
        /// <value>Country</value>
        /// <example>MX</example>
        [DataMember(Name = "country", EmitDefaultValue = false)]
        public string Country { get; set; }

        /// <summary>
        /// Postal code
        /// </summary>
        /// <value>Postal code</value>
        /// <example>3072</example>
        [DataMember(Name = "postal_code", EmitDefaultValue = false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Street number
        /// </summary>
        /// <value>Street number</value>
        /// <example>123</example>
        [DataMember(Name = "external_number", EmitDefaultValue = false)]
        public string ExternalNumber { get; set; }

        /// <summary>
        /// Unit / apartment number
        /// </summary>
        /// <value>Unit / apartment number</value>
        /// <example>123</example>
        [DataMember(Name = "internal_number", EmitDefaultValue = false)]
        public string InternalNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CompanyFiscalInfoAddressResponse {\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
            sb.Append("  Street1: ").Append(Street1).Append("\n");
            sb.Append("  Street2: ").Append(Street2).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  ExternalNumber: ").Append(ExternalNumber).Append("\n");
            sb.Append("  InternalNumber: ").Append(InternalNumber).Append("\n");
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
