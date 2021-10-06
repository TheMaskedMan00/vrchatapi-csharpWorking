/*
 * VRChat API Documentation
 *
 *
 * The version of the OpenAPI document: 1.4.1
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
    /// Notification
    /// </summary>
    [DataContract]
    public partial class Notification :  IEquatable<Notification>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public NotificationType Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Notification" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Notification() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Notification" /> class.
        /// </summary>
        /// <param name="createdAt">createdAt (required).</param>
        /// <param name="details">**NOTICE:** This is not a JSON object, this is a json **encoded** object, meaning you have to json-de-encode to get the NotificationDetail object depending on the NotificationType. (required) (default to &quot;{}&quot;).</param>
        /// <param name="id">id (required).</param>
        /// <param name="message">message (required).</param>
        /// <param name="seen">seen (required) (default to false).</param>
        /// <param name="senderUserId">senderUserId (required).</param>
        /// <param name="senderUsername">senderUsername (required).</param>
        /// <param name="type">type (required).</param>
        public Notification(DateTime createdAt = default(DateTime), string details = "{}", string id = default(string), string message = default(string), bool seen = false, string senderUserId = default(string), string senderUsername = default(string), NotificationType type = default(NotificationType))
        {
            // to ensure "createdAt" is required (not null)
            if (createdAt == null)
            {
                throw new InvalidDataException("createdAt is a required property for Notification and cannot be null");
            }
            else
            {
                this.CreatedAt = createdAt;
            }

            // to ensure "details" is required (not null)
            if (details == null)
            {
                throw new InvalidDataException("details is a required property for Notification and cannot be null");
            }
            else
            {
                this.Details = details;
            }

            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for Notification and cannot be null");
            }
            else
            {
                this.Id = id;
            }

            // to ensure "message" is required (not null)
            if (message == null)
            {
                throw new InvalidDataException("message is a required property for Notification and cannot be null");
            }
            else
            {
                this.Message = message;
            }

            // to ensure "seen" is required (not null)
            if (seen == null)
            {
                throw new InvalidDataException("seen is a required property for Notification and cannot be null");
            }
            else
            {
                this.Seen = seen;
            }

            // to ensure "senderUserId" is required (not null)
            if (senderUserId == null)
            {
                throw new InvalidDataException("senderUserId is a required property for Notification and cannot be null");
            }
            else
            {
                this.SenderUserId = senderUserId;
            }

            // to ensure "senderUsername" is required (not null)
            if (senderUsername == null)
            {
                throw new InvalidDataException("senderUsername is a required property for Notification and cannot be null");
            }
            else
            {
                this.SenderUsername = senderUsername;
            }

            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for Notification and cannot be null");
            }
            else
            {
                this.Type = type;
            }

        }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="created_at", EmitDefaultValue=true)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// **NOTICE:** This is not a JSON object, this is a json **encoded** object, meaning you have to json-de-encode to get the NotificationDetail object depending on the NotificationType.
        /// </summary>
        /// <value>**NOTICE:** This is not a JSON object, this is a json **encoded** object, meaning you have to json-de-encode to get the NotificationDetail object depending on the NotificationType.</value>
        [DataMember(Name="details", EmitDefaultValue=true)]
        public string Details { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=true)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets Seen
        /// </summary>
        [DataMember(Name="seen", EmitDefaultValue=true)]
        public bool Seen { get; set; }

        /// <summary>
        /// Gets or Sets SenderUserId
        /// </summary>
        [DataMember(Name="senderUserId", EmitDefaultValue=true)]
        public string SenderUserId { get; set; }

        /// <summary>
        /// Gets or Sets SenderUsername
        /// </summary>
        [DataMember(Name="senderUsername", EmitDefaultValue=true)]
        public string SenderUsername { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Notification {\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Seen: ").Append(Seen).Append("\n");
            sb.Append("  SenderUserId: ").Append(SenderUserId).Append("\n");
            sb.Append("  SenderUsername: ").Append(SenderUsername).Append("\n");
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
            return this.Equals(input as Notification);
        }

        /// <summary>
        /// Returns true if Notification instances are equal
        /// </summary>
        /// <param name="input">Instance of Notification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Notification input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.Details == input.Details ||
                    (this.Details != null &&
                    this.Details.Equals(input.Details))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.Seen == input.Seen ||
                    (this.Seen != null &&
                    this.Seen.Equals(input.Seen))
                ) && 
                (
                    this.SenderUserId == input.SenderUserId ||
                    (this.SenderUserId != null &&
                    this.SenderUserId.Equals(input.SenderUserId))
                ) && 
                (
                    this.SenderUsername == input.SenderUsername ||
                    (this.SenderUsername != null &&
                    this.SenderUsername.Equals(input.SenderUsername))
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
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.Details != null)
                    hashCode = hashCode * 59 + this.Details.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.Seen != null)
                    hashCode = hashCode * 59 + this.Seen.GetHashCode();
                if (this.SenderUserId != null)
                    hashCode = hashCode * 59 + this.SenderUserId.GetHashCode();
                if (this.SenderUsername != null)
                    hashCode = hashCode * 59 + this.SenderUsername.GetHashCode();
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

            // Id (string) minLength
            if(this.Id != null && this.Id.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, length must be greater than 1.", new [] { "Id" });
            }
 

            // SenderUsername (string) minLength
            if(this.SenderUsername != null && this.SenderUsername.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SenderUsername, length must be greater than 1.", new [] { "SenderUsername" });
            }
 
            yield break;
        }
    }

}
