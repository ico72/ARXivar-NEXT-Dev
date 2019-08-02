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
    /// Class of Model for profiling
    /// </summary>
    [DataContract]
    public partial class ModelDTO :  IEquatable<ModelDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelDTO" /> class.
        /// </summary>
        /// <param name="id">Identifier.</param>
        /// <param name="description">Description.</param>
        /// <param name="user">Author.</param>
        /// <param name="userDescription">Author&#39;s model name.</param>
        /// <param name="type">Possible values:  1: Public  2: Private .</param>
        /// <param name="fileName">Original File Name.</param>
        /// <param name="lockModality">Possible values:  0: Unblocked  1: Blocked .</param>
        /// <param name="predefinedProfileId">Predefined Profile Identifier.</param>
        /// <param name="groupId">Group Identifier.</param>
        /// <param name="groupName">Model&#39;s group name.</param>
        /// <param name="extension">Extensione File.</param>
        /// <param name="openAfterProfilation">Open File After to Profiliing.</param>
        /// <param name="maskId">Mask Identifier.</param>
        /// <param name="previewFileName">File Name of the original preview file.</param>
        public ModelDTO(int? id = default(int?), string description = default(string), int? user = default(int?), string userDescription = default(string), int? type = default(int?), string fileName = default(string), int? lockModality = default(int?), int? predefinedProfileId = default(int?), int? groupId = default(int?), string groupName = default(string), string extension = default(string), bool? openAfterProfilation = default(bool?), string maskId = default(string), string previewFileName = default(string))
        {
            this.Id = id;
            this.Description = description;
            this.User = user;
            this.UserDescription = userDescription;
            this.Type = type;
            this.FileName = fileName;
            this.LockModality = lockModality;
            this.PredefinedProfileId = predefinedProfileId;
            this.GroupId = groupId;
            this.GroupName = groupName;
            this.Extension = extension;
            this.OpenAfterProfilation = openAfterProfilation;
            this.MaskId = maskId;
            this.PreviewFileName = previewFileName;
        }
        
        /// <summary>
        /// Identifier
        /// </summary>
        /// <value>Identifier</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        /// <value>Description</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Author
        /// </summary>
        /// <value>Author</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public int? User { get; set; }

        /// <summary>
        /// Author&#39;s model name
        /// </summary>
        /// <value>Author&#39;s model name</value>
        [DataMember(Name="userDescription", EmitDefaultValue=false)]
        public string UserDescription { get; set; }

        /// <summary>
        /// Possible values:  1: Public  2: Private 
        /// </summary>
        /// <value>Possible values:  1: Public  2: Private </value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public int? Type { get; set; }

        /// <summary>
        /// Original File Name
        /// </summary>
        /// <value>Original File Name</value>
        [DataMember(Name="fileName", EmitDefaultValue=false)]
        public string FileName { get; set; }

        /// <summary>
        /// Possible values:  0: Unblocked  1: Blocked 
        /// </summary>
        /// <value>Possible values:  0: Unblocked  1: Blocked </value>
        [DataMember(Name="lockModality", EmitDefaultValue=false)]
        public int? LockModality { get; set; }

        /// <summary>
        /// Predefined Profile Identifier
        /// </summary>
        /// <value>Predefined Profile Identifier</value>
        [DataMember(Name="predefinedProfileId", EmitDefaultValue=false)]
        public int? PredefinedProfileId { get; set; }

        /// <summary>
        /// Group Identifier
        /// </summary>
        /// <value>Group Identifier</value>
        [DataMember(Name="groupId", EmitDefaultValue=false)]
        public int? GroupId { get; set; }

        /// <summary>
        /// Model&#39;s group name
        /// </summary>
        /// <value>Model&#39;s group name</value>
        [DataMember(Name="groupName", EmitDefaultValue=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// Extensione File
        /// </summary>
        /// <value>Extensione File</value>
        [DataMember(Name="extension", EmitDefaultValue=false)]
        public string Extension { get; set; }

        /// <summary>
        /// Open File After to Profiliing
        /// </summary>
        /// <value>Open File After to Profiliing</value>
        [DataMember(Name="openAfterProfilation", EmitDefaultValue=false)]
        public bool? OpenAfterProfilation { get; set; }

        /// <summary>
        /// Mask Identifier
        /// </summary>
        /// <value>Mask Identifier</value>
        [DataMember(Name="maskId", EmitDefaultValue=false)]
        public string MaskId { get; set; }

        /// <summary>
        /// File Name of the original preview file
        /// </summary>
        /// <value>File Name of the original preview file</value>
        [DataMember(Name="previewFileName", EmitDefaultValue=false)]
        public string PreviewFileName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModelDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  UserDescription: ").Append(UserDescription).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  FileName: ").Append(FileName).Append("\n");
            sb.Append("  LockModality: ").Append(LockModality).Append("\n");
            sb.Append("  PredefinedProfileId: ").Append(PredefinedProfileId).Append("\n");
            sb.Append("  GroupId: ").Append(GroupId).Append("\n");
            sb.Append("  GroupName: ").Append(GroupName).Append("\n");
            sb.Append("  Extension: ").Append(Extension).Append("\n");
            sb.Append("  OpenAfterProfilation: ").Append(OpenAfterProfilation).Append("\n");
            sb.Append("  MaskId: ").Append(MaskId).Append("\n");
            sb.Append("  PreviewFileName: ").Append(PreviewFileName).Append("\n");
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
            return this.Equals(input as ModelDTO);
        }

        /// <summary>
        /// Returns true if ModelDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of ModelDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModelDTO input)
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
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.UserDescription == input.UserDescription ||
                    (this.UserDescription != null &&
                    this.UserDescription.Equals(input.UserDescription))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.FileName == input.FileName ||
                    (this.FileName != null &&
                    this.FileName.Equals(input.FileName))
                ) && 
                (
                    this.LockModality == input.LockModality ||
                    (this.LockModality != null &&
                    this.LockModality.Equals(input.LockModality))
                ) && 
                (
                    this.PredefinedProfileId == input.PredefinedProfileId ||
                    (this.PredefinedProfileId != null &&
                    this.PredefinedProfileId.Equals(input.PredefinedProfileId))
                ) && 
                (
                    this.GroupId == input.GroupId ||
                    (this.GroupId != null &&
                    this.GroupId.Equals(input.GroupId))
                ) && 
                (
                    this.GroupName == input.GroupName ||
                    (this.GroupName != null &&
                    this.GroupName.Equals(input.GroupName))
                ) && 
                (
                    this.Extension == input.Extension ||
                    (this.Extension != null &&
                    this.Extension.Equals(input.Extension))
                ) && 
                (
                    this.OpenAfterProfilation == input.OpenAfterProfilation ||
                    (this.OpenAfterProfilation != null &&
                    this.OpenAfterProfilation.Equals(input.OpenAfterProfilation))
                ) && 
                (
                    this.MaskId == input.MaskId ||
                    (this.MaskId != null &&
                    this.MaskId.Equals(input.MaskId))
                ) && 
                (
                    this.PreviewFileName == input.PreviewFileName ||
                    (this.PreviewFileName != null &&
                    this.PreviewFileName.Equals(input.PreviewFileName))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.UserDescription != null)
                    hashCode = hashCode * 59 + this.UserDescription.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.FileName != null)
                    hashCode = hashCode * 59 + this.FileName.GetHashCode();
                if (this.LockModality != null)
                    hashCode = hashCode * 59 + this.LockModality.GetHashCode();
                if (this.PredefinedProfileId != null)
                    hashCode = hashCode * 59 + this.PredefinedProfileId.GetHashCode();
                if (this.GroupId != null)
                    hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                if (this.GroupName != null)
                    hashCode = hashCode * 59 + this.GroupName.GetHashCode();
                if (this.Extension != null)
                    hashCode = hashCode * 59 + this.Extension.GetHashCode();
                if (this.OpenAfterProfilation != null)
                    hashCode = hashCode * 59 + this.OpenAfterProfilation.GetHashCode();
                if (this.MaskId != null)
                    hashCode = hashCode * 59 + this.MaskId.GetHashCode();
                if (this.PreviewFileName != null)
                    hashCode = hashCode * 59 + this.PreviewFileName.GetHashCode();
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
