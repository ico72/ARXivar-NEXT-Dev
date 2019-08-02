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
    /// TaskPreviewRequestDto
    /// </summary>
    [DataContract]
    public partial class TaskPreviewRequestDto :  IEquatable<TaskPreviewRequestDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskPreviewRequestDto" /> class.
        /// </summary>
        /// <param name="dmTaskworkId">dmTaskworkId.</param>
        /// <param name="dmProcessDocId">dmProcessDocId.</param>
        public TaskPreviewRequestDto(int? dmTaskworkId = default(int?), int? dmProcessDocId = default(int?))
        {
            this.DmTaskworkId = dmTaskworkId;
            this.DmProcessDocId = dmProcessDocId;
        }
        
        /// <summary>
        /// Gets or Sets DmTaskworkId
        /// </summary>
        [DataMember(Name="dmTaskworkId", EmitDefaultValue=false)]
        public int? DmTaskworkId { get; set; }

        /// <summary>
        /// Gets or Sets DmProcessDocId
        /// </summary>
        [DataMember(Name="dmProcessDocId", EmitDefaultValue=false)]
        public int? DmProcessDocId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskPreviewRequestDto {\n");
            sb.Append("  DmTaskworkId: ").Append(DmTaskworkId).Append("\n");
            sb.Append("  DmProcessDocId: ").Append(DmProcessDocId).Append("\n");
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
            return this.Equals(input as TaskPreviewRequestDto);
        }

        /// <summary>
        /// Returns true if TaskPreviewRequestDto instances are equal
        /// </summary>
        /// <param name="input">Instance of TaskPreviewRequestDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskPreviewRequestDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DmTaskworkId == input.DmTaskworkId ||
                    (this.DmTaskworkId != null &&
                    this.DmTaskworkId.Equals(input.DmTaskworkId))
                ) && 
                (
                    this.DmProcessDocId == input.DmProcessDocId ||
                    (this.DmProcessDocId != null &&
                    this.DmProcessDocId.Equals(input.DmProcessDocId))
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
                if (this.DmTaskworkId != null)
                    hashCode = hashCode * 59 + this.DmTaskworkId.GetHashCode();
                if (this.DmProcessDocId != null)
                    hashCode = hashCode * 59 + this.DmProcessDocId.GetHashCode();
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
