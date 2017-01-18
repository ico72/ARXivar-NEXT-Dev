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
    /// FieldBaseDTO
    /// </summary>
    [DataContract]
    public partial class FieldBaseDTO :  IEquatable<FieldBaseDTO>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldBaseDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FieldBaseDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldBaseDTO" /> class.
        /// </summary>
        /// <param name="Name">Nome del campo.</param>
        /// <param name="ExternalId">Codice esterno assegnato al campo, nel caso di campi aggiuntivi è configurabile lato server  Nel caso di campi standard sarà uguale al FieldName.</param>
        /// <param name="Description">Etichetta del campo.</param>
        /// <param name="Order">Indica l&#39;ordinamento con cui il campo deve essere visualizzato nella maschera  dal valore più basso al valore più alto.</param>
        /// <param name="DataSource">Sorgente dati.</param>
        /// <param name="Required">Indica se il campo è obbligatorio.</param>
        /// <param name="Formula">Indica la formula associata al campo.</param>
        /// <param name="Locked">Indica se il campo è bloccato per la sola lettura  Eventuali cambianti su tale valore avverranno solo per mezzo di formule.</param>
        /// <param name="ComboGruppiId">ComboGruppiId.</param>
        /// <param name="DependencyFields">DependencyFields.</param>
        /// <param name="Associations">Associations.</param>
        /// <param name="IsAdditional">IsAdditional.</param>
        /// <param name="Visible">Visible.</param>
        /// <param name="PredefinedProfileFormula">PredefinedProfileFormula.</param>
        public FieldBaseDTO(string Name = null, string ExternalId = null, string Description = null, int? Order = null, string DataSource = null, bool? Required = null, string Formula = null, bool? Locked = null, string ComboGruppiId = null, List<DependencyFieldItem> DependencyFields = null, Dictionary<string, string> Associations = null, bool? IsAdditional = null, bool? Visible = null, string PredefinedProfileFormula = null)
        {
            this.Name = Name;
            this.ExternalId = ExternalId;
            this.Description = Description;
            this.Order = Order;
            this.DataSource = DataSource;
            this.Required = Required;
            this.Formula = Formula;
            this.Locked = Locked;
            this.ComboGruppiId = ComboGruppiId;
            this.DependencyFields = DependencyFields;
            this.Associations = Associations;
            this.IsAdditional = IsAdditional;
            this.Visible = Visible;
            this.PredefinedProfileFormula = PredefinedProfileFormula;
        }
        
        /// <summary>
        /// Nome del campo
        /// </summary>
        /// <value>Nome del campo</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Codice esterno assegnato al campo, nel caso di campi aggiuntivi è configurabile lato server  Nel caso di campi standard sarà uguale al FieldName
        /// </summary>
        /// <value>Codice esterno assegnato al campo, nel caso di campi aggiuntivi è configurabile lato server  Nel caso di campi standard sarà uguale al FieldName</value>
        [DataMember(Name="externalId", EmitDefaultValue=false)]
        public string ExternalId { get; set; }
        /// <summary>
        /// Etichetta del campo
        /// </summary>
        /// <value>Etichetta del campo</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// Indica l&#39;ordinamento con cui il campo deve essere visualizzato nella maschera  dal valore più basso al valore più alto
        /// </summary>
        /// <value>Indica l&#39;ordinamento con cui il campo deve essere visualizzato nella maschera  dal valore più basso al valore più alto</value>
        [DataMember(Name="order", EmitDefaultValue=false)]
        public int? Order { get; set; }
        /// <summary>
        /// Sorgente dati
        /// </summary>
        /// <value>Sorgente dati</value>
        [DataMember(Name="dataSource", EmitDefaultValue=false)]
        public string DataSource { get; set; }
        /// <summary>
        /// Indica se il campo è obbligatorio
        /// </summary>
        /// <value>Indica se il campo è obbligatorio</value>
        [DataMember(Name="required", EmitDefaultValue=false)]
        public bool? Required { get; set; }
        /// <summary>
        /// Indica la formula associata al campo
        /// </summary>
        /// <value>Indica la formula associata al campo</value>
        [DataMember(Name="formula", EmitDefaultValue=false)]
        public string Formula { get; set; }
        /// <summary>
        /// Indica il nome completo della classe
        /// </summary>
        /// <value>Indica il nome completo della classe</value>
        [DataMember(Name="className", EmitDefaultValue=false)]
        public string ClassName { get; private set; }
        /// <summary>
        /// Indica se il campo è bloccato per la sola lettura  Eventuali cambianti su tale valore avverranno solo per mezzo di formule
        /// </summary>
        /// <value>Indica se il campo è bloccato per la sola lettura  Eventuali cambianti su tale valore avverranno solo per mezzo di formule</value>
        [DataMember(Name="locked", EmitDefaultValue=false)]
        public bool? Locked { get; set; }
        /// <summary>
        /// Gets or Sets ComboGruppiId
        /// </summary>
        [DataMember(Name="comboGruppiId", EmitDefaultValue=false)]
        public string ComboGruppiId { get; set; }
        /// <summary>
        /// Gets or Sets DependencyFields
        /// </summary>
        [DataMember(Name="dependencyFields", EmitDefaultValue=false)]
        public List<DependencyFieldItem> DependencyFields { get; set; }
        /// <summary>
        /// Gets or Sets Associations
        /// </summary>
        [DataMember(Name="associations", EmitDefaultValue=false)]
        public Dictionary<string, string> Associations { get; set; }
        /// <summary>
        /// Gets or Sets IsAdditional
        /// </summary>
        [DataMember(Name="isAdditional", EmitDefaultValue=false)]
        public bool? IsAdditional { get; set; }
        /// <summary>
        /// Gets or Sets Visible
        /// </summary>
        [DataMember(Name="visible", EmitDefaultValue=false)]
        public bool? Visible { get; set; }
        /// <summary>
        /// Gets or Sets PredefinedProfileFormula
        /// </summary>
        [DataMember(Name="predefinedProfileFormula", EmitDefaultValue=false)]
        public string PredefinedProfileFormula { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FieldBaseDTO {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  DataSource: ").Append(DataSource).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
            sb.Append("  Formula: ").Append(Formula).Append("\n");
            sb.Append("  ClassName: ").Append(ClassName).Append("\n");
            sb.Append("  Locked: ").Append(Locked).Append("\n");
            sb.Append("  ComboGruppiId: ").Append(ComboGruppiId).Append("\n");
            sb.Append("  DependencyFields: ").Append(DependencyFields).Append("\n");
            sb.Append("  Associations: ").Append(Associations).Append("\n");
            sb.Append("  IsAdditional: ").Append(IsAdditional).Append("\n");
            sb.Append("  Visible: ").Append(Visible).Append("\n");
            sb.Append("  PredefinedProfileFormula: ").Append(PredefinedProfileFormula).Append("\n");
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
            return this.Equals(obj as FieldBaseDTO);
        }

        /// <summary>
        /// Returns true if FieldBaseDTO instances are equal
        /// </summary>
        /// <param name="other">Instance of FieldBaseDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FieldBaseDTO other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.ExternalId == other.ExternalId ||
                    this.ExternalId != null &&
                    this.ExternalId.Equals(other.ExternalId)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.Order == other.Order ||
                    this.Order != null &&
                    this.Order.Equals(other.Order)
                ) && 
                (
                    this.DataSource == other.DataSource ||
                    this.DataSource != null &&
                    this.DataSource.Equals(other.DataSource)
                ) && 
                (
                    this.Required == other.Required ||
                    this.Required != null &&
                    this.Required.Equals(other.Required)
                ) && 
                (
                    this.Formula == other.Formula ||
                    this.Formula != null &&
                    this.Formula.Equals(other.Formula)
                ) && 
                (
                    this.ClassName == other.ClassName ||
                    this.ClassName != null &&
                    this.ClassName.Equals(other.ClassName)
                ) && 
                (
                    this.Locked == other.Locked ||
                    this.Locked != null &&
                    this.Locked.Equals(other.Locked)
                ) && 
                (
                    this.ComboGruppiId == other.ComboGruppiId ||
                    this.ComboGruppiId != null &&
                    this.ComboGruppiId.Equals(other.ComboGruppiId)
                ) && 
                (
                    this.DependencyFields == other.DependencyFields ||
                    this.DependencyFields != null &&
                    this.DependencyFields.SequenceEqual(other.DependencyFields)
                ) && 
                (
                    this.Associations == other.Associations ||
                    this.Associations != null &&
                    this.Associations.SequenceEqual(other.Associations)
                ) && 
                (
                    this.IsAdditional == other.IsAdditional ||
                    this.IsAdditional != null &&
                    this.IsAdditional.Equals(other.IsAdditional)
                ) && 
                (
                    this.Visible == other.Visible ||
                    this.Visible != null &&
                    this.Visible.Equals(other.Visible)
                ) && 
                (
                    this.PredefinedProfileFormula == other.PredefinedProfileFormula ||
                    this.PredefinedProfileFormula != null &&
                    this.PredefinedProfileFormula.Equals(other.PredefinedProfileFormula)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.ExternalId != null)
                    hash = hash * 59 + this.ExternalId.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.Order != null)
                    hash = hash * 59 + this.Order.GetHashCode();
                if (this.DataSource != null)
                    hash = hash * 59 + this.DataSource.GetHashCode();
                if (this.Required != null)
                    hash = hash * 59 + this.Required.GetHashCode();
                if (this.Formula != null)
                    hash = hash * 59 + this.Formula.GetHashCode();
                if (this.ClassName != null)
                    hash = hash * 59 + this.ClassName.GetHashCode();
                if (this.Locked != null)
                    hash = hash * 59 + this.Locked.GetHashCode();
                if (this.ComboGruppiId != null)
                    hash = hash * 59 + this.ComboGruppiId.GetHashCode();
                if (this.DependencyFields != null)
                    hash = hash * 59 + this.DependencyFields.GetHashCode();
                if (this.Associations != null)
                    hash = hash * 59 + this.Associations.GetHashCode();
                if (this.IsAdditional != null)
                    hash = hash * 59 + this.IsAdditional.GetHashCode();
                if (this.Visible != null)
                    hash = hash * 59 + this.Visible.GetHashCode();
                if (this.PredefinedProfileFormula != null)
                    hash = hash * 59 + this.PredefinedProfileFormula.GetHashCode();
                return hash;
            }
        }
    }

}
