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
    /// AttachmentsGridDTO
    /// </summary>
    [DataContract]
    public partial class AttachmentsGridDTO :  IEquatable<AttachmentsGridDTO>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AttachmentsGridDTO" /> class.
        /// </summary>
        /// <param name="ExternalAttachments">ExternalAttachments.</param>
        /// <param name="InternalAttachments">InternalAttachments.</param>
        public AttachmentsGridDTO(List<RowSearchResult> ExternalAttachments = null, List<RowSearchResult> InternalAttachments = null)
        {
            this.ExternalAttachments = ExternalAttachments;
            this.InternalAttachments = InternalAttachments;
        }
        
        /// <summary>
        /// Gets or Sets ExternalAttachments
        /// </summary>
        [DataMember(Name="externalAttachments", EmitDefaultValue=false)]
        public List<RowSearchResult> ExternalAttachments { get; set; }
        /// <summary>
        /// Gets or Sets InternalAttachments
        /// </summary>
        [DataMember(Name="internalAttachments", EmitDefaultValue=false)]
        public List<RowSearchResult> InternalAttachments { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AttachmentsGridDTO {\n");
            sb.Append("  ExternalAttachments: ").Append(ExternalAttachments).Append("\n");
            sb.Append("  InternalAttachments: ").Append(InternalAttachments).Append("\n");
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
            return this.Equals(obj as AttachmentsGridDTO);
        }

        /// <summary>
        /// Returns true if AttachmentsGridDTO instances are equal
        /// </summary>
        /// <param name="other">Instance of AttachmentsGridDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AttachmentsGridDTO other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ExternalAttachments == other.ExternalAttachments ||
                    this.ExternalAttachments != null &&
                    this.ExternalAttachments.SequenceEqual(other.ExternalAttachments)
                ) && 
                (
                    this.InternalAttachments == other.InternalAttachments ||
                    this.InternalAttachments != null &&
                    this.InternalAttachments.SequenceEqual(other.InternalAttachments)
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
                if (this.ExternalAttachments != null)
                    hash = hash * 59 + this.ExternalAttachments.GetHashCode();
                if (this.InternalAttachments != null)
                    hash = hash * 59 + this.InternalAttachments.GetHashCode();
                return hash;
            }
        }
    }

}