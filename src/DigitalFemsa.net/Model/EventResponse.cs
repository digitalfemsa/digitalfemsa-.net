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
    /// event model
    /// </summary>
    [DataContract(Name = "event_response")]
    public partial class EventResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventResponse" /> class.
        /// </summary>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="data">data.</param>
        /// <param name="id">id.</param>
        /// <param name="livemode">livemode.</param>
        /// <param name="varObject">varObject.</param>
        /// <param name="type">type.</param>
        /// <param name="webhookLogs">webhookLogs.</param>
        /// <param name="webhookStatus">webhookStatus.</param>
        public EventResponse(long createdAt = default(long), Dictionary<string, Object> data = default(Dictionary<string, Object>), string id = default(string), bool livemode = default(bool), string varObject = default(string), string type = default(string), List<WebhookLog> webhookLogs = default(List<WebhookLog>), string webhookStatus = default(string))
        {
            this.CreatedAt = createdAt;
            this.Data = data;
            this.Id = id;
            this.Livemode = livemode;
            this.Object = varObject;
            this.Type = type;
            this.WebhookLogs = webhookLogs;
            this.WebhookStatus = webhookStatus;
        }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        /// <example>1661445644</example>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public long CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        /// <example>{&quot;action&quot;:&quot;ping&quot;,&quot;livemode&quot;:true}</example>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public Dictionary<string, Object> Data { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        /// <example>6307a60c41de27127515a575</example>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Livemode
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "livemode", EmitDefaultValue = true)]
        public bool Livemode { get; set; }

        /// <summary>
        /// Gets or Sets Object
        /// </summary>
        /// <example>event</example>
        [DataMember(Name = "object", EmitDefaultValue = false)]
        public string Object { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        /// <example>webhook_ping</example>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets WebhookLogs
        /// </summary>
        [DataMember(Name = "webhook_logs", EmitDefaultValue = false)]
        public List<WebhookLog> WebhookLogs { get; set; }

        /// <summary>
        /// Gets or Sets WebhookStatus
        /// </summary>
        /// <example>successful</example>
        [DataMember(Name = "webhook_status", EmitDefaultValue = false)]
        public string WebhookStatus { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EventResponse {\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Livemode: ").Append(Livemode).Append("\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  WebhookLogs: ").Append(WebhookLogs).Append("\n");
            sb.Append("  WebhookStatus: ").Append(WebhookStatus).Append("\n");
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