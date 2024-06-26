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
    /// NotificationDetails
    /// </summary>
    [DataContract(Name = "NotificationDetails")]
    public partial class NotificationDetails : IEquatable<NotificationDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationDetails" /> class.
        /// </summary>
        /// <param name="inviteMessage">inviteMessage.</param>
        /// <param name="worldId">WorldID be \&quot;offline\&quot; on User profiles if you are not friends with that user..</param>
        /// <param name="worldName">worldName.</param>
        /// <param name="initiatorUserId">A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed..</param>
        /// <param name="userToKickId">A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed..</param>
        /// <param name="inResponseTo">inResponseTo.</param>
        /// <param name="requestMessage">Used when using InviteMessage Slot..</param>
        /// <param name="platform">TODO: Does this still exist?.</param>
        /// <param name="responseMessage">responseMessage.</param>
        public NotificationDetails(string inviteMessage = default(string), string worldId = default(string), string worldName = default(string), string initiatorUserId = default(string), string userToKickId = default(string), string inResponseTo = default(string), string requestMessage = default(string), string platform = default(string), string responseMessage = default(string))
        {
            this.InviteMessage = inviteMessage;
            this.WorldId = worldId;
            this.WorldName = worldName;
            this.InitiatorUserId = initiatorUserId;
            this.UserToKickId = userToKickId;
            this.InResponseTo = inResponseTo;
            this.RequestMessage = requestMessage;
            this.Platform = platform;
            this.ResponseMessage = responseMessage;
        }

        /// <summary>
        /// Gets or Sets InviteMessage
        /// </summary>
        [DataMember(Name = "inviteMessage", EmitDefaultValue = false)]
        public string InviteMessage { get; set; }

        /// <summary>
        /// WorldID be \&quot;offline\&quot; on User profiles if you are not friends with that user.
        /// </summary>
        /// <value>WorldID be \&quot;offline\&quot; on User profiles if you are not friends with that user.</value>
        [DataMember(Name = "worldId", EmitDefaultValue = false)]
        public string WorldId { get; set; }

        /// <summary>
        /// Gets or Sets WorldName
        /// </summary>
        [DataMember(Name = "worldName", EmitDefaultValue = false)]
        public string WorldName { get; set; }

        /// <summary>
        /// A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.
        /// </summary>
        /// <value>A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.</value>
        [DataMember(Name = "initiatorUserId", EmitDefaultValue = false)]
        public string InitiatorUserId { get; set; }

        /// <summary>
        /// A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.
        /// </summary>
        /// <value>A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.</value>
        [DataMember(Name = "userToKickId", EmitDefaultValue = false)]
        public string UserToKickId { get; set; }

        /// <summary>
        /// Gets or Sets InResponseTo
        /// </summary>
        [DataMember(Name = "inResponseTo", EmitDefaultValue = false)]
        public string InResponseTo { get; set; }

        /// <summary>
        /// Used when using InviteMessage Slot.
        /// </summary>
        /// <value>Used when using InviteMessage Slot.</value>
        [DataMember(Name = "requestMessage", EmitDefaultValue = false)]
        public string RequestMessage { get; set; }

        /// <summary>
        /// TODO: Does this still exist?
        /// </summary>
        /// <value>TODO: Does this still exist?</value>
        [DataMember(Name = "platform", EmitDefaultValue = false)]
        public string Platform { get; set; }

        /// <summary>
        /// Gets or Sets ResponseMessage
        /// </summary>
        [DataMember(Name = "responseMessage", EmitDefaultValue = false)]
        public string ResponseMessage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NotificationDetails {\n");
            sb.Append("  InviteMessage: ").Append(InviteMessage).Append("\n");
            sb.Append("  WorldId: ").Append(WorldId).Append("\n");
            sb.Append("  WorldName: ").Append(WorldName).Append("\n");
            sb.Append("  InitiatorUserId: ").Append(InitiatorUserId).Append("\n");
            sb.Append("  UserToKickId: ").Append(UserToKickId).Append("\n");
            sb.Append("  InResponseTo: ").Append(InResponseTo).Append("\n");
            sb.Append("  RequestMessage: ").Append(RequestMessage).Append("\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
            sb.Append("  ResponseMessage: ").Append(ResponseMessage).Append("\n");
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
            return this.Equals(input as NotificationDetails);
        }

        /// <summary>
        /// Returns true if NotificationDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of NotificationDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NotificationDetails input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.InviteMessage == input.InviteMessage ||
                    (this.InviteMessage != null &&
                    this.InviteMessage.Equals(input.InviteMessage))
                ) && 
                (
                    this.WorldId == input.WorldId ||
                    (this.WorldId != null &&
                    this.WorldId.Equals(input.WorldId))
                ) && 
                (
                    this.WorldName == input.WorldName ||
                    (this.WorldName != null &&
                    this.WorldName.Equals(input.WorldName))
                ) && 
                (
                    this.InitiatorUserId == input.InitiatorUserId ||
                    (this.InitiatorUserId != null &&
                    this.InitiatorUserId.Equals(input.InitiatorUserId))
                ) && 
                (
                    this.UserToKickId == input.UserToKickId ||
                    (this.UserToKickId != null &&
                    this.UserToKickId.Equals(input.UserToKickId))
                ) && 
                (
                    this.InResponseTo == input.InResponseTo ||
                    (this.InResponseTo != null &&
                    this.InResponseTo.Equals(input.InResponseTo))
                ) && 
                (
                    this.RequestMessage == input.RequestMessage ||
                    (this.RequestMessage != null &&
                    this.RequestMessage.Equals(input.RequestMessage))
                ) && 
                (
                    this.Platform == input.Platform ||
                    (this.Platform != null &&
                    this.Platform.Equals(input.Platform))
                ) && 
                (
                    this.ResponseMessage == input.ResponseMessage ||
                    (this.ResponseMessage != null &&
                    this.ResponseMessage.Equals(input.ResponseMessage))
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
                if (this.InviteMessage != null)
                {
                    hashCode = (hashCode * 59) + this.InviteMessage.GetHashCode();
                }
                if (this.WorldId != null)
                {
                    hashCode = (hashCode * 59) + this.WorldId.GetHashCode();
                }
                if (this.WorldName != null)
                {
                    hashCode = (hashCode * 59) + this.WorldName.GetHashCode();
                }
                if (this.InitiatorUserId != null)
                {
                    hashCode = (hashCode * 59) + this.InitiatorUserId.GetHashCode();
                }
                if (this.UserToKickId != null)
                {
                    hashCode = (hashCode * 59) + this.UserToKickId.GetHashCode();
                }
                if (this.InResponseTo != null)
                {
                    hashCode = (hashCode * 59) + this.InResponseTo.GetHashCode();
                }
                if (this.RequestMessage != null)
                {
                    hashCode = (hashCode * 59) + this.RequestMessage.GetHashCode();
                }
                if (this.Platform != null)
                {
                    hashCode = (hashCode * 59) + this.Platform.GetHashCode();
                }
                if (this.ResponseMessage != null)
                {
                    hashCode = (hashCode * 59) + this.ResponseMessage.GetHashCode();
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
            yield break;
        }
    }

}
