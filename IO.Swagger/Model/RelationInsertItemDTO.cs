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
    /// RelationInsertItemDTO
    /// </summary>
    [DataContract]
    public partial class RelationInsertItemDTO :  IEquatable<RelationInsertItemDTO>
    {
        /// <summary>
        /// Gets or Sets RelationType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RelationTypeEnum
        {
            
            /// <summary>
            /// Enum Date for "Date"
            /// </summary>
            [EnumMember(Value = "Date")]
            Date,
            
            /// <summary>
            /// Enum Father for "Father"
            /// </summary>
            [EnumMember(Value = "Father")]
            Father,
            
            /// <summary>
            /// Enum Child for "Child"
            /// </summary>
            [EnumMember(Value = "Child")]
            Child
        }

        /// <summary>
        /// Gets or Sets RelationType
        /// </summary>
        [DataMember(Name="relationType", EmitDefaultValue=false)]
        public RelationTypeEnum? RelationType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RelationInsertItemDTO" /> class.
        /// </summary>
        /// <param name="DocNumber">DocNumber.</param>
        /// <param name="RelationType">RelationType.</param>
        public RelationInsertItemDTO(int? DocNumber = null, RelationTypeEnum? RelationType = null)
        {
            this.DocNumber = DocNumber;
            this.RelationType = RelationType;
        }
        
        /// <summary>
        /// Gets or Sets DocNumber
        /// </summary>
        [DataMember(Name="docNumber", EmitDefaultValue=false)]
        public int? DocNumber { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RelationInsertItemDTO {\n");
            sb.Append("  DocNumber: ").Append(DocNumber).Append("\n");
            sb.Append("  RelationType: ").Append(RelationType).Append("\n");
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
            return this.Equals(obj as RelationInsertItemDTO);
        }

        /// <summary>
        /// Returns true if RelationInsertItemDTO instances are equal
        /// </summary>
        /// <param name="other">Instance of RelationInsertItemDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RelationInsertItemDTO other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DocNumber == other.DocNumber ||
                    this.DocNumber != null &&
                    this.DocNumber.Equals(other.DocNumber)
                ) && 
                (
                    this.RelationType == other.RelationType ||
                    this.RelationType != null &&
                    this.RelationType.Equals(other.RelationType)
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
                if (this.DocNumber != null)
                    hash = hash * 59 + this.DocNumber.GetHashCode();
                if (this.RelationType != null)
                    hash = hash * 59 + this.RelationType.GetHashCode();
                return hash;
            }
        }
    }

}