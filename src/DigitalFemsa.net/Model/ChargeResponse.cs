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
    /// ChargeResponse
    /// </summary>
    [DataContract(Name = "charge_response")]
    public partial class ChargeResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChargeResponse" /> class.
        /// </summary>
        /// <param name="amount">amount.</param>
        /// <param name="channel">channel.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="currency">currency.</param>
        /// <param name="customerId">customerId.</param>
        /// <param name="description">description.</param>
        /// <param name="deviceFingerprint">deviceFingerprint.</param>
        /// <param name="failureCode">failureCode.</param>
        /// <param name="failureMessage">failureMessage.</param>
        /// <param name="id">id.</param>
        /// <param name="livemode">livemode.</param>
        /// <param name="varObject">varObject.</param>
        /// <param name="orderId">orderId.</param>
        /// <param name="paidAt">paidAt.</param>
        /// <param name="paymentMethod">paymentMethod.</param>
        /// <param name="referenceId">Reference ID of the charge.</param>
        /// <param name="refunds">refunds.</param>
        /// <param name="status">status.</param>
        public ChargeResponse(int amount = default(int), ChargeResponseChannel channel = default(ChargeResponseChannel), long createdAt = default(long), string currency = default(string), string customerId = default(string), string description = default(string), string deviceFingerprint = default(string), string failureCode = default(string), string failureMessage = default(string), string id = default(string), bool livemode = default(bool), string varObject = default(string), string orderId = default(string), int? paidAt = default(int?), ChargeResponsePaymentMethod paymentMethod = default(ChargeResponsePaymentMethod), string referenceId = default(string), ChargeResponseRefunds refunds = default(ChargeResponseRefunds), string status = default(string))
        {
            this.Amount = amount;
            this.Channel = channel;
            this.CreatedAt = createdAt;
            this.Currency = currency;
            this.CustomerId = customerId;
            this.Description = description;
            this.DeviceFingerprint = deviceFingerprint;
            this.FailureCode = failureCode;
            this.FailureMessage = failureMessage;
            this.Id = id;
            this.Livemode = livemode;
            this.Object = varObject;
            this.OrderId = orderId;
            this.PaidAt = paidAt;
            this.PaymentMethod = paymentMethod;
            this.ReferenceId = referenceId;
            this.Refunds = refunds;
            this.Status = status;
        }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        /// <example>4321</example>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public int Amount { get; set; }

        /// <summary>
        /// Gets or Sets Channel
        /// </summary>
        [DataMember(Name = "channel", EmitDefaultValue = false)]
        public ChargeResponseChannel Channel { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        /// <example>1676386026</example>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public long CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        /// <example>MXN</example>
        [DataMember(Name = "currency", EmitDefaultValue = false)]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or Sets CustomerId
        /// </summary>
        [DataMember(Name = "customer_id", EmitDefaultValue = false)]
        public string CustomerId { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        /// <example>Payment from order</example>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets DeviceFingerprint
        /// </summary>
        /// <example>6FR3chaU4Y1nGAW5NAGd1rcjAKa142Ba</example>
        [DataMember(Name = "device_fingerprint", EmitDefaultValue = false)]
        public string DeviceFingerprint { get; set; }

        /// <summary>
        /// Gets or Sets FailureCode
        /// </summary>
        /// <example>suspected_fraud</example>
        [DataMember(Name = "failure_code", EmitDefaultValue = false)]
        public string FailureCode { get; set; }

        /// <summary>
        /// Gets or Sets FailureMessage
        /// </summary>
        /// <example>Este cargo ha sido declinado porque el comportamiento del comprador es sospechoso.</example>
        [DataMember(Name = "failure_message", EmitDefaultValue = false)]
        public string FailureMessage { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        /// <example>63efa757cf65380001aec040</example>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Livemode
        /// </summary>
        [DataMember(Name = "livemode", EmitDefaultValue = true)]
        public bool Livemode { get; set; }

        /// <summary>
        /// Gets or Sets Object
        /// </summary>
        [DataMember(Name = "object", EmitDefaultValue = false)]
        public string Object { get; set; }

        /// <summary>
        /// Gets or Sets OrderId
        /// </summary>
        /// <example>ord_2tN73UdUSNrYRPD9r</example>
        [DataMember(Name = "order_id", EmitDefaultValue = false)]
        public string OrderId { get; set; }

        /// <summary>
        /// Gets or Sets PaidAt
        /// </summary>
        /// <example>1676390742</example>
        [DataMember(Name = "paid_at", EmitDefaultValue = true)]
        public int? PaidAt { get; set; }

        /// <summary>
        /// Gets or Sets PaymentMethod
        /// </summary>
        [DataMember(Name = "payment_method", EmitDefaultValue = false)]
        public ChargeResponsePaymentMethod PaymentMethod { get; set; }

        /// <summary>
        /// Reference ID of the charge
        /// </summary>
        /// <value>Reference ID of the charge</value>
        /// <example>ref_2tN73UdUSNrYRPD9r</example>
        [DataMember(Name = "reference_id", EmitDefaultValue = true)]
        public string ReferenceId { get; set; }

        /// <summary>
        /// Gets or Sets Refunds
        /// </summary>
        [DataMember(Name = "refunds", EmitDefaultValue = true)]
        public ChargeResponseRefunds Refunds { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        /// <example>pending_payment</example>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ChargeResponse {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Channel: ").Append(Channel).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DeviceFingerprint: ").Append(DeviceFingerprint).Append("\n");
            sb.Append("  FailureCode: ").Append(FailureCode).Append("\n");
            sb.Append("  FailureMessage: ").Append(FailureMessage).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Livemode: ").Append(Livemode).Append("\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  PaidAt: ").Append(PaidAt).Append("\n");
            sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
            sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
            sb.Append("  Refunds: ").Append(Refunds).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
