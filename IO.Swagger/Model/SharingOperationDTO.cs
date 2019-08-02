/* 
 * Abletech.Arxivar.Server.WebApi.Services
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// SharingOperationDTO
    /// </summary>
    [DataContract]
    public partial class SharingOperationDTO :  IEquatable<SharingOperationDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SharingOperationDTO" /> class.
        /// </summary>
        /// <param name="sharingOperationId">Unique id for the operation..</param>
        /// <param name="sharingReceiverId">Unique id for the receiver.</param>
        /// <param name="sharingDetailId">Unique id for the sharing detail..</param>
        /// <param name="operationKind">Possible values:  0: ReadDocument .</param>
        /// <param name="operationTime">DateTime of the operation..</param>
        public SharingOperationDTO(string sharingOperationId = default(string), string sharingReceiverId = default(string), string sharingDetailId = default(string), int? operationKind = default(int?), DateTime? operationTime = default(DateTime?))
        {
            this.SharingOperationId = sharingOperationId;
            this.SharingReceiverId = sharingReceiverId;
            this.SharingDetailId = sharingDetailId;
            this.OperationKind = operationKind;
            this.OperationTime = operationTime;
        }
        
        /// <summary>
        /// Unique id for the operation.
        /// </summary>
        /// <value>Unique id for the operation.</value>
        [DataMember(Name="sharingOperationId", EmitDefaultValue=false)]
        public string SharingOperationId { get; set; }

        /// <summary>
        /// Unique id for the receiver
        /// </summary>
        /// <value>Unique id for the receiver</value>
        [DataMember(Name="sharingReceiverId", EmitDefaultValue=false)]
        public string SharingReceiverId { get; set; }

        /// <summary>
        /// Unique id for the sharing detail.
        /// </summary>
        /// <value>Unique id for the sharing detail.</value>
        [DataMember(Name="sharingDetailId", EmitDefaultValue=false)]
        public string SharingDetailId { get; set; }

        /// <summary>
        /// Possible values:  0: ReadDocument 
        /// </summary>
        /// <value>Possible values:  0: ReadDocument </value>
        [DataMember(Name="operationKind", EmitDefaultValue=false)]
        public int? OperationKind { get; set; }

        /// <summary>
        /// DateTime of the operation.
        /// </summary>
        /// <value>DateTime of the operation.</value>
        [DataMember(Name="operationTime", EmitDefaultValue=false)]
        public DateTime? OperationTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SharingOperationDTO {\n");
            sb.Append("  SharingOperationId: ").Append(SharingOperationId).Append("\n");
            sb.Append("  SharingReceiverId: ").Append(SharingReceiverId).Append("\n");
            sb.Append("  SharingDetailId: ").Append(SharingDetailId).Append("\n");
            sb.Append("  OperationKind: ").Append(OperationKind).Append("\n");
            sb.Append("  OperationTime: ").Append(OperationTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SharingOperationDTO);
        }

        /// <summary>
        /// Returns true if SharingOperationDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of SharingOperationDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SharingOperationDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SharingOperationId == input.SharingOperationId ||
                    (this.SharingOperationId != null &&
                    this.SharingOperationId.Equals(input.SharingOperationId))
                ) && 
                (
                    this.SharingReceiverId == input.SharingReceiverId ||
                    (this.SharingReceiverId != null &&
                    this.SharingReceiverId.Equals(input.SharingReceiverId))
                ) && 
                (
                    this.SharingDetailId == input.SharingDetailId ||
                    (this.SharingDetailId != null &&
                    this.SharingDetailId.Equals(input.SharingDetailId))
                ) && 
                (
                    this.OperationKind == input.OperationKind ||
                    (this.OperationKind != null &&
                    this.OperationKind.Equals(input.OperationKind))
                ) && 
                (
                    this.OperationTime == input.OperationTime ||
                    (this.OperationTime != null &&
                    this.OperationTime.Equals(input.OperationTime))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.SharingOperationId != null)
                    hashCode = hashCode * 59 + this.SharingOperationId.GetHashCode();
                if (this.SharingReceiverId != null)
                    hashCode = hashCode * 59 + this.SharingReceiverId.GetHashCode();
                if (this.SharingDetailId != null)
                    hashCode = hashCode * 59 + this.SharingDetailId.GetHashCode();
                if (this.OperationKind != null)
                    hashCode = hashCode * 59 + this.OperationKind.GetHashCode();
                if (this.OperationTime != null)
                    hashCode = hashCode * 59 + this.OperationTime.GetHashCode();
                return hashCode;
            }
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
