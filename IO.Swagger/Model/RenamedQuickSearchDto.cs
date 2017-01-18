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
    /// RenamedQuickSearchDto
    /// </summary>
    [DataContract]
    public partial class RenamedQuickSearchDto :  IEquatable<RenamedQuickSearchDto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RenamedQuickSearchDto" /> class.
        /// </summary>
        /// <param name="QuickSearchId">QuickSearchId.</param>
        /// <param name="Description">Description.</param>
        public RenamedQuickSearchDto(string QuickSearchId = null, string Description = null)
        {
            this.QuickSearchId = QuickSearchId;
            this.Description = Description;
        }
        
        /// <summary>
        /// Gets or Sets QuickSearchId
        /// </summary>
        [DataMember(Name="quickSearchId", EmitDefaultValue=false)]
        public string QuickSearchId { get; set; }
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RenamedQuickSearchDto {\n");
            sb.Append("  QuickSearchId: ").Append(QuickSearchId).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return this.Equals(obj as RenamedQuickSearchDto);
        }

        /// <summary>
        /// Returns true if RenamedQuickSearchDto instances are equal
        /// </summary>
        /// <param name="other">Instance of RenamedQuickSearchDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RenamedQuickSearchDto other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.QuickSearchId == other.QuickSearchId ||
                    this.QuickSearchId != null &&
                    this.QuickSearchId.Equals(other.QuickSearchId)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
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
                if (this.QuickSearchId != null)
                    hash = hash * 59 + this.QuickSearchId.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                return hash;
            }
        }
    }

}
