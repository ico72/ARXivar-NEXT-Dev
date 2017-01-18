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
    /// QuickSearchDto
    /// </summary>
    [DataContract]
    public partial class QuickSearchDto :  IEquatable<QuickSearchDto>
    {
        /// <summary>
        /// Gets or Sets DaAAndOr
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DaAAndOrEnum
        {
            
            /// <summary>
            /// Enum And for "And"
            /// </summary>
            [EnumMember(Value = "And")]
            And,
            
            /// <summary>
            /// Enum Or for "Or"
            /// </summary>
            [EnumMember(Value = "Or")]
            Or
        }

        /// <summary>
        /// Gets or Sets DaAAndOr
        /// </summary>
        [DataMember(Name="daAAndOr", EmitDefaultValue=false)]
        public DaAAndOrEnum? DaAAndOr { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="QuickSearchDto" /> class.
        /// </summary>
        /// <param name="Find">Find.</param>
        /// <param name="MaxItems">MaxItems.</param>
        /// <param name="DaAAndOr">DaAAndOr.</param>
        /// <param name="SearchFilterDto">SearchFilterDto.</param>
        /// <param name="SelectFilterDto">SelectFilterDto.</param>
        public QuickSearchDto(FindDTO Find = null, int? MaxItems = null, DaAAndOrEnum? DaAAndOr = null, SearchDTO SearchFilterDto = null, SelectDTO SelectFilterDto = null)
        {
            this.Find = Find;
            this.MaxItems = MaxItems;
            this.DaAAndOr = DaAAndOr;
            this.SearchFilterDto = SearchFilterDto;
            this.SelectFilterDto = SelectFilterDto;
        }
        
        /// <summary>
        /// Gets or Sets Find
        /// </summary>
        [DataMember(Name="find", EmitDefaultValue=false)]
        public FindDTO Find { get; set; }
        /// <summary>
        /// Gets or Sets MaxItems
        /// </summary>
        [DataMember(Name="maxItems", EmitDefaultValue=false)]
        public int? MaxItems { get; set; }
        /// <summary>
        /// Gets or Sets SearchFilterDto
        /// </summary>
        [DataMember(Name="searchFilterDto", EmitDefaultValue=false)]
        public SearchDTO SearchFilterDto { get; set; }
        /// <summary>
        /// Gets or Sets SelectFilterDto
        /// </summary>
        [DataMember(Name="selectFilterDto", EmitDefaultValue=false)]
        public SelectDTO SelectFilterDto { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QuickSearchDto {\n");
            sb.Append("  Find: ").Append(Find).Append("\n");
            sb.Append("  MaxItems: ").Append(MaxItems).Append("\n");
            sb.Append("  DaAAndOr: ").Append(DaAAndOr).Append("\n");
            sb.Append("  SearchFilterDto: ").Append(SearchFilterDto).Append("\n");
            sb.Append("  SelectFilterDto: ").Append(SelectFilterDto).Append("\n");
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
            return this.Equals(obj as QuickSearchDto);
        }

        /// <summary>
        /// Returns true if QuickSearchDto instances are equal
        /// </summary>
        /// <param name="other">Instance of QuickSearchDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QuickSearchDto other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Find == other.Find ||
                    this.Find != null &&
                    this.Find.Equals(other.Find)
                ) && 
                (
                    this.MaxItems == other.MaxItems ||
                    this.MaxItems != null &&
                    this.MaxItems.Equals(other.MaxItems)
                ) && 
                (
                    this.DaAAndOr == other.DaAAndOr ||
                    this.DaAAndOr != null &&
                    this.DaAAndOr.Equals(other.DaAAndOr)
                ) && 
                (
                    this.SearchFilterDto == other.SearchFilterDto ||
                    this.SearchFilterDto != null &&
                    this.SearchFilterDto.Equals(other.SearchFilterDto)
                ) && 
                (
                    this.SelectFilterDto == other.SelectFilterDto ||
                    this.SelectFilterDto != null &&
                    this.SelectFilterDto.Equals(other.SelectFilterDto)
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
                if (this.Find != null)
                    hash = hash * 59 + this.Find.GetHashCode();
                if (this.MaxItems != null)
                    hash = hash * 59 + this.MaxItems.GetHashCode();
                if (this.DaAAndOr != null)
                    hash = hash * 59 + this.DaAAndOr.GetHashCode();
                if (this.SearchFilterDto != null)
                    hash = hash * 59 + this.SearchFilterDto.GetHashCode();
                if (this.SelectFilterDto != null)
                    hash = hash * 59 + this.SelectFilterDto.GetHashCode();
                return hash;
            }
        }
    }

}
