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
    /// SearchConcreteDTO
    /// </summary>
    [DataContract]
    public partial class SearchConcreteDTO :  IEquatable<SearchConcreteDTO>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchConcreteDTO" /> class.
        /// </summary>
        /// <param name="ContactFields">ContactFields.</param>
        /// <param name="AooField">AooField.</param>
        /// <param name="DocumentTypeField">DocumentTypeField.</param>
        /// <param name="ProtocolField">ProtocolField.</param>
        /// <param name="ConservationField">ConservationField.</param>
        /// <param name="StampField">StampField.</param>
        /// <param name="DateTimeFields">DateTimeFields.</param>
        /// <param name="StringFields">StringFields.</param>
        /// <param name="IntFields">IntFields.</param>
        /// <param name="BoolFields">BoolFields.</param>
        /// <param name="DoubleFields">DoubleFields.</param>
        /// <param name="StringListFields">StringListFields.</param>
        /// <param name="GroupFields">GroupFields.</param>
        /// <param name="MaxItems">MaxItems.</param>
        public SearchConcreteDTO(List<FieldBaseForSearchContactDto> ContactFields = null, FieldBaseForSearchAooDto AooField = null, FieldBaseForSearchDocumentTypeDto DocumentTypeField = null, FieldBaseForSearchProtocolloDto ProtocolField = null, FieldBaseForSearchConservazioneDto ConservationField = null, FieldBaseForSearchStampDto StampField = null, List<FieldBaseForSearchDateTimeDto> DateTimeFields = null, List<FieldBaseForSearchStringDto> StringFields = null, List<FieldBaseForSearchIntDto> IntFields = null, List<FieldBaseForSearchBoolDto> BoolFields = null, List<FieldBaseForSearchDoubleDto> DoubleFields = null, List<FieldBaseForSearchListDto> StringListFields = null, List<FieldBaseForSearchDTO> GroupFields = null, int? MaxItems = null)
        {
            this.ContactFields = ContactFields;
            this.AooField = AooField;
            this.DocumentTypeField = DocumentTypeField;
            this.ProtocolField = ProtocolField;
            this.ConservationField = ConservationField;
            this.StampField = StampField;
            this.DateTimeFields = DateTimeFields;
            this.StringFields = StringFields;
            this.IntFields = IntFields;
            this.BoolFields = BoolFields;
            this.DoubleFields = DoubleFields;
            this.StringListFields = StringListFields;
            this.GroupFields = GroupFields;
            this.MaxItems = MaxItems;
        }
        
        /// <summary>
        /// Gets or Sets ContactFields
        /// </summary>
        [DataMember(Name="contactFields", EmitDefaultValue=false)]
        public List<FieldBaseForSearchContactDto> ContactFields { get; set; }
        /// <summary>
        /// Gets or Sets AooField
        /// </summary>
        [DataMember(Name="aooField", EmitDefaultValue=false)]
        public FieldBaseForSearchAooDto AooField { get; set; }
        /// <summary>
        /// Gets or Sets DocumentTypeField
        /// </summary>
        [DataMember(Name="documentTypeField", EmitDefaultValue=false)]
        public FieldBaseForSearchDocumentTypeDto DocumentTypeField { get; set; }
        /// <summary>
        /// Gets or Sets ProtocolField
        /// </summary>
        [DataMember(Name="protocolField", EmitDefaultValue=false)]
        public FieldBaseForSearchProtocolloDto ProtocolField { get; set; }
        /// <summary>
        /// Gets or Sets ConservationField
        /// </summary>
        [DataMember(Name="conservationField", EmitDefaultValue=false)]
        public FieldBaseForSearchConservazioneDto ConservationField { get; set; }
        /// <summary>
        /// Gets or Sets StampField
        /// </summary>
        [DataMember(Name="stampField", EmitDefaultValue=false)]
        public FieldBaseForSearchStampDto StampField { get; set; }
        /// <summary>
        /// Gets or Sets DateTimeFields
        /// </summary>
        [DataMember(Name="dateTimeFields", EmitDefaultValue=false)]
        public List<FieldBaseForSearchDateTimeDto> DateTimeFields { get; set; }
        /// <summary>
        /// Gets or Sets StringFields
        /// </summary>
        [DataMember(Name="stringFields", EmitDefaultValue=false)]
        public List<FieldBaseForSearchStringDto> StringFields { get; set; }
        /// <summary>
        /// Gets or Sets IntFields
        /// </summary>
        [DataMember(Name="intFields", EmitDefaultValue=false)]
        public List<FieldBaseForSearchIntDto> IntFields { get; set; }
        /// <summary>
        /// Gets or Sets BoolFields
        /// </summary>
        [DataMember(Name="boolFields", EmitDefaultValue=false)]
        public List<FieldBaseForSearchBoolDto> BoolFields { get; set; }
        /// <summary>
        /// Gets or Sets DoubleFields
        /// </summary>
        [DataMember(Name="doubleFields", EmitDefaultValue=false)]
        public List<FieldBaseForSearchDoubleDto> DoubleFields { get; set; }
        /// <summary>
        /// Gets or Sets StringListFields
        /// </summary>
        [DataMember(Name="stringListFields", EmitDefaultValue=false)]
        public List<FieldBaseForSearchListDto> StringListFields { get; set; }
        /// <summary>
        /// Gets or Sets GroupFields
        /// </summary>
        [DataMember(Name="groupFields", EmitDefaultValue=false)]
        public List<FieldBaseForSearchDTO> GroupFields { get; set; }
        /// <summary>
        /// Gets or Sets MaxItems
        /// </summary>
        [DataMember(Name="maxItems", EmitDefaultValue=false)]
        public int? MaxItems { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchConcreteDTO {\n");
            sb.Append("  ContactFields: ").Append(ContactFields).Append("\n");
            sb.Append("  AooField: ").Append(AooField).Append("\n");
            sb.Append("  DocumentTypeField: ").Append(DocumentTypeField).Append("\n");
            sb.Append("  ProtocolField: ").Append(ProtocolField).Append("\n");
            sb.Append("  ConservationField: ").Append(ConservationField).Append("\n");
            sb.Append("  StampField: ").Append(StampField).Append("\n");
            sb.Append("  DateTimeFields: ").Append(DateTimeFields).Append("\n");
            sb.Append("  StringFields: ").Append(StringFields).Append("\n");
            sb.Append("  IntFields: ").Append(IntFields).Append("\n");
            sb.Append("  BoolFields: ").Append(BoolFields).Append("\n");
            sb.Append("  DoubleFields: ").Append(DoubleFields).Append("\n");
            sb.Append("  StringListFields: ").Append(StringListFields).Append("\n");
            sb.Append("  GroupFields: ").Append(GroupFields).Append("\n");
            sb.Append("  MaxItems: ").Append(MaxItems).Append("\n");
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
            return this.Equals(obj as SearchConcreteDTO);
        }

        /// <summary>
        /// Returns true if SearchConcreteDTO instances are equal
        /// </summary>
        /// <param name="other">Instance of SearchConcreteDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchConcreteDTO other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ContactFields == other.ContactFields ||
                    this.ContactFields != null &&
                    this.ContactFields.SequenceEqual(other.ContactFields)
                ) && 
                (
                    this.AooField == other.AooField ||
                    this.AooField != null &&
                    this.AooField.Equals(other.AooField)
                ) && 
                (
                    this.DocumentTypeField == other.DocumentTypeField ||
                    this.DocumentTypeField != null &&
                    this.DocumentTypeField.Equals(other.DocumentTypeField)
                ) && 
                (
                    this.ProtocolField == other.ProtocolField ||
                    this.ProtocolField != null &&
                    this.ProtocolField.Equals(other.ProtocolField)
                ) && 
                (
                    this.ConservationField == other.ConservationField ||
                    this.ConservationField != null &&
                    this.ConservationField.Equals(other.ConservationField)
                ) && 
                (
                    this.StampField == other.StampField ||
                    this.StampField != null &&
                    this.StampField.Equals(other.StampField)
                ) && 
                (
                    this.DateTimeFields == other.DateTimeFields ||
                    this.DateTimeFields != null &&
                    this.DateTimeFields.SequenceEqual(other.DateTimeFields)
                ) && 
                (
                    this.StringFields == other.StringFields ||
                    this.StringFields != null &&
                    this.StringFields.SequenceEqual(other.StringFields)
                ) && 
                (
                    this.IntFields == other.IntFields ||
                    this.IntFields != null &&
                    this.IntFields.SequenceEqual(other.IntFields)
                ) && 
                (
                    this.BoolFields == other.BoolFields ||
                    this.BoolFields != null &&
                    this.BoolFields.SequenceEqual(other.BoolFields)
                ) && 
                (
                    this.DoubleFields == other.DoubleFields ||
                    this.DoubleFields != null &&
                    this.DoubleFields.SequenceEqual(other.DoubleFields)
                ) && 
                (
                    this.StringListFields == other.StringListFields ||
                    this.StringListFields != null &&
                    this.StringListFields.SequenceEqual(other.StringListFields)
                ) && 
                (
                    this.GroupFields == other.GroupFields ||
                    this.GroupFields != null &&
                    this.GroupFields.SequenceEqual(other.GroupFields)
                ) && 
                (
                    this.MaxItems == other.MaxItems ||
                    this.MaxItems != null &&
                    this.MaxItems.Equals(other.MaxItems)
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
                if (this.ContactFields != null)
                    hash = hash * 59 + this.ContactFields.GetHashCode();
                if (this.AooField != null)
                    hash = hash * 59 + this.AooField.GetHashCode();
                if (this.DocumentTypeField != null)
                    hash = hash * 59 + this.DocumentTypeField.GetHashCode();
                if (this.ProtocolField != null)
                    hash = hash * 59 + this.ProtocolField.GetHashCode();
                if (this.ConservationField != null)
                    hash = hash * 59 + this.ConservationField.GetHashCode();
                if (this.StampField != null)
                    hash = hash * 59 + this.StampField.GetHashCode();
                if (this.DateTimeFields != null)
                    hash = hash * 59 + this.DateTimeFields.GetHashCode();
                if (this.StringFields != null)
                    hash = hash * 59 + this.StringFields.GetHashCode();
                if (this.IntFields != null)
                    hash = hash * 59 + this.IntFields.GetHashCode();
                if (this.BoolFields != null)
                    hash = hash * 59 + this.BoolFields.GetHashCode();
                if (this.DoubleFields != null)
                    hash = hash * 59 + this.DoubleFields.GetHashCode();
                if (this.StringListFields != null)
                    hash = hash * 59 + this.StringListFields.GetHashCode();
                if (this.GroupFields != null)
                    hash = hash * 59 + this.GroupFields.GetHashCode();
                if (this.MaxItems != null)
                    hash = hash * 59 + this.MaxItems.GetHashCode();
                return hash;
            }
        }
    }

}
