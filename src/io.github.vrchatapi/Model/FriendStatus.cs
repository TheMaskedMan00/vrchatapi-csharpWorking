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
    /// FriendStatus
    /// </summary>
    [DataContract]
    public partial class FriendStatus :  IEquatable<FriendStatus>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FriendStatus" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FriendStatus() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FriendStatus" /> class.
        /// </summary>
        /// <param name="incomingRequest">incomingRequest (required) (default to false).</param>
        /// <param name="isFriend">isFriend (required) (default to false).</param>
        /// <param name="outgoingRequest">outgoingRequest (required) (default to false).</param>
        public FriendStatus(bool incomingRequest = false, bool isFriend = false, bool outgoingRequest = false)
        {
            // to ensure "incomingRequest" is required (not null)
            if (incomingRequest == null)
            {
                throw new InvalidDataException("incomingRequest is a required property for FriendStatus and cannot be null");
            }
            else
            {
                this.IncomingRequest = incomingRequest;
            }

            // to ensure "isFriend" is required (not null)
            if (isFriend == null)
            {
                throw new InvalidDataException("isFriend is a required property for FriendStatus and cannot be null");
            }
            else
            {
                this.IsFriend = isFriend;
            }

            // to ensure "outgoingRequest" is required (not null)
            if (outgoingRequest == null)
            {
                throw new InvalidDataException("outgoingRequest is a required property for FriendStatus and cannot be null");
            }
            else
            {
                this.OutgoingRequest = outgoingRequest;
            }

        }

        /// <summary>
        /// Gets or Sets IncomingRequest
        /// </summary>
        [DataMember(Name="incomingRequest", EmitDefaultValue=true)]
        public bool IncomingRequest { get; set; }

        /// <summary>
        /// Gets or Sets IsFriend
        /// </summary>
        [DataMember(Name="isFriend", EmitDefaultValue=true)]
        public bool IsFriend { get; set; }

        /// <summary>
        /// Gets or Sets OutgoingRequest
        /// </summary>
        [DataMember(Name="outgoingRequest", EmitDefaultValue=true)]
        public bool OutgoingRequest { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FriendStatus {\n");
            sb.Append("  IncomingRequest: ").Append(IncomingRequest).Append("\n");
            sb.Append("  IsFriend: ").Append(IsFriend).Append("\n");
            sb.Append("  OutgoingRequest: ").Append(OutgoingRequest).Append("\n");
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
            return this.Equals(input as FriendStatus);
        }

        /// <summary>
        /// Returns true if FriendStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of FriendStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FriendStatus input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IncomingRequest == input.IncomingRequest ||
                    (this.IncomingRequest != null &&
                    this.IncomingRequest.Equals(input.IncomingRequest))
                ) && 
                (
                    this.IsFriend == input.IsFriend ||
                    (this.IsFriend != null &&
                    this.IsFriend.Equals(input.IsFriend))
                ) && 
                (
                    this.OutgoingRequest == input.OutgoingRequest ||
                    (this.OutgoingRequest != null &&
                    this.OutgoingRequest.Equals(input.OutgoingRequest))
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
                if (this.IncomingRequest != null)
                    hashCode = hashCode * 59 + this.IncomingRequest.GetHashCode();
                if (this.IsFriend != null)
                    hashCode = hashCode * 59 + this.IsFriend.GetHashCode();
                if (this.OutgoingRequest != null)
                    hashCode = hashCode * 59 + this.OutgoingRequest.GetHashCode();
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
