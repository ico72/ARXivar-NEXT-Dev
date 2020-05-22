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
    /// Class of Dependent Field
    /// </summary>
    [DataContract]
    public partial class DependencyFieldItem :  IEquatable<DependencyFieldItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DependencyFieldItem" /> class.
        /// </summary>
        /// <param name="fieldClassName">Dependent Classname.</param>
        /// <param name="fieldId">Name.</param>
        public DependencyFieldItem(string fieldClassName = default(string), string fieldId = default(string))
        {
            this.FieldClassName = fieldClassName;
            this.FieldId = fieldId;
        }
        
        /// <summary>
        /// Dependent Classname
        /// </summary>
        /// <value>Dependent Classname</value>
        [DataMember(Name="fieldClassName", EmitDefaultValue=false)]
        public string FieldClassName { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        /// <value>Name</value>
        [DataMember(Name="fieldId", EmitDefaultValue=false)]
        public string FieldId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DependencyFieldItem {\n");
            sb.Append("  FieldClassName: ").Append(FieldClassName).Append("\n");
            sb.Append("  FieldId: ").Append(FieldId).Append("\n");
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
            return this.Equals(input as DependencyFieldItem);
        }

        /// <summary>
        /// Returns true if DependencyFieldItem instances are equal
        /// </summary>
        /// <param name="input">Instance of DependencyFieldItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DependencyFieldItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FieldClassName == input.FieldClassName ||
                    (this.FieldClassName != null &&
                    this.FieldClassName.Equals(input.FieldClassName))
                ) && 
                (
                    this.FieldId == input.FieldId ||
                    (this.FieldId != null &&
                    this.FieldId.Equals(input.FieldId))
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
                if (this.FieldClassName != null)
                    hashCode = hashCode * 59 + this.FieldClassName.GetHashCode();
                if (this.FieldId != null)
                    hashCode = hashCode * 59 + this.FieldId.GetHashCode();
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