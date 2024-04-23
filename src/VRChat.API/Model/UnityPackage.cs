/*
 * VRChat API Documentation
 *
 *
 * The version of the OpenAPI document: 1.17.2
 * Contact: vrchatapi.lpv0t@aries.fyi
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = VRChat.API.Client.OpenAPIDateConverter;

namespace VRChat.API.Model
{
    /// <summary>
    /// UnityPackage
    /// </summary>
    [DataContract(Name = "UnityPackage")]
    public partial class UnityPackage : IEquatable<UnityPackage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnityPackage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UnityPackage() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UnityPackage" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="assetUrl">assetUrl.</param>
        /// <param name="assetUrlObject">assetUrlObject.</param>
        /// <param name="assetVersion">assetVersion (required).</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="platform">This can be &#x60;standalonewindows&#x60; or &#x60;android&#x60;, but can also pretty much be any random Unity verison such as &#x60;2019.2.4-801-Release&#x60; or &#x60;2019.2.2-772-Release&#x60; or even &#x60;unknownplatform&#x60;. (required).</param>
        /// <param name="pluginUrl">pluginUrl.</param>
        /// <param name="pluginUrlObject">pluginUrlObject.</param>
        /// <param name="unitySortNumber">unitySortNumber.</param>
        /// <param name="unityVersion">unityVersion (required) (default to &quot;5.3.4p1&quot;).</param>
        /// <param name="impostorUrl">impostorUrl.</param>
        /// <param name="scanStatus">scanStatus.</param>
        public UnityPackage(string id = default(string), string assetUrl = default(string), Object assetUrlObject = default(Object), int assetVersion = default(int), DateTime createdAt = default(DateTime), string platform = default(string), string pluginUrl = default(string), Object pluginUrlObject = default(Object), long unitySortNumber = default(long), string unityVersion = "5.3.4p1", string impostorUrl = default(string), string scanStatus = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for UnityPackage and cannot be null");
            }
            this.Id = id;
            this.AssetVersion = assetVersion;
            // to ensure "platform" is required (not null)
            if (platform == null)
            {
                throw new ArgumentNullException("platform is a required property for UnityPackage and cannot be null");
            }
            this.Platform = platform;
            // to ensure "unityVersion" is required (not null)
            if (unityVersion == null)
            {
                throw new ArgumentNullException("unityVersion is a required property for UnityPackage and cannot be null");
            }
            this.UnityVersion = unityVersion;
            this.AssetUrl = assetUrl;
            this.AssetUrlObject = assetUrlObject;
            this.CreatedAt = createdAt;
            this.PluginUrl = pluginUrl;
            this.PluginUrlObject = pluginUrlObject;
            this.UnitySortNumber = unitySortNumber;
            this.ImpostorUrl = impostorUrl;
            this.ScanStatus = scanStatus;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets AssetUrl
        /// </summary>
        [DataMember(Name = "assetUrl", EmitDefaultValue = true)]
        public string AssetUrl { get; set; }

        /// <summary>
        /// Gets or Sets AssetUrlObject
        /// </summary>
        [DataMember(Name = "assetUrlObject", EmitDefaultValue = false)]
        public Object AssetUrlObject { get; set; }

        /// <summary>
        /// Gets or Sets AssetVersion
        /// </summary>
        [DataMember(Name = "assetVersion", IsRequired = true, EmitDefaultValue = true)]
        public int AssetVersion { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// This can be &#x60;standalonewindows&#x60; or &#x60;android&#x60;, but can also pretty much be any random Unity verison such as &#x60;2019.2.4-801-Release&#x60; or &#x60;2019.2.2-772-Release&#x60; or even &#x60;unknownplatform&#x60;.
        /// </summary>
        /// <value>This can be &#x60;standalonewindows&#x60; or &#x60;android&#x60;, but can also pretty much be any random Unity verison such as &#x60;2019.2.4-801-Release&#x60; or &#x60;2019.2.2-772-Release&#x60; or even &#x60;unknownplatform&#x60;.</value>
        [DataMember(Name = "platform", IsRequired = true, EmitDefaultValue = true)]
        public string Platform { get; set; }

        /// <summary>
        /// Gets or Sets PluginUrl
        /// </summary>
        [DataMember(Name = "pluginUrl", EmitDefaultValue = false)]
        public string PluginUrl { get; set; }

        /// <summary>
        /// Gets or Sets PluginUrlObject
        /// </summary>
        [DataMember(Name = "pluginUrlObject", EmitDefaultValue = false)]
        public Object PluginUrlObject { get; set; }

        /// <summary>
        /// Gets or Sets UnitySortNumber
        /// </summary>
        [DataMember(Name = "unitySortNumber", EmitDefaultValue = false)]
        public long UnitySortNumber { get; set; }

        /// <summary>
        /// Gets or Sets UnityVersion
        /// </summary>
        [DataMember(Name = "unityVersion", IsRequired = true, EmitDefaultValue = true)]
        public string UnityVersion { get; set; }

        /// <summary>
        /// Gets or Sets ImpostorUrl
        /// </summary>
        [DataMember(Name = "impostorUrl", EmitDefaultValue = true)]
        public string ImpostorUrl { get; set; }

        /// <summary>
        /// Gets or Sets ScanStatus
        /// </summary>
        [DataMember(Name = "scanStatus", EmitDefaultValue = false)]
        public string ScanStatus { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UnityPackage {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AssetUrl: ").Append(AssetUrl).Append("\n");
            sb.Append("  AssetUrlObject: ").Append(AssetUrlObject).Append("\n");
            sb.Append("  AssetVersion: ").Append(AssetVersion).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
            sb.Append("  PluginUrl: ").Append(PluginUrl).Append("\n");
            sb.Append("  PluginUrlObject: ").Append(PluginUrlObject).Append("\n");
            sb.Append("  UnitySortNumber: ").Append(UnitySortNumber).Append("\n");
            sb.Append("  UnityVersion: ").Append(UnityVersion).Append("\n");
            sb.Append("  ImpostorUrl: ").Append(ImpostorUrl).Append("\n");
            sb.Append("  ScanStatus: ").Append(ScanStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as UnityPackage);
        }

        /// <summary>
        /// Returns true if UnityPackage instances are equal
        /// </summary>
        /// <param name="input">Instance of UnityPackage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UnityPackage input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.AssetUrl == input.AssetUrl ||
                    (this.AssetUrl != null &&
                    this.AssetUrl.Equals(input.AssetUrl))
                ) && 
                (
                    this.AssetUrlObject == input.AssetUrlObject ||
                    (this.AssetUrlObject != null &&
                    this.AssetUrlObject.Equals(input.AssetUrlObject))
                ) && 
                (
                    this.AssetVersion == input.AssetVersion ||
                    this.AssetVersion.Equals(input.AssetVersion)
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.Platform == input.Platform ||
                    (this.Platform != null &&
                    this.Platform.Equals(input.Platform))
                ) && 
                (
                    this.PluginUrl == input.PluginUrl ||
                    (this.PluginUrl != null &&
                    this.PluginUrl.Equals(input.PluginUrl))
                ) && 
                (
                    this.PluginUrlObject == input.PluginUrlObject ||
                    (this.PluginUrlObject != null &&
                    this.PluginUrlObject.Equals(input.PluginUrlObject))
                ) && 
                (
                    this.UnitySortNumber == input.UnitySortNumber ||
                    this.UnitySortNumber.Equals(input.UnitySortNumber)
                ) && 
                (
                    this.UnityVersion == input.UnityVersion ||
                    (this.UnityVersion != null &&
                    this.UnityVersion.Equals(input.UnityVersion))
                ) && 
                (
                    this.ImpostorUrl == input.ImpostorUrl ||
                    (this.ImpostorUrl != null &&
                    this.ImpostorUrl.Equals(input.ImpostorUrl))
                ) && 
                (
                    this.ScanStatus == input.ScanStatus ||
                    (this.ScanStatus != null &&
                    this.ScanStatus.Equals(input.ScanStatus))
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
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.AssetUrl != null)
                {
                    hashCode = (hashCode * 59) + this.AssetUrl.GetHashCode();
                }
                if (this.AssetUrlObject != null)
                {
                    hashCode = (hashCode * 59) + this.AssetUrlObject.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AssetVersion.GetHashCode();
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.Platform != null)
                {
                    hashCode = (hashCode * 59) + this.Platform.GetHashCode();
                }
                if (this.PluginUrl != null)
                {
                    hashCode = (hashCode * 59) + this.PluginUrl.GetHashCode();
                }
                if (this.PluginUrlObject != null)
                {
                    hashCode = (hashCode * 59) + this.PluginUrlObject.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.UnitySortNumber.GetHashCode();
                if (this.UnityVersion != null)
                {
                    hashCode = (hashCode * 59) + this.UnityVersion.GetHashCode();
                }
                if (this.ImpostorUrl != null)
                {
                    hashCode = (hashCode * 59) + this.ImpostorUrl.GetHashCode();
                }
                if (this.ScanStatus != null)
                {
                    hashCode = (hashCode * 59) + this.ScanStatus.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            // AssetUrl (string) minLength
            if (this.AssetUrl != null && this.AssetUrl.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AssetUrl, length must be greater than 1.", new [] { "AssetUrl" });
            }

            // AssetVersion (int) minimum
            if (this.AssetVersion < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AssetVersion, must be a value greater than or equal to 0.", new [] { "AssetVersion" });
            }

            // UnitySortNumber (long) minimum
            if (this.UnitySortNumber < (long)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for UnitySortNumber, must be a value greater than or equal to 0.", new [] { "UnitySortNumber" });
            }

            // UnityVersion (string) minLength
            if (this.UnityVersion != null && this.UnityVersion.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for UnityVersion, length must be greater than 1.", new [] { "UnityVersion" });
            }

            yield break;
        }
    }

}
