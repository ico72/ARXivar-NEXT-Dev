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
    /// Criteria for all the call that retrieve information about additional field values or additional field filters
    /// </summary>
    [DataContract]
    public partial class FieldValuesSearchCriteriaDto :  IEquatable<FieldValuesSearchCriteriaDto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldValuesSearchCriteriaDto" /> class.
        /// </summary>
        /// <param name="SearchFilterDto">SearchFilterDto.</param>
        /// <param name="FieldName">FieldName.</param>
        /// <param name="FilterValue">FilterValue.</param>
        /// <param name="FilterId">FilterId.</param>
        /// <param name="Filters">Filters.</param>
        public FieldValuesSearchCriteriaDto(SearchDTO SearchFilterDto = null, string FieldName = null, string FilterValue = null, string FilterId = null, List<FieldBaseForSearchDTO> Filters = null)
        {
            this.SearchFilterDto = SearchFilterDto;
            this.FieldName = FieldName;
            this.FilterValue = FilterValue;
            this.FilterId = FilterId;
            this.Filters = Filters;
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
        /// Gets or Sets FilterValue
        /// </summary>
        [DataMember(Name="filterValue", EmitDefaultValue=false)]
        public string FilterValue { get; set; }
        /// <summary>
        /// Gets or Sets FilterId
        /// </summary>
        [DataMember(Name="filterId", EmitDefaultValue=false)]
        public string FilterId { get; set; }
        /// <summary>
        /// Gets or Sets Filters
        /// </summary>
        [DataMember(Name="filters", EmitDefaultValue=false)]
        public List<FieldBaseForSearchDTO> Filters { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FieldValuesSearchCriteriaDto {\n");
            sb.Append("  SearchFilterDto: ").Append(SearchFilterDto).Append("\n");
            sb.Append("  FieldName: ").Append(FieldName).Append("\n");
            sb.Append("  FilterValue: ").Append(FilterValue).Append("\n");
            sb.Append("  FilterId: ").Append(FilterId).Append("\n");
            sb.Append("  Filters: ").Append(Filters).Append("\n");
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
            return this.Equals(obj as FieldValuesSearchCriteriaDto);
        }

        /// <summary>
        /// Returns true if FieldValuesSearchCriteriaDto instances are equal
        /// </summary>
        /// <param name="other">Instance of FieldValuesSearchCriteriaDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FieldValuesSearchCriteriaDto other)
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
                    this.FilterValue == other.FilterValue ||
                    this.FilterValue != null &&
                    this.FilterValue.Equals(other.FilterValue)
                ) && 
                (
                    this.FilterId == other.FilterId ||
                    this.FilterId != null &&
                    this.FilterId.Equals(other.FilterId)
                ) && 
                (
                    this.Filters == other.Filters ||
                    this.Filters != null &&
                    this.Filters.SequenceEqual(other.Filters)
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
                if (this.FilterValue != null)
                    hash = hash * 59 + this.FilterValue.GetHashCode();
                if (this.FilterId != null)
                    hash = hash * 59 + this.FilterId.GetHashCode();
                if (this.Filters != null)
                    hash = hash * 59 + this.Filters.GetHashCode();
                return hash;
            }
        }
    }

}