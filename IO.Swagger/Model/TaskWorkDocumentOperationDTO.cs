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
    /// Document operation DTO.
    /// </summary>
    [DataContract]
    public partial class TaskWorkDocumentOperationDTO :  IEquatable<TaskWorkDocumentOperationDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskWorkDocumentOperationDTO" /> class.
        /// </summary>
        /// <param name="id">Operation Id..</param>
        /// <param name="taskWorkId">TaskWork Id..</param>
        /// <param name="processId">Process Id..</param>
        /// <param name="allowNewDocument">Archiviation enabled..</param>
        /// <param name="allowDocumentSelection">Selection enabled..</param>
        /// <param name="viewId">Indicates the id of the view to use for the search.</param>
        /// <param name="isRequired">Required..</param>
        /// <param name="taskWorkDocumentOperationType">Possible values:  0: Attachment  1: PrincipalDocument  2: SecondaryDocument .</param>
        /// <param name="editBuffer">Edit buffer copy..</param>
        /// <param name="documentTypeType1">DocumentType Type one..</param>
        /// <param name="documentTypeType2">DocumentType Type two..</param>
        /// <param name="documentTypeType3">DocumentType Type three..</param>
        /// <param name="moduleId">Model Id..</param>
        /// <param name="toAssociates">Associates enabled..</param>
        /// <param name="description">Operation description..</param>
        /// <param name="maskId">Mask Id..</param>
        /// <param name="toSend">Send enabled..</param>
        /// <param name="fromFileSystem">FileSystem selection..</param>
        /// <param name="fromScanner">Scanner selection..</param>
        /// <param name="isExecuted">Operation Executed..</param>
        /// <param name="relatedBinder">Related binder id.</param>
        /// <param name="taskWorkDocumentOperationRealtionMode">Possible values:  0: AsChild  1: AsFather  -1: None .</param>
        public TaskWorkDocumentOperationDTO(string id = default(string), int? taskWorkId = default(int?), int? processId = default(int?), bool? allowNewDocument = default(bool?), bool? allowDocumentSelection = default(bool?), string viewId = default(string), bool? isRequired = default(bool?), int? taskWorkDocumentOperationType = default(int?), bool? editBuffer = default(bool?), int? documentTypeType1 = default(int?), int? documentTypeType2 = default(int?), int? documentTypeType3 = default(int?), int? moduleId = default(int?), bool? toAssociates = default(bool?), string description = default(string), string maskId = default(string), bool? toSend = default(bool?), bool? fromFileSystem = default(bool?), bool? fromScanner = default(bool?), bool? isExecuted = default(bool?), string relatedBinder = default(string), int? taskWorkDocumentOperationRealtionMode = default(int?))
        {
            this.Id = id;
            this.TaskWorkId = taskWorkId;
            this.ProcessId = processId;
            this.AllowNewDocument = allowNewDocument;
            this.AllowDocumentSelection = allowDocumentSelection;
            this.ViewId = viewId;
            this.IsRequired = isRequired;
            this.TaskWorkDocumentOperationType = taskWorkDocumentOperationType;
            this.EditBuffer = editBuffer;
            this.DocumentTypeType1 = documentTypeType1;
            this.DocumentTypeType2 = documentTypeType2;
            this.DocumentTypeType3 = documentTypeType3;
            this.ModuleId = moduleId;
            this.ToAssociates = toAssociates;
            this.Description = description;
            this.MaskId = maskId;
            this.ToSend = toSend;
            this.FromFileSystem = fromFileSystem;
            this.FromScanner = fromScanner;
            this.IsExecuted = isExecuted;
            this.RelatedBinder = relatedBinder;
            this.TaskWorkDocumentOperationRealtionMode = taskWorkDocumentOperationRealtionMode;
        }
        
        /// <summary>
        /// Operation Id.
        /// </summary>
        /// <value>Operation Id.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// TaskWork Id.
        /// </summary>
        /// <value>TaskWork Id.</value>
        [DataMember(Name="taskWorkId", EmitDefaultValue=false)]
        public int? TaskWorkId { get; set; }

        /// <summary>
        /// Process Id.
        /// </summary>
        /// <value>Process Id.</value>
        [DataMember(Name="processId", EmitDefaultValue=false)]
        public int? ProcessId { get; set; }

        /// <summary>
        /// Archiviation enabled.
        /// </summary>
        /// <value>Archiviation enabled.</value>
        [DataMember(Name="allowNewDocument", EmitDefaultValue=false)]
        public bool? AllowNewDocument { get; set; }

        /// <summary>
        /// Selection enabled.
        /// </summary>
        /// <value>Selection enabled.</value>
        [DataMember(Name="allowDocumentSelection", EmitDefaultValue=false)]
        public bool? AllowDocumentSelection { get; set; }

        /// <summary>
        /// Indicates the id of the view to use for the search
        /// </summary>
        /// <value>Indicates the id of the view to use for the search</value>
        [DataMember(Name="viewId", EmitDefaultValue=false)]
        public string ViewId { get; set; }

        /// <summary>
        /// Required.
        /// </summary>
        /// <value>Required.</value>
        [DataMember(Name="isRequired", EmitDefaultValue=false)]
        public bool? IsRequired { get; set; }

        /// <summary>
        /// Possible values:  0: Attachment  1: PrincipalDocument  2: SecondaryDocument 
        /// </summary>
        /// <value>Possible values:  0: Attachment  1: PrincipalDocument  2: SecondaryDocument </value>
        [DataMember(Name="taskWorkDocumentOperationType", EmitDefaultValue=false)]
        public int? TaskWorkDocumentOperationType { get; set; }

        /// <summary>
        /// Edit buffer copy.
        /// </summary>
        /// <value>Edit buffer copy.</value>
        [DataMember(Name="editBuffer", EmitDefaultValue=false)]
        public bool? EditBuffer { get; set; }

        /// <summary>
        /// DocumentType Type one.
        /// </summary>
        /// <value>DocumentType Type one.</value>
        [DataMember(Name="documentTypeType1", EmitDefaultValue=false)]
        public int? DocumentTypeType1 { get; set; }

        /// <summary>
        /// DocumentType Type two.
        /// </summary>
        /// <value>DocumentType Type two.</value>
        [DataMember(Name="documentTypeType2", EmitDefaultValue=false)]
        public int? DocumentTypeType2 { get; set; }

        /// <summary>
        /// DocumentType Type three.
        /// </summary>
        /// <value>DocumentType Type three.</value>
        [DataMember(Name="documentTypeType3", EmitDefaultValue=false)]
        public int? DocumentTypeType3 { get; set; }

        /// <summary>
        /// Model Id.
        /// </summary>
        /// <value>Model Id.</value>
        [DataMember(Name="moduleId", EmitDefaultValue=false)]
        public int? ModuleId { get; set; }

        /// <summary>
        /// Associates enabled.
        /// </summary>
        /// <value>Associates enabled.</value>
        [DataMember(Name="toAssociates", EmitDefaultValue=false)]
        public bool? ToAssociates { get; set; }

        /// <summary>
        /// Operation description.
        /// </summary>
        /// <value>Operation description.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Mask Id.
        /// </summary>
        /// <value>Mask Id.</value>
        [DataMember(Name="maskId", EmitDefaultValue=false)]
        public string MaskId { get; set; }

        /// <summary>
        /// Send enabled.
        /// </summary>
        /// <value>Send enabled.</value>
        [DataMember(Name="toSend", EmitDefaultValue=false)]
        public bool? ToSend { get; set; }

        /// <summary>
        /// FileSystem selection.
        /// </summary>
        /// <value>FileSystem selection.</value>
        [DataMember(Name="fromFileSystem", EmitDefaultValue=false)]
        public bool? FromFileSystem { get; set; }

        /// <summary>
        /// Scanner selection.
        /// </summary>
        /// <value>Scanner selection.</value>
        [DataMember(Name="fromScanner", EmitDefaultValue=false)]
        public bool? FromScanner { get; set; }

        /// <summary>
        /// Operation Executed.
        /// </summary>
        /// <value>Operation Executed.</value>
        [DataMember(Name="isExecuted", EmitDefaultValue=false)]
        public bool? IsExecuted { get; set; }

        /// <summary>
        /// Related binder id
        /// </summary>
        /// <value>Related binder id</value>
        [DataMember(Name="relatedBinder", EmitDefaultValue=false)]
        public string RelatedBinder { get; set; }

        /// <summary>
        /// Possible values:  0: AsChild  1: AsFather  -1: None 
        /// </summary>
        /// <value>Possible values:  0: AsChild  1: AsFather  -1: None </value>
        [DataMember(Name="taskWorkDocumentOperationRealtionMode", EmitDefaultValue=false)]
        public int? TaskWorkDocumentOperationRealtionMode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskWorkDocumentOperationDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TaskWorkId: ").Append(TaskWorkId).Append("\n");
            sb.Append("  ProcessId: ").Append(ProcessId).Append("\n");
            sb.Append("  AllowNewDocument: ").Append(AllowNewDocument).Append("\n");
            sb.Append("  AllowDocumentSelection: ").Append(AllowDocumentSelection).Append("\n");
            sb.Append("  ViewId: ").Append(ViewId).Append("\n");
            sb.Append("  IsRequired: ").Append(IsRequired).Append("\n");
            sb.Append("  TaskWorkDocumentOperationType: ").Append(TaskWorkDocumentOperationType).Append("\n");
            sb.Append("  EditBuffer: ").Append(EditBuffer).Append("\n");
            sb.Append("  DocumentTypeType1: ").Append(DocumentTypeType1).Append("\n");
            sb.Append("  DocumentTypeType2: ").Append(DocumentTypeType2).Append("\n");
            sb.Append("  DocumentTypeType3: ").Append(DocumentTypeType3).Append("\n");
            sb.Append("  ModuleId: ").Append(ModuleId).Append("\n");
            sb.Append("  ToAssociates: ").Append(ToAssociates).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  MaskId: ").Append(MaskId).Append("\n");
            sb.Append("  ToSend: ").Append(ToSend).Append("\n");
            sb.Append("  FromFileSystem: ").Append(FromFileSystem).Append("\n");
            sb.Append("  FromScanner: ").Append(FromScanner).Append("\n");
            sb.Append("  IsExecuted: ").Append(IsExecuted).Append("\n");
            sb.Append("  RelatedBinder: ").Append(RelatedBinder).Append("\n");
            sb.Append("  TaskWorkDocumentOperationRealtionMode: ").Append(TaskWorkDocumentOperationRealtionMode).Append("\n");
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
            return this.Equals(input as TaskWorkDocumentOperationDTO);
        }

        /// <summary>
        /// Returns true if TaskWorkDocumentOperationDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of TaskWorkDocumentOperationDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskWorkDocumentOperationDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.TaskWorkId == input.TaskWorkId ||
                    (this.TaskWorkId != null &&
                    this.TaskWorkId.Equals(input.TaskWorkId))
                ) && 
                (
                    this.ProcessId == input.ProcessId ||
                    (this.ProcessId != null &&
                    this.ProcessId.Equals(input.ProcessId))
                ) && 
                (
                    this.AllowNewDocument == input.AllowNewDocument ||
                    (this.AllowNewDocument != null &&
                    this.AllowNewDocument.Equals(input.AllowNewDocument))
                ) && 
                (
                    this.AllowDocumentSelection == input.AllowDocumentSelection ||
                    (this.AllowDocumentSelection != null &&
                    this.AllowDocumentSelection.Equals(input.AllowDocumentSelection))
                ) && 
                (
                    this.ViewId == input.ViewId ||
                    (this.ViewId != null &&
                    this.ViewId.Equals(input.ViewId))
                ) && 
                (
                    this.IsRequired == input.IsRequired ||
                    (this.IsRequired != null &&
                    this.IsRequired.Equals(input.IsRequired))
                ) && 
                (
                    this.TaskWorkDocumentOperationType == input.TaskWorkDocumentOperationType ||
                    (this.TaskWorkDocumentOperationType != null &&
                    this.TaskWorkDocumentOperationType.Equals(input.TaskWorkDocumentOperationType))
                ) && 
                (
                    this.EditBuffer == input.EditBuffer ||
                    (this.EditBuffer != null &&
                    this.EditBuffer.Equals(input.EditBuffer))
                ) && 
                (
                    this.DocumentTypeType1 == input.DocumentTypeType1 ||
                    (this.DocumentTypeType1 != null &&
                    this.DocumentTypeType1.Equals(input.DocumentTypeType1))
                ) && 
                (
                    this.DocumentTypeType2 == input.DocumentTypeType2 ||
                    (this.DocumentTypeType2 != null &&
                    this.DocumentTypeType2.Equals(input.DocumentTypeType2))
                ) && 
                (
                    this.DocumentTypeType3 == input.DocumentTypeType3 ||
                    (this.DocumentTypeType3 != null &&
                    this.DocumentTypeType3.Equals(input.DocumentTypeType3))
                ) && 
                (
                    this.ModuleId == input.ModuleId ||
                    (this.ModuleId != null &&
                    this.ModuleId.Equals(input.ModuleId))
                ) && 
                (
                    this.ToAssociates == input.ToAssociates ||
                    (this.ToAssociates != null &&
                    this.ToAssociates.Equals(input.ToAssociates))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.MaskId == input.MaskId ||
                    (this.MaskId != null &&
                    this.MaskId.Equals(input.MaskId))
                ) && 
                (
                    this.ToSend == input.ToSend ||
                    (this.ToSend != null &&
                    this.ToSend.Equals(input.ToSend))
                ) && 
                (
                    this.FromFileSystem == input.FromFileSystem ||
                    (this.FromFileSystem != null &&
                    this.FromFileSystem.Equals(input.FromFileSystem))
                ) && 
                (
                    this.FromScanner == input.FromScanner ||
                    (this.FromScanner != null &&
                    this.FromScanner.Equals(input.FromScanner))
                ) && 
                (
                    this.IsExecuted == input.IsExecuted ||
                    (this.IsExecuted != null &&
                    this.IsExecuted.Equals(input.IsExecuted))
                ) && 
                (
                    this.RelatedBinder == input.RelatedBinder ||
                    (this.RelatedBinder != null &&
                    this.RelatedBinder.Equals(input.RelatedBinder))
                ) && 
                (
                    this.TaskWorkDocumentOperationRealtionMode == input.TaskWorkDocumentOperationRealtionMode ||
                    (this.TaskWorkDocumentOperationRealtionMode != null &&
                    this.TaskWorkDocumentOperationRealtionMode.Equals(input.TaskWorkDocumentOperationRealtionMode))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.TaskWorkId != null)
                    hashCode = hashCode * 59 + this.TaskWorkId.GetHashCode();
                if (this.ProcessId != null)
                    hashCode = hashCode * 59 + this.ProcessId.GetHashCode();
                if (this.AllowNewDocument != null)
                    hashCode = hashCode * 59 + this.AllowNewDocument.GetHashCode();
                if (this.AllowDocumentSelection != null)
                    hashCode = hashCode * 59 + this.AllowDocumentSelection.GetHashCode();
                if (this.ViewId != null)
                    hashCode = hashCode * 59 + this.ViewId.GetHashCode();
                if (this.IsRequired != null)
                    hashCode = hashCode * 59 + this.IsRequired.GetHashCode();
                if (this.TaskWorkDocumentOperationType != null)
                    hashCode = hashCode * 59 + this.TaskWorkDocumentOperationType.GetHashCode();
                if (this.EditBuffer != null)
                    hashCode = hashCode * 59 + this.EditBuffer.GetHashCode();
                if (this.DocumentTypeType1 != null)
                    hashCode = hashCode * 59 + this.DocumentTypeType1.GetHashCode();
                if (this.DocumentTypeType2 != null)
                    hashCode = hashCode * 59 + this.DocumentTypeType2.GetHashCode();
                if (this.DocumentTypeType3 != null)
                    hashCode = hashCode * 59 + this.DocumentTypeType3.GetHashCode();
                if (this.ModuleId != null)
                    hashCode = hashCode * 59 + this.ModuleId.GetHashCode();
                if (this.ToAssociates != null)
                    hashCode = hashCode * 59 + this.ToAssociates.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.MaskId != null)
                    hashCode = hashCode * 59 + this.MaskId.GetHashCode();
                if (this.ToSend != null)
                    hashCode = hashCode * 59 + this.ToSend.GetHashCode();
                if (this.FromFileSystem != null)
                    hashCode = hashCode * 59 + this.FromFileSystem.GetHashCode();
                if (this.FromScanner != null)
                    hashCode = hashCode * 59 + this.FromScanner.GetHashCode();
                if (this.IsExecuted != null)
                    hashCode = hashCode * 59 + this.IsExecuted.GetHashCode();
                if (this.RelatedBinder != null)
                    hashCode = hashCode * 59 + this.RelatedBinder.GetHashCode();
                if (this.TaskWorkDocumentOperationRealtionMode != null)
                    hashCode = hashCode * 59 + this.TaskWorkDocumentOperationRealtionMode.GetHashCode();
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
