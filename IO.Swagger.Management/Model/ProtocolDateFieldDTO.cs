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
    /// Protoco date
    /// </summary>
    [DataContract]
    public partial class ProtocolDateFieldDTO : FieldBaseDTO,  IEquatable<ProtocolDateFieldDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProtocolDateFieldDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProtocolDateFieldDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProtocolDateFieldDTO" /> class.
        /// </summary>
        /// <param name="value">Protocol date value.</param>
        /// <param name="editTime">Last edit time of the document.</param>
        public ProtocolDateFieldDTO(DateTime? value = default(DateTime?), bool? editTime = default(bool?), string name = default(string), string externalId = default(string), string description = default(string), int? order = default(int?), string dataSource = default(string), bool? required = default(bool?), string formula = default(string), string className = "ProtocolDateFieldDTO", bool? locked = default(bool?), string comboGruppiId = default(string), List<DependencyFieldItem> dependencyFields = default(List<DependencyFieldItem>), List<AssocitationFieldItem> associations = default(List<AssocitationFieldItem>), bool? isAdditional = default(bool?), bool? visible = default(bool?), string predefinedProfileFormula = default(string), string visibilityCondition = default(string), int? addressBookDefaultFilter = default(int?), List<int?> enabledAddressBook = default(List<int?>), int? columns = default(int?)) : base(name, externalId, description, order, dataSource, required, formula, className, locked, comboGruppiId, dependencyFields, associations, isAdditional, visible, predefinedProfileFormula, visibilityCondition, addressBookDefaultFilter, enabledAddressBook, columns)
        {
            this.Value = value;
            this.EditTime = editTime;
        }
        
        /// <summary>
        /// Protocol date value
        /// </summary>
        /// <value>Protocol date value</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public DateTime? Value { get; set; }

        /// <summary>
        /// Last edit time of the document
        /// </summary>
        /// <value>Last edit time of the document</value>
        [DataMember(Name="editTime", EmitDefaultValue=false)]
        public bool? EditTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProtocolDateFieldDTO {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  EditTime: ").Append(EditTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as ProtocolDateFieldDTO);
        }

        /// <summary>
        /// Returns true if ProtocolDateFieldDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of ProtocolDateFieldDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProtocolDateFieldDTO input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && base.Equals(input) && 
                (
                    this.EditTime == input.EditTime ||
                    (this.EditTime != null &&
                    this.EditTime.Equals(input.EditTime))
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
                int hashCode = base.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.EditTime != null)
                    hashCode = hashCode * 59 + this.EditTime.GetHashCode();
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
            foreach(var x in BaseValidate(validationContext)) yield return x;
            yield break;
        }
    }

}
