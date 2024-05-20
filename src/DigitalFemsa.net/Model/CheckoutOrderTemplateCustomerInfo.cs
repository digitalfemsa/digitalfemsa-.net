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
using System.Reflection;

namespace DigitalFemsa.net.Model
{
    /// <summary>
    /// It is the information of the customer who will be created when receiving a new payment.
    /// </summary>
    [JsonConverter(typeof(CheckoutOrderTemplateCustomerInfoJsonConverter))]
    [DataContract(Name = "checkout_order_template_customer_info")]
    public partial class CheckoutOrderTemplateCustomerInfo : AbstractOpenAPISchema, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckoutOrderTemplateCustomerInfo" /> class
        /// with the <see cref="CustomerInfo" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of CustomerInfo.</param>
        public CheckoutOrderTemplateCustomerInfo(CustomerInfo actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckoutOrderTemplateCustomerInfo" /> class
        /// with the <see cref="CustomerInfoJustCustomerId" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of CustomerInfoJustCustomerId.</param>
        public CheckoutOrderTemplateCustomerInfo(CustomerInfoJustCustomerId actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }


        private Object _actualInstance;

        /// <summary>
        /// Gets or Sets ActualInstance
        /// </summary>
        public override Object ActualInstance
        {
            get
            {
                return _actualInstance;
            }
            set
            {
                if (value.GetType() == typeof(CustomerInfo))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(CustomerInfoJustCustomerId))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: CustomerInfo, CustomerInfoJustCustomerId");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `CustomerInfo`. If the actual instance is not `CustomerInfo`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of CustomerInfo</returns>
        public CustomerInfo GetCustomerInfo()
        {
            return (CustomerInfo)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `CustomerInfoJustCustomerId`. If the actual instance is not `CustomerInfoJustCustomerId`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of CustomerInfoJustCustomerId</returns>
        public CustomerInfoJustCustomerId GetCustomerInfoJustCustomerId()
        {
            return (CustomerInfoJustCustomerId)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckoutOrderTemplateCustomerInfo {\n");
            sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this.ActualInstance, CheckoutOrderTemplateCustomerInfo.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of CheckoutOrderTemplateCustomerInfo
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of CheckoutOrderTemplateCustomerInfo</returns>
        public static CheckoutOrderTemplateCustomerInfo FromJson(string jsonString)
        {
            CheckoutOrderTemplateCustomerInfo newCheckoutOrderTemplateCustomerInfo = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newCheckoutOrderTemplateCustomerInfo;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(CustomerInfo).GetProperty("AdditionalProperties") == null)
                {
                    newCheckoutOrderTemplateCustomerInfo = new CheckoutOrderTemplateCustomerInfo(JsonConvert.DeserializeObject<CustomerInfo>(jsonString, CheckoutOrderTemplateCustomerInfo.SerializerSettings));
                }
                else
                {
                    newCheckoutOrderTemplateCustomerInfo = new CheckoutOrderTemplateCustomerInfo(JsonConvert.DeserializeObject<CustomerInfo>(jsonString, CheckoutOrderTemplateCustomerInfo.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("CustomerInfo");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into CustomerInfo: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(CustomerInfoJustCustomerId).GetProperty("AdditionalProperties") == null)
                {
                    newCheckoutOrderTemplateCustomerInfo = new CheckoutOrderTemplateCustomerInfo(JsonConvert.DeserializeObject<CustomerInfoJustCustomerId>(jsonString, CheckoutOrderTemplateCustomerInfo.SerializerSettings));
                }
                else
                {
                    newCheckoutOrderTemplateCustomerInfo = new CheckoutOrderTemplateCustomerInfo(JsonConvert.DeserializeObject<CustomerInfoJustCustomerId>(jsonString, CheckoutOrderTemplateCustomerInfo.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("CustomerInfoJustCustomerId");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into CustomerInfoJustCustomerId: {1}", jsonString, exception.ToString()));
            }

            if (match == 0)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
            }
            else if (match > 1)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` incorrectly matches more than one schema (should be exactly one match): " + String.Join(",", matchedTypes));
            }

            // deserialization is considered successful at this point if no exception has been thrown.
            return newCheckoutOrderTemplateCustomerInfo;
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

    /// <summary>
    /// Custom JSON converter for CheckoutOrderTemplateCustomerInfo
    /// </summary>
    public class CheckoutOrderTemplateCustomerInfoJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(CheckoutOrderTemplateCustomerInfo).GetMethod("ToJson").Invoke(value, null)));
        }

        /// <summary>
        /// To convert a JSON string into an object
        /// </summary>
        /// <param name="reader">JSON reader</param>
        /// <param name="objectType">Object type</param>
        /// <param name="existingValue">Existing value</param>
        /// <param name="serializer">JSON Serializer</param>
        /// <returns>The object converted from the JSON string</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            switch(reader.TokenType) 
            {
                case JsonToken.StartObject:
                    return CheckoutOrderTemplateCustomerInfo.FromJson(JObject.Load(reader).ToString(Formatting.None));
                case JsonToken.StartArray:
                    return CheckoutOrderTemplateCustomerInfo.FromJson(JArray.Load(reader).ToString(Formatting.None));
                default:
                    return null;
            }
        }

        /// <summary>
        /// Check if the object can be converted
        /// </summary>
        /// <param name="objectType">Object type</param>
        /// <returns>True if the object can be converted</returns>
        public override bool CanConvert(Type objectType)
        {
            return false;
        }
    }

}