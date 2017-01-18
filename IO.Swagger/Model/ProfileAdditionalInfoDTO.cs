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
    /// ProfileAdditionalInfoDTO
    /// </summary>
    [DataContract]
    public partial class ProfileAdditionalInfoDTO :  IEquatable<ProfileAdditionalInfoDTO>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProfileAdditionalInfoDTO" /> class.
        /// </summary>
        /// <param name="IsProtocolEnabled">IsProtocolEnabled.</param>
        /// <param name="ProtocolNumber">ProtocolNumber.</param>
        /// <param name="FileName">FileName.</param>
        /// <param name="DocNumber">DocNumber.</param>
        /// <param name="Revision">Revision.</param>
        /// <param name="CreationDate">CreationDate.</param>
        /// <param name="ProtocolDate">ProtocolDate.</param>
        /// <param name="Author">Author.</param>
        public ProfileAdditionalInfoDTO(bool? IsProtocolEnabled = null, string ProtocolNumber = null, string FileName = null, int? DocNumber = null, int? Revision = null, DateTime? CreationDate = null, DateTime? ProtocolDate = null, string Author = null)
        {
            this.IsProtocolEnabled = IsProtocolEnabled;
            this.ProtocolNumber = ProtocolNumber;
            this.FileName = FileName;
            this.DocNumber = DocNumber;
            this.Revision = Revision;
            this.CreationDate = CreationDate;
            this.ProtocolDate = ProtocolDate;
            this.Author = Author;
        }
        
        /// <summary>
        /// Gets or Sets IsProtocolEnabled
        /// </summary>
        [DataMember(Name="isProtocolEnabled", EmitDefaultValue=false)]
        public bool? IsProtocolEnabled { get; set; }
        /// <summary>
        /// Gets or Sets ProtocolNumber
        /// </summary>
        [DataMember(Name="protocolNumber", EmitDefaultValue=false)]
        public string ProtocolNumber { get; set; }
        /// <summary>
        /// Gets or Sets FileName
        /// </summary>
        [DataMember(Name="fileName", EmitDefaultValue=false)]
        public string FileName { get; set; }
        /// <summary>
        /// Gets or Sets DocNumber
        /// </summary>
        [DataMember(Name="docNumber", EmitDefaultValue=false)]
        public int? DocNumber { get; set; }
        /// <summary>
        /// Gets or Sets Revision
        /// </summary>
        [DataMember(Name="revision", EmitDefaultValue=false)]
        public int? Revision { get; set; }
        /// <summary>
        /// Gets or Sets CreationDate
        /// </summary>
        [DataMember(Name="creationDate", EmitDefaultValue=false)]
        public DateTime? CreationDate { get; set; }
        /// <summary>
        /// Gets or Sets ProtocolDate
        /// </summary>
        [DataMember(Name="protocolDate", EmitDefaultValue=false)]
        public DateTime? ProtocolDate { get; set; }
        /// <summary>
        /// Gets or Sets Author
        /// </summary>
        [DataMember(Name="author", EmitDefaultValue=false)]
        public string Author { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProfileAdditionalInfoDTO {\n");
            sb.Append("  IsProtocolEnabled: ").Append(IsProtocolEnabled).Append("\n");
            sb.Append("  ProtocolNumber: ").Append(ProtocolNumber).Append("\n");
            sb.Append("  FileName: ").Append(FileName).Append("\n");
            sb.Append("  DocNumber: ").Append(DocNumber).Append("\n");
            sb.Append("  Revision: ").Append(Revision).Append("\n");
            sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
            sb.Append("  ProtocolDate: ").Append(ProtocolDate).Append("\n");
            sb.Append("  Author: ").Append(Author).Append("\n");
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
            return this.Equals(obj as ProfileAdditionalInfoDTO);
        }

        /// <summary>
        /// Returns true if ProfileAdditionalInfoDTO instances are equal
        /// </summary>
        /// <param name="other">Instance of ProfileAdditionalInfoDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProfileAdditionalInfoDTO other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IsProtocolEnabled == other.IsProtocolEnabled ||
                    this.IsProtocolEnabled != null &&
                    this.IsProtocolEnabled.Equals(other.IsProtocolEnabled)
                ) && 
                (
                    this.ProtocolNumber == other.ProtocolNumber ||
                    this.ProtocolNumber != null &&
                    this.ProtocolNumber.Equals(other.ProtocolNumber)
                ) && 
                (
                    this.FileName == other.FileName ||
                    this.FileName != null &&
                    this.FileName.Equals(other.FileName)
                ) && 
                (
                    this.DocNumber == other.DocNumber ||
                    this.DocNumber != null &&
                    this.DocNumber.Equals(other.DocNumber)
                ) && 
                (
                    this.Revision == other.Revision ||
                    this.Revision != null &&
                    this.Revision.Equals(other.Revision)
                ) && 
                (
                    this.CreationDate == other.CreationDate ||
                    this.CreationDate != null &&
                    this.CreationDate.Equals(other.CreationDate)
                ) && 
                (
                    this.ProtocolDate == other.ProtocolDate ||
                    this.ProtocolDate != null &&
                    this.ProtocolDate.Equals(other.ProtocolDate)
                ) && 
                (
                    this.Author == other.Author ||
                    this.Author != null &&
                    this.Author.Equals(other.Author)
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
                if (this.IsProtocolEnabled != null)
                    hash = hash * 59 + this.IsProtocolEnabled.GetHashCode();
                if (this.ProtocolNumber != null)
                    hash = hash * 59 + this.ProtocolNumber.GetHashCode();
                if (this.FileName != null)
                    hash = hash * 59 + this.FileName.GetHashCode();
                if (this.DocNumber != null)
                    hash = hash * 59 + this.DocNumber.GetHashCode();
                if (this.Revision != null)
                    hash = hash * 59 + this.Revision.GetHashCode();
                if (this.CreationDate != null)
                    hash = hash * 59 + this.CreationDate.GetHashCode();
                if (this.ProtocolDate != null)
                    hash = hash * 59 + this.ProtocolDate.GetHashCode();
                if (this.Author != null)
                    hash = hash * 59 + this.Author.GetHashCode();
                return hash;
            }
        }
    }

}
