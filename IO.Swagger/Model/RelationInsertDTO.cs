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
    /// RelationInsertDTO
    /// </summary>
    [DataContract]
    public partial class RelationInsertDTO :  IEquatable<RelationInsertDTO>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RelationInsertDTO" /> class.
        /// </summary>
        /// <param name="DocNumber">DocNumber.</param>
        /// <param name="Items">Items.</param>
        public RelationInsertDTO(int? DocNumber = null, List<RelationInsertItemDTO> Items = null)
        {
            this.DocNumber = DocNumber;
            this.Items = Items;
        }
        
        /// <summary>
        /// Gets or Sets DocNumber
        /// </summary>
        [DataMember(Name="docNumber", EmitDefaultValue=false)]
        public int? DocNumber { get; set; }
        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public List<RelationInsertItemDTO> Items { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RelationInsertDTO {\n");
            sb.Append("  DocNumber: ").Append(DocNumber).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
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
            return this.Equals(obj as RelationInsertDTO);
        }

        /// <summary>
        /// Returns true if RelationInsertDTO instances are equal
        /// </summary>
        /// <param name="other">Instance of RelationInsertDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RelationInsertDTO other)
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
                    this.Items == other.Items ||
                    this.Items != null &&
                    this.Items.SequenceEqual(other.Items)
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
                if (this.Items != null)
                    hash = hash * 59 + this.Items.GetHashCode();
                return hash;
            }
        }
    }

}
