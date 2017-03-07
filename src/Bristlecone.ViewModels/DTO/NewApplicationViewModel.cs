using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Bristlecone.ViewModels.DTO
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class NewApplicationDTO : IEquatable<NewApplicationDTO>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NewApplication" /> class.
        /// </summary>
        /// <param name="ApplicantId">Unique identifier for the applicant user.</param>
        /// <param name="RetailerId">Unique id of the retailer at which the Applicant is applying (required).</param>
        /// <param name="CreatorId">Unique identifier for the user who created the application.</param>
        /// <param name="BankAccountId">Unique identifier for the bank account entry associated with this application.</param>
        /// <param name="MonthlyIncome">Applicant&#39;s gross income on a monthly basis (required).</param>
        /// <param name="CreatedBy">enum identifier for if the application is created by the applicant/retailer/admin.</param>
        /// <param name="ExpirationDate">Date at which the application will expire and no longer be usable.</param>
        public NewApplicationDTO(string ApplicantId = null, string RetailerId = null, string CreatorId = null, string BankAccountId = null, decimal? MonthlyIncome = null, decimal? CreatedBy = null, string ExpirationDate = null)
        {
            // to ensure "RetailerId" is required (not null)
            if (RetailerId == null)
            {
                throw new InvalidDataException("RetailerId is a required property for NewApplication and cannot be null");
            }
            else
            {
                this.RetailerId = RetailerId;
            }
            // to ensure "MonthlyIncome" is required (not null)
            if (MonthlyIncome == null)
            {
                throw new InvalidDataException("MonthlyIncome is a required property for NewApplication and cannot be null");
            }
            else
            {
                this.MonthlyIncome = MonthlyIncome;
            }
            this.ApplicantId = ApplicantId;
            this.CreatorId = CreatorId;
            this.BankAccountId = BankAccountId;
            this.CreatedBy = CreatedBy;
            this.ExpirationDate = ExpirationDate;

        }

        /// <summary>
        /// Unique identifier for the applicant user
        /// </summary>
        /// <value>Unique identifier for the applicant user</value>
        [DataMember(Name = "applicantId")]
        public string ApplicantId { get; set; }

        /// <summary>
        /// Unique id of the retailer at which the Applicant is applying
        /// </summary>
        /// <value>Unique id of the retailer at which the Applicant is applying</value>
        [DataMember(Name = "retailerId")]
        public string RetailerId { get; set; }

        /// <summary>
        /// Unique identifier for the user who created the application
        /// </summary>
        /// <value>Unique identifier for the user who created the application</value>
        [DataMember(Name = "creatorId")]
        public string CreatorId { get; set; }

        /// <summary>
        /// Unique identifier for the bank account entry associated with this application
        /// </summary>
        /// <value>Unique identifier for the bank account entry associated with this application</value>
        [DataMember(Name = "bankAccountId")]
        public string BankAccountId { get; set; }

        /// <summary>
        /// Applicant's gross income on a monthly basis
        /// </summary>
        /// <value>Applicant's gross income on a monthly basis</value>
        [DataMember(Name = "monthlyIncome")]
        public decimal? MonthlyIncome { get; set; }

        /// <summary>
        /// enum identifier for if the application is created by the applicant/retailer/admin
        /// </summary>
        /// <value>enum identifier for if the application is created by the applicant/retailer/admin</value>
        [DataMember(Name = "createdBy")]
        public decimal? CreatedBy { get; set; }

        /// <summary>
        /// Date at which the application will expire and no longer be usable
        /// </summary>
        /// <value>Date at which the application will expire and no longer be usable</value>
        [DataMember(Name = "expirationDate")]
        public string ExpirationDate { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NewApplication {\n");
            sb.Append("  ApplicantId: ").Append(ApplicantId).Append("\n");
            sb.Append("  RetailerId: ").Append(RetailerId).Append("\n");
            sb.Append("  CreatorId: ").Append(CreatorId).Append("\n");
            sb.Append("  BankAccountId: ").Append(BankAccountId).Append("\n");
            sb.Append("  MonthlyIncome: ").Append(MonthlyIncome).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
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
            return Equals((NewApplicationDTO)obj);
        }

        /// <summary>
        /// Returns true if NewApplication instances are equal
        /// </summary>
        /// <param name="other">Instance of NewApplication to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NewApplicationDTO other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    this.ApplicantId == other.ApplicantId ||
                    this.ApplicantId != null &&
                    this.ApplicantId.Equals(other.ApplicantId)
                ) &&
                (
                    this.RetailerId == other.RetailerId ||
                    this.RetailerId != null &&
                    this.RetailerId.Equals(other.RetailerId)
                ) &&
                (
                    this.CreatorId == other.CreatorId ||
                    this.CreatorId != null &&
                    this.CreatorId.Equals(other.CreatorId)
                ) &&
                (
                    this.BankAccountId == other.BankAccountId ||
                    this.BankAccountId != null &&
                    this.BankAccountId.Equals(other.BankAccountId)
                ) &&
                (
                    this.MonthlyIncome == other.MonthlyIncome ||
                    this.MonthlyIncome != null &&
                    this.MonthlyIncome.Equals(other.MonthlyIncome)
                ) &&
                (
                    this.CreatedBy == other.CreatedBy ||
                    this.CreatedBy != null &&
                    this.CreatedBy.Equals(other.CreatedBy)
                ) &&
                (
                    this.ExpirationDate == other.ExpirationDate ||
                    this.ExpirationDate != null &&
                    this.ExpirationDate.Equals(other.ExpirationDate)
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
                if (this.ApplicantId != null)
                    hash = hash * 59 + this.ApplicantId.GetHashCode();
                if (this.RetailerId != null)
                    hash = hash * 59 + this.RetailerId.GetHashCode();
                if (this.CreatorId != null)
                    hash = hash * 59 + this.CreatorId.GetHashCode();
                if (this.BankAccountId != null)
                    hash = hash * 59 + this.BankAccountId.GetHashCode();
                if (this.MonthlyIncome != null)
                    hash = hash * 59 + this.MonthlyIncome.GetHashCode();
                if (this.CreatedBy != null)
                    hash = hash * 59 + this.CreatedBy.GetHashCode();
                if (this.ExpirationDate != null)
                    hash = hash * 59 + this.ExpirationDate.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(NewApplicationDTO left, NewApplicationDTO right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(NewApplicationDTO left, NewApplicationDTO right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }

}
