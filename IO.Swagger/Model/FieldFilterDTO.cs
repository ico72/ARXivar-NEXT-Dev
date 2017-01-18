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
    /// This class contain information about avaible filters for a given additional field
    /// </summary>
    [DataContract]
    public partial class FieldFilterDTO :  IEquatable<FieldFilterDTO>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldFilterDTO" /> class.
        /// </summary>
        /// <param name="KeyField">The column name of the property that the client have to use for set the value of the additional field.</param>
        /// <param name="SelectField">The column name of the property that the client have to use for display the value of the additional field.</param>
        /// <param name="Filters">Array of avaible filters for the additional field.</param>
        /// <param name="ShowFilled">This property show to client if the search for this field has to be prefilled or not.</param>
        /// <param name="DefaultField">The name of filter to use for this field by default.</param>
        public FieldFilterDTO(string KeyField = null, string SelectField = null, List<FieldBaseForSearchDTO> Filters = null, bool? ShowFilled = null, string DefaultField = null)
        {
            this.KeyField = KeyField;
            this.SelectField = SelectField;
            this.Filters = Filters;
            this.ShowFilled = ShowFilled;
            this.DefaultField = DefaultField;
        }
        
        /// <summary>
        /// The column name of the property that the client have to use for set the value of the additional field
        /// </summary>
        /// <value>The column name of the property that the client have to use for set the value of the additional field</value>
        [DataMember(Name="keyField", EmitDefaultValue=false)]
        public string KeyField { get; set; }
        /// <summary>
        /// The column name of the property that the client have to use for display the value of the additional field
        /// </summary>
        /// <value>The column name of the property that the client have to use for display the value of the additional field</value>
        [DataMember(Name="selectField", EmitDefaultValue=false)]
        public string SelectField { get; set; }
        /// <summary>
        /// Array of avaible filters for the additional field
        /// </summary>
        /// <value>Array of avaible filters for the additional field</value>
        [DataMember(Name="filters", EmitDefaultValue=false)]
        public List<FieldBaseForSearchDTO> Filters { get; set; }
        /// <summary>
        /// This property show to client if the search for this field has to be prefilled or not
        /// </summary>
        /// <value>This property show to client if the search for this field has to be prefilled or not</value>
        [DataMember(Name="showFilled", EmitDefaultValue=false)]
        public bool? ShowFilled { get; set; }
        /// <summary>
        /// The name of filter to use for this field by default
        /// </summary>
        /// <value>The name of filter to use for this field by default</value>
        [DataMember(Name="defaultField", EmitDefaultValue=false)]
        public string DefaultField { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FieldFilterDTO {\n");
            sb.Append("  KeyField: ").Append(KeyField).Append("\n");
            sb.Append("  SelectField: ").Append(SelectField).Append("\n");
            sb.Append("  Filters: ").Append(Filters).Append("\n");
            sb.Append("  ShowFilled: ").Append(ShowFilled).Append("\n");
            sb.Append("  DefaultField: ").Append(DefaultField).Append("\n");
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
            return this.Equals(obj as FieldFilterDTO);
        }

        /// <summary>
        /// Returns true if FieldFilterDTO instances are equal
        /// </summary>
        /// <param name="other">Instance of FieldFilterDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FieldFilterDTO other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.KeyField == other.KeyField ||
                    this.KeyField != null &&
                    this.KeyField.Equals(other.KeyField)
                ) && 
                (
                    this.SelectField == other.SelectField ||
                    this.SelectField != null &&
                    this.SelectField.Equals(other.SelectField)
                ) && 
                (
                    this.Filters == other.Filters ||
                    this.Filters != null &&
                    this.Filters.SequenceEqual(other.Filters)
                ) && 
                (
                    this.ShowFilled == other.ShowFilled ||
                    this.ShowFilled != null &&
                    this.ShowFilled.Equals(other.ShowFilled)
                ) && 
                (
                    this.DefaultField == other.DefaultField ||
                    this.DefaultField != null &&
                    this.DefaultField.Equals(other.DefaultField)
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
                if (this.KeyField != null)
                    hash = hash * 59 + this.KeyField.GetHashCode();
                if (this.SelectField != null)
                    hash = hash * 59 + this.SelectField.GetHashCode();
                if (this.Filters != null)
                    hash = hash * 59 + this.Filters.GetHashCode();
                if (this.ShowFilled != null)
                    hash = hash * 59 + this.ShowFilled.GetHashCode();
                if (this.DefaultField != null)
                    hash = hash * 59 + this.DefaultField.GetHashCode();
                return hash;
            }
        }
    }

}