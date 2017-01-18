/* 
 * Abletech.Arxivar.Server.WebApi.Services
 *
 * No descripton provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace IO.Swagger.Model
{
    /// <summary>
    /// FieldFormulaCalculateCriteriaDto
    /// </summary>
    [DataContract]
    public partial class FieldFormulaCalculateCriteriaDto :  IEquatable<FieldFormulaCalculateCriteriaDto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldFormulaCalculateCriteriaDto" /> class.
        /// </summary>
        /// <param name="SearchFilterDto">SearchFilterDto.</param>
        /// <param name="FieldName">FieldName.</param>
        /// <param name="Formula">Formula.</param>
        public FieldFormulaCalculateCriteriaDto(SearchDTO SearchFilterDto = null, string FieldName = null, string Formula = null)
        {
            this.SearchFilterDto = SearchFilterDto;
            this.FieldName = FieldName;
            this.Formula = Formula;
        }
        
        /// <summary>
        /// Gets or Sets SearchFilterDto
        /// </summary>
        [DataMember(Name="searchFilterDto", EmitDefaultValue=false)]
        public SearchDTO SearchFilterDto { get; set; }
        /// <summary>
        /// Gets or Sets FieldName
        /// </summary>
        [DataMember(Name="fieldName", EmitDefaultValue=false)]
        public string FieldName { get; set; }
        /// <summary>
        /// Gets or Sets Formula
        /// </summary>
        [DataMember(Name="formula", EmitDefaultValue=false)]
        public string Formula { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FieldFormulaCalculateCriteriaDto {\n");
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
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as FieldFormulaCalculateCriteriaDto);
        }

        /// <summary>
        /// Returns true if FieldFormulaCalculateCriteriaDto instances are equal
        /// </summary>
        /// <param name="other">Instance of FieldFormulaCalculateCriteriaDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FieldFormulaCalculateCriteriaDto other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.SearchFilterDto == other.SearchFilterDto ||
                    this.SearchFilterDto != null &&
                    this.SearchFilterDto.Equals(other.SearchFilterDto)
                ) && 
                (
                    this.FieldName == other.FieldName ||
                    this.FieldName != null &&
                    this.FieldName.Equals(other.FieldName)
                ) && 
                (
                    this.Formula == other.Formula ||
                    this.Formula != null &&
                    this.Formula.Equals(other.Formula)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.SearchFilterDto != null)
                    hash = hash * 59 + this.SearchFilterDto.GetHashCode();
                if (this.FieldName != null)
                    hash = hash * 59 + this.FieldName.GetHashCode();
                if (this.Formula != null)
                    hash = hash * 59 + this.Formula.GetHashCode();
                return hash;
            }
        }
    }

}
