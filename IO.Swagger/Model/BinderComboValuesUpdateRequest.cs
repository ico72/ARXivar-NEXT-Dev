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
    /// Dto for update binder combo custom fields values
    /// </summary>
    [DataContract]
    public partial class BinderComboValuesUpdateRequest :  IEquatable<BinderComboValuesUpdateRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BinderComboValuesUpdateRequest" /> class.
        /// </summary>
        /// <param name="Values">Array of values to update.</param>
        /// <param name="BinderComboCustomFieldId">The id of the binder custom combo field.</param>
        public BinderComboValuesUpdateRequest(List<string> Values = null, int? BinderComboCustomFieldId = null)
        {
            this.Values = Values;
            this.BinderComboCustomFieldId = BinderComboCustomFieldId;
        }
        
        /// <summary>
        /// Array of values to update
        /// </summary>
        /// <value>Array of values to update</value>
        [DataMember(Name="values", EmitDefaultValue=false)]
        public List<string> Values { get; set; }
        /// <summary>
        /// The id of the binder custom combo field
        /// </summary>
        /// <value>The id of the binder custom combo field</value>
        [DataMember(Name="binderComboCustomFieldId", EmitDefaultValue=false)]
        public int? BinderComboCustomFieldId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BinderComboValuesUpdateRequest {\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
            sb.Append("  BinderComboCustomFieldId: ").Append(BinderComboCustomFieldId).Append("\n");
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
            return this.Equals(obj as BinderComboValuesUpdateRequest);
        }

        /// <summary>
        /// Returns true if BinderComboValuesUpdateRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of BinderComboValuesUpdateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BinderComboValuesUpdateRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Values == other.Values ||
                    this.Values != null &&
                    this.Values.SequenceEqual(other.Values)
                ) && 
                (
                    this.BinderComboCustomFieldId == other.BinderComboCustomFieldId ||
                    this.BinderComboCustomFieldId != null &&
                    this.BinderComboCustomFieldId.Equals(other.BinderComboCustomFieldId)
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
                if (this.Values != null)
                    hash = hash * 59 + this.Values.GetHashCode();
                if (this.BinderComboCustomFieldId != null)
                    hash = hash * 59 + this.BinderComboCustomFieldId.GetHashCode();
                return hash;
            }
        }
    }

}