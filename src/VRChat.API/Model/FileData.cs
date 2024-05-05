/*
 * VRChat API Documentation
 *
 *
 * The version of the OpenAPI document: 1.17.3
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
    /// FileData
    /// </summary>
    [DataContract(Name = "FileData")]
    public partial class FileData : IEquatable<FileData>, IValidatableObject
    {
        /// <summary>
        /// Defines Category
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CategoryEnum
        {
            /// <summary>
            /// Enum Multipart for value: multipart
            /// </summary>
            [EnumMember(Value = "multipart")]
            Multipart = 1,

            /// <summary>
            /// Enum Queued for value: queued
            /// </summary>
            [EnumMember(Value = "queued")]
            Queued = 2,

            /// <summary>
            /// Enum Simple for value: simple
            /// </summary>
            [EnumMember(Value = "simple")]
            Simple = 3

        }


        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name = "category", EmitDefaultValue = false)]
        public CategoryEnum? Category { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public FileStatus? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FileData" /> class.
        /// </summary>
        /// <param name="category">category (default to CategoryEnum.Queued).</param>
        /// <param name="fileName">fileName.</param>
        /// <param name="md5">md5.</param>
        /// <param name="sizeInBytes">sizeInBytes.</param>
        /// <param name="status">status.</param>
        /// <param name="uploadId">uploadId (default to &quot;&quot;).</param>
        /// <param name="url">url.</param>
        public FileData(CategoryEnum? category = CategoryEnum.Queued, string fileName = default(string), string md5 = default(string), int sizeInBytes = default(int), FileStatus? status = default(FileStatus?), string uploadId = "", string url = default(string))
        {
            this.Category = category;
            this.FileName = fileName;
            this.Md5 = md5;
            this.SizeInBytes = sizeInBytes;
            this.Status = status;
            // use default value if no "uploadId" provided
            this.UploadId = uploadId ?? "";
            this.Url = url;
        }

        /// <summary>
        /// Gets or Sets FileName
        /// </summary>
        [DataMember(Name = "fileName", EmitDefaultValue = false)]
        public string FileName { get; set; }

        /// <summary>
        /// Gets or Sets Md5
        /// </summary>
        [DataMember(Name = "md5", EmitDefaultValue = false)]
        public string Md5 { get; set; }

        /// <summary>
        /// Gets or Sets SizeInBytes
        /// </summary>
        [DataMember(Name = "sizeInBytes", EmitDefaultValue = false)]
        public int SizeInBytes { get; set; }

        /// <summary>
        /// Gets or Sets UploadId
        /// </summary>
        [DataMember(Name = "uploadId", EmitDefaultValue = false)]
        public string UploadId { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name = "url", EmitDefaultValue = false)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FileData {\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  FileName: ").Append(FileName).Append("\n");
            sb.Append("  Md5: ").Append(Md5).Append("\n");
            sb.Append("  SizeInBytes: ").Append(SizeInBytes).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  UploadId: ").Append(UploadId).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
            return this.Equals(input as FileData);
        }

        /// <summary>
        /// Returns true if FileData instances are equal
        /// </summary>
        /// <param name="input">Instance of FileData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FileData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Category == input.Category ||
                    this.Category.Equals(input.Category)
                ) && 
                (
                    this.FileName == input.FileName ||
                    (this.FileName != null &&
                    this.FileName.Equals(input.FileName))
                ) && 
                (
                    this.Md5 == input.Md5 ||
                    (this.Md5 != null &&
                    this.Md5.Equals(input.Md5))
                ) && 
                (
                    this.SizeInBytes == input.SizeInBytes ||
                    this.SizeInBytes.Equals(input.SizeInBytes)
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.UploadId == input.UploadId ||
                    (this.UploadId != null &&
                    this.UploadId.Equals(input.UploadId))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
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
                hashCode = (hashCode * 59) + this.Category.GetHashCode();
                if (this.FileName != null)
                {
                    hashCode = (hashCode * 59) + this.FileName.GetHashCode();
                }
                if (this.Md5 != null)
                {
                    hashCode = (hashCode * 59) + this.Md5.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SizeInBytes.GetHashCode();
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.UploadId != null)
                {
                    hashCode = (hashCode * 59) + this.UploadId.GetHashCode();
                }
                if (this.Url != null)
                {
                    hashCode = (hashCode * 59) + this.Url.GetHashCode();
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
            // FileName (string) minLength
            if (this.FileName != null && this.FileName.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FileName, length must be greater than 1.", new [] { "FileName" });
            }

            // Md5 (string) minLength
            if (this.Md5 != null && this.Md5.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Md5, length must be greater than 0.", new [] { "Md5" });
            }

            // SizeInBytes (int) minimum
            if (this.SizeInBytes < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SizeInBytes, must be a value greater than or equal to 0.", new [] { "SizeInBytes" });
            }

            // UploadId (string) minLength
            if (this.UploadId != null && this.UploadId.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for UploadId, length must be greater than 0.", new [] { "UploadId" });
            }

            // Url (string) minLength
            if (this.Url != null && this.Url.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Url, length must be greater than 1.", new [] { "Url" });
            }

            yield break;
        }
    }

}
