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
    /// BinderTypeDTO
    /// </summary>
    [DataContract]
    public partial class BinderTypeDTO :  IEquatable<BinderTypeDTO>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BinderTypeDTO" /> class.
        /// </summary>
        /// <param name="Id">Identificativo della tipologia..</param>
        /// <param name="BinderType">Nome della tipologia di pratica..</param>
        /// <param name="FolderId">Identificativo fascicolo..</param>
        /// <param name="DynamicFolder">Nome dinamico del sottofascicolo..</param>
        /// <param name="Progressive">Numero progressivo..</param>
        /// <param name="DynamicNumber">Numero progressivo dinamico..</param>
        /// <param name="ExternalId">Identificativo esterno..</param>
        /// <param name="Fields">Array of custon binder type fields.</param>
        /// <param name="_Default">_Default.</param>
        public BinderTypeDTO(int? Id = null, string BinderType = null, int? FolderId = null, string DynamicFolder = null, int? Progressive = null, string DynamicNumber = null, string ExternalId = null, List<FieldBaseDTO> Fields = null, bool? _Default = null)
        {
            this.Id = Id;
            this.BinderType = BinderType;
            this.FolderId = FolderId;
            this.DynamicFolder = DynamicFolder;
            this.Progressive = Progressive;
            this.DynamicNumber = DynamicNumber;
            this.ExternalId = ExternalId;
            this.Fields = Fields;
            this._Default = _Default;
        }
        
        /// <summary>
        /// Identificativo della tipologia.
        /// </summary>
        /// <value>Identificativo della tipologia.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }
        /// <summary>
        /// Nome della tipologia di pratica.
        /// </summary>
        /// <value>Nome della tipologia di pratica.</value>
        [DataMember(Name="binderType", EmitDefaultValue=false)]
        public string BinderType { get; set; }
        /// <summary>
        /// Identificativo fascicolo.
        /// </summary>
        /// <value>Identificativo fascicolo.</value>
        [DataMember(Name="folderId", EmitDefaultValue=false)]
        public int? FolderId { get; set; }
        /// <summary>
        /// Nome dinamico del sottofascicolo.
        /// </summary>
        /// <value>Nome dinamico del sottofascicolo.</value>
        [DataMember(Name="dynamicFolder", EmitDefaultValue=false)]
        public string DynamicFolder { get; set; }
        /// <summary>
        /// Numero progressivo.
        /// </summary>
        /// <value>Numero progressivo.</value>
        [DataMember(Name="progressive", EmitDefaultValue=false)]
        public int? Progressive { get; set; }
        /// <summary>
        /// Numero progressivo dinamico.
        /// </summary>
        /// <value>Numero progressivo dinamico.</value>
        [DataMember(Name="dynamicNumber", EmitDefaultValue=false)]
        public string DynamicNumber { get; set; }
        /// <summary>
        /// Identificativo esterno.
        /// </summary>
        /// <value>Identificativo esterno.</value>
        [DataMember(Name="externalId", EmitDefaultValue=false)]
        public string ExternalId { get; set; }
        /// <summary>
        /// Array of custon binder type fields
        /// </summary>
        /// <value>Array of custon binder type fields</value>
        [DataMember(Name="fields", EmitDefaultValue=false)]
        public List<FieldBaseDTO> Fields { get; set; }
        /// <summary>
        /// Gets or Sets _Default
        /// </summary>
        [DataMember(Name="default", EmitDefaultValue=false)]
        public bool? _Default { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BinderTypeDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  BinderType: ").Append(BinderType).Append("\n");
            sb.Append("  FolderId: ").Append(FolderId).Append("\n");
            sb.Append("  DynamicFolder: ").Append(DynamicFolder).Append("\n");
            sb.Append("  Progressive: ").Append(Progressive).Append("\n");
            sb.Append("  DynamicNumber: ").Append(DynamicNumber).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
            sb.Append("  _Default: ").Append(_Default).Append("\n");
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
            return this.Equals(obj as BinderTypeDTO);
        }

        /// <summary>
        /// Returns true if BinderTypeDTO instances are equal
        /// </summary>
        /// <param name="other">Instance of BinderTypeDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BinderTypeDTO other)
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
                    this.BinderType == other.BinderType ||
                    this.BinderType != null &&
                    this.BinderType.Equals(other.BinderType)
                ) && 
                (
                    this.FolderId == other.FolderId ||
                    this.FolderId != null &&
                    this.FolderId.Equals(other.FolderId)
                ) && 
                (
                    this.DynamicFolder == other.DynamicFolder ||
                    this.DynamicFolder != null &&
                    this.DynamicFolder.Equals(other.DynamicFolder)
                ) && 
                (
                    this.Progressive == other.Progressive ||
                    this.Progressive != null &&
                    this.Progressive.Equals(other.Progressive)
                ) && 
                (
                    this.DynamicNumber == other.DynamicNumber ||
                    this.DynamicNumber != null &&
                    this.DynamicNumber.Equals(other.DynamicNumber)
                ) && 
                (
                    this.ExternalId == other.ExternalId ||
                    this.ExternalId != null &&
                    this.ExternalId.Equals(other.ExternalId)
                ) && 
                (
                    this.Fields == other.Fields ||
                    this.Fields != null &&
                    this.Fields.SequenceEqual(other.Fields)
                ) && 
                (
                    this._Default == other._Default ||
                    this._Default != null &&
                    this._Default.Equals(other._Default)
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
                if (this.BinderType != null)
                    hash = hash * 59 + this.BinderType.GetHashCode();
                if (this.FolderId != null)
                    hash = hash * 59 + this.FolderId.GetHashCode();
                if (this.DynamicFolder != null)
                    hash = hash * 59 + this.DynamicFolder.GetHashCode();
                if (this.Progressive != null)
                    hash = hash * 59 + this.Progressive.GetHashCode();
                if (this.DynamicNumber != null)
                    hash = hash * 59 + this.DynamicNumber.GetHashCode();
                if (this.ExternalId != null)
                    hash = hash * 59 + this.ExternalId.GetHashCode();
                if (this.Fields != null)
                    hash = hash * 59 + this.Fields.GetHashCode();
                if (this._Default != null)
                    hash = hash * 59 + this._Default.GetHashCode();
                return hash;
            }
        }
    }

}
