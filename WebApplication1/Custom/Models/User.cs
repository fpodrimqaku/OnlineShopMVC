namespace WebApplication1.Custom.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            ActivityLogs = new HashSet<ActivityLog>();
            BudgetDetails = new HashSet<BudgetDetail>();
            BudgetRequests = new HashSet<BudgetRequest>();
            ChangeLogs = new HashSet<ChangeLog>();
            FunctionalCodes = new HashSet<FunctionalCode>();
            Fundings = new HashSet<Funding>();
            FundSources = new HashSet<FundSource>();
            IndividualAccesses = new HashSet<IndividualAccess>();
            Notifications = new HashSet<Notification>();
            OrganisationSectors = new HashSet<OrganisationSector>();
            OrganisationUsers = new HashSet<OrganisationUser>();
            RequestBudgetTransfers = new HashSet<RequestBudgetTransfer>();
            RequestBudgetTransfers1 = new HashSet<RequestBudgetTransfer>();
            RequestBudgetTransfers2 = new HashSet<RequestBudgetTransfer>();
            StaffDetails = new HashSet<StaffDetail>();
            SystemStatus = new HashSet<SystemStatu>();
            User1 = new HashSet<User>();
            UserHistories = new HashSet<UserHistory>();
        }

        public int Id { get; set; }

        public int IdRole { get; set; }

        public int IdEntryUser { get; set; }

        public int IdCenter { get; set; }

        [StringLength(50)]
        public string First { get; set; }

        [StringLength(50)]
        public string Last { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(100)]
        public string Image { get; set; }

        [Required]
        [StringLength(100)]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        [StringLength(500)]
        public string Salt { get; set; }

        public DateTime InsertionDate { get; set; }

        public DateTime? ExpirityDate { get; set; }

        public bool HasIndividualPremission { get; set; }

        public bool IsActive { get; set; }

        public bool IsDeleted { get; set; }

        public bool FirstLogin { get; set; }

        public bool? HasResetPasswordRequest { get; set; }

        public bool WithExpiryDate { get; set; }

        public DateTime? LastLoginDate { get; set; }

        public DateTime? LastLogOutDate { get; set; }

        public DateTime? LastActivityDate { get; set; }

        [StringLength(500)]
        public string Guid { get; set; }

        public bool WithSchedule { get; set; }

        public DateTime? WorkTimeFrom { get; set; }

        public DateTime? WorkTimeTo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActivityLog> ActivityLogs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BudgetDetail> BudgetDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BudgetRequest> BudgetRequests { get; set; }

        public virtual Center Center { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChangeLog> ChangeLogs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FunctionalCode> FunctionalCodes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Funding> Fundings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FundSource> FundSources { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IndividualAccess> IndividualAccesses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Notification> Notifications { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganisationSector> OrganisationSectors { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganisationUser> OrganisationUsers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RequestBudgetTransfer> RequestBudgetTransfers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RequestBudgetTransfer> RequestBudgetTransfers1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RequestBudgetTransfer> RequestBudgetTransfers2 { get; set; }

        public virtual Role Role { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StaffDetail> StaffDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SystemStatu> SystemStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> User1 { get; set; }

        public virtual User User2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserHistory> UserHistories { get; set; }
    }
}
