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
    /// ProfileResultDTO
    /// </summary>
    [DataContract]
    public partial class ProfileResultDTO :  IEquatable<ProfileResultDTO>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProfileResultDTO" /> class.
        /// </summary>
        /// <param name="DocNumber">DocNumber.</param>
        /// <param name="InternalProtocolNumber">InternalProtocolNumber.</param>
        /// <param name="Year">Year.</param>
        /// <param name="ProtocolNumber">ProtocolNumber.</param>
        /// <param name="ShowMessage">ShowMessage.</param>
        public ProfileResultDTO(int? DocNumber = null, string InternalProtocolNumber = null, string Year = null, string ProtocolNumber = null, bool? ShowMessage = null)
        {
            this.DocNumber = DocNumber;
            this.InternalProtocolNumber = InternalProtocolNumber;
            this.Year = Year;
            this.ProtocolNumber = ProtocolNumber;
            this.ShowMessage = ShowMessage;
        }
        
        /// <summary>
        /// Gets or Sets DocNumber
        /// </summary>
        [DataMember(Name="docNumber", EmitDefaultValue=false)]
        public int? DocNumber { get; set; }
        /// <summary>
        /// Gets or Sets InternalProtocolNumber
        /// </summary>
        [DataMember(Name="internalProtocolNumber", EmitDefaultValue=false)]
        public string InternalProtocolNumber { get; set; }
        /// <summary>
        /// Gets or Sets Year
        /// </summary>
        [DataMember(Name="year", EmitDefaultValue=false)]
        public string Year { get; set; }
        /// <summary>
        /// Gets or Sets ProtocolNumber
        /// </summary>
        [DataMember(Name="protocolNumber", EmitDefaultValue=false)]
        public string ProtocolNumber { get; set; }
        /// <summary>
        /// Gets or Sets ShowMessage
        /// </summary>
        [DataMember(Name="showMessage", EmitDefaultValue=false)]
        public bool? ShowMessage { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProfileResultDTO {\n");
            sb.Append("  DocNumber: ").Append(DocNumber).Append("\n");
            sb.Append("  InternalProtocolNumber: ").Append(InternalProtocolNumber).Append("\n");
            sb.Append("  Year: ").Append(Year).Append("\n");
            sb.Append("  ProtocolNumber: ").Append(ProtocolNumber).Append("\n");
            sb.Append("  ShowMessage: ").Append(ShowMessage).Append("\n");
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
            return this.Equals(obj as ProfileResultDTO);
        }

        /// <summary>
        /// Returns true if ProfileResultDTO instances are equal
        /// </summary>
        /// <param name="other">Instance of ProfileResultDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProfileResultDTO other)
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
                    this.InternalProtocolNumber == other.InternalProtocolNumber ||
                    this.InternalProtocolNumber != null &&
                    this.InternalProtocolNumber.Equals(other.InternalProtocolNumber)
                ) && 
                (
                    this.Year == other.Year ||
                    this.Year != null &&
                    this.Year.Equals(other.Year)
                ) && 
                (
                    this.ProtocolNumber == other.ProtocolNumber ||
                    this.ProtocolNumber != null &&
                    this.ProtocolNumber.Equals(other.ProtocolNumber)
                ) && 
                (
                    this.ShowMessage == other.ShowMessage ||
                    this.ShowMessage != null &&
                    this.ShowMessage.Equals(other.ShowMessage)
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
                if (this.InternalProtocolNumber != null)
                    hash = hash * 59 + this.InternalProtocolNumber.GetHashCode();
                if (this.Year != null)
                    hash = hash * 59 + this.Year.GetHashCode();
                if (this.ProtocolNumber != null)
                    hash = hash * 59 + this.ProtocolNumber.GetHashCode();
                if (this.ShowMessage != null)
                    hash = hash * 59 + this.ShowMessage.GetHashCode();
                return hash;
            }
        }
    }

}