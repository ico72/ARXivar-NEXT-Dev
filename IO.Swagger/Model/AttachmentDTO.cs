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
    /// AttachmentDTO
    /// </summary>
    [DataContract]
    public partial class AttachmentDTO :  IEquatable<AttachmentDTO>
    {
        /// <summary>
        /// Dispositivo di salvataggio del file.
        /// </summary>
        /// <value>Dispositivo di salvataggio del file.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DeviceEnum
        {
            
            /// <summary>
            /// Enum Hd for "Hd"
            /// </summary>
            [EnumMember(Value = "Hd")]
            Hd,
            
            /// <summary>
            /// Enum Cd for "Cd"
            /// </summary>
            [EnumMember(Value = "Cd")]
            Cd
        }

        /// <summary>
        /// Tipologia di blocco dell'allegato.
        /// </summary>
        /// <value>Tipologia di blocco dell'allegato.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BlockEnum
        {
            
            /// <summary>
            /// Enum None for "None"
            /// </summary>
            [EnumMember(Value = "None")]
            None,
            
            /// <summary>
            /// Enum Active for "Active"
            /// </summary>
            [EnumMember(Value = "Active")]
            Active,
            
            /// <summary>
            /// Enum Marked for "Marked"
            /// </summary>
            [EnumMember(Value = "Marked")]
            Marked
        }

        /// <summary>
        /// Livello di accesso dell'allegato.
        /// </summary>
        /// <value>Livello di accesso dell'allegato.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AccessEnum
        {
            
            /// <summary>
            /// Enum None for "None"
            /// </summary>
            [EnumMember(Value = "None")]
            None,
            
            /// <summary>
            /// Enum AccessDenied for "Access_Denied"
            /// </summary>
            [EnumMember(Value = "Access_Denied")]
            AccessDenied,
            
            /// <summary>
            /// Enum ReadOnly for "Read_Only"
            /// </summary>
            [EnumMember(Value = "Read_Only")]
            ReadOnly,
            
            /// <summary>
            /// Enum Edit for "Edit"
            /// </summary>
            [EnumMember(Value = "Edit")]
            Edit,
            
            /// <summary>
            /// Enum FullTrust for "Full_Trust"
            /// </summary>
            [EnumMember(Value = "Full_Trust")]
            FullTrust
        }

        /// <summary>
        /// Tipologia di salvataggio.
        /// </summary>
        /// <value>Tipologia di salvataggio.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SaveTypeEnum
        {
            
            /// <summary>
            /// Enum FileSystem for "File_System"
            /// </summary>
            [EnumMember(Value = "File_System")]
            FileSystem,
            
            /// <summary>
            /// Enum Database for "Database"
            /// </summary>
            [EnumMember(Value = "Database")]
            Database
        }

        /// <summary>
        /// Tipologia di allegato
        /// </summary>
        /// <value>Tipologia di allegato</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum KindEnum
        {
            
            /// <summary>
            /// Enum ExternalAttachement for "ExternalAttachement"
            /// </summary>
            [EnumMember(Value = "ExternalAttachement")]
            ExternalAttachement,
            
            /// <summary>
            /// Enum InternalAttachement for "InternalAttachement"
            /// </summary>
            [EnumMember(Value = "InternalAttachement")]
            InternalAttachement
        }

        /// <summary>
        /// Gets or Sets CompressionMode
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CompressionModeEnum
        {
            
            /// <summary>
            /// Enum None for "None"
            /// </summary>
            [EnumMember(Value = "None")]
            None,
            
            /// <summary>
            /// Enum CompressChilkat91 for "CompressChilkat91"
            /// </summary>
            [EnumMember(Value = "CompressChilkat91")]
            CompressChilkat91,
            
            /// <summary>
            /// Enum CompressChilkat95 for "CompressChilkat95"
            /// </summary>
            [EnumMember(Value = "CompressChilkat95")]
            CompressChilkat95,
            
            /// <summary>
            /// Enum CompressChilkat95AndCryptoAes256 for "CompressChilkat95AndCryptoAes256"
            /// </summary>
            [EnumMember(Value = "CompressChilkat95AndCryptoAes256")]
            CompressChilkat95AndCryptoAes256
        }

        /// <summary>
        /// Dispositivo di salvataggio del file.
        /// </summary>
        /// <value>Dispositivo di salvataggio del file.</value>
        [DataMember(Name="device", EmitDefaultValue=false)]
        public DeviceEnum? Device { get; set; }
        /// <summary>
        /// Tipologia di blocco dell'allegato.
        /// </summary>
        /// <value>Tipologia di blocco dell'allegato.</value>
        [DataMember(Name="block", EmitDefaultValue=false)]
        public BlockEnum? Block { get; set; }
        /// <summary>
        /// Livello di accesso dell'allegato.
        /// </summary>
        /// <value>Livello di accesso dell'allegato.</value>
        [DataMember(Name="access", EmitDefaultValue=false)]
        public AccessEnum? Access { get; set; }
        /// <summary>
        /// Tipologia di salvataggio.
        /// </summary>
        /// <value>Tipologia di salvataggio.</value>
        [DataMember(Name="saveType", EmitDefaultValue=false)]
        public SaveTypeEnum? SaveType { get; set; }
        /// <summary>
        /// Tipologia di allegato
        /// </summary>
        /// <value>Tipologia di allegato</value>
        [DataMember(Name="kind", EmitDefaultValue=false)]
        public KindEnum? Kind { get; set; }
        /// <summary>
        /// Gets or Sets CompressionMode
        /// </summary>
        [DataMember(Name="compressionMode", EmitDefaultValue=false)]
        public CompressionModeEnum? CompressionMode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AttachmentDTO" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Docnumber">Identificativo del profilo documentale..</param>
        /// <param name="Revision">Identificativo della revisione del profilo documentale..</param>
        /// <param name="Filename">Nome del file compresso..</param>
        /// <param name="Filepath">Percorso di salvataggio del file..</param>
        /// <param name="Originalname">Nome originale del file..</param>
        /// <param name="Device">Dispositivo di salvataggio del file..</param>
        /// <param name="Cdlabel">Etichetta, nel caso il file si presenta su CD..</param>
        /// <param name="Comment">Descrizione dell’allegato..</param>
        /// <param name="Importdate">Data d&#39;importazione dell&#39;allegato..</param>
        /// <param name="User">Identificatore dell&#39;utente che ha importato l&#39;allegato..</param>
        /// <param name="UserCompleteName">UserCompleteName.</param>
        /// <param name="Block">Tipologia di blocco dell&#39;allegato..</param>
        /// <param name="Zippassword">Codice di password del file criptato..</param>
        /// <param name="Compliantcopy">Verifica che l&#39;allegato sostituisca il profilo documentale nel caso di visualizzazione via Web..</param>
        /// <param name="Cstring">Stringa di connessione criptata di salvataggio del file..</param>
        /// <param name="Footprint">Impronta del file..</param>
        /// <param name="Checksend">Verifica se l&#39;allegato dovrà essere inviato insieme al documento principale, nel caso di spedizione..</param>
        /// <param name="Aosflag">Verifica se l&#39;allegato dovrà essere conservato in modalità sostitutiva con il profilo documentale..</param>
        /// <param name="Access">Livello di accesso dell&#39;allegato..</param>
        /// <param name="SaveType">Tipologia di salvataggio..</param>
        /// <param name="Filesize">Dimensione del file di riferimento..</param>
        /// <param name="Kind">Tipologia di allegato.</param>
        /// <param name="AttachedDocnumber">Profilo del documento allegato.</param>
        /// <param name="IxCheck">Verifica se l&#39;allegato dovrà essere inviato a IX insieme al documento principale, nel caso di spedizione..</param>
        /// <param name="AttachmentRevision">Indica la revisione dell&#39;allegato.</param>
        /// <param name="CompressionMode">CompressionMode.</param>
        public AttachmentDTO(int? Id = null, int? Docnumber = null, int? Revision = null, string Filename = null, string Filepath = null, string Originalname = null, DeviceEnum? Device = null, string Cdlabel = null, string Comment = null, DateTime? Importdate = null, int? User = null, string UserCompleteName = null, BlockEnum? Block = null, string Zippassword = null, bool? Compliantcopy = null, string Cstring = null, string Footprint = null, bool? Checksend = null, bool? Aosflag = null, AccessEnum? Access = null, SaveTypeEnum? SaveType = null, long? Filesize = null, KindEnum? Kind = null, int? AttachedDocnumber = null, bool? IxCheck = null, int? AttachmentRevision = null, CompressionModeEnum? CompressionMode = null)
        {
            this.Id = Id;
            this.Docnumber = Docnumber;
            this.Revision = Revision;
            this.Filename = Filename;
            this.Filepath = Filepath;
            this.Originalname = Originalname;
            this.Device = Device;
            this.Cdlabel = Cdlabel;
            this.Comment = Comment;
            this.Importdate = Importdate;
            this.User = User;
            this.UserCompleteName = UserCompleteName;
            this.Block = Block;
            this.Zippassword = Zippassword;
            this.Compliantcopy = Compliantcopy;
            this.Cstring = Cstring;
            this.Footprint = Footprint;
            this.Checksend = Checksend;
            this.Aosflag = Aosflag;
            this.Access = Access;
            this.SaveType = SaveType;
            this.Filesize = Filesize;
            this.Kind = Kind;
            this.AttachedDocnumber = AttachedDocnumber;
            this.IxCheck = IxCheck;
            this.AttachmentRevision = AttachmentRevision;
            this.CompressionMode = CompressionMode;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }
        /// <summary>
        /// Identificativo del profilo documentale.
        /// </summary>
        /// <value>Identificativo del profilo documentale.</value>
        [DataMember(Name="docnumber", EmitDefaultValue=false)]
        public int? Docnumber { get; set; }
        /// <summary>
        /// Identificativo della revisione del profilo documentale.
        /// </summary>
        /// <value>Identificativo della revisione del profilo documentale.</value>
        [DataMember(Name="revision", EmitDefaultValue=false)]
        public int? Revision { get; set; }
        /// <summary>
        /// Nome del file compresso.
        /// </summary>
        /// <value>Nome del file compresso.</value>
        [DataMember(Name="filename", EmitDefaultValue=false)]
        public string Filename { get; set; }
        /// <summary>
        /// Percorso di salvataggio del file.
        /// </summary>
        /// <value>Percorso di salvataggio del file.</value>
        [DataMember(Name="filepath", EmitDefaultValue=false)]
        public string Filepath { get; set; }
        /// <summary>
        /// Nome originale del file.
        /// </summary>
        /// <value>Nome originale del file.</value>
        [DataMember(Name="originalname", EmitDefaultValue=false)]
        public string Originalname { get; set; }
        /// <summary>
        /// Etichetta, nel caso il file si presenta su CD.
        /// </summary>
        /// <value>Etichetta, nel caso il file si presenta su CD.</value>
        [DataMember(Name="cdlabel", EmitDefaultValue=false)]
        public string Cdlabel { get; set; }
        /// <summary>
        /// Descrizione dell’allegato.
        /// </summary>
        /// <value>Descrizione dell’allegato.</value>
        [DataMember(Name="comment", EmitDefaultValue=false)]
        public string Comment { get; set; }
        /// <summary>
        /// Data d&#39;importazione dell&#39;allegato.
        /// </summary>
        /// <value>Data d&#39;importazione dell&#39;allegato.</value>
        [DataMember(Name="importdate", EmitDefaultValue=false)]
        public DateTime? Importdate { get; set; }
        /// <summary>
        /// Identificatore dell&#39;utente che ha importato l&#39;allegato.
        /// </summary>
        /// <value>Identificatore dell&#39;utente che ha importato l&#39;allegato.</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public int? User { get; set; }
        /// <summary>
        /// Gets or Sets UserCompleteName
        /// </summary>
        [DataMember(Name="userCompleteName", EmitDefaultValue=false)]
        public string UserCompleteName { get; set; }
        /// <summary>
        /// Codice di password del file criptato.
        /// </summary>
        /// <value>Codice di password del file criptato.</value>
        [DataMember(Name="zippassword", EmitDefaultValue=false)]
        public string Zippassword { get; set; }
        /// <summary>
        /// Verifica che l&#39;allegato sostituisca il profilo documentale nel caso di visualizzazione via Web.
        /// </summary>
        /// <value>Verifica che l&#39;allegato sostituisca il profilo documentale nel caso di visualizzazione via Web.</value>
        [DataMember(Name="compliantcopy", EmitDefaultValue=false)]
        public bool? Compliantcopy { get; set; }
        /// <summary>
        /// Stringa di connessione criptata di salvataggio del file.
        /// </summary>
        /// <value>Stringa di connessione criptata di salvataggio del file.</value>
        [DataMember(Name="cstring", EmitDefaultValue=false)]
        public string Cstring { get; set; }
        /// <summary>
        /// Impronta del file.
        /// </summary>
        /// <value>Impronta del file.</value>
        [DataMember(Name="footprint", EmitDefaultValue=false)]
        public string Footprint { get; set; }
        /// <summary>
        /// Verifica se l&#39;allegato dovrà essere inviato insieme al documento principale, nel caso di spedizione.
        /// </summary>
        /// <value>Verifica se l&#39;allegato dovrà essere inviato insieme al documento principale, nel caso di spedizione.</value>
        [DataMember(Name="checksend", EmitDefaultValue=false)]
        public bool? Checksend { get; set; }
        /// <summary>
        /// Verifica se l&#39;allegato dovrà essere conservato in modalità sostitutiva con il profilo documentale.
        /// </summary>
        /// <value>Verifica se l&#39;allegato dovrà essere conservato in modalità sostitutiva con il profilo documentale.</value>
        [DataMember(Name="aosflag", EmitDefaultValue=false)]
        public bool? Aosflag { get; set; }
        /// <summary>
        /// Dimensione del file di riferimento.
        /// </summary>
        /// <value>Dimensione del file di riferimento.</value>
        [DataMember(Name="filesize", EmitDefaultValue=false)]
        public long? Filesize { get; set; }
        /// <summary>
        /// Profilo del documento allegato
        /// </summary>
        /// <value>Profilo del documento allegato</value>
        [DataMember(Name="attachedDocnumber", EmitDefaultValue=false)]
        public int? AttachedDocnumber { get; set; }
        /// <summary>
        /// Verifica se l&#39;allegato dovrà essere inviato a IX insieme al documento principale, nel caso di spedizione.
        /// </summary>
        /// <value>Verifica se l&#39;allegato dovrà essere inviato a IX insieme al documento principale, nel caso di spedizione.</value>
        [DataMember(Name="ixCheck", EmitDefaultValue=false)]
        public bool? IxCheck { get; set; }
        /// <summary>
        /// Indica la revisione dell&#39;allegato
        /// </summary>
        /// <value>Indica la revisione dell&#39;allegato</value>
        [DataMember(Name="attachmentRevision", EmitDefaultValue=false)]
        public int? AttachmentRevision { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AttachmentDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Docnumber: ").Append(Docnumber).Append("\n");
            sb.Append("  Revision: ").Append(Revision).Append("\n");
            sb.Append("  Filename: ").Append(Filename).Append("\n");
            sb.Append("  Filepath: ").Append(Filepath).Append("\n");
            sb.Append("  Originalname: ").Append(Originalname).Append("\n");
            sb.Append("  Device: ").Append(Device).Append("\n");
            sb.Append("  Cdlabel: ").Append(Cdlabel).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  Importdate: ").Append(Importdate).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  UserCompleteName: ").Append(UserCompleteName).Append("\n");
            sb.Append("  Block: ").Append(Block).Append("\n");
            sb.Append("  Zippassword: ").Append(Zippassword).Append("\n");
            sb.Append("  Compliantcopy: ").Append(Compliantcopy).Append("\n");
            sb.Append("  Cstring: ").Append(Cstring).Append("\n");
            sb.Append("  Footprint: ").Append(Footprint).Append("\n");
            sb.Append("  Checksend: ").Append(Checksend).Append("\n");
            sb.Append("  Aosflag: ").Append(Aosflag).Append("\n");
            sb.Append("  Access: ").Append(Access).Append("\n");
            sb.Append("  SaveType: ").Append(SaveType).Append("\n");
            sb.Append("  Filesize: ").Append(Filesize).Append("\n");
            sb.Append("  Kind: ").Append(Kind).Append("\n");
            sb.Append("  AttachedDocnumber: ").Append(AttachedDocnumber).Append("\n");
            sb.Append("  IxCheck: ").Append(IxCheck).Append("\n");
            sb.Append("  AttachmentRevision: ").Append(AttachmentRevision).Append("\n");
            sb.Append("  CompressionMode: ").Append(CompressionMode).Append("\n");
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
            return this.Equals(obj as AttachmentDTO);
        }

        /// <summary>
        /// Returns true if AttachmentDTO instances are equal
        /// </summary>
        /// <param name="other">Instance of AttachmentDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AttachmentDTO other)
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
                    this.Docnumber == other.Docnumber ||
                    this.Docnumber != null &&
                    this.Docnumber.Equals(other.Docnumber)
                ) && 
                (
                    this.Revision == other.Revision ||
                    this.Revision != null &&
                    this.Revision.Equals(other.Revision)
                ) && 
                (
                    this.Filename == other.Filename ||
                    this.Filename != null &&
                    this.Filename.Equals(other.Filename)
                ) && 
                (
                    this.Filepath == other.Filepath ||
                    this.Filepath != null &&
                    this.Filepath.Equals(other.Filepath)
                ) && 
                (
                    this.Originalname == other.Originalname ||
                    this.Originalname != null &&
                    this.Originalname.Equals(other.Originalname)
                ) && 
                (
                    this.Device == other.Device ||
                    this.Device != null &&
                    this.Device.Equals(other.Device)
                ) && 
                (
                    this.Cdlabel == other.Cdlabel ||
                    this.Cdlabel != null &&
                    this.Cdlabel.Equals(other.Cdlabel)
                ) && 
                (
                    this.Comment == other.Comment ||
                    this.Comment != null &&
                    this.Comment.Equals(other.Comment)
                ) && 
                (
                    this.Importdate == other.Importdate ||
                    this.Importdate != null &&
                    this.Importdate.Equals(other.Importdate)
                ) && 
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) && 
                (
                    this.UserCompleteName == other.UserCompleteName ||
                    this.UserCompleteName != null &&
                    this.UserCompleteName.Equals(other.UserCompleteName)
                ) && 
                (
                    this.Block == other.Block ||
                    this.Block != null &&
                    this.Block.Equals(other.Block)
                ) && 
                (
                    this.Zippassword == other.Zippassword ||
                    this.Zippassword != null &&
                    this.Zippassword.Equals(other.Zippassword)
                ) && 
                (
                    this.Compliantcopy == other.Compliantcopy ||
                    this.Compliantcopy != null &&
                    this.Compliantcopy.Equals(other.Compliantcopy)
                ) && 
                (
                    this.Cstring == other.Cstring ||
                    this.Cstring != null &&
                    this.Cstring.Equals(other.Cstring)
                ) && 
                (
                    this.Footprint == other.Footprint ||
                    this.Footprint != null &&
                    this.Footprint.Equals(other.Footprint)
                ) && 
                (
                    this.Checksend == other.Checksend ||
                    this.Checksend != null &&
                    this.Checksend.Equals(other.Checksend)
                ) && 
                (
                    this.Aosflag == other.Aosflag ||
                    this.Aosflag != null &&
                    this.Aosflag.Equals(other.Aosflag)
                ) && 
                (
                    this.Access == other.Access ||
                    this.Access != null &&
                    this.Access.Equals(other.Access)
                ) && 
                (
                    this.SaveType == other.SaveType ||
                    this.SaveType != null &&
                    this.SaveType.Equals(other.SaveType)
                ) && 
                (
                    this.Filesize == other.Filesize ||
                    this.Filesize != null &&
                    this.Filesize.Equals(other.Filesize)
                ) && 
                (
                    this.Kind == other.Kind ||
                    this.Kind != null &&
                    this.Kind.Equals(other.Kind)
                ) && 
                (
                    this.AttachedDocnumber == other.AttachedDocnumber ||
                    this.AttachedDocnumber != null &&
                    this.AttachedDocnumber.Equals(other.AttachedDocnumber)
                ) && 
                (
                    this.IxCheck == other.IxCheck ||
                    this.IxCheck != null &&
                    this.IxCheck.Equals(other.IxCheck)
                ) && 
                (
                    this.AttachmentRevision == other.AttachmentRevision ||
                    this.AttachmentRevision != null &&
                    this.AttachmentRevision.Equals(other.AttachmentRevision)
                ) && 
                (
                    this.CompressionMode == other.CompressionMode ||
                    this.CompressionMode != null &&
                    this.CompressionMode.Equals(other.CompressionMode)
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
                if (this.Docnumber != null)
                    hash = hash * 59 + this.Docnumber.GetHashCode();
                if (this.Revision != null)
                    hash = hash * 59 + this.Revision.GetHashCode();
                if (this.Filename != null)
                    hash = hash * 59 + this.Filename.GetHashCode();
                if (this.Filepath != null)
                    hash = hash * 59 + this.Filepath.GetHashCode();
                if (this.Originalname != null)
                    hash = hash * 59 + this.Originalname.GetHashCode();
                if (this.Device != null)
                    hash = hash * 59 + this.Device.GetHashCode();
                if (this.Cdlabel != null)
                    hash = hash * 59 + this.Cdlabel.GetHashCode();
                if (this.Comment != null)
                    hash = hash * 59 + this.Comment.GetHashCode();
                if (this.Importdate != null)
                    hash = hash * 59 + this.Importdate.GetHashCode();
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();
                if (this.UserCompleteName != null)
                    hash = hash * 59 + this.UserCompleteName.GetHashCode();
                if (this.Block != null)
                    hash = hash * 59 + this.Block.GetHashCode();
                if (this.Zippassword != null)
                    hash = hash * 59 + this.Zippassword.GetHashCode();
                if (this.Compliantcopy != null)
                    hash = hash * 59 + this.Compliantcopy.GetHashCode();
                if (this.Cstring != null)
                    hash = hash * 59 + this.Cstring.GetHashCode();
                if (this.Footprint != null)
                    hash = hash * 59 + this.Footprint.GetHashCode();
                if (this.Checksend != null)
                    hash = hash * 59 + this.Checksend.GetHashCode();
                if (this.Aosflag != null)
                    hash = hash * 59 + this.Aosflag.GetHashCode();
                if (this.Access != null)
                    hash = hash * 59 + this.Access.GetHashCode();
                if (this.SaveType != null)
                    hash = hash * 59 + this.SaveType.GetHashCode();
                if (this.Filesize != null)
                    hash = hash * 59 + this.Filesize.GetHashCode();
                if (this.Kind != null)
                    hash = hash * 59 + this.Kind.GetHashCode();
                if (this.AttachedDocnumber != null)
                    hash = hash * 59 + this.AttachedDocnumber.GetHashCode();
                if (this.IxCheck != null)
                    hash = hash * 59 + this.IxCheck.GetHashCode();
                if (this.AttachmentRevision != null)
                    hash = hash * 59 + this.AttachmentRevision.GetHashCode();
                if (this.CompressionMode != null)
                    hash = hash * 59 + this.CompressionMode.GetHashCode();
                return hash;
            }
        }
    }

}
