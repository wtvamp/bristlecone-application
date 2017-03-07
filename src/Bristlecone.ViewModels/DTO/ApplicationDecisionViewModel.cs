using Newtonsoft.Json;
using System;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace Bristlecone.ViewModels.DTO
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class ApplicationDecisionDTO : IEquatable<ApplicationDecisionDTO>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationDecision" /> class.
        /// </summary>
        /// <param name="Id">Unique identifier representing the application (required).</param>
        /// <param name="Status">The current status of the application..</param>
        /// <param name="Reason">Extended information about the status.</param>
        public ApplicationDecisionDTO(string Id = null, string Status = null, string Reason = null)
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for ApplicationDecision and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            this.Status = Status;
            this.Reason = Reason;

        }

        /// <summary>
        /// Unique identifier representing the application
        /// </summary>
        /// <value>Unique identifier representing the application</value>
        [DataMember(Name = "id")]
        public string Id { get; set; }

        /// <summary>
        /// The current status of the application.
        /// </summary>
        /// <value>The current status of the application.</value>
        [DataMember(Name = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Extended information about the status
        /// </summary>
        /// <value>Extended information about the status</value>
        [DataMember(Name = "reason")]
        public string Reason { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplicationDecision {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((ApplicationDecisionDTO)obj);
        }

        /// <summary>
        /// Returns true if ApplicationDecision instances are equal
        /// </summary>
        /// <param name="other">Instance of ApplicationDecision to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplicationDecisionDTO other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.Reason == other.Reason ||
                    this.Reason != null &&
                    this.Reason.Equals(other.Reason)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.Reason != null)
                    hash = hash * 59 + this.Reason.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(ApplicationDecisionDTO left, ApplicationDecisionDTO right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ApplicationDecisionDTO left, ApplicationDecisionDTO right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
