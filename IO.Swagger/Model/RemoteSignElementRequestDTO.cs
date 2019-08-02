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
    /// Class of remote signature field
    /// </summary>
    [DataContract]
    public partial class RemoteSignElementRequestDTO :  IEquatable<RemoteSignElementRequestDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RemoteSignElementRequestDTO" /> class.
        /// </summary>
        /// <param name="tableType">Possible values:  0: Attachment  2: TaskWorkAttachment  14: Profile  74: ProcessDoc .</param>
        /// <param name="docId">Document Identifier.</param>
        /// <param name="docExtraId">Document External Identifier.</param>
        /// <param name="pdfEmbeddedMode">Enabled Pdf Embedded Signature.</param>
        /// <param name="signPdfProperties">Settings of pdf signature.</param>
        public RemoteSignElementRequestDTO(int? tableType = default(int?), string docId = default(string), string docExtraId = default(string), bool? pdfEmbeddedMode = default(bool?), SignPdfPropertiesDTO signPdfProperties = default(SignPdfPropertiesDTO))
        {
            this.TableType = tableType;
            this.DocId = docId;
            this.DocExtraId = docExtraId;
            this.PdfEmbeddedMode = pdfEmbeddedMode;
            this.SignPdfProperties = signPdfProperties;
        }
        
        /// <summary>
        /// Possible values:  0: Attachment  2: TaskWorkAttachment  14: Profile  74: ProcessDoc 
        /// </summary>
        /// <value>Possible values:  0: Attachment  2: TaskWorkAttachment  14: Profile  74: ProcessDoc </value>
        [DataMember(Name="tableType", EmitDefaultValue=false)]
        public int? TableType { get; set; }

        /// <summary>
        /// Document Identifier
        /// </summary>
        /// <value>Document Identifier</value>
        [DataMember(Name="docId", EmitDefaultValue=false)]
        public string DocId { get; set; }

        /// <summary>
        /// Document External Identifier
        /// </summary>
        /// <value>Document External Identifier</value>
        [DataMember(Name="docExtraId", EmitDefaultValue=false)]
        public string DocExtraId { get; set; }

        /// <summary>
        /// Enabled Pdf Embedded Signature
        /// </summary>
        /// <value>Enabled Pdf Embedded Signature</value>
        [DataMember(Name="pdfEmbeddedMode", EmitDefaultValue=false)]
        public bool? PdfEmbeddedMode { get; set; }

        /// <summary>
        /// Settings of pdf signature
        /// </summary>
        /// <value>Settings of pdf signature</value>
        [DataMember(Name="signPdfProperties", EmitDefaultValue=false)]
        public SignPdfPropertiesDTO SignPdfProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RemoteSignElementRequestDTO {\n");
            sb.Append("  TableType: ").Append(TableType).Append("\n");
            sb.Append("  DocId: ").Append(DocId).Append("\n");
            sb.Append("  DocExtraId: ").Append(DocExtraId).Append("\n");
            sb.Append("  PdfEmbeddedMode: ").Append(PdfEmbeddedMode).Append("\n");
            sb.Append("  SignPdfProperties: ").Append(SignPdfProperties).Append("\n");
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
            return this.Equals(input as RemoteSignElementRequestDTO);
        }

        /// <summary>
        /// Returns true if RemoteSignElementRequestDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of RemoteSignElementRequestDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RemoteSignElementRequestDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TableType == input.TableType ||
                    (this.TableType != null &&
                    this.TableType.Equals(input.TableType))
                ) && 
                (
                    this.DocId == input.DocId ||
                    (this.DocId != null &&
                    this.DocId.Equals(input.DocId))
                ) && 
                (
                    this.DocExtraId == input.DocExtraId ||
                    (this.DocExtraId != null &&
                    this.DocExtraId.Equals(input.DocExtraId))
                ) && 
                (
                    this.PdfEmbeddedMode == input.PdfEmbeddedMode ||
                    (this.PdfEmbeddedMode != null &&
                    this.PdfEmbeddedMode.Equals(input.PdfEmbeddedMode))
                ) && 
                (
                    this.SignPdfProperties == input.SignPdfProperties ||
                    (this.SignPdfProperties != null &&
                    this.SignPdfProperties.Equals(input.SignPdfProperties))
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
                if (this.TableType != null)
                    hashCode = hashCode * 59 + this.TableType.GetHashCode();
                if (this.DocId != null)
                    hashCode = hashCode * 59 + this.DocId.GetHashCode();
                if (this.DocExtraId != null)
                    hashCode = hashCode * 59 + this.DocExtraId.GetHashCode();
                if (this.PdfEmbeddedMode != null)
                    hashCode = hashCode * 59 + this.PdfEmbeddedMode.GetHashCode();
                if (this.SignPdfProperties != null)
                    hashCode = hashCode * 59 + this.SignPdfProperties.GetHashCode();
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
