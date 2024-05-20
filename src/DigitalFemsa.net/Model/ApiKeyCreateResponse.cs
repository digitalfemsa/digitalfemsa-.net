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
    /// ApiKeyCreateResponse
    /// </summary>
    [DataContract(Name = "api_key_create_response")]
    public partial class ApiKeyCreateResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeyCreateResponse" /> class.
        /// </summary>
        /// <param name="active">Indicates if the api key is active.</param>
        /// <param name="createdAt">Unix timestamp in seconds of when the api key was created.</param>
        /// <param name="updatedAt">Unix timestamp in seconds of when the api key was last updated.</param>
        /// <param name="deactivatedAt">Unix timestamp in seconds of when the api key was deleted.</param>
        /// <param name="description">A name or brief explanation of what this api key is used for.</param>
        /// <param name="id">Unique identifier of the api key.</param>
        /// <param name="livemode">Indicates if the api key is in production.</param>
        /// <param name="deleted">Indicates if the api key was deleted.</param>
        /// <param name="varObject">Object name, value is &#39;api_key&#39;.</param>
        /// <param name="prefix">The first few characters of the authentication_token.</param>
        /// <param name="role">Indicates if the api key is private or public.</param>
        /// <param name="authenticationToken">It is occupied as a user when authenticated with basic authentication, with a blank password. This value will only appear once, in the request to create a new key. Copy and save it in a safe place..</param>
        public ApiKeyCreateResponse(bool active = default(bool), long createdAt = default(long), long updatedAt = default(long), long? deactivatedAt = default(long?), string description = default(string), string id = default(string), bool livemode = default(bool), bool deleted = default(bool), string varObject = default(string), string prefix = default(string), string role = default(string), string authenticationToken = default(string))
        {
            this.Active = active;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.DeactivatedAt = deactivatedAt;
            this.Description = description;
            this.Id = id;
            this.Livemode = livemode;
            this.Deleted = deleted;
            this.Object = varObject;
            this.Prefix = prefix;
            this.Role = role;
            this.AuthenticationToken = authenticationToken;
        }

        /// <summary>
        /// Indicates if the api key is active
        /// </summary>
        /// <value>Indicates if the api key is active</value>
        /// <example>true</example>
        [DataMember(Name = "active", EmitDefaultValue = true)]
        public bool Active { get; set; }

        /// <summary>
        /// Unix timestamp in seconds of when the api key was created
        /// </summary>
        /// <value>Unix timestamp in seconds of when the api key was created</value>
        /// <example>1684167881</example>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public long CreatedAt { get; set; }

        /// <summary>
        /// Unix timestamp in seconds of when the api key was last updated
        /// </summary>
        /// <value>Unix timestamp in seconds of when the api key was last updated</value>
        /// <example>1684167923</example>
        [DataMember(Name = "updated_at", EmitDefaultValue = false)]
        public long UpdatedAt { get; set; }

        /// <summary>
        /// Unix timestamp in seconds of when the api key was deleted
        /// </summary>
        /// <value>Unix timestamp in seconds of when the api key was deleted</value>
        [DataMember(Name = "deactivated_at", EmitDefaultValue = true)]
        public long? DeactivatedAt { get; set; }

        /// <summary>
        /// A name or brief explanation of what this api key is used for
        /// </summary>
        /// <value>A name or brief explanation of what this api key is used for</value>
        /// <example>online store</example>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Unique identifier of the api key
        /// </summary>
        /// <value>Unique identifier of the api key</value>
        /// <example>64625cc9f3e02c00163f5e4d</example>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Indicates if the api key is in production
        /// </summary>
        /// <value>Indicates if the api key is in production</value>
        /// <example>false</example>
        [DataMember(Name = "livemode", EmitDefaultValue = true)]
        public bool Livemode { get; set; }

        /// <summary>
        /// Indicates if the api key was deleted
        /// </summary>
        /// <value>Indicates if the api key was deleted</value>
        /// <example>false</example>
        [DataMember(Name = "deleted", EmitDefaultValue = true)]
        public bool Deleted { get; set; }

        /// <summary>
        /// Object name, value is &#39;api_key&#39;
        /// </summary>
        /// <value>Object name, value is &#39;api_key&#39;</value>
        /// <example>api_key</example>
        [DataMember(Name = "object", EmitDefaultValue = false)]
        public string Object { get; set; }

        /// <summary>
        /// The first few characters of the authentication_token
        /// </summary>
        /// <value>The first few characters of the authentication_token</value>
        /// <example>key_rp</example>
        [DataMember(Name = "prefix", EmitDefaultValue = false)]
        public string Prefix { get; set; }

        /// <summary>
        /// Indicates if the api key is private or public
        /// </summary>
        /// <value>Indicates if the api key is private or public</value>
        /// <example>private</example>
        [DataMember(Name = "role", EmitDefaultValue = false)]
        public string Role { get; set; }

        /// <summary>
        /// It is occupied as a user when authenticated with basic authentication, with a blank password. This value will only appear once, in the request to create a new key. Copy and save it in a safe place.
        /// </summary>
        /// <value>It is occupied as a user when authenticated with basic authentication, with a blank password. This value will only appear once, in the request to create a new key. Copy and save it in a safe place.</value>
        /// <example>key_rpHzxufNgjFCdprEEFZRTKi</example>
        [DataMember(Name = "authentication_token", EmitDefaultValue = false)]
        public string AuthenticationToken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ApiKeyCreateResponse {\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  DeactivatedAt: ").Append(DeactivatedAt).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Livemode: ").Append(Livemode).Append("\n");
            sb.Append("  Deleted: ").Append(Deleted).Append("\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
            sb.Append("  Prefix: ").Append(Prefix).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
            sb.Append("  AuthenticationToken: ").Append(AuthenticationToken).Append("\n");
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
