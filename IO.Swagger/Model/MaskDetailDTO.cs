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
    /// MaskDetailDTO
    /// </summary>
    [DataContract]
    public partial class MaskDetailDTO :  IEquatable<MaskDetailDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MaskDetailDTO" /> class.
        /// </summary>
        /// <param name="id">Detail Identifier.</param>
        /// <param name="maskId">Mask Identifier.</param>
        /// <param name="fieldName">Name of the field..</param>
        /// <param name="label">Label.</param>
        /// <param name="order">Mask detail order.</param>
        /// <param name="readOnly">Read Only.</param>
        /// <param name="required">Required.</param>
        /// <param name="detailKind">Possible values:  0: NonImpostato  1: From  2: To  3: Cc  4: Aoo  5: DocumentType  6: DataDoc  7: Numero  8: Oggetto  9: Origine  10: Stato  11: Pratiche  12: Scadenza  13: Importante  14: AbilitaWeb  15: AvviaWorkFlow  16: InviaPerFax  17: InviaPerMail  18: AllegaATaskAttivo  19: InserisciInAssociazione  20: InserisciInFascicolo  21: InserisciInRelazioneManuale  22: GestisciRevisioni  23: Note  24: Allegati  25: Aggiuntivo  26: File  27: Scanner  28: Barcode  29: SicurezzaSingoloDocumento  30: ExternalId  31: AllegaMemo  32: Senders  33: AvviaCollaboration  34: ScansioneImmediata  35: NegaCommuta  36: From_Cap  37: From_Cell  38: From_Codfis  39: From_Codice  40: From_Contatti  41: From_Email  42: From_Fax  43: From_Faxnome  44: From_Indirizzo  45: From_Localita  46: From_Mail  47: From_Mansione  48: From_Nazione  49: From_Partiva  50: From_Provincia  51: From_Reparto  52: From_Riferimento  53: From_Tel  54: From_Telnome  55: From_Ufficio  56: From_Valore  57: From_Abitazione  58: To_Cap  59: To_Cell  60: To_Codfis  61: To_Codice  62: To_Contatti  63: To_Email  64: To_Fax  65: To_Faxnome  66: To_Indirizzo  67: To_Localita  68: To_Mail  69: To_Mansione  70: To_Nazione  71: To_Partiva  72: To_Provincia  73: To_Reparto  74: To_Riferimento  75: To_Tel  76: To_Telnome  77: To_Ufficio  78: To_Valore  79: To_Abitazione  80: Cc_Cap  81: Cc_Cell  82: Cc_Codfis  83: Cc_Codice  84: Cc_Contatti  85: Cc_Email  86: Cc_Fax  87: Cc_Faxnome  88: Cc_Indirizzo  89: Cc_Localita  90: Cc_Mail  91: Cc_Mansione  92: Cc_Nazione  93: Cc_Partiva  94: Cc_Provincia  95: Cc_Reparto  96: Cc_Riferimento  97: Cc_Tel  98: Cc_Telnome  99: Cc_Ufficio  100: Cc_Valore  101: Cc_Abitazione  102: Senders_Cap  103: Senders_Cell  104: Senders_Codfis  105: Senders_Codice  106: Senders_Contatti  107: Senders_Email  108: Senders_Fax  109: Senders_Faxnome  110: Senders_Indirizzo  111: Senders_Localita  112: Senders_Mail  113: Senders_Mansione  114: Senders_Nazione  115: Senders_Partiva  116: Senders_Provincia  117: Senders_Reparto  118: Senders_Riferimento  119: Senders_Tel  120: Senders_Telnome  121: Senders_Ufficio  122: Senders_Valore  123: Senders_Abitazione  124: From_Priorita  125: To_Priorita  126: Cc_Priorita  127: Senders_Priorita .</param>
        public MaskDetailDTO(string id = default(string), string maskId = default(string), string fieldName = default(string), string label = default(string), int? order = default(int?), bool? readOnly = default(bool?), bool? required = default(bool?), int? detailKind = default(int?))
        {
            this.Id = id;
            this.MaskId = maskId;
            this.FieldName = fieldName;
            this.Label = label;
            this.Order = order;
            this.ReadOnly = readOnly;
            this.Required = required;
            this.DetailKind = detailKind;
        }
        
        /// <summary>
        /// Detail Identifier
        /// </summary>
        /// <value>Detail Identifier</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Mask Identifier
        /// </summary>
        /// <value>Mask Identifier</value>
        [DataMember(Name="maskId", EmitDefaultValue=false)]
        public string MaskId { get; set; }

        /// <summary>
        /// Name of the field.
        /// </summary>
        /// <value>Name of the field.</value>
        [DataMember(Name="fieldName", EmitDefaultValue=false)]
        public string FieldName { get; set; }

        /// <summary>
        /// Label
        /// </summary>
        /// <value>Label</value>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; set; }

        /// <summary>
        /// Mask detail order
        /// </summary>
        /// <value>Mask detail order</value>
        [DataMember(Name="order", EmitDefaultValue=false)]
        public int? Order { get; set; }

        /// <summary>
        /// Read Only
        /// </summary>
        /// <value>Read Only</value>
        [DataMember(Name="readOnly", EmitDefaultValue=false)]
        public bool? ReadOnly { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        /// <value>Required</value>
        [DataMember(Name="required", EmitDefaultValue=false)]
        public bool? Required { get; set; }

        /// <summary>
        /// Possible values:  0: NonImpostato  1: From  2: To  3: Cc  4: Aoo  5: DocumentType  6: DataDoc  7: Numero  8: Oggetto  9: Origine  10: Stato  11: Pratiche  12: Scadenza  13: Importante  14: AbilitaWeb  15: AvviaWorkFlow  16: InviaPerFax  17: InviaPerMail  18: AllegaATaskAttivo  19: InserisciInAssociazione  20: InserisciInFascicolo  21: InserisciInRelazioneManuale  22: GestisciRevisioni  23: Note  24: Allegati  25: Aggiuntivo  26: File  27: Scanner  28: Barcode  29: SicurezzaSingoloDocumento  30: ExternalId  31: AllegaMemo  32: Senders  33: AvviaCollaboration  34: ScansioneImmediata  35: NegaCommuta  36: From_Cap  37: From_Cell  38: From_Codfis  39: From_Codice  40: From_Contatti  41: From_Email  42: From_Fax  43: From_Faxnome  44: From_Indirizzo  45: From_Localita  46: From_Mail  47: From_Mansione  48: From_Nazione  49: From_Partiva  50: From_Provincia  51: From_Reparto  52: From_Riferimento  53: From_Tel  54: From_Telnome  55: From_Ufficio  56: From_Valore  57: From_Abitazione  58: To_Cap  59: To_Cell  60: To_Codfis  61: To_Codice  62: To_Contatti  63: To_Email  64: To_Fax  65: To_Faxnome  66: To_Indirizzo  67: To_Localita  68: To_Mail  69: To_Mansione  70: To_Nazione  71: To_Partiva  72: To_Provincia  73: To_Reparto  74: To_Riferimento  75: To_Tel  76: To_Telnome  77: To_Ufficio  78: To_Valore  79: To_Abitazione  80: Cc_Cap  81: Cc_Cell  82: Cc_Codfis  83: Cc_Codice  84: Cc_Contatti  85: Cc_Email  86: Cc_Fax  87: Cc_Faxnome  88: Cc_Indirizzo  89: Cc_Localita  90: Cc_Mail  91: Cc_Mansione  92: Cc_Nazione  93: Cc_Partiva  94: Cc_Provincia  95: Cc_Reparto  96: Cc_Riferimento  97: Cc_Tel  98: Cc_Telnome  99: Cc_Ufficio  100: Cc_Valore  101: Cc_Abitazione  102: Senders_Cap  103: Senders_Cell  104: Senders_Codfis  105: Senders_Codice  106: Senders_Contatti  107: Senders_Email  108: Senders_Fax  109: Senders_Faxnome  110: Senders_Indirizzo  111: Senders_Localita  112: Senders_Mail  113: Senders_Mansione  114: Senders_Nazione  115: Senders_Partiva  116: Senders_Provincia  117: Senders_Reparto  118: Senders_Riferimento  119: Senders_Tel  120: Senders_Telnome  121: Senders_Ufficio  122: Senders_Valore  123: Senders_Abitazione  124: From_Priorita  125: To_Priorita  126: Cc_Priorita  127: Senders_Priorita 
        /// </summary>
        /// <value>Possible values:  0: NonImpostato  1: From  2: To  3: Cc  4: Aoo  5: DocumentType  6: DataDoc  7: Numero  8: Oggetto  9: Origine  10: Stato  11: Pratiche  12: Scadenza  13: Importante  14: AbilitaWeb  15: AvviaWorkFlow  16: InviaPerFax  17: InviaPerMail  18: AllegaATaskAttivo  19: InserisciInAssociazione  20: InserisciInFascicolo  21: InserisciInRelazioneManuale  22: GestisciRevisioni  23: Note  24: Allegati  25: Aggiuntivo  26: File  27: Scanner  28: Barcode  29: SicurezzaSingoloDocumento  30: ExternalId  31: AllegaMemo  32: Senders  33: AvviaCollaboration  34: ScansioneImmediata  35: NegaCommuta  36: From_Cap  37: From_Cell  38: From_Codfis  39: From_Codice  40: From_Contatti  41: From_Email  42: From_Fax  43: From_Faxnome  44: From_Indirizzo  45: From_Localita  46: From_Mail  47: From_Mansione  48: From_Nazione  49: From_Partiva  50: From_Provincia  51: From_Reparto  52: From_Riferimento  53: From_Tel  54: From_Telnome  55: From_Ufficio  56: From_Valore  57: From_Abitazione  58: To_Cap  59: To_Cell  60: To_Codfis  61: To_Codice  62: To_Contatti  63: To_Email  64: To_Fax  65: To_Faxnome  66: To_Indirizzo  67: To_Localita  68: To_Mail  69: To_Mansione  70: To_Nazione  71: To_Partiva  72: To_Provincia  73: To_Reparto  74: To_Riferimento  75: To_Tel  76: To_Telnome  77: To_Ufficio  78: To_Valore  79: To_Abitazione  80: Cc_Cap  81: Cc_Cell  82: Cc_Codfis  83: Cc_Codice  84: Cc_Contatti  85: Cc_Email  86: Cc_Fax  87: Cc_Faxnome  88: Cc_Indirizzo  89: Cc_Localita  90: Cc_Mail  91: Cc_Mansione  92: Cc_Nazione  93: Cc_Partiva  94: Cc_Provincia  95: Cc_Reparto  96: Cc_Riferimento  97: Cc_Tel  98: Cc_Telnome  99: Cc_Ufficio  100: Cc_Valore  101: Cc_Abitazione  102: Senders_Cap  103: Senders_Cell  104: Senders_Codfis  105: Senders_Codice  106: Senders_Contatti  107: Senders_Email  108: Senders_Fax  109: Senders_Faxnome  110: Senders_Indirizzo  111: Senders_Localita  112: Senders_Mail  113: Senders_Mansione  114: Senders_Nazione  115: Senders_Partiva  116: Senders_Provincia  117: Senders_Reparto  118: Senders_Riferimento  119: Senders_Tel  120: Senders_Telnome  121: Senders_Ufficio  122: Senders_Valore  123: Senders_Abitazione  124: From_Priorita  125: To_Priorita  126: Cc_Priorita  127: Senders_Priorita </value>
        [DataMember(Name="detailKind", EmitDefaultValue=false)]
        public int? DetailKind { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MaskDetailDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  MaskId: ").Append(MaskId).Append("\n");
            sb.Append("  FieldName: ").Append(FieldName).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  ReadOnly: ").Append(ReadOnly).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
            sb.Append("  DetailKind: ").Append(DetailKind).Append("\n");
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
            return this.Equals(input as MaskDetailDTO);
        }

        /// <summary>
        /// Returns true if MaskDetailDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of MaskDetailDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MaskDetailDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.MaskId == input.MaskId ||
                    (this.MaskId != null &&
                    this.MaskId.Equals(input.MaskId))
                ) && 
                (
                    this.FieldName == input.FieldName ||
                    (this.FieldName != null &&
                    this.FieldName.Equals(input.FieldName))
                ) && 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
                ) && 
                (
                    this.Order == input.Order ||
                    (this.Order != null &&
                    this.Order.Equals(input.Order))
                ) && 
                (
                    this.ReadOnly == input.ReadOnly ||
                    (this.ReadOnly != null &&
                    this.ReadOnly.Equals(input.ReadOnly))
                ) && 
                (
                    this.Required == input.Required ||
                    (this.Required != null &&
                    this.Required.Equals(input.Required))
                ) && 
                (
                    this.DetailKind == input.DetailKind ||
                    (this.DetailKind != null &&
                    this.DetailKind.Equals(input.DetailKind))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.MaskId != null)
                    hashCode = hashCode * 59 + this.MaskId.GetHashCode();
                if (this.FieldName != null)
                    hashCode = hashCode * 59 + this.FieldName.GetHashCode();
                if (this.Label != null)
                    hashCode = hashCode * 59 + this.Label.GetHashCode();
                if (this.Order != null)
                    hashCode = hashCode * 59 + this.Order.GetHashCode();
                if (this.ReadOnly != null)
                    hashCode = hashCode * 59 + this.ReadOnly.GetHashCode();
                if (this.Required != null)
                    hashCode = hashCode * 59 + this.Required.GetHashCode();
                if (this.DetailKind != null)
                    hashCode = hashCode * 59 + this.DetailKind.GetHashCode();
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
