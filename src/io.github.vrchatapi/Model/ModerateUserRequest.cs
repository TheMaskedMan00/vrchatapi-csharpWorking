/*
 * VRChat API Documentation
 *
 *
 * The version of the OpenAPI document: 1.5.3
 * Contact: me@ruby.js.org
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = io.github.vrchatapi.Client.OpenAPIDateConverter;

namespace io.github.vrchatapi.Model
{
    /// <summary>
    /// ModerateUserRequest
    /// </summary>
    [DataContract]
    public partial class ModerateUserRequest :  IEquatable<ModerateUserRequest>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public PlayerModerationType Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ModerateUserRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ModerateUserRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ModerateUserRequest" /> class.
        /// </summary>
        /// <param name="moderated">moderated (required).</param>
        /// <param name="type">type (required).</param>
        public ModerateUserRequest(string moderated = default(string), PlayerModerationType type = default(PlayerModerationType))
        {
            // to ensure "moderated" is required (not null)
            if (moderated == null)
            {
                throw new InvalidDataException("moderated is a required property for ModerateUserRequest and cannot be null");
            }
            else
            {
                this.Moderated = moderated;
            }

            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for ModerateUserRequest and cannot be null");
            }
            else
            {
                this.Type = type;
            }

        }

        /// <summary>
        /// Gets or Sets Moderated
        /// </summary>
        [DataMember(Name="moderated", EmitDefaultValue=true)]
        public string Moderated { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModerateUserRequest {\n");
            sb.Append("  Moderated: ").Append(Moderated).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as ModerateUserRequest);
        }

        /// <summary>
        /// Returns true if ModerateUserRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ModerateUserRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModerateUserRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Moderated == input.Moderated ||
                    (this.Moderated != null &&
                    this.Moderated.Equals(input.Moderated))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Moderated != null)
                    hashCode = hashCode * 59 + this.Moderated.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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
