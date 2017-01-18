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
    /// UserOptionsDto
    /// </summary>
    [DataContract]
    public partial class UserOptionsDto :  IEquatable<UserOptionsDto>
    {
        /// <summary>
        /// Gets or Sets DocumentTypeViewMode
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DocumentTypeViewModeEnum
        {
            
            /// <summary>
            /// Enum Code for "Code"
            /// </summary>
            [EnumMember(Value = "Code")]
            Code,
            
            /// <summary>
            /// Enum Description for "Description"
            /// </summary>
            [EnumMember(Value = "Description")]
            Description
        }

        /// <summary>
        /// Gets or Sets DocumentTypeViewMode
        /// </summary>
        [DataMember(Name="documentTypeViewMode", EmitDefaultValue=false)]
        public DocumentTypeViewModeEnum? DocumentTypeViewMode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserOptionsDto" /> class.
        /// </summary>
        /// <param name="Search">Search.</param>
        /// <param name="DocumentTypeViewMode">DocumentTypeViewMode.</param>
        public UserOptionsDto(UserSearchOptionDTO Search = null, DocumentTypeViewModeEnum? DocumentTypeViewMode = null)
        {
            this.Search = Search;
            this.DocumentTypeViewMode = DocumentTypeViewMode;
        }
        
        /// <summary>
        /// Gets or Sets Search
        /// </summary>
        [DataMember(Name="search", EmitDefaultValue=false)]
        public UserSearchOptionDTO Search { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserOptionsDto {\n");
            sb.Append("  Search: ").Append(Search).Append("\n");
            sb.Append("  DocumentTypeViewMode: ").Append(DocumentTypeViewMode).Append("\n");
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
            return this.Equals(obj as UserOptionsDto);
        }

        /// <summary>
        /// Returns true if UserOptionsDto instances are equal
        /// </summary>
        /// <param name="other">Instance of UserOptionsDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserOptionsDto other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Search == other.Search ||
                    this.Search != null &&
                    this.Search.Equals(other.Search)
                ) && 
                (
                    this.DocumentTypeViewMode == other.DocumentTypeViewMode ||
                    this.DocumentTypeViewMode != null &&
                    this.DocumentTypeViewMode.Equals(other.DocumentTypeViewMode)
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
                if (this.Search != null)
                    hash = hash * 59 + this.Search.GetHashCode();
                if (this.DocumentTypeViewMode != null)
                    hash = hash * 59 + this.DocumentTypeViewMode.GetHashCode();
                return hash;
            }
        }
    }

}
