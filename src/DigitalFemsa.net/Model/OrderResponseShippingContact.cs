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
    /// OrderResponseShippingContact
    /// </summary>
    [DataContract(Name = "order_response_shipping_contact")]
    public partial class OrderResponseShippingContact : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderResponseShippingContact" /> class.
        /// </summary>
        /// <param name="phone">phone.</param>
        /// <param name="receiver">receiver.</param>
        /// <param name="betweenStreets">betweenStreets.</param>
        /// <param name="address">address.</param>
        /// <param name="parentId">parentId.</param>
        /// <param name="varDefault">varDefault.</param>
        /// <param name="id">id.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="metadata">Metadata associated with the shipping contact.</param>
        /// <param name="varObject">varObject.</param>
        /// <param name="deleted">deleted.</param>
        public OrderResponseShippingContact(string phone = default(string), string receiver = default(string), string betweenStreets = default(string), CustomerShippingContactsResponseAddress address = default(CustomerShippingContactsResponseAddress), string parentId = default(string), bool varDefault = default(bool), string id = default(string), long createdAt = default(long), Dictionary<string, Object> metadata = default(Dictionary<string, Object>), string varObject = default(string), bool deleted = default(bool))
        {
            this.Phone = phone;
            this.Receiver = receiver;
            this.BetweenStreets = betweenStreets;
            this.Address = address;
            this.ParentId = parentId;
            this.Default = varDefault;
            this.Id = id;
            this.CreatedAt = createdAt;
            this.Metadata = metadata;
            this.Object = varObject;
            this.Deleted = deleted;
        }

        /// <summary>
        /// Gets or Sets Phone
        /// </summary>
        /// <example>+525511223344</example>
        [DataMember(Name = "phone", EmitDefaultValue = false)]
        public string Phone { get; set; }

        /// <summary>
        /// Gets or Sets Receiver
        /// </summary>
        /// <example>Marvin Fuller</example>
        [DataMember(Name = "receiver", EmitDefaultValue = false)]
        public string Receiver { get; set; }

        /// <summary>
        /// Gets or Sets BetweenStreets
        /// </summary>
        /// <example>Ackerman Crescent</example>
        [DataMember(Name = "between_streets", EmitDefaultValue = true)]
        public string BetweenStreets { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        public CustomerShippingContactsResponseAddress Address { get; set; }

        /// <summary>
        /// Gets or Sets ParentId
        /// </summary>
        [DataMember(Name = "parent_id", EmitDefaultValue = false)]
        public string ParentId { get; set; }

        /// <summary>
        /// Gets or Sets Default
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "default", EmitDefaultValue = true)]
        public bool Default { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public long CreatedAt { get; set; }

        /// <summary>
        /// Metadata associated with the shipping contact
        /// </summary>
        /// <value>Metadata associated with the shipping contact</value>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public Dictionary<string, Object> Metadata { get; set; }

        /// <summary>
        /// Gets or Sets Object
        /// </summary>
        [DataMember(Name = "object", EmitDefaultValue = false)]
        public string Object { get; set; }

        /// <summary>
        /// Gets or Sets Deleted
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "deleted", EmitDefaultValue = true)]
        public bool Deleted { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderResponseShippingContact {\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  Receiver: ").Append(Receiver).Append("\n");
            sb.Append("  BetweenStreets: ").Append(BetweenStreets).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  ParentId: ").Append(ParentId).Append("\n");
            sb.Append("  Default: ").Append(Default).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
            sb.Append("  Deleted: ").Append(Deleted).Append("\n");
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