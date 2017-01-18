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
    /// ProfileDTO
    /// </summary>
    [DataContract]
    public partial class ProfileDTO :  IEquatable<ProfileDTO>
    {
        /// <summary>
        /// Gets or Sets ConstrainRoleBehaviour
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ConstrainRoleBehaviourEnum
        {
            
            /// <summary>
            /// Enum None for "None"
            /// </summary>
            [EnumMember(Value = "None")]
            None,
            
            /// <summary>
            /// Enum ForceInsert for "ForceInsert"
            /// </summary>
            [EnumMember(Value = "ForceInsert")]
            ForceInsert,
            
            /// <summary>
            /// Enum State for "State"
            /// </summary>
            [EnumMember(Value = "State")]
            State
        }

        /// <summary>
        /// Gets or Sets ConstrainRoleBehaviour
        /// </summary>
        [DataMember(Name="constrainRoleBehaviour", EmitDefaultValue=false)]
        public ConstrainRoleBehaviourEnum? ConstrainRoleBehaviour { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProfileDTO" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Document">Document.</param>
        /// <param name="Fields">Fields.</param>
        /// <param name="PostProfilationActions">PostProfilationActions.</param>
        /// <param name="ConstrainRoleBehaviour">ConstrainRoleBehaviour.</param>
        /// <param name="Attachments">Attachments.</param>
        /// <param name="Notes">Notes.</param>
        /// <param name="PaNotes">PaNotes.</param>
        /// <param name="AuthorityData">AuthorityData.</param>
        /// <param name="GeneratePaProtocol">GeneratePaProtocol.</param>
        public ProfileDTO(int? Id = null, FileDTO Document = null, List<FieldBaseDTO> Fields = null, List<PostProfilationActionDTO> PostProfilationActions = null, ConstrainRoleBehaviourEnum? ConstrainRoleBehaviour = null, List<string> Attachments = null, List<NoteDTO> Notes = null, List<string> PaNotes = null, AuthorityDataDTO AuthorityData = null, bool? GeneratePaProtocol = null)
        {
            this.Id = Id;
            this.Document = Document;
            this.Fields = Fields;
            this.PostProfilationActions = PostProfilationActions;
            this.ConstrainRoleBehaviour = ConstrainRoleBehaviour;
            this.Attachments = Attachments;
            this.Notes = Notes;
            this.PaNotes = PaNotes;
            this.AuthorityData = AuthorityData;
            this.GeneratePaProtocol = GeneratePaProtocol;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }
        /// <summary>
        /// Gets or Sets Document
        /// </summary>
        [DataMember(Name="document", EmitDefaultValue=false)]
        public FileDTO Document { get; set; }
        /// <summary>
        /// Gets or Sets Fields
        /// </summary>
        [DataMember(Name="fields", EmitDefaultValue=false)]
        public List<FieldBaseDTO> Fields { get; set; }
        /// <summary>
        /// Gets or Sets PostProfilationActions
        /// </summary>
        [DataMember(Name="postProfilationActions", EmitDefaultValue=false)]
        public List<PostProfilationActionDTO> PostProfilationActions { get; set; }
        /// <summary>
        /// Gets or Sets Attachments
        /// </summary>
        [DataMember(Name="attachments", EmitDefaultValue=false)]
        public List<string> Attachments { get; set; }
        /// <summary>
        /// Gets or Sets Notes
        /// </summary>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public List<NoteDTO> Notes { get; set; }
        /// <summary>
        /// Gets or Sets PaNotes
        /// </summary>
        [DataMember(Name="paNotes", EmitDefaultValue=false)]
        public List<string> PaNotes { get; set; }
        /// <summary>
        /// Gets or Sets AuthorityData
        /// </summary>
        [DataMember(Name="authorityData", EmitDefaultValue=false)]
        public AuthorityDataDTO AuthorityData { get; set; }
        /// <summary>
        /// Gets or Sets GeneratePaProtocol
        /// </summary>
        [DataMember(Name="generatePaProtocol", EmitDefaultValue=false)]
        public bool? GeneratePaProtocol { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProfileDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Document: ").Append(Document).Append("\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
            sb.Append("  PostProfilationActions: ").Append(PostProfilationActions).Append("\n");
            sb.Append("  ConstrainRoleBehaviour: ").Append(ConstrainRoleBehaviour).Append("\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  PaNotes: ").Append(PaNotes).Append("\n");
            sb.Append("  AuthorityData: ").Append(AuthorityData).Append("\n");
            sb.Append("  GeneratePaProtocol: ").Append(GeneratePaProtocol).Append("\n");
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
            return this.Equals(obj as ProfileDTO);
        }

        /// <summary>
        /// Returns true if ProfileDTO instances are equal
        /// </summary>
        /// <param name="other">Instance of ProfileDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProfileDTO other)
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
                    this.Document == other.Document ||
                    this.Document != null &&
                    this.Document.Equals(other.Document)
                ) && 
                (
                    this.Fields == other.Fields ||
                    this.Fields != null &&
                    this.Fields.SequenceEqual(other.Fields)
                ) && 
                (
                    this.PostProfilationActions == other.PostProfilationActions ||
                    this.PostProfilationActions != null &&
                    this.PostProfilationActions.SequenceEqual(other.PostProfilationActions)
                ) && 
                (
                    this.ConstrainRoleBehaviour == other.ConstrainRoleBehaviour ||
                    this.ConstrainRoleBehaviour != null &&
                    this.ConstrainRoleBehaviour.Equals(other.ConstrainRoleBehaviour)
                ) && 
                (
                    this.Attachments == other.Attachments ||
                    this.Attachments != null &&
                    this.Attachments.SequenceEqual(other.Attachments)
                ) && 
                (
                    this.Notes == other.Notes ||
                    this.Notes != null &&
                    this.Notes.SequenceEqual(other.Notes)
                ) && 
                (
                    this.PaNotes == other.PaNotes ||
                    this.PaNotes != null &&
                    this.PaNotes.SequenceEqual(other.PaNotes)
                ) && 
                (
                    this.AuthorityData == other.AuthorityData ||
                    this.AuthorityData != null &&
                    this.AuthorityData.Equals(other.AuthorityData)
                ) && 
                (
                    this.GeneratePaProtocol == other.GeneratePaProtocol ||
                    this.GeneratePaProtocol != null &&
                    this.GeneratePaProtocol.Equals(other.GeneratePaProtocol)
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
                if (this.Document != null)
                    hash = hash * 59 + this.Document.GetHashCode();
                if (this.Fields != null)
                    hash = hash * 59 + this.Fields.GetHashCode();
                if (this.PostProfilationActions != null)
                    hash = hash * 59 + this.PostProfilationActions.GetHashCode();
                if (this.ConstrainRoleBehaviour != null)
                    hash = hash * 59 + this.ConstrainRoleBehaviour.GetHashCode();
                if (this.Attachments != null)
                    hash = hash * 59 + this.Attachments.GetHashCode();
                if (this.Notes != null)
                    hash = hash * 59 + this.Notes.GetHashCode();
                if (this.PaNotes != null)
                    hash = hash * 59 + this.PaNotes.GetHashCode();
                if (this.AuthorityData != null)
                    hash = hash * 59 + this.AuthorityData.GetHashCode();
                if (this.GeneratePaProtocol != null)
                    hash = hash * 59 + this.GeneratePaProtocol.GetHashCode();
                return hash;
            }
        }
    }

}
