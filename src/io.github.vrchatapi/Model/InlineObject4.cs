/*
 * VRChat API Documentation
 *
 *
 * The version of the OpenAPI document: 1.4.2
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
    /// InlineObject4
    /// </summary>
    [DataContract]
    public partial class InlineObject4 :  IEquatable<InlineObject4>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineObject4" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InlineObject4() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineObject4" /> class.
        /// </summary>
        /// <param name="signatureMd5">signatureMd5 (required).</param>
        /// <param name="signatureSizeInBytes">signatureSizeInBytes (required).</param>
        /// <param name="fileMd5">fileMd5.</param>
        /// <param name="fileSizeInBytes">fileSizeInBytes.</param>
        public InlineObject4(string signatureMd5 = default(string), decimal signatureSizeInBytes = default(decimal), string fileMd5 = default(string), decimal fileSizeInBytes = default(decimal))
        {
            // to ensure "signatureMd5" is required (not null)
            if (signatureMd5 == null)
            {
                throw new InvalidDataException("signatureMd5 is a required property for InlineObject4 and cannot be null");
            }
            else
            {
                this.SignatureMd5 = signatureMd5;
            }

            // to ensure "signatureSizeInBytes" is required (not null)
            if (signatureSizeInBytes == null)
            {
                throw new InvalidDataException("signatureSizeInBytes is a required property for InlineObject4 and cannot be null");
            }
            else
            {
                this.SignatureSizeInBytes = signatureSizeInBytes;
            }

            this.FileMd5 = fileMd5;
            this.FileSizeInBytes = fileSizeInBytes;
        }

        /// <summary>
        /// Gets or Sets SignatureMd5
        /// </summary>
        [DataMember(Name="signatureMd5", EmitDefaultValue=true)]
        public string SignatureMd5 { get; set; }

        /// <summary>
        /// Gets or Sets SignatureSizeInBytes
        /// </summary>
        [DataMember(Name="signatureSizeInBytes", EmitDefaultValue=true)]
        public decimal SignatureSizeInBytes { get; set; }

        /// <summary>
        /// Gets or Sets FileMd5
        /// </summary>
        [DataMember(Name="fileMd5", EmitDefaultValue=false)]
        public string FileMd5 { get; set; }

        /// <summary>
        /// Gets or Sets FileSizeInBytes
        /// </summary>
        [DataMember(Name="fileSizeInBytes", EmitDefaultValue=false)]
        public decimal FileSizeInBytes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineObject4 {\n");
            sb.Append("  SignatureMd5: ").Append(SignatureMd5).Append("\n");
            sb.Append("  SignatureSizeInBytes: ").Append(SignatureSizeInBytes).Append("\n");
            sb.Append("  FileMd5: ").Append(FileMd5).Append("\n");
            sb.Append("  FileSizeInBytes: ").Append(FileSizeInBytes).Append("\n");
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
            return this.Equals(input as InlineObject4);
        }

        /// <summary>
        /// Returns true if InlineObject4 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineObject4 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineObject4 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SignatureMd5 == input.SignatureMd5 ||
                    (this.SignatureMd5 != null &&
                    this.SignatureMd5.Equals(input.SignatureMd5))
                ) && 
                (
                    this.SignatureSizeInBytes == input.SignatureSizeInBytes ||
                    (this.SignatureSizeInBytes != null &&
                    this.SignatureSizeInBytes.Equals(input.SignatureSizeInBytes))
                ) && 
                (
                    this.FileMd5 == input.FileMd5 ||
                    (this.FileMd5 != null &&
                    this.FileMd5.Equals(input.FileMd5))
                ) && 
                (
                    this.FileSizeInBytes == input.FileSizeInBytes ||
                    (this.FileSizeInBytes != null &&
                    this.FileSizeInBytes.Equals(input.FileSizeInBytes))
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
                if (this.SignatureMd5 != null)
                    hashCode = hashCode * 59 + this.SignatureMd5.GetHashCode();
                if (this.SignatureSizeInBytes != null)
                    hashCode = hashCode * 59 + this.SignatureSizeInBytes.GetHashCode();
                if (this.FileMd5 != null)
                    hashCode = hashCode * 59 + this.FileMd5.GetHashCode();
                if (this.FileSizeInBytes != null)
                    hashCode = hashCode * 59 + this.FileSizeInBytes.GetHashCode();
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

            // SignatureMd5 (string) minLength
            if(this.SignatureMd5 != null && this.SignatureMd5.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SignatureMd5, length must be greater than 1.", new [] { "SignatureMd5" });
            }
 

            // FileMd5 (string) minLength
            if(this.FileMd5 != null && this.FileMd5.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FileMd5, length must be greater than 1.", new [] { "FileMd5" });
            }
 
            yield break;
        }
    }

}
