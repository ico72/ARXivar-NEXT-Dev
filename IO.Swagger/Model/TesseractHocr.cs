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
    /// TesseractHocr
    /// </summary>
    [DataContract]
    public partial class TesseractHocr :  IEquatable<TesseractHocr>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TesseractHocr" /> class.
        /// </summary>
        /// <param name="Areas">Areas.</param>
        /// <param name="Words">Words.</param>
        public TesseractHocr(List<AreaDTO> Areas = null, List<AreaDTO> Words = null)
        {
            this.Areas = Areas;
            this.Words = Words;
        }
        
        /// <summary>
        /// Gets or Sets Areas
        /// </summary>
        [DataMember(Name="areas", EmitDefaultValue=false)]
        public List<AreaDTO> Areas { get; set; }
        /// <summary>
        /// Gets or Sets Words
        /// </summary>
        [DataMember(Name="words", EmitDefaultValue=false)]
        public List<AreaDTO> Words { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TesseractHocr {\n");
            sb.Append("  Areas: ").Append(Areas).Append("\n");
            sb.Append("  Words: ").Append(Words).Append("\n");
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
            return this.Equals(obj as TesseractHocr);
        }

        /// <summary>
        /// Returns true if TesseractHocr instances are equal
        /// </summary>
        /// <param name="other">Instance of TesseractHocr to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TesseractHocr other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Areas == other.Areas ||
                    this.Areas != null &&
                    this.Areas.SequenceEqual(other.Areas)
                ) && 
                (
                    this.Words == other.Words ||
                    this.Words != null &&
                    this.Words.SequenceEqual(other.Words)
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
                if (this.Areas != null)
                    hash = hash * 59 + this.Areas.GetHashCode();
                if (this.Words != null)
                    hash = hash * 59 + this.Words.GetHashCode();
                return hash;
            }
        }
    }

}
