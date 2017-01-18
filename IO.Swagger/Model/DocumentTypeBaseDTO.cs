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
    /// DocumentTypeBaseDTO
    /// </summary>
    [DataContract]
    public partial class DocumentTypeBaseDTO :  IEquatable<DocumentTypeBaseDTO>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentTypeBaseDTO" /> class.
        /// </summary>
        /// <param name="Id">Codice della classe documentale.</param>
        /// <param name="IdParent">Codice del nodo padre, se null è la root.</param>
        /// <param name="Key">Codice completo della classe.  Esempio: AMM.FATT.</param>
        /// <param name="Description">Descrizione della classe.</param>
        /// <param name="DocumentType">DocumentType.</param>
        /// <param name="Type2">Type2.</param>
        /// <param name="Type3">Type3.</param>
        /// <param name="DocState">DocState.</param>
        /// <param name="InOut">InOut.</param>
        /// <param name="IsLeaf">IsLeaf.</param>
        /// <param name="RequireFile">RequireFile.</param>
        /// <param name="Pa">Pa.</param>
        /// <param name="PaDefaultValue">PaDefaultValue.</param>
        public DocumentTypeBaseDTO(int? Id = null, int? IdParent = null, string Key = null, string Description = null, int? DocumentType = null, int? Type2 = null, int? Type3 = null, string DocState = null, int? InOut = null, bool? IsLeaf = null, int? RequireFile = null, int? Pa = null, bool? PaDefaultValue = null)
        {
            this.Id = Id;
            this.IdParent = IdParent;
            this.Key = Key;
            this.Description = Description;
            this.DocumentType = DocumentType;
            this.Type2 = Type2;
            this.Type3 = Type3;
            this.DocState = DocState;
            this.InOut = InOut;
            this.IsLeaf = IsLeaf;
            this.RequireFile = RequireFile;
            this.Pa = Pa;
            this.PaDefaultValue = PaDefaultValue;
        }
        
        /// <summary>
        /// Codice della classe documentale
        /// </summary>
        /// <value>Codice della classe documentale</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }
        /// <summary>
        /// Codice del nodo padre, se null è la root
        /// </summary>
        /// <value>Codice del nodo padre, se null è la root</value>
        [DataMember(Name="idParent", EmitDefaultValue=false)]
        public int? IdParent { get; set; }
        /// <summary>
        /// Codice completo della classe.  Esempio: AMM.FATT
        /// </summary>
        /// <value>Codice completo della classe.  Esempio: AMM.FATT</value>
        [DataMember(Name="key", EmitDefaultValue=false)]
        public string Key { get; set; }
        /// <summary>
        /// Descrizione della classe
        /// </summary>
        /// <value>Descrizione della classe</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// Gets or Sets DocumentType
        /// </summary>
        [DataMember(Name="documentType", EmitDefaultValue=false)]
        public int? DocumentType { get; set; }
        /// <summary>
        /// Gets or Sets Type2
        /// </summary>
        [DataMember(Name="type2", EmitDefaultValue=false)]
        public int? Type2 { get; set; }
        /// <summary>
        /// Gets or Sets Type3
        /// </summary>
        [DataMember(Name="type3", EmitDefaultValue=false)]
        public int? Type3 { get; set; }
        /// <summary>
        /// Gets or Sets DocState
        /// </summary>
        [DataMember(Name="docState", EmitDefaultValue=false)]
        public string DocState { get; set; }
        /// <summary>
        /// Gets or Sets InOut
        /// </summary>
        [DataMember(Name="inOut", EmitDefaultValue=false)]
        public int? InOut { get; set; }
        /// <summary>
        /// Gets or Sets IsLeaf
        /// </summary>
        [DataMember(Name="isLeaf", EmitDefaultValue=false)]
        public bool? IsLeaf { get; set; }
        /// <summary>
        /// Gets or Sets RequireFile
        /// </summary>
        [DataMember(Name="requireFile", EmitDefaultValue=false)]
        public int? RequireFile { get; set; }
        /// <summary>
        /// Gets or Sets Pa
        /// </summary>
        [DataMember(Name="pa", EmitDefaultValue=false)]
        public int? Pa { get; set; }
        /// <summary>
        /// Gets or Sets PaDefaultValue
        /// </summary>
        [DataMember(Name="paDefaultValue", EmitDefaultValue=false)]
        public bool? PaDefaultValue { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentTypeBaseDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IdParent: ").Append(IdParent).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DocumentType: ").Append(DocumentType).Append("\n");
            sb.Append("  Type2: ").Append(Type2).Append("\n");
            sb.Append("  Type3: ").Append(Type3).Append("\n");
            sb.Append("  DocState: ").Append(DocState).Append("\n");
            sb.Append("  InOut: ").Append(InOut).Append("\n");
            sb.Append("  IsLeaf: ").Append(IsLeaf).Append("\n");
            sb.Append("  RequireFile: ").Append(RequireFile).Append("\n");
            sb.Append("  Pa: ").Append(Pa).Append("\n");
            sb.Append("  PaDefaultValue: ").Append(PaDefaultValue).Append("\n");
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
            return this.Equals(obj as DocumentTypeBaseDTO);
        }

        /// <summary>
        /// Returns true if DocumentTypeBaseDTO instances are equal
        /// </summary>
        /// <param name="other">Instance of DocumentTypeBaseDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentTypeBaseDTO other)
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
                    this.IdParent == other.IdParent ||
                    this.IdParent != null &&
                    this.IdParent.Equals(other.IdParent)
                ) && 
                (
                    this.Key == other.Key ||
                    this.Key != null &&
                    this.Key.Equals(other.Key)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.DocumentType == other.DocumentType ||
                    this.DocumentType != null &&
                    this.DocumentType.Equals(other.DocumentType)
                ) && 
                (
                    this.Type2 == other.Type2 ||
                    this.Type2 != null &&
                    this.Type2.Equals(other.Type2)
                ) && 
                (
                    this.Type3 == other.Type3 ||
                    this.Type3 != null &&
                    this.Type3.Equals(other.Type3)
                ) && 
                (
                    this.DocState == other.DocState ||
                    this.DocState != null &&
                    this.DocState.Equals(other.DocState)
                ) && 
                (
                    this.InOut == other.InOut ||
                    this.InOut != null &&
                    this.InOut.Equals(other.InOut)
                ) && 
                (
                    this.IsLeaf == other.IsLeaf ||
                    this.IsLeaf != null &&
                    this.IsLeaf.Equals(other.IsLeaf)
                ) && 
                (
                    this.RequireFile == other.RequireFile ||
                    this.RequireFile != null &&
                    this.RequireFile.Equals(other.RequireFile)
                ) && 
                (
                    this.Pa == other.Pa ||
                    this.Pa != null &&
                    this.Pa.Equals(other.Pa)
                ) && 
                (
                    this.PaDefaultValue == other.PaDefaultValue ||
                    this.PaDefaultValue != null &&
                    this.PaDefaultValue.Equals(other.PaDefaultValue)
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
                if (this.IdParent != null)
                    hash = hash * 59 + this.IdParent.GetHashCode();
                if (this.Key != null)
                    hash = hash * 59 + this.Key.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.DocumentType != null)
                    hash = hash * 59 + this.DocumentType.GetHashCode();
                if (this.Type2 != null)
                    hash = hash * 59 + this.Type2.GetHashCode();
                if (this.Type3 != null)
                    hash = hash * 59 + this.Type3.GetHashCode();
                if (this.DocState != null)
                    hash = hash * 59 + this.DocState.GetHashCode();
                if (this.InOut != null)
                    hash = hash * 59 + this.InOut.GetHashCode();
                if (this.IsLeaf != null)
                    hash = hash * 59 + this.IsLeaf.GetHashCode();
                if (this.RequireFile != null)
                    hash = hash * 59 + this.RequireFile.GetHashCode();
                if (this.Pa != null)
                    hash = hash * 59 + this.Pa.GetHashCode();
                if (this.PaDefaultValue != null)
                    hash = hash * 59 + this.PaDefaultValue.GetHashCode();
                return hash;
            }
        }
    }

}
