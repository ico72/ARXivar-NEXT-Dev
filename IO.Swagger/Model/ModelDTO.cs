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
    /// ModelDTO
    /// </summary>
    [DataContract]
    public partial class ModelDTO :  IEquatable<ModelDTO>
    {
        /// <summary>
        /// Tipologia del modello.
        /// </summary>
        /// <value>Tipologia del modello.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Public for "Public"
            /// </summary>
            [EnumMember(Value = "Public")]
            Public,
            
            /// <summary>
            /// Enum Private for "Private"
            /// </summary>
            [EnumMember(Value = "Private")]
            Private
        }

        /// <summary>
        /// Modalità di blocco.
        /// </summary>
        /// <value>Modalità di blocco.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LockModalityEnum
        {
            
            /// <summary>
            /// Enum Unblocked for "Unblocked"
            /// </summary>
            [EnumMember(Value = "Unblocked")]
            Unblocked,
            
            /// <summary>
            /// Enum Blocked for "Blocked"
            /// </summary>
            [EnumMember(Value = "Blocked")]
            Blocked
        }

        /// <summary>
        /// Tipologia del modello.
        /// </summary>
        /// <value>Tipologia del modello.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Modalità di blocco.
        /// </summary>
        /// <value>Modalità di blocco.</value>
        [DataMember(Name="lockModality", EmitDefaultValue=false)]
        public LockModalityEnum? LockModality { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelDTO" /> class.
        /// </summary>
        /// <param name="Id">Identificativo..</param>
        /// <param name="Description">Descrizione del modulo.</param>
        /// <param name="User">Identificativo utente creato del modello..</param>
        /// <param name="UserDescription">Author&#39;s model name.</param>
        /// <param name="Type">Tipologia del modello..</param>
        /// <param name="FileName">Nome del file originale..</param>
        /// <param name="LockModality">Modalità di blocco..</param>
        /// <param name="PredefinedProfileId">Identificativo del profilo predefinito associato..</param>
        /// <param name="GroupId">Identificativo del raggruppamento..</param>
        /// <param name="GroupName">Model&#39;s group name.</param>
        /// <param name="Extension">Extension.</param>
        /// <param name="OpenAfterProfilation">Apertura del file dopo la profilazione..</param>
        /// <param name="MaskId">Identificativo della maschera di profilazione semplificata..</param>
        /// <param name="PreviewFileName">Nome del file preview originale.</param>
        public ModelDTO(int? Id = null, string Description = null, int? User = null, string UserDescription = null, TypeEnum? Type = null, string FileName = null, LockModalityEnum? LockModality = null, int? PredefinedProfileId = null, int? GroupId = null, string GroupName = null, string Extension = null, bool? OpenAfterProfilation = null, string MaskId = null, string PreviewFileName = null)
        {
            this.Id = Id;
            this.Description = Description;
            this.User = User;
            this.UserDescription = UserDescription;
            this.Type = Type;
            this.FileName = FileName;
            this.LockModality = LockModality;
            this.PredefinedProfileId = PredefinedProfileId;
            this.GroupId = GroupId;
            this.GroupName = GroupName;
            this.Extension = Extension;
            this.OpenAfterProfilation = OpenAfterProfilation;
            this.MaskId = MaskId;
            this.PreviewFileName = PreviewFileName;
        }
        
        /// <summary>
        /// Identificativo.
        /// </summary>
        /// <value>Identificativo.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }
        /// <summary>
        /// Descrizione del modulo
        /// </summary>
        /// <value>Descrizione del modulo</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// Identificativo utente creato del modello.
        /// </summary>
        /// <value>Identificativo utente creato del modello.</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public int? User { get; set; }
        /// <summary>
        /// Author&#39;s model name
        /// </summary>
        /// <value>Author&#39;s model name</value>
        [DataMember(Name="userDescription", EmitDefaultValue=false)]
        public string UserDescription { get; set; }
        /// <summary>
        /// Nome del file originale.
        /// </summary>
        /// <value>Nome del file originale.</value>
        [DataMember(Name="fileName", EmitDefaultValue=false)]
        public string FileName { get; set; }
        /// <summary>
        /// Identificativo del profilo predefinito associato.
        /// </summary>
        /// <value>Identificativo del profilo predefinito associato.</value>
        [DataMember(Name="predefinedProfileId", EmitDefaultValue=false)]
        public int? PredefinedProfileId { get; set; }
        /// <summary>
        /// Identificativo del raggruppamento.
        /// </summary>
        /// <value>Identificativo del raggruppamento.</value>
        [DataMember(Name="groupId", EmitDefaultValue=false)]
        public int? GroupId { get; set; }
        /// <summary>
        /// Model&#39;s group name
        /// </summary>
        /// <value>Model&#39;s group name</value>
        [DataMember(Name="groupName", EmitDefaultValue=false)]
        public string GroupName { get; set; }
        /// <summary>
        /// Gets or Sets Extension
        /// </summary>
        [DataMember(Name="extension", EmitDefaultValue=false)]
        public string Extension { get; set; }
        /// <summary>
        /// Apertura del file dopo la profilazione.
        /// </summary>
        /// <value>Apertura del file dopo la profilazione.</value>
        [DataMember(Name="openAfterProfilation", EmitDefaultValue=false)]
        public bool? OpenAfterProfilation { get; set; }
        /// <summary>
        /// Identificativo della maschera di profilazione semplificata.
        /// </summary>
        /// <value>Identificativo della maschera di profilazione semplificata.</value>
        [DataMember(Name="maskId", EmitDefaultValue=false)]
        public string MaskId { get; set; }
        /// <summary>
        /// Nome del file preview originale
        /// </summary>
        /// <value>Nome del file preview originale</value>
        [DataMember(Name="previewFileName", EmitDefaultValue=false)]
        public string PreviewFileName { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModelDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  UserDescription: ").Append(UserDescription).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  FileName: ").Append(FileName).Append("\n");
            sb.Append("  LockModality: ").Append(LockModality).Append("\n");
            sb.Append("  PredefinedProfileId: ").Append(PredefinedProfileId).Append("\n");
            sb.Append("  GroupId: ").Append(GroupId).Append("\n");
            sb.Append("  GroupName: ").Append(GroupName).Append("\n");
            sb.Append("  Extension: ").Append(Extension).Append("\n");
            sb.Append("  OpenAfterProfilation: ").Append(OpenAfterProfilation).Append("\n");
            sb.Append("  MaskId: ").Append(MaskId).Append("\n");
            sb.Append("  PreviewFileName: ").Append(PreviewFileName).Append("\n");
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
            return this.Equals(obj as ModelDTO);
        }

        /// <summary>
        /// Returns true if ModelDTO instances are equal
        /// </summary>
        /// <param name="other">Instance of ModelDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModelDTO other)
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
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) && 
                (
                    this.UserDescription == other.UserDescription ||
                    this.UserDescription != null &&
                    this.UserDescription.Equals(other.UserDescription)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.FileName == other.FileName ||
                    this.FileName != null &&
                    this.FileName.Equals(other.FileName)
                ) && 
                (
                    this.LockModality == other.LockModality ||
                    this.LockModality != null &&
                    this.LockModality.Equals(other.LockModality)
                ) && 
                (
                    this.PredefinedProfileId == other.PredefinedProfileId ||
                    this.PredefinedProfileId != null &&
                    this.PredefinedProfileId.Equals(other.PredefinedProfileId)
                ) && 
                (
                    this.GroupId == other.GroupId ||
                    this.GroupId != null &&
                    this.GroupId.Equals(other.GroupId)
                ) && 
                (
                    this.GroupName == other.GroupName ||
                    this.GroupName != null &&
                    this.GroupName.Equals(other.GroupName)
                ) && 
                (
                    this.Extension == other.Extension ||
                    this.Extension != null &&
                    this.Extension.Equals(other.Extension)
                ) && 
                (
                    this.OpenAfterProfilation == other.OpenAfterProfilation ||
                    this.OpenAfterProfilation != null &&
                    this.OpenAfterProfilation.Equals(other.OpenAfterProfilation)
                ) && 
                (
                    this.MaskId == other.MaskId ||
                    this.MaskId != null &&
                    this.MaskId.Equals(other.MaskId)
                ) && 
                (
                    this.PreviewFileName == other.PreviewFileName ||
                    this.PreviewFileName != null &&
                    this.PreviewFileName.Equals(other.PreviewFileName)
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
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();
                if (this.UserDescription != null)
                    hash = hash * 59 + this.UserDescription.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.FileName != null)
                    hash = hash * 59 + this.FileName.GetHashCode();
                if (this.LockModality != null)
                    hash = hash * 59 + this.LockModality.GetHashCode();
                if (this.PredefinedProfileId != null)
                    hash = hash * 59 + this.PredefinedProfileId.GetHashCode();
                if (this.GroupId != null)
                    hash = hash * 59 + this.GroupId.GetHashCode();
                if (this.GroupName != null)
                    hash = hash * 59 + this.GroupName.GetHashCode();
                if (this.Extension != null)
                    hash = hash * 59 + this.Extension.GetHashCode();
                if (this.OpenAfterProfilation != null)
                    hash = hash * 59 + this.OpenAfterProfilation.GetHashCode();
                if (this.MaskId != null)
                    hash = hash * 59 + this.MaskId.GetHashCode();
                if (this.PreviewFileName != null)
                    hash = hash * 59 + this.PreviewFileName.GetHashCode();
                return hash;
            }
        }
    }

}