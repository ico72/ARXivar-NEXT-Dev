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
    /// Class of queue job
    /// </summary>
    [DataContract]
    public partial class QueueJobInfoDto :  IEquatable<QueueJobInfoDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueueJobInfoDto" /> class.
        /// </summary>
        /// <param name="queueJob">Queue Job.</param>
        /// <param name="createdAt">Creation Date.</param>
        /// <param name="history">List of history queue status.</param>
        /// <param name="expireAt">Expiration Date.</param>
        public QueueJobInfoDto(QueueJobDto queueJob = default(QueueJobDto), DateTime? createdAt = default(DateTime?), List<QueueStateHistoryDto> history = default(List<QueueStateHistoryDto>), DateTime? expireAt = default(DateTime?))
        {
            this.QueueJob = queueJob;
            this.CreatedAt = createdAt;
            this.History = history;
            this.ExpireAt = expireAt;
        }
        
        /// <summary>
        /// Queue Job
        /// </summary>
        /// <value>Queue Job</value>
        [DataMember(Name="queueJob", EmitDefaultValue=false)]
        public QueueJobDto QueueJob { get; set; }

        /// <summary>
        /// Creation Date
        /// </summary>
        /// <value>Creation Date</value>
        [DataMember(Name="createdAt", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// List of history queue status
        /// </summary>
        /// <value>List of history queue status</value>
        [DataMember(Name="history", EmitDefaultValue=false)]
        public List<QueueStateHistoryDto> History { get; set; }

        /// <summary>
        /// Expiration Date
        /// </summary>
        /// <value>Expiration Date</value>
        [DataMember(Name="expireAt", EmitDefaultValue=false)]
        public DateTime? ExpireAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueueJobInfoDto {\n");
            sb.Append("  QueueJob: ").Append(QueueJob).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  History: ").Append(History).Append("\n");
            sb.Append("  ExpireAt: ").Append(ExpireAt).Append("\n");
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
            return this.Equals(input as QueueJobInfoDto);
        }

        /// <summary>
        /// Returns true if QueueJobInfoDto instances are equal
        /// </summary>
        /// <param name="input">Instance of QueueJobInfoDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueueJobInfoDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.QueueJob == input.QueueJob ||
                    (this.QueueJob != null &&
                    this.QueueJob.Equals(input.QueueJob))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.History == input.History ||
                    this.History != null &&
                    this.History.SequenceEqual(input.History)
                ) && 
                (
                    this.ExpireAt == input.ExpireAt ||
                    (this.ExpireAt != null &&
                    this.ExpireAt.Equals(input.ExpireAt))
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
                if (this.QueueJob != null)
                    hashCode = hashCode * 59 + this.QueueJob.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.History != null)
                    hashCode = hashCode * 59 + this.History.GetHashCode();
                if (this.ExpireAt != null)
                    hashCode = hashCode * 59 + this.ExpireAt.GetHashCode();
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
