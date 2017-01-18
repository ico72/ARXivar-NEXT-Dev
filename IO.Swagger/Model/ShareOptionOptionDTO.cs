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
    /// ShareOptionOptionDTO
    /// </summary>
    [DataContract]
    public partial class ShareOptionOptionDTO :  IEquatable<ShareOptionOptionDTO>
    {
        /// <summary>
        /// Gets or Sets Option
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OptionEnum
        {
            
            /// <summary>
            /// Enum Lettura for "Lettura"
            /// </summary>
            [EnumMember(Value = "Lettura")]
            Lettura,
            
            /// <summary>
            /// Enum LetturaScrittura for "LetturaScrittura"
            /// </summary>
            [EnumMember(Value = "LetturaScrittura")]
            LetturaScrittura
        }

        /// <summary>
        /// Gets or Sets Option
        /// </summary>
        [DataMember(Name="option", EmitDefaultValue=false)]
        public OptionEnum? Option { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShareOptionOptionDTO" /> class.
        /// </summary>
        /// <param name="Option">Option.</param>
        /// <param name="OptionUserMessage">OptionUserMessage.</param>
        public ShareOptionOptionDTO(OptionEnum? Option = null, string OptionUserMessage = null)
        {
            this.Option = Option;
            this.OptionUserMessage = OptionUserMessage;
        }
        
        /// <summary>
        /// Gets or Sets OptionUserMessage
        /// </summary>
        [DataMember(Name="optionUserMessage", EmitDefaultValue=false)]
        public string OptionUserMessage { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShareOptionOptionDTO {\n");
            sb.Append("  Option: ").Append(Option).Append("\n");
            sb.Append("  OptionUserMessage: ").Append(OptionUserMessage).Append("\n");
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
            return this.Equals(obj as ShareOptionOptionDTO);
        }

        /// <summary>
        /// Returns true if ShareOptionOptionDTO instances are equal
        /// </summary>
        /// <param name="other">Instance of ShareOptionOptionDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShareOptionOptionDTO other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Option == other.Option ||
                    this.Option != null &&
                    this.Option.Equals(other.Option)
                ) && 
                (
                    this.OptionUserMessage == other.OptionUserMessage ||
                    this.OptionUserMessage != null &&
                    this.OptionUserMessage.Equals(other.OptionUserMessage)
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
                if (this.Option != null)
                    hash = hash * 59 + this.Option.GetHashCode();
                if (this.OptionUserMessage != null)
                    hash = hash * 59 + this.OptionUserMessage.GetHashCode();
                return hash;
            }
        }
    }

}
