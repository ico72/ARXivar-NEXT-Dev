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
    /// PluginSettingRequest
    /// </summary>
    [DataContract]
    public partial class PluginSettingRequest :  IEquatable<PluginSettingRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PluginSettingRequest" /> class.
        /// </summary>
        /// <param name="PluginId">PluginId.</param>
        /// <param name="DesktopId">DesktopId.</param>
        /// <param name="InstanceId">InstanceId.</param>
        /// <param name="Settings">Settings.</param>
        public PluginSettingRequest(string PluginId = null, string DesktopId = null, string InstanceId = null, Dictionary<string, Object> Settings = null)
        {
            this.PluginId = PluginId;
            this.DesktopId = DesktopId;
            this.InstanceId = InstanceId;
            this.Settings = Settings;
        }
        
        /// <summary>
        /// Gets or Sets PluginId
        /// </summary>
        [DataMember(Name="pluginId", EmitDefaultValue=false)]
        public string PluginId { get; set; }
        /// <summary>
        /// Gets or Sets DesktopId
        /// </summary>
        [DataMember(Name="desktopId", EmitDefaultValue=false)]
        public string DesktopId { get; set; }
        /// <summary>
        /// Gets or Sets InstanceId
        /// </summary>
        [DataMember(Name="instanceId", EmitDefaultValue=false)]
        public string InstanceId { get; set; }
        /// <summary>
        /// Gets or Sets Settings
        /// </summary>
        [DataMember(Name="settings", EmitDefaultValue=false)]
        public Dictionary<string, Object> Settings { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PluginSettingRequest {\n");
            sb.Append("  PluginId: ").Append(PluginId).Append("\n");
            sb.Append("  DesktopId: ").Append(DesktopId).Append("\n");
            sb.Append("  InstanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  Settings: ").Append(Settings).Append("\n");
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
            return this.Equals(obj as PluginSettingRequest);
        }

        /// <summary>
        /// Returns true if PluginSettingRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of PluginSettingRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PluginSettingRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.PluginId == other.PluginId ||
                    this.PluginId != null &&
                    this.PluginId.Equals(other.PluginId)
                ) && 
                (
                    this.DesktopId == other.DesktopId ||
                    this.DesktopId != null &&
                    this.DesktopId.Equals(other.DesktopId)
                ) && 
                (
                    this.InstanceId == other.InstanceId ||
                    this.InstanceId != null &&
                    this.InstanceId.Equals(other.InstanceId)
                ) && 
                (
                    this.Settings == other.Settings ||
                    this.Settings != null &&
                    this.Settings.SequenceEqual(other.Settings)
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
                if (this.PluginId != null)
                    hash = hash * 59 + this.PluginId.GetHashCode();
                if (this.DesktopId != null)
                    hash = hash * 59 + this.DesktopId.GetHashCode();
                if (this.InstanceId != null)
                    hash = hash * 59 + this.InstanceId.GetHashCode();
                if (this.Settings != null)
                    hash = hash * 59 + this.Settings.GetHashCode();
                return hash;
            }
        }
    }

}
