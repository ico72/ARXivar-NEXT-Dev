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
    /// TaskWorkVariableOperationDTO
    /// </summary>
    [DataContract]
    public partial class TaskWorkVariableOperationDTO :  IEquatable<TaskWorkVariableOperationDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskWorkVariableOperationDTO" /> class.
        /// </summary>
        /// <param name="processVariables">processVariables.</param>
        /// <param name="processVariablesFields">processVariablesFields.</param>
        /// <param name="description">description.</param>
        /// <param name="executed">Indica se l&#39;operazione di valorizzazione variabili è stata eseguita, è la somma logica di tutte le variabili sono state valorizzate.</param>
        /// <param name="required">required.</param>
        public TaskWorkVariableOperationDTO(List<ProcessVariableDTO> processVariables = default(List<ProcessVariableDTO>), ProcessVariablesFieldsDTO processVariablesFields = default(ProcessVariablesFieldsDTO), string description = default(string), bool? executed = default(bool?), bool? required = default(bool?))
        {
            this.ProcessVariables = processVariables;
            this.ProcessVariablesFields = processVariablesFields;
            this.Description = description;
            this.Executed = executed;
            this.Required = required;
        }
        
        /// <summary>
        /// Gets or Sets ProcessVariables
        /// </summary>
        [DataMember(Name="processVariables", EmitDefaultValue=false)]
        public List<ProcessVariableDTO> ProcessVariables { get; set; }

        /// <summary>
        /// Gets or Sets ProcessVariablesFields
        /// </summary>
        [DataMember(Name="processVariablesFields", EmitDefaultValue=false)]
        public ProcessVariablesFieldsDTO ProcessVariablesFields { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Indica se l&#39;operazione di valorizzazione variabili è stata eseguita, è la somma logica di tutte le variabili sono state valorizzate
        /// </summary>
        /// <value>Indica se l&#39;operazione di valorizzazione variabili è stata eseguita, è la somma logica di tutte le variabili sono state valorizzate</value>
        [DataMember(Name="executed", EmitDefaultValue=false)]
        public bool? Executed { get; set; }

        /// <summary>
        /// Gets or Sets Required
        /// </summary>
        [DataMember(Name="required", EmitDefaultValue=false)]
        public bool? Required { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskWorkVariableOperationDTO {\n");
            sb.Append("  ProcessVariables: ").Append(ProcessVariables).Append("\n");
            sb.Append("  ProcessVariablesFields: ").Append(ProcessVariablesFields).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Executed: ").Append(Executed).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
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
            return this.Equals(input as TaskWorkVariableOperationDTO);
        }

        /// <summary>
        /// Returns true if TaskWorkVariableOperationDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of TaskWorkVariableOperationDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskWorkVariableOperationDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProcessVariables == input.ProcessVariables ||
                    this.ProcessVariables != null &&
                    this.ProcessVariables.SequenceEqual(input.ProcessVariables)
                ) && 
                (
                    this.ProcessVariablesFields == input.ProcessVariablesFields ||
                    (this.ProcessVariablesFields != null &&
                    this.ProcessVariablesFields.Equals(input.ProcessVariablesFields))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Executed == input.Executed ||
                    (this.Executed != null &&
                    this.Executed.Equals(input.Executed))
                ) && 
                (
                    this.Required == input.Required ||
                    (this.Required != null &&
                    this.Required.Equals(input.Required))
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
                if (this.ProcessVariables != null)
                    hashCode = hashCode * 59 + this.ProcessVariables.GetHashCode();
                if (this.ProcessVariablesFields != null)
                    hashCode = hashCode * 59 + this.ProcessVariablesFields.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Executed != null)
                    hashCode = hashCode * 59 + this.Executed.GetHashCode();
                if (this.Required != null)
                    hashCode = hashCode * 59 + this.Required.GetHashCode();
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
