/*
 * VRChat API Documentation
 *
 *
 * The version of the OpenAPI document: 1.7.6
 * Contact: me@ariesclark.com
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
    /// API/Photon region.
    /// </summary>
    /// <value>API/Photon region.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Region
    {
        /// <summary>
        /// Enum Us for value: us
        /// </summary>
        [EnumMember(Value = "us")]
        Us = 1,

        /// <summary>
        /// Enum Use for value: use
        /// </summary>
        [EnumMember(Value = "use")]
        Use = 2,

        /// <summary>
        /// Enum Usw for value: usw
        /// </summary>
        [EnumMember(Value = "usw")]
        Usw = 3,

        /// <summary>
        /// Enum Eu for value: eu
        /// </summary>
        [EnumMember(Value = "eu")]
        Eu = 4,

        /// <summary>
        /// Enum Jp for value: jp
        /// </summary>
        [EnumMember(Value = "jp")]
        Jp = 5,

        /// <summary>
        /// Enum Unknown for value: unknown
        /// </summary>
        [EnumMember(Value = "unknown")]
        Unknown = 6

    }

}
