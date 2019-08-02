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
    /// Class of exception state
    /// </summary>
    [DataContract]
    public partial class StateExceptionDTO :  IEquatable<StateExceptionDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StateExceptionDTO" /> class.
        /// </summary>
        /// <param name="userMessage">Message.</param>
        /// <param name="exceptionCode">Possible values:  0: Generico  1: Modalità .</param>
        public StateExceptionDTO(string userMessage = default(string), int? exceptionCode = default(int?))
        {
            this.UserMessage = userMessage;
            this.ExceptionCode = exceptionCode;
        }
        
        /// <summary>
        /// Message
        /// </summary>
        /// <value>Message</value>
        [DataMember(Name="userMessage", EmitDefaultValue=false)]
        public string UserMessage { get; set; }

        /// <summary>
        /// Possible values:  0: Generico  1: Modalità 
        /// </summary>
        /// <value>Possible values:  0: Generico  1: Modalità </value>
        [DataMember(Name="exceptionCode", EmitDefaultValue=false)]
        public int? ExceptionCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StateExceptionDTO {\n");
            sb.Append("  UserMessage: ").Append(UserMessage).Append("\n");
            sb.Append("  ExceptionCode: ").Append(ExceptionCode).Append("\n");
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
            return this.Equals(input as StateExceptionDTO);
        }

        /// <summary>
        /// Returns true if StateExceptionDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of StateExceptionDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StateExceptionDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UserMessage == input.UserMessage ||
                    (this.UserMessage != null &&
                    this.UserMessage.Equals(input.UserMessage))
                ) && 
                (
                    this.ExceptionCode == input.ExceptionCode ||
                    (this.ExceptionCode != null &&
                    this.ExceptionCode.Equals(input.ExceptionCode))
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
                if (this.UserMessage != null)
                    hashCode = hashCode * 59 + this.UserMessage.GetHashCode();
                if (this.ExceptionCode != null)
                    hashCode = hashCode * 59 + this.ExceptionCode.GetHashCode();
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
