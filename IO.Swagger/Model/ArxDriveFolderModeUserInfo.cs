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
    /// ArxDriveFolderModeUserInfo
    /// </summary>
    [DataContract]
    public partial class ArxDriveFolderModeUserInfo :  IEquatable<ArxDriveFolderModeUserInfo>
    {
        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CategoryEnum
        {
            
            /// <summary>
            /// Enum U for "U"
            /// </summary>
            [EnumMember(Value = "U")]
            U,
            
            /// <summary>
            /// Enum S for "S"
            /// </summary>
            [EnumMember(Value = "S")]
            S,
            
            /// <summary>
            /// Enum M for "M"
            /// </summary>
            [EnumMember(Value = "M")]
            M,
            
            /// <summary>
            /// Enum F for "F"
            /// </summary>
            [EnumMember(Value = "F")]
            F,
            
            /// <summary>
            /// Enum G for "G"
            /// </summary>
            [EnumMember(Value = "G")]
            G,
            
            /// <summary>
            /// Enum I for "I"
            /// </summary>
            [EnumMember(Value = "I")]
            I,
            
            /// <summary>
            /// Enum D for "D"
            /// </summary>
            [EnumMember(Value = "D")]
            D
        }

        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public CategoryEnum? Category { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ArxDriveFolderModeUserInfo" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="UserId">UserId.</param>
        /// <param name="UserCompleteName">UserCompleteName.</param>
        /// <param name="Category">Category.</param>
        public ArxDriveFolderModeUserInfo(int? Id = null, int? UserId = null, string UserCompleteName = null, CategoryEnum? Category = null)
        {
            this.Id = Id;
            this.UserId = UserId;
            this.UserCompleteName = UserCompleteName;
            this.Category = Category;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }
        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public int? UserId { get; set; }
        /// <summary>
        /// Gets or Sets UserCompleteName
        /// </summary>
        [DataMember(Name="userCompleteName", EmitDefaultValue=false)]
        public string UserCompleteName { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ArxDriveFolderModeUserInfo {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  UserCompleteName: ").Append(UserCompleteName).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
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
            return this.Equals(obj as ArxDriveFolderModeUserInfo);
        }

        /// <summary>
        /// Returns true if ArxDriveFolderModeUserInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of ArxDriveFolderModeUserInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ArxDriveFolderModeUserInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) && 
                (
                    this.UserCompleteName == other.UserCompleteName ||
                    this.UserCompleteName != null &&
                    this.UserCompleteName.Equals(other.UserCompleteName)
                ) && 
                (
                    this.Category == other.Category ||
                    this.Category != null &&
                    this.Category.Equals(other.Category)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();
                if (this.UserCompleteName != null)
                    hash = hash * 59 + this.UserCompleteName.GetHashCode();
                if (this.Category != null)
                    hash = hash * 59 + this.Category.GetHashCode();
                return hash;
            }
        }
    }

}