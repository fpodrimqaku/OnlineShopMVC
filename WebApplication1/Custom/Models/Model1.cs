namespace WebApplication1.Custom.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<AccessType> AccessTypes { get; set; }
        public virtual DbSet<ActivityLog> ActivityLogs { get; set; }
        public virtual DbSet<ActivityLogType> ActivityLogTypes { get; set; }
        public virtual DbSet<Budget> Budgets { get; set; }
        public virtual DbSet<BudgetDetail> BudgetDetails { get; set; }
        public virtual DbSet<BudgetDetailsExecute> BudgetDetailsExecutes { get; set; }
        public virtual DbSet<BudgetDetailsReview> BudgetDetailsReviews { get; set; }
        public virtual DbSet<BudgetExecute> BudgetExecutes { get; set; }
        public virtual DbSet<BudgetForm> BudgetForms { get; set; }
        public virtual DbSet<BudgetFormExecute> BudgetFormExecutes { get; set; }
        public virtual DbSet<BudgetFormReview> BudgetFormReviews { get; set; }
        public virtual DbSet<BudgetParameterBoundary> BudgetParameterBoundaries { get; set; }
        public virtual DbSet<BudgetRequest> BudgetRequests { get; set; }
        public virtual DbSet<BudgetReview> BudgetReviews { get; set; }
        public virtual DbSet<BudgetTotal> BudgetTotals { get; set; }
        public virtual DbSet<BudgetTransfer> BudgetTransfers { get; set; }
        public virtual DbSet<BudgetTransferStatu> BudgetTransferStatus { get; set; }
        public virtual DbSet<Center> Centers { get; set; }
        public virtual DbSet<ChangeLog> ChangeLogs { get; set; }
        public virtual DbSet<Constant> Constants { get; set; }
        public virtual DbSet<ConstantGroup> ConstantGroups { get; set; }
        public virtual DbSet<EconomicCategory> EconomicCategories { get; set; }
        public virtual DbSet<FailedLogin> FailedLogins { get; set; }
        public virtual DbSet<FunctionalCode> FunctionalCodes { get; set; }
        public virtual DbSet<Funding> Fundings { get; set; }
        public virtual DbSet<FundingDetail> FundingDetails { get; set; }
        public virtual DbSet<FundingDetailsExecute> FundingDetailsExecutes { get; set; }
        public virtual DbSet<FundingDetailsReview> FundingDetailsReviews { get; set; }
        public virtual DbSet<FundingPlanned> FundingPlanneds { get; set; }
        public virtual DbSet<FundSource> FundSources { get; set; }
        public virtual DbSet<Hierarchy> Hierarchies { get; set; }
        public virtual DbSet<IndividualAccess> IndividualAccesses { get; set; }
        public virtual DbSet<Notification> Notifications { get; set; }
        public virtual DbSet<NotificationType> NotificationTypes { get; set; }
        public virtual DbSet<OperationSystemType> OperationSystemTypes { get; set; }
        public virtual DbSet<OrganisationGroup> OrganisationGroups { get; set; }
        public virtual DbSet<OrganisationLevel> OrganisationLevels { get; set; }
        public virtual DbSet<Organisation> Organisations { get; set; }
        public virtual DbSet<OrganisationSector> OrganisationSectors { get; set; }
        public virtual DbSet<OrganisationUser> OrganisationUsers { get; set; }
        public virtual DbSet<ParameterCalculation> ParameterCalculations { get; set; }
        public virtual DbSet<Parameter> Parameters { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<RequestBudgetTransfer> RequestBudgetTransfers { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<RoleAccess> RoleAccesses { get; set; }
        public virtual DbSet<RolePIP> RolePIPs { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }
        public virtual DbSet<StaffDetail> StaffDetails { get; set; }
        public virtual DbSet<StaffDetailsExecute> StaffDetailsExecutes { get; set; }
        public virtual DbSet<StaffDetailsReview> StaffDetailsReviews { get; set; }
        public virtual DbSet<StatusProcess> StatusProcesses { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<SystemStatu> SystemStatus { get; set; }
        public virtual DbSet<Table> Tables { get; set; }
        public virtual DbSet<TransferPercentage> TransferPercentages { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserHistory> UserHistories { get; set; }
        public virtual DbSet<UserRolePIP> UserRolePIPs { get; set; }
        public virtual DbSet<UserSystemStatu> UserSystemStatus { get; set; }
        public virtual DbSet<View> Views { get; set; }
        public virtual DbSet<WageClass> WageClasses { get; set; }
        public virtual DbSet<WageCoefficient> WageCoefficients { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccessType>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<AccessType>()
                .HasMany(e => e.IndividualAccesses)
                .WithRequired(e => e.AccessType)
                .HasForeignKey(e => e.IdAccessType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AccessType>()
                .HasMany(e => e.RoleAccesses)
                .WithRequired(e => e.AccessType)
                .HasForeignKey(e => e.IdAccessType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ActivityLog>()
                .Property(e => e.BrowserType)
                .IsUnicode(false);

            modelBuilder.Entity<ActivityLog>()
                .Property(e => e.BrowserAndUserAgentType)
                .IsUnicode(false);

            modelBuilder.Entity<ActivityLogType>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<ActivityLogType>()
                .HasMany(e => e.ActivityLogs)
                .WithRequired(e => e.ActivityLogType)
                .HasForeignKey(e => e.IdActivityLogType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Budget>()
                .HasMany(e => e.BudgetDetails)
                .WithRequired(e => e.Budget)
                .HasForeignKey(e => e.IDBudget)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Budget>()
                .HasMany(e => e.BudgetRequests)
                .WithRequired(e => e.Budget)
                .HasForeignKey(e => e.IDBudget)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BudgetDetail>()
                .HasMany(e => e.FundingDetails)
                .WithRequired(e => e.BudgetDetail)
                .HasForeignKey(e => e.IDBudgetDetails)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BudgetDetailsExecute>()
                .HasMany(e => e.FundingDetailsExecutes)
                .WithRequired(e => e.BudgetDetailsExecute)
                .HasForeignKey(e => e.IDBudgetDetails)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BudgetDetailsReview>()
                .HasMany(e => e.FundingDetailsReviews)
                .WithRequired(e => e.BudgetDetailsReview)
                .HasForeignKey(e => e.IDBudgetDetails)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BudgetExecute>()
                .HasMany(e => e.BudgetDetailsExecutes)
                .WithRequired(e => e.BudgetExecute)
                .HasForeignKey(e => e.IDBudget)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BudgetForm>()
                .HasMany(e => e.Budgets)
                .WithRequired(e => e.BudgetForm)
                .HasForeignKey(e => e.IDBudgetForm)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BudgetForm>()
                .HasMany(e => e.BudgetFormExecutes)
                .WithRequired(e => e.BudgetForm)
                .HasForeignKey(e => e.IDBudgetFormInherited)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BudgetForm>()
                .HasMany(e => e.Fundings)
                .WithRequired(e => e.BudgetForm)
                .HasForeignKey(e => e.IDBudgetForm)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BudgetForm>()
                .HasMany(e => e.Staffs)
                .WithRequired(e => e.BudgetForm)
                .HasForeignKey(e => e.IDBudgetForm)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BudgetForm>()
                .HasMany(e => e.StaffDetails)
                .WithRequired(e => e.BudgetForm)
                .HasForeignKey(e => e.IDBudgetForm)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BudgetFormExecute>()
                .HasMany(e => e.BudgetExecutes)
                .WithRequired(e => e.BudgetFormExecute)
                .HasForeignKey(e => e.IDBudgetForm)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BudgetFormExecute>()
                .HasMany(e => e.BudgetFormReviews)
                .WithRequired(e => e.BudgetFormExecute)
                .HasForeignKey(e => e.IDBudgetFormInherited)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BudgetFormExecute>()
                .HasMany(e => e.BudgetTransfers)
                .WithRequired(e => e.BudgetFormExecute)
                .HasForeignKey(e => e.IDBudgetForm)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BudgetFormExecute>()
                .HasMany(e => e.StaffDetailsExecutes)
                .WithRequired(e => e.BudgetFormExecute)
                .HasForeignKey(e => e.IDBudgetForm)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BudgetFormReview>()
                .HasMany(e => e.BudgetReviews)
                .WithRequired(e => e.BudgetFormReview)
                .HasForeignKey(e => e.IDBudgetForm)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BudgetFormReview>()
                .HasMany(e => e.StaffDetailsReviews)
                .WithRequired(e => e.BudgetFormReview)
                .HasForeignKey(e => e.IDBudgetForm)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BudgetReview>()
                .HasMany(e => e.BudgetDetailsReviews)
                .WithRequired(e => e.BudgetReview)
                .HasForeignKey(e => e.IDBudget)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BudgetTransfer>()
                .HasMany(e => e.RequestBudgetTransfers)
                .WithRequired(e => e.BudgetTransfer)
                .HasForeignKey(e => e.IDTransfer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BudgetTransferStatu>()
                .HasMany(e => e.BudgetTransfers)
                .WithRequired(e => e.BudgetTransferStatu)
                .HasForeignKey(e => e.IDTransferStatus)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Center>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.Center)
                .HasForeignKey(e => e.IdCenter)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Constant>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<ConstantGroup>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<ConstantGroup>()
                .HasMany(e => e.Constants)
                .WithRequired(e => e.ConstantGroup)
                .HasForeignKey(e => e.IdConstantGroup)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EconomicCategory>()
                .HasMany(e => e.Budgets)
                .WithRequired(e => e.EconomicCategory)
                .HasForeignKey(e => e.IDEconomicCategory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EconomicCategory>()
                .HasMany(e => e.BudgetDetails)
                .WithRequired(e => e.EconomicCategory)
                .HasForeignKey(e => e.IDEconomicCategory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FailedLogin>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<FailedLogin>()
                .Property(e => e.ComputerName)
                .IsUnicode(false);

            modelBuilder.Entity<FailedLogin>()
                .Property(e => e.IPAddress)
                .IsUnicode(false);

            modelBuilder.Entity<FailedLogin>()
                .Property(e => e.BrowserType)
                .IsUnicode(false);

            modelBuilder.Entity<FunctionalCode>()
                .HasMany(e => e.Organisations)
                .WithOptional(e => e.FunctionalCode)
                .HasForeignKey(e => e.IDFunctionalCode);

            modelBuilder.Entity<FundSource>()
                .HasMany(e => e.Fundings)
                .WithRequired(e => e.FundSource)
                .HasForeignKey(e => e.IDFundSource)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Hierarchy>()
                .Property(e => e.OrderPosition)
                .IsUnicode(false);

            modelBuilder.Entity<Hierarchy>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<Notification>()
                .Property(e => e.Value)
                .IsUnicode(false);

            modelBuilder.Entity<NotificationType>()
                .Property(e => e.Text)
                .IsUnicode(false);

            modelBuilder.Entity<NotificationType>()
                .HasMany(e => e.Notifications)
                .WithRequired(e => e.NotificationType)
                .HasForeignKey(e => e.IdNotificationType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OperationSystemType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<OperationSystemType>()
                .HasMany(e => e.UserHistories)
                .WithOptional(e => e.OperationSystemType)
                .HasForeignKey(e => e.IdOperationSystemType);

            modelBuilder.Entity<OrganisationLevel>()
                .HasMany(e => e.Organisations)
                .WithRequired(e => e.OrganisationLevel)
                .HasForeignKey(e => e.IDOrganisationLevel)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Organisation>()
                .HasMany(e => e.Budgets)
                .WithRequired(e => e.Organisation)
                .HasForeignKey(e => e.IDOrganisation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Organisation>()
                .HasMany(e => e.BudgetDetails)
                .WithRequired(e => e.Organisation)
                .HasForeignKey(e => e.IDOrganisation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Organisation>()
                .HasMany(e => e.Fundings)
                .WithRequired(e => e.Organisation)
                .HasForeignKey(e => e.IDOrganisation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Organisation>()
                .HasMany(e => e.SystemStatus)
                .WithOptional(e => e.Organisation)
                .HasForeignKey(e => e.IDOrganisation);

            modelBuilder.Entity<ParameterCalculation>()
                .HasOptional(e => e.ParameterCalculations1)
                .WithRequired(e => e.ParameterCalculation1);

            modelBuilder.Entity<Person>()
                .Property(e => e.First)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.Last)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<Role>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.RoleAccesses)
                .WithRequired(e => e.Role)
                .HasForeignKey(e => e.IdRole)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.Role)
                .HasForeignKey(e => e.IdRole)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RolePIP>()
                .Property(e => e.TitleSQ)
                .IsUnicode(false);

            modelBuilder.Entity<RolePIP>()
                .Property(e => e.TitleEN)
                .IsUnicode(false);

            modelBuilder.Entity<RolePIP>()
                .Property(e => e.TitleSR)
                .IsUnicode(false);

            modelBuilder.Entity<Table>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<Table>()
                .HasMany(e => e.ChangeLogs)
                .WithRequired(e => e.Table)
                .HasForeignKey(e => e.IdTable)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .Property(e => e.First)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Last)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Image)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.ActivityLogs)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.IdUser)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.BudgetDetails)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.EntryUserID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.BudgetRequests)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.EntryUserID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.ChangeLogs)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.IdEntryUser)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.FunctionalCodes)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.IDEntryUser)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Fundings)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.IDEntryUser)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.FundSources)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.IDEntryUser)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.IndividualAccesses)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.IdUser);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Notifications)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.IdEntryUser)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.OrganisationSectors)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.IDEntryUser)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.OrganisationUsers)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.IDUser);

            modelBuilder.Entity<User>()
                .HasMany(e => e.RequestBudgetTransfers)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.IDEntryUser)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.RequestBudgetTransfers1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.IDAnalystUser);

            modelBuilder.Entity<User>()
                .HasMany(e => e.RequestBudgetTransfers2)
                .WithOptional(e => e.User2)
                .HasForeignKey(e => e.IDLeadUser);

            modelBuilder.Entity<User>()
                .HasMany(e => e.StaffDetails)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.IDEntryUser)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.SystemStatus)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.IDEntryUser)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.User1)
                .WithRequired(e => e.User2)
                .HasForeignKey(e => e.IdEntryUser);

            modelBuilder.Entity<User>()
                .HasMany(e => e.UserHistories)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.IdUser)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UserHistory>()
                .Property(e => e.ComputerName)
                .IsUnicode(false);

            modelBuilder.Entity<UserHistory>()
                .Property(e => e.IPAddress)
                .IsUnicode(false);

            modelBuilder.Entity<UserHistory>()
                .Property(e => e.BrowserType)
                .IsUnicode(false);

            modelBuilder.Entity<UserHistory>()
                .Property(e => e.BrowserAndUserAgentType)
                .IsUnicode(false);

            modelBuilder.Entity<View>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<View>()
                .Property(e => e.URL)
                .IsUnicode(false);

            modelBuilder.Entity<View>()
                .HasMany(e => e.ActivityLogs)
                .WithRequired(e => e.View)
                .HasForeignKey(e => e.IdView)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<View>()
                .HasMany(e => e.IndividualAccesses)
                .WithRequired(e => e.View)
                .HasForeignKey(e => e.IdView)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<View>()
                .HasMany(e => e.RoleAccesses)
                .WithRequired(e => e.View)
                .HasForeignKey(e => e.IdView)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WageCoefficient>()
                .HasMany(e => e.StaffDetails)
                .WithRequired(e => e.WageCoefficient)
                .HasForeignKey(e => e.IDWageCoefficients)
                .WillCascadeOnDelete(false);
        }
    }
}
