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
    /// FieldBaseForSearchIntDto
    /// </summary>
    [DataContract]
    public partial class FieldBaseForSearchIntDto : FieldBaseDTO,  IEquatable<FieldBaseForSearchIntDto>
    {
        /// <summary>
        /// The code of the actual operator for this field
        /// </summary>
        /// <value>The code of the actual operator for this field</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OperatorEnum
        {
            
            /// <summary>
            /// Enum NonImpostato for "Non_Impostato"
            /// </summary>
            [EnumMember(Value = "Non_Impostato")]
            NonImpostato,
            
            /// <summary>
            /// Enum Minore for "Minore"
            /// </summary>
            [EnumMember(Value = "Minore")]
            Minore,
            
            /// <summary>
            /// Enum MinoreUguale for "Minore_Uguale"
            /// </summary>
            [EnumMember(Value = "Minore_Uguale")]
            MinoreUguale,
            
            /// <summary>
            /// Enum Uguale for "Uguale"
            /// </summary>
            [EnumMember(Value = "Uguale")]
            Uguale,
            
            /// <summary>
            /// Enum MaggioreUguale for "Maggiore_Uguale"
            /// </summary>
            [EnumMember(Value = "Maggiore_Uguale")]
            MaggioreUguale,
            
            /// <summary>
            /// Enum Maggiore for "Maggiore"
            /// </summary>
            [EnumMember(Value = "Maggiore")]
            Maggiore,
            
            /// <summary>
            /// Enum Diverso for "Diverso"
            /// </summary>
            [EnumMember(Value = "Diverso")]
            Diverso,
            
            /// <summary>
            /// Enum Compreso for "Compreso"
            /// </summary>
            [EnumMember(Value = "Compreso")]
            Compreso,
            
            /// <summary>
            /// Enum Nullo for "Nullo"
            /// </summary>
            [EnumMember(Value = "Nullo")]
            Nullo,
            
            /// <summary>
            /// Enum NonNullo for "Non_Nullo"
            /// </summary>
            [EnumMember(Value = "Non_Nullo")]
            NonNullo,
            
            /// <summary>
            /// Enum NullooZero for "Nullo_o_Zero"
            /// </summary>
            [EnumMember(Value = "Nullo_o_Zero")]
            NullooZero,
            
            /// <summary>
            /// Enum NonNulloeNonZero for "Non_Nullo_e_Non_Zero"
            /// </summary>
            [EnumMember(Value = "Non_Nullo_e_Non_Zero")]
            NonNulloeNonZero,
            
            /// <summary>
            /// Enum Escluso for "Escluso"
            /// </summary>
            [EnumMember(Value = "Escluso")]
            Escluso
        }

        /// <summary>
        /// Type of this field
        /// </summary>
        /// <value>Type of this field</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FieldTypeEnum
        {
            
            /// <summary>
            /// Enum Standard for "Standard"
            /// </summary>
            [EnumMember(Value = "Standard")]
            Standard,
            
            /// <summary>
            /// Enum Group for "Group"
            /// </summary>
            [EnumMember(Value = "Group")]
            Group,
            
            /// <summary>
            /// Enum Additional for "Additional"
            /// </summary>
            [EnumMember(Value = "Additional")]
            Additional
        }

        /// <summary>
        /// If the field is an additional field (see FieldType) this property provide the information about witch kind of additional field this item is
        /// </summary>
        /// <value>If the field is an additional field (see FieldType) this property provide the information about witch kind of additional field this item is</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AdditionalFieldTypeEnum
        {
            
            /// <summary>
            /// Enum Textbox for "Textbox"
            /// </summary>
            [EnumMember(Value = "Textbox")]
            Textbox,
            
            /// <summary>
            /// Enum Databox for "Databox"
            /// </summary>
            [EnumMember(Value = "Databox")]
            Databox,
            
            /// <summary>
            /// Enum Numeric for "Numeric"
            /// </summary>
            [EnumMember(Value = "Numeric")]
            Numeric,
            
            /// <summary>
            /// Enum Combobox for "Combobox"
            /// </summary>
            [EnumMember(Value = "Combobox")]
            Combobox,
            
            /// <summary>
            /// Enum TableBox for "TableBox"
            /// </summary>
            [EnumMember(Value = "TableBox")]
            TableBox,
            
            /// <summary>
            /// Enum Checkbox for "Checkbox"
            /// </summary>
            [EnumMember(Value = "Checkbox")]
            Checkbox,
            
            /// <summary>
            /// Enum MultiValue for "MultiValue"
            /// </summary>
            [EnumMember(Value = "MultiValue")]
            MultiValue,
            
            /// <summary>
            /// Enum ClasseBox for "ClasseBox"
            /// </summary>
            [EnumMember(Value = "ClasseBox")]
            ClasseBox,
            
            /// <summary>
            /// Enum Group for "Group"
            /// </summary>
            [EnumMember(Value = "Group")]
            Group,
            
            /// <summary>
            /// Enum RubricaBox for "RubricaBox"
            /// </summary>
            [EnumMember(Value = "RubricaBox")]
            RubricaBox,
            
            /// <summary>
            /// Enum TextArea for "TextArea"
            /// </summary>
            [EnumMember(Value = "TextArea")]
            TextArea
        }

        /// <summary>
        /// The code of the actual operator for this field
        /// </summary>
        /// <value>The code of the actual operator for this field</value>
        [DataMember(Name="operator", EmitDefaultValue=false)]
        public OperatorEnum? _Operator { get; set; }
        /// <summary>
        /// Type of this field
        /// </summary>
        /// <value>Type of this field</value>
        [DataMember(Name="fieldType", EmitDefaultValue=false)]
        public FieldTypeEnum? FieldType { get; set; }
        /// <summary>
        /// If the field is an additional field (see FieldType) this property provide the information about witch kind of additional field this item is
        /// </summary>
        /// <value>If the field is an additional field (see FieldType) this property provide the information about witch kind of additional field this item is</value>
        [DataMember(Name="additionalFieldType", EmitDefaultValue=false)]
        public AdditionalFieldTypeEnum? AdditionalFieldType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldBaseForSearchIntDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FieldBaseForSearchIntDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldBaseForSearchIntDto" /> class.
        /// </summary>
        /// <param name="Name">Nome del campo.</param>
        /// <param name="ExternalId">Codice esterno assegnato al campo, nel caso di campi aggiuntivi è configurabile lato server  Nel caso di campi standard sarà uguale al FieldName.</param>
        /// <param name="Description">Etichetta del campo.</param>
        /// <param name="Order">Order value for this filter.</param>
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
        /// <param name="_Operator">The code of the actual operator for this field.</param>
        /// <param name="Valore1">The value of this field.</param>
        /// <param name="Valore2">The second value for this field (used only for some operator).</param>
        /// <param name="GroupId">GroupId.</param>
        /// <param name="FieldType">Type of this field.</param>
        /// <param name="AdditionalFieldType">If the field is an additional field (see FieldType) this property provide the information about witch kind of additional field this item is.</param>
        /// <param name="DefaultOperator">The code of the default operator for this field.</param>
        /// <param name="TableName">Table name of the additional field.</param>
        /// <param name="Multiple">Multiple values.</param>
        public FieldBaseForSearchIntDto(string Name = null, string ExternalId = null, string Description = null, int? Order = null, string DataSource = null, bool? Required = null, string Formula = null, bool? Locked = null, string ComboGruppiId = null, List<DependencyFieldItem> DependencyFields = null, Dictionary<string, string> Associations = null, bool? IsAdditional = null, bool? Visible = null, string PredefinedProfileFormula = null, OperatorEnum? _Operator = null, int? Valore1 = null, int? Valore2 = null, int? GroupId = null, FieldTypeEnum? FieldType = null, AdditionalFieldTypeEnum? AdditionalFieldType = null, int? DefaultOperator = null, string TableName = null, string Multiple = null)
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
            this._Operator = _Operator;
            this.Valore1 = Valore1;
            this.Valore2 = Valore2;
            this.GroupId = GroupId;
            this.FieldType = FieldType;
            this.AdditionalFieldType = AdditionalFieldType;
            this.DefaultOperator = DefaultOperator;
            this.TableName = TableName;
            this.Multiple = Multiple;
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
        /// Order value for this filter
        /// </summary>
        /// <value>Order value for this filter</value>
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
        /// The value of this field
        /// </summary>
        /// <value>The value of this field</value>
        [DataMember(Name="valore1", EmitDefaultValue=false)]
        public int? Valore1 { get; set; }
        /// <summary>
        /// The second value for this field (used only for some operator)
        /// </summary>
        /// <value>The second value for this field (used only for some operator)</value>
        [DataMember(Name="valore2", EmitDefaultValue=false)]
        public int? Valore2 { get; set; }
        /// <summary>
        /// Gets or Sets GroupId
        /// </summary>
        [DataMember(Name="groupId", EmitDefaultValue=false)]
        public int? GroupId { get; set; }
        /// <summary>
        /// The code of the default operator for this field
        /// </summary>
        /// <value>The code of the default operator for this field</value>
        [DataMember(Name="defaultOperator", EmitDefaultValue=false)]
        public int? DefaultOperator { get; set; }
        /// <summary>
        /// Table name of the additional field
        /// </summary>
        /// <value>Table name of the additional field</value>
        [DataMember(Name="tableName", EmitDefaultValue=false)]
        public string TableName { get; set; }
        /// <summary>
        /// Multiple values
        /// </summary>
        /// <value>Multiple values</value>
        [DataMember(Name="multiple", EmitDefaultValue=false)]
        public string Multiple { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FieldBaseForSearchIntDto {\n");
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
            sb.Append("  _Operator: ").Append(_Operator).Append("\n");
            sb.Append("  Valore1: ").Append(Valore1).Append("\n");
            sb.Append("  Valore2: ").Append(Valore2).Append("\n");
            sb.Append("  GroupId: ").Append(GroupId).Append("\n");
            sb.Append("  FieldType: ").Append(FieldType).Append("\n");
            sb.Append("  AdditionalFieldType: ").Append(AdditionalFieldType).Append("\n");
            sb.Append("  DefaultOperator: ").Append(DefaultOperator).Append("\n");
            sb.Append("  TableName: ").Append(TableName).Append("\n");
            sb.Append("  Multiple: ").Append(Multiple).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public  new string ToJson()
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
            return this.Equals(obj as FieldBaseForSearchIntDto);
        }

        /// <summary>
        /// Returns true if FieldBaseForSearchIntDto instances are equal
        /// </summary>
        /// <param name="other">Instance of FieldBaseForSearchIntDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FieldBaseForSearchIntDto other)
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
                ) && 
                (
                    this._Operator == other._Operator ||
                    this._Operator != null &&
                    this._Operator.Equals(other._Operator)
                ) && 
                (
                    this.Valore1 == other.Valore1 ||
                    this.Valore1 != null &&
                    this.Valore1.Equals(other.Valore1)
                ) && 
                (
                    this.Valore2 == other.Valore2 ||
                    this.Valore2 != null &&
                    this.Valore2.Equals(other.Valore2)
                ) && 
                (
                    this.GroupId == other.GroupId ||
                    this.GroupId != null &&
                    this.GroupId.Equals(other.GroupId)
                ) && 
                (
                    this.FieldType == other.FieldType ||
                    this.FieldType != null &&
                    this.FieldType.Equals(other.FieldType)
                ) && 
                (
                    this.AdditionalFieldType == other.AdditionalFieldType ||
                    this.AdditionalFieldType != null &&
                    this.AdditionalFieldType.Equals(other.AdditionalFieldType)
                ) && 
                (
                    this.DefaultOperator == other.DefaultOperator ||
                    this.DefaultOperator != null &&
                    this.DefaultOperator.Equals(other.DefaultOperator)
                ) && 
                (
                    this.TableName == other.TableName ||
                    this.TableName != null &&
                    this.TableName.Equals(other.TableName)
                ) && 
                (
                    this.Multiple == other.Multiple ||
                    this.Multiple != null &&
                    this.Multiple.Equals(other.Multiple)
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
                if (this._Operator != null)
                    hash = hash * 59 + this._Operator.GetHashCode();
                if (this.Valore1 != null)
                    hash = hash * 59 + this.Valore1.GetHashCode();
                if (this.Valore2 != null)
                    hash = hash * 59 + this.Valore2.GetHashCode();
                if (this.GroupId != null)
                    hash = hash * 59 + this.GroupId.GetHashCode();
                if (this.FieldType != null)
                    hash = hash * 59 + this.FieldType.GetHashCode();
                if (this.AdditionalFieldType != null)
                    hash = hash * 59 + this.AdditionalFieldType.GetHashCode();
                if (this.DefaultOperator != null)
                    hash = hash * 59 + this.DefaultOperator.GetHashCode();
                if (this.TableName != null)
                    hash = hash * 59 + this.TableName.GetHashCode();
                if (this.Multiple != null)
                    hash = hash * 59 + this.Multiple.GetHashCode();
                return hash;
            }
        }
    }

}
