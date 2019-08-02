/* 
 * Abletech.Arxivar.Server.WebApi.Services
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Class that represent the External Id of a document
    /// </summary>
    [DataContract]
    public partial class ByIdErpDto :  IEquatable<ByIdErpDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ByIdErpDto" /> class.
        /// </summary>
        /// <param name="idErp">idErp.</param>
        public ByIdErpDto(string idErp = default(string))
        {
            this.IdErp = idErp;
        }
        
        /// <summary>
        /// Gets or Sets IdErp
        /// </summary>
        [DataMember(Name="idErp", EmitDefaultValue=false)]
        public string IdErp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ByIdErpDto {\n");
            sb.Append("  IdErp: ").Append(IdErp).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ByIdErpDto);
        }

        /// <summary>
        /// Returns true if ByIdErpDto instances are equal
        /// </summary>
        /// <param name="input">Instance of ByIdErpDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ByIdErpDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IdErp == input.IdErp ||
                    (this.IdErp != null &&
                    this.IdErp.Equals(input.IdErp))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.IdErp != null)
                    hashCode = hashCode * 59 + this.IdErp.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
