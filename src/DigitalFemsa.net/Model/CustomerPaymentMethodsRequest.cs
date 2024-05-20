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
    /// CustomerPaymentMethodsRequest
    /// </summary>
    [JsonConverter(typeof(CustomerPaymentMethodsRequestJsonConverter))]
    [DataContract(Name = "customer_payment_methods_request")]
    public partial class CustomerPaymentMethodsRequest : AbstractOpenAPISchema, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerPaymentMethodsRequest" /> class
        /// with the <see cref="PaymentMethodCashRequest" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of PaymentMethodCashRequest.</param>
        public CustomerPaymentMethodsRequest(PaymentMethodCashRequest actualInstance)
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
                if (value.GetType() == typeof(PaymentMethodCashRequest))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: PaymentMethodCashRequest");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `PaymentMethodCashRequest`. If the actual instance is not `PaymentMethodCashRequest`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of PaymentMethodCashRequest</returns>
        public PaymentMethodCashRequest GetPaymentMethodCashRequest()
        {
            return (PaymentMethodCashRequest)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomerPaymentMethodsRequest {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, CustomerPaymentMethodsRequest.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of CustomerPaymentMethodsRequest
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of CustomerPaymentMethodsRequest</returns>
        public static CustomerPaymentMethodsRequest FromJson(string jsonString)
        {
            CustomerPaymentMethodsRequest newCustomerPaymentMethodsRequest = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newCustomerPaymentMethodsRequest;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(PaymentMethodCashRequest).GetProperty("AdditionalProperties") == null)
                {
                    newCustomerPaymentMethodsRequest = new CustomerPaymentMethodsRequest(JsonConvert.DeserializeObject<PaymentMethodCashRequest>(jsonString, CustomerPaymentMethodsRequest.SerializerSettings));
                }
                else
                {
                    newCustomerPaymentMethodsRequest = new CustomerPaymentMethodsRequest(JsonConvert.DeserializeObject<PaymentMethodCashRequest>(jsonString, CustomerPaymentMethodsRequest.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("PaymentMethodCashRequest");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into PaymentMethodCashRequest: {1}", jsonString, exception.ToString()));
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
            return newCustomerPaymentMethodsRequest;
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
    /// Custom JSON converter for CustomerPaymentMethodsRequest
    /// </summary>
    public class CustomerPaymentMethodsRequestJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(CustomerPaymentMethodsRequest).GetMethod("ToJson").Invoke(value, null)));
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
                    return CustomerPaymentMethodsRequest.FromJson(JObject.Load(reader).ToString(Formatting.None));
                case JsonToken.StartArray:
                    return CustomerPaymentMethodsRequest.FromJson(JArray.Load(reader).ToString(Formatting.None));
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
