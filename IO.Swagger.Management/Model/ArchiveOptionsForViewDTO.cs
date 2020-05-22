/* 
 * WebAPI - Area Management
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: management
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
using SwaggerDateConverter = IO.Swagger.Management.Client.SwaggerDateConverter;

namespace IO.Swagger.Management.Model
{
    /// <summary>
    /// Class of document type: archive options for view
    /// </summary>
    [DataContract]
    public partial class ArchiveOptionsForViewDTO :  IEquatable<ArchiveOptionsForViewDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArchiveOptionsForViewDTO" /> class.
        /// </summary>
        /// <param name="inheritedOptions">Inherited options by parent document type if present they exist.</param>
        /// <param name="documentType">Document type.</param>
        /// <param name="numDayWrite">Days without writing before moving.</param>
        /// <param name="numDayRead">Days without reading before moving.</param>
        /// <param name="_operator">Possible values:  0: AND  1: OR .</param>
        public ArchiveOptionsForViewDTO(ArchiveOptionsForViewDTO inheritedOptions = default(ArchiveOptionsForViewDTO), DocumentTypeSimpleDTO documentType = default(DocumentTypeSimpleDTO), int? numDayWrite = default(int?), int? numDayRead = default(int?), int? _operator = default(int?))
        {
            this.InheritedOptions = inheritedOptions;
            this.DocumentType = documentType;
            this.NumDayWrite = numDayWrite;
            this.NumDayRead = numDayRead;
            this.Operator = _operator;
        }
        
        /// <summary>
        /// Inherited options by parent document type if present they exist
        /// </summary>
        /// <value>Inherited options by parent document type if present they exist</value>
        [DataMember(Name="inheritedOptions", EmitDefaultValue=false)]
        public ArchiveOptionsForViewDTO InheritedOptions { get; set; }

        /// <summary>
        /// Document type
        /// </summary>
        /// <value>Document type</value>
        [DataMember(Name="documentType", EmitDefaultValue=false)]
        public DocumentTypeSimpleDTO DocumentType { get; set; }

        /// <summary>
        /// Days without writing before moving
        /// </summary>
        /// <value>Days without writing before moving</value>
        [DataMember(Name="numDayWrite", EmitDefaultValue=false)]
        public int? NumDayWrite { get; set; }

        /// <summary>
        /// Days without reading before moving
        /// </summary>
        /// <value>Days without reading before moving</value>
        [DataMember(Name="numDayRead", EmitDefaultValue=false)]
        public int? NumDayRead { get; set; }

        /// <summary>
        /// Possible values:  0: AND  1: OR 
        /// </summary>
        /// <value>Possible values:  0: AND  1: OR </value>
        [DataMember(Name="operator", EmitDefaultValue=false)]
        public int? Operator { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ArchiveOptionsForViewDTO {\n");
            sb.Append("  InheritedOptions: ").Append(InheritedOptions).Append("\n");
            sb.Append("  DocumentType: ").Append(DocumentType).Append("\n");
            sb.Append("  NumDayWrite: ").Append(NumDayWrite).Append("\n");
            sb.Append("  NumDayRead: ").Append(NumDayRead).Append("\n");
            sb.Append("  Operator: ").Append(Operator).Append("\n");
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
            return this.Equals(input as ArchiveOptionsForViewDTO);
        }

        /// <summary>
        /// Returns true if ArchiveOptionsForViewDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of ArchiveOptionsForViewDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ArchiveOptionsForViewDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InheritedOptions == input.InheritedOptions ||
                    (this.InheritedOptions != null &&
                    this.InheritedOptions.Equals(input.InheritedOptions))
                ) && 
                (
                    this.DocumentType == input.DocumentType ||
                    (this.DocumentType != null &&
                    this.DocumentType.Equals(input.DocumentType))
                ) && 
                (
                    this.NumDayWrite == input.NumDayWrite ||
                    (this.NumDayWrite != null &&
                    this.NumDayWrite.Equals(input.NumDayWrite))
                ) && 
                (
                    this.NumDayRead == input.NumDayRead ||
                    (this.NumDayRead != null &&
                    this.NumDayRead.Equals(input.NumDayRead))
                ) && 
                (
                    this.Operator == input.Operator ||
                    (this.Operator != null &&
                    this.Operator.Equals(input.Operator))
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
                if (this.InheritedOptions != null)
                    hashCode = hashCode * 59 + this.InheritedOptions.GetHashCode();
                if (this.DocumentType != null)
                    hashCode = hashCode * 59 + this.DocumentType.GetHashCode();
                if (this.NumDayWrite != null)
                    hashCode = hashCode * 59 + this.NumDayWrite.GetHashCode();
                if (this.NumDayRead != null)
                    hashCode = hashCode * 59 + this.NumDayRead.GetHashCode();
                if (this.Operator != null)
                    hashCode = hashCode * 59 + this.Operator.GetHashCode();
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
