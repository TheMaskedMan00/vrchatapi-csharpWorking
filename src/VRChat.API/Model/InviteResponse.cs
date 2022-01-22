/*
 * VRChat API Documentation
 *
 *
 * The version of the OpenAPI document: 1.6.8
 * Contact: me@ruby.js.org
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
    /// InviteResponse
    /// </summary>
    [DataContract(Name = "InviteResponse")]
    public partial class InviteResponse : IEquatable<InviteResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InviteResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InviteResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InviteResponse" /> class.
        /// </summary>
        /// <param name="responseSlot">responseSlot (required).</param>
        public InviteResponse(int responseSlot = default(int))
        {
            this.ResponseSlot = responseSlot;
        }

        /// <summary>
        /// Gets or Sets ResponseSlot
        /// </summary>
        [DataMember(Name = "responseSlot", IsRequired = true, EmitDefaultValue = false)]
        public int ResponseSlot { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InviteResponse {\n");
            sb.Append("  ResponseSlot: ").Append(ResponseSlot).Append("\n");
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
            return this.Equals(input as InviteResponse);
        }

        /// <summary>
        /// Returns true if InviteResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of InviteResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InviteResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ResponseSlot == input.ResponseSlot ||
                    this.ResponseSlot.Equals(input.ResponseSlot)
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
                hashCode = hashCode * 59 + this.ResponseSlot.GetHashCode();
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
            // ResponseSlot (int) maximum
            if(this.ResponseSlot > (int)11)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ResponseSlot, must be a value less than or equal to 11.", new [] { "ResponseSlot" });
            }

            // ResponseSlot (int) minimum
            if(this.ResponseSlot < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ResponseSlot, must be a value greater than or equal to 0.", new [] { "ResponseSlot" });
            }

            yield break;
        }
    }

}
