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
    /// Class of criteria fields to calculate formula
    /// </summary>
    [DataContract]
    public partial class FieldFormulaCalculateArchiveCriteriaDto :  IEquatable<FieldFormulaCalculateArchiveCriteriaDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldFormulaCalculateArchiveCriteriaDto" /> class.
        /// </summary>
        /// <param name="searchFilterDto">Filter for profiling.</param>
        /// <param name="fieldName">Field Name.</param>
        /// <param name="formula">Formula.</param>
        public FieldFormulaCalculateArchiveCriteriaDto(ProfileDTO searchFilterDto = default(ProfileDTO), string fieldName = default(string), string formula = default(string))
        {
            this.SearchFilterDto = searchFilterDto;
            this.FieldName = fieldName;
            this.Formula = formula;
        }
        
        /// <summary>
        /// Filter for profiling
        /// </summary>
        /// <value>Filter for profiling</value>
        [DataMember(Name="searchFilterDto", EmitDefaultValue=false)]
        public ProfileDTO SearchFilterDto { get; set; }

        /// <summary>
        /// Field Name
        /// </summary>
        /// <value>Field Name</value>
        [DataMember(Name="fieldName", EmitDefaultValue=false)]
        public string FieldName { get; set; }

        /// <summary>
        /// Formula
        /// </summary>
        /// <value>Formula</value>
        [DataMember(Name="formula", EmitDefaultValue=false)]
        public string Formula { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FieldFormulaCalculateArchiveCriteriaDto {\n");
            sb.Append("  SearchFilterDto: ").Append(SearchFilterDto).Append("\n");
            sb.Append("  FieldName: ").Append(FieldName).Append("\n");
            sb.Append("  Formula: ").Append(Formula).Append("\n");
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
            return this.Equals(input as FieldFormulaCalculateArchiveCriteriaDto);
        }

        /// <summary>
        /// Returns true if FieldFormulaCalculateArchiveCriteriaDto instances are equal
        /// </summary>
        /// <param name="input">Instance of FieldFormulaCalculateArchiveCriteriaDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FieldFormulaCalculateArchiveCriteriaDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SearchFilterDto == input.SearchFilterDto ||
                    (this.SearchFilterDto != null &&
                    this.SearchFilterDto.Equals(input.SearchFilterDto))
                ) && 
                (
                    this.FieldName == input.FieldName ||
                    (this.FieldName != null &&
                    this.FieldName.Equals(input.FieldName))
                ) && 
                (
                    this.Formula == input.Formula ||
                    (this.Formula != null &&
                    this.Formula.Equals(input.Formula))
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
                if (this.SearchFilterDto != null)
                    hashCode = hashCode * 59 + this.SearchFilterDto.GetHashCode();
                if (this.FieldName != null)
                    hashCode = hashCode * 59 + this.FieldName.GetHashCode();
                if (this.Formula != null)
                    hashCode = hashCode * 59 + this.Formula.GetHashCode();
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
