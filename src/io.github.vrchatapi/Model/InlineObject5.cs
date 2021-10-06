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
    /// InlineObject5
    /// </summary>
    [DataContract]
    public partial class InlineObject5 :  IEquatable<InlineObject5>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineObject5" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InlineObject5() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineObject5" /> class.
        /// </summary>
        /// <param name="etags">Array of ETags uploaded..</param>
        /// <param name="nextPartNumber">Always a zero in string form, despite how many parts uploaded. (required) (default to &quot;0&quot;).</param>
        /// <param name="maxParts">Always a zero in string form, despite how many parts uploaded. (required) (default to &quot;0&quot;).</param>
        public InlineObject5(List<string> etags = default(List<string>), string nextPartNumber = "0", string maxParts = "0")
        {
            // to ensure "nextPartNumber" is required (not null)
            if (nextPartNumber == null)
            {
                throw new InvalidDataException("nextPartNumber is a required property for InlineObject5 and cannot be null");
            }
            else
            {
                this.NextPartNumber = nextPartNumber;
            }

            // to ensure "maxParts" is required (not null)
            if (maxParts == null)
            {
                throw new InvalidDataException("maxParts is a required property for InlineObject5 and cannot be null");
            }
            else
            {
                this.MaxParts = maxParts;
            }

            this.Etags = etags;
        }

        /// <summary>
        /// Array of ETags uploaded.
        /// </summary>
        /// <value>Array of ETags uploaded.</value>
        [DataMember(Name="etags", EmitDefaultValue=false)]
        public List<string> Etags { get; set; }

        /// <summary>
        /// Always a zero in string form, despite how many parts uploaded.
        /// </summary>
        /// <value>Always a zero in string form, despite how many parts uploaded.</value>
        [DataMember(Name="nextPartNumber", EmitDefaultValue=true)]
        public string NextPartNumber { get; set; }

        /// <summary>
        /// Always a zero in string form, despite how many parts uploaded.
        /// </summary>
        /// <value>Always a zero in string form, despite how many parts uploaded.</value>
        [DataMember(Name="maxParts", EmitDefaultValue=true)]
        public string MaxParts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineObject5 {\n");
            sb.Append("  Etags: ").Append(Etags).Append("\n");
            sb.Append("  NextPartNumber: ").Append(NextPartNumber).Append("\n");
            sb.Append("  MaxParts: ").Append(MaxParts).Append("\n");
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
            return this.Equals(input as InlineObject5);
        }

        /// <summary>
        /// Returns true if InlineObject5 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineObject5 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineObject5 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Etags == input.Etags ||
                    this.Etags != null &&
                    input.Etags != null &&
                    this.Etags.SequenceEqual(input.Etags)
                ) && 
                (
                    this.NextPartNumber == input.NextPartNumber ||
                    (this.NextPartNumber != null &&
                    this.NextPartNumber.Equals(input.NextPartNumber))
                ) && 
                (
                    this.MaxParts == input.MaxParts ||
                    (this.MaxParts != null &&
                    this.MaxParts.Equals(input.MaxParts))
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
                if (this.Etags != null)
                    hashCode = hashCode * 59 + this.Etags.GetHashCode();
                if (this.NextPartNumber != null)
                    hashCode = hashCode * 59 + this.NextPartNumber.GetHashCode();
                if (this.MaxParts != null)
                    hashCode = hashCode * 59 + this.MaxParts.GetHashCode();
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

 
            // NextPartNumber (string) maxLength
            if(this.NextPartNumber != null && this.NextPartNumber.Length > 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for NextPartNumber, length must be less than 1.", new [] { "NextPartNumber" });
            }

            // NextPartNumber (string) minLength
            if(this.NextPartNumber != null && this.NextPartNumber.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for NextPartNumber, length must be greater than 1.", new [] { "NextPartNumber" });
            }
 
            // NextPartNumber (string) pattern
            Regex regexNextPartNumber = new Regex(@"0", RegexOptions.CultureInvariant);
            if (false == regexNextPartNumber.Match(this.NextPartNumber).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for NextPartNumber, must match a pattern of " + regexNextPartNumber, new [] { "NextPartNumber" });
            }

            // MaxParts (string) maxLength
            if(this.MaxParts != null && this.MaxParts.Length > 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MaxParts, length must be less than 1.", new [] { "MaxParts" });
            }

            // MaxParts (string) minLength
            if(this.MaxParts != null && this.MaxParts.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MaxParts, length must be greater than 1.", new [] { "MaxParts" });
            }
 
            // MaxParts (string) pattern
            Regex regexMaxParts = new Regex(@"0", RegexOptions.CultureInvariant);
            if (false == regexMaxParts.Match(this.MaxParts).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MaxParts, must match a pattern of " + regexMaxParts, new [] { "MaxParts" });
            }

            yield break;
        }
    }

}
