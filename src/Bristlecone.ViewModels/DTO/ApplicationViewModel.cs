using System;
using System.Runtime.Serialization;

namespace Bristlecone.ViewModels.DTO
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class ApplicationDTO : IEquatable<ApplicationDTO>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Application" /> class.
        /// </summary>
        /// <param name="Id">Unique identifier for the application (required).</param>
        /// <param name="ApplicantId">Unique identifier for the applicant user (required).</param>
        /// <param name="RetailerId">Unique id of the retailer at which the Applicant is applying (required).</param>
        /// <param name="CreatorId">Unique identifier for the user who created the application.</param>
        /// <param name="RiskViewId">Unique identifier for the risk view score of the applicant for this application.</param>
        /// <param name="FlexId">Unique identifier for the flex id score of the applicant for this application.</param>
        /// <param name="FraudPointId">Unique identifier for the fraud point score of the applicant for this application.</param>
        /// <param name="CreditScoreId">Unique identifier for the credit score score of the applicant for this application.</param>
        /// <param name="Status">The current decision state of the application.</param>
        /// <param name="MonthlyIncome">Applicant&#39;s gross income on a monthly basis (required).</param>
        /// <param name="FraudStatus">enum identifier for if the application is fraudulent.</param>
        /// <param name="CreatedBy">enum identifier for if the application is created by the applicant/retailer/admin.</param>
        /// <param name="ExpirationDate">Date at which the application will expire and no longer be usable.</param>
        public Application(string Id = null, string ApplicantId = null, string RetailerId = null, string CreatorId = null, string RiskViewId = null, string FlexId = null, string FraudPointId = null, string CreditScoreId = null, string Status = null, decimal? MonthlyIncome = null, decimal? FraudStatus = null, decimal? CreatedBy = null, string ExpirationDate = null)
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for Application and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "ApplicantId" is required (not null)
            if (ApplicantId == null)
            {
                throw new InvalidDataException("ApplicantId is a required property for Application and cannot be null");
            }
            else
            {
                this.ApplicantId = ApplicantId;
            }
            // to ensure "RetailerId" is required (not null)
            if (RetailerId == null)
            {
                throw new InvalidDataException("RetailerId is a required property for Application and cannot be null");
            }
            else
            {
                this.RetailerId = RetailerId;
            }
            // to ensure "MonthlyIncome" is required (not null)
            if (MonthlyIncome == null)
            {
                throw new InvalidDataException("MonthlyIncome is a required property for Application and cannot be null");
            }
            else
            {
                this.MonthlyIncome = MonthlyIncome;
            }
            this.CreatorId = CreatorId;
            this.RiskViewId = RiskViewId;
            this.FlexId = FlexId;
            this.FraudPointId = FraudPointId;
            this.CreditScoreId = CreditScoreId;
            this.Status = Status;
            this.FraudStatus = FraudStatus;
            this.CreatedBy = CreatedBy;
            this.ExpirationDate = ExpirationDate;

        }

        /// <summary>
        /// Unique identifier for the application
        /// </summary>
        /// <value>Unique identifier for the application</value>
        [DataMember(Name = "id")]
        public string Id { get; set; }

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
        /// Unique identifier for the risk view score of the applicant for this application
        /// </summary>
        /// <value>Unique identifier for the risk view score of the applicant for this application</value>
        [DataMember(Name = "riskViewId")]
        public string RiskViewId { get; set; }

        /// <summary>
        /// Unique identifier for the flex id score of the applicant for this application
        /// </summary>
        /// <value>Unique identifier for the flex id score of the applicant for this application</value>
        [DataMember(Name = "flexId")]
        public string FlexId { get; set; }

        /// <summary>
        /// Unique identifier for the fraud point score of the applicant for this application
        /// </summary>
        /// <value>Unique identifier for the fraud point score of the applicant for this application</value>
        [DataMember(Name = "fraudPointId")]
        public string FraudPointId { get; set; }

        /// <summary>
        /// Unique identifier for the credit score score of the applicant for this application
        /// </summary>
        /// <value>Unique identifier for the credit score score of the applicant for this application</value>
        [DataMember(Name = "creditScoreId")]
        public string CreditScoreId { get; set; }

        /// <summary>
        /// The current decision state of the application
        /// </summary>
        /// <value>The current decision state of the application</value>
        [DataMember(Name = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Applicant's gross income on a monthly basis
        /// </summary>
        /// <value>Applicant's gross income on a monthly basis</value>
        [DataMember(Name = "monthlyIncome")]
        public decimal? MonthlyIncome { get; set; }

        /// <summary>
        /// enum identifier for if the application is fraudulent
        /// </summary>
        /// <value>enum identifier for if the application is fraudulent</value>
        [DataMember(Name = "fraudStatus")]
        public decimal? FraudStatus { get; set; }

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
            sb.Append("class Application {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ApplicantId: ").Append(ApplicantId).Append("\n");
            sb.Append("  RetailerId: ").Append(RetailerId).Append("\n");
            sb.Append("  CreatorId: ").Append(CreatorId).Append("\n");
            sb.Append("  RiskViewId: ").Append(RiskViewId).Append("\n");
            sb.Append("  FlexId: ").Append(FlexId).Append("\n");
            sb.Append("  FraudPointId: ").Append(FraudPointId).Append("\n");
            sb.Append("  CreditScoreId: ").Append(CreditScoreId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  MonthlyIncome: ").Append(MonthlyIncome).Append("\n");
            sb.Append("  FraudStatus: ").Append(FraudStatus).Append("\n");
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
            return Equals((Application)obj);
        }

        /// <summary>
        /// Returns true if Application instances are equal
        /// </summary>
        /// <param name="other">Instance of Application to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Application other)
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
                    this.RiskViewId == other.RiskViewId ||
                    this.RiskViewId != null &&
                    this.RiskViewId.Equals(other.RiskViewId)
                ) &&
                (
                    this.FlexId == other.FlexId ||
                    this.FlexId != null &&
                    this.FlexId.Equals(other.FlexId)
                ) &&
                (
                    this.FraudPointId == other.FraudPointId ||
                    this.FraudPointId != null &&
                    this.FraudPointId.Equals(other.FraudPointId)
                ) &&
                (
                    this.CreditScoreId == other.CreditScoreId ||
                    this.CreditScoreId != null &&
                    this.CreditScoreId.Equals(other.CreditScoreId)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) &&
                (
                    this.MonthlyIncome == other.MonthlyIncome ||
                    this.MonthlyIncome != null &&
                    this.MonthlyIncome.Equals(other.MonthlyIncome)
                ) &&
                (
                    this.FraudStatus == other.FraudStatus ||
                    this.FraudStatus != null &&
                    this.FraudStatus.Equals(other.FraudStatus)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.ApplicantId != null)
                    hash = hash * 59 + this.ApplicantId.GetHashCode();
                if (this.RetailerId != null)
                    hash = hash * 59 + this.RetailerId.GetHashCode();
                if (this.CreatorId != null)
                    hash = hash * 59 + this.CreatorId.GetHashCode();
                if (this.RiskViewId != null)
                    hash = hash * 59 + this.RiskViewId.GetHashCode();
                if (this.FlexId != null)
                    hash = hash * 59 + this.FlexId.GetHashCode();
                if (this.FraudPointId != null)
                    hash = hash * 59 + this.FraudPointId.GetHashCode();
                if (this.CreditScoreId != null)
                    hash = hash * 59 + this.CreditScoreId.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.MonthlyIncome != null)
                    hash = hash * 59 + this.MonthlyIncome.GetHashCode();
                if (this.FraudStatus != null)
                    hash = hash * 59 + this.FraudStatus.GetHashCode();
                if (this.CreatedBy != null)
                    hash = hash * 59 + this.CreatedBy.GetHashCode();
                if (this.ExpirationDate != null)
                    hash = hash * 59 + this.ExpirationDate.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(Application left, Application right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Application left, Application right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }

}