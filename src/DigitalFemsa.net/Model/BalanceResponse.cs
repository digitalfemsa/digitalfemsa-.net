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
    /// balance model
    /// </summary>
    [DataContract(Name = "balance_response")]
    public partial class BalanceResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BalanceResponse" /> class.
        /// </summary>
        /// <param name="available">The balance&#39;s available.</param>
        /// <param name="cashoutRetentionAmount">The balance&#39;s cashout retention amount.</param>
        /// <param name="conektaRetention">The balance&#39;s Femsa retention.</param>
        /// <param name="gateway">The balance&#39;s gateway.</param>
        /// <param name="pending">The balance&#39;s pending.</param>
        /// <param name="retained">The balance&#39;s retained.</param>
        /// <param name="retentionAmount">The balance&#39;s retention amount.</param>
        /// <param name="targetCollateralAmount">The balance&#39;s target collateral amount.</param>
        /// <param name="targetRetentionAmount">The balance&#39;s target retention amount.</param>
        /// <param name="temporarilyRetained">The balance&#39;s temporarily retained.</param>
        public BalanceResponse(List<BalanceCommonField> available = default(List<BalanceCommonField>), List<BalanceCommonField> cashoutRetentionAmount = default(List<BalanceCommonField>), List<BalanceCommonField> conektaRetention = default(List<BalanceCommonField>), List<BalanceCommonField> gateway = default(List<BalanceCommonField>), List<BalanceCommonField> pending = default(List<BalanceCommonField>), List<BalanceCommonField> retained = default(List<BalanceCommonField>), List<BalanceCommonField> retentionAmount = default(List<BalanceCommonField>), Object targetCollateralAmount = default(Object), List<BalanceCommonField> targetRetentionAmount = default(List<BalanceCommonField>), List<BalanceCommonField> temporarilyRetained = default(List<BalanceCommonField>))
        {
            this.Available = available;
            this.CashoutRetentionAmount = cashoutRetentionAmount;
            this.ConektaRetention = conektaRetention;
            this.Gateway = gateway;
            this.Pending = pending;
            this.Retained = retained;
            this.RetentionAmount = retentionAmount;
            this.TargetCollateralAmount = targetCollateralAmount;
            this.TargetRetentionAmount = targetRetentionAmount;
            this.TemporarilyRetained = temporarilyRetained;
        }

        /// <summary>
        /// The balance&#39;s available
        /// </summary>
        /// <value>The balance&#39;s available</value>
        [DataMember(Name = "available", EmitDefaultValue = false)]
        public List<BalanceCommonField> Available { get; set; }

        /// <summary>
        /// The balance&#39;s cashout retention amount
        /// </summary>
        /// <value>The balance&#39;s cashout retention amount</value>
        [DataMember(Name = "cashout_retention_amount", EmitDefaultValue = false)]
        public List<BalanceCommonField> CashoutRetentionAmount { get; set; }

        /// <summary>
        /// The balance&#39;s Femsa retention
        /// </summary>
        /// <value>The balance&#39;s Femsa retention</value>
        [DataMember(Name = "conekta_retention", EmitDefaultValue = false)]
        public List<BalanceCommonField> ConektaRetention { get; set; }

        /// <summary>
        /// The balance&#39;s gateway
        /// </summary>
        /// <value>The balance&#39;s gateway</value>
        [DataMember(Name = "gateway", EmitDefaultValue = false)]
        public List<BalanceCommonField> Gateway { get; set; }

        /// <summary>
        /// The balance&#39;s pending
        /// </summary>
        /// <value>The balance&#39;s pending</value>
        [DataMember(Name = "pending", EmitDefaultValue = false)]
        public List<BalanceCommonField> Pending { get; set; }

        /// <summary>
        /// The balance&#39;s retained
        /// </summary>
        /// <value>The balance&#39;s retained</value>
        [DataMember(Name = "retained", EmitDefaultValue = false)]
        public List<BalanceCommonField> Retained { get; set; }

        /// <summary>
        /// The balance&#39;s retention amount
        /// </summary>
        /// <value>The balance&#39;s retention amount</value>
        [DataMember(Name = "retention_amount", EmitDefaultValue = false)]
        public List<BalanceCommonField> RetentionAmount { get; set; }

        /// <summary>
        /// The balance&#39;s target collateral amount
        /// </summary>
        /// <value>The balance&#39;s target collateral amount</value>
        [DataMember(Name = "target_collateral_amount", EmitDefaultValue = false)]
        public Object TargetCollateralAmount { get; set; }

        /// <summary>
        /// The balance&#39;s target retention amount
        /// </summary>
        /// <value>The balance&#39;s target retention amount</value>
        [DataMember(Name = "target_retention_amount", EmitDefaultValue = false)]
        public List<BalanceCommonField> TargetRetentionAmount { get; set; }

        /// <summary>
        /// The balance&#39;s temporarily retained
        /// </summary>
        /// <value>The balance&#39;s temporarily retained</value>
        [DataMember(Name = "temporarily_retained", EmitDefaultValue = false)]
        public List<BalanceCommonField> TemporarilyRetained { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BalanceResponse {\n");
            sb.Append("  Available: ").Append(Available).Append("\n");
            sb.Append("  CashoutRetentionAmount: ").Append(CashoutRetentionAmount).Append("\n");
            sb.Append("  ConektaRetention: ").Append(ConektaRetention).Append("\n");
            sb.Append("  Gateway: ").Append(Gateway).Append("\n");
            sb.Append("  Pending: ").Append(Pending).Append("\n");
            sb.Append("  Retained: ").Append(Retained).Append("\n");
            sb.Append("  RetentionAmount: ").Append(RetentionAmount).Append("\n");
            sb.Append("  TargetCollateralAmount: ").Append(TargetCollateralAmount).Append("\n");
            sb.Append("  TargetRetentionAmount: ").Append(TargetRetentionAmount).Append("\n");
            sb.Append("  TemporarilyRetained: ").Append(TemporarilyRetained).Append("\n");
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
