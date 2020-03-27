using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace NeoCrmPlugin.Data.Models
{
    public partial class NeoCRMContext : DbContext
    {
        public NeoCRMContext()
        {
        }

        public NeoCRMContext(DbContextOptions<NeoCRMContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<CallRecords> CallRecords { get; set; }
        public virtual DbSet<CategorySetups> CategorySetups { get; set; }
        public virtual DbSet<CccommunicationInformations> CccommunicationInformations { get; set; }
        public virtual DbSet<Chats> Chats { get; set; }
        public virtual DbSet<ClassEnd> ClassEnd { get; set; }
        public virtual DbSet<ClassJoin> ClassJoin { get; set; }
        public virtual DbSet<CommentHistoryFacebooks> CommentHistoryFacebooks { get; set; }
        public virtual DbSet<CommunicationInformations> CommunicationInformations { get; set; }
        public virtual DbSet<CommunicationModes> CommunicationModes { get; set; }
        public virtual DbSet<Counseling> Counseling { get; set; }
        public virtual DbSet<CrmActions> CrmActions { get; set; }
        public virtual DbSet<CrmAgentCustomerMapping> CrmAgentCustomerMapping { get; set; }
        public virtual DbSet<CrmAgentProduct> CrmAgentProduct { get; set; }
        public virtual DbSet<CrmAgentType> CrmAgentType { get; set; }
        public virtual DbSet<CrmAgentes> CrmAgentes { get; set; }
        public virtual DbSet<CrmBranchSetups> CrmBranchSetups { get; set; }
        public virtual DbSet<CrmBrandSetups> CrmBrandSetups { get; set; }
        public virtual DbSet<CrmCampaignFaqs> CrmCampaignFaqs { get; set; }
        public virtual DbSet<CrmCampaigns> CrmCampaigns { get; set; }
        public virtual DbSet<CrmCompanySetups> CrmCompanySetups { get; set; }
        public virtual DbSet<CrmCompanySubTypes> CrmCompanySubTypes { get; set; }
        public virtual DbSet<CrmCompanyTypes> CrmCompanyTypes { get; set; }
        public virtual DbSet<CrmCustomerCompanies> CrmCustomerCompanies { get; set; }
        public virtual DbSet<CrmCustomerSectors> CrmCustomerSectors { get; set; }
        public virtual DbSet<CrmCustomers> CrmCustomers { get; set; }
        public virtual DbSet<CrmLeadDetails> CrmLeadDetails { get; set; }
        public virtual DbSet<CrmLeadTypes> CrmLeadTypes { get; set; }
        public virtual DbSet<CrmLeads> CrmLeads { get; set; }
        public virtual DbSet<CrmLocationTypes> CrmLocationTypes { get; set; }
        public virtual DbSet<CrmLocations> CrmLocations { get; set; }
        public virtual DbSet<CrmMenuSettings> CrmMenuSettings { get; set; }
        public virtual DbSet<CrmPreferenceTable> CrmPreferenceTable { get; set; }
        public virtual DbSet<CrmProcessFollowUps> CrmProcessFollowUps { get; set; }
        public virtual DbSet<CrmProcesse> CrmProcesse { get; set; }
        public virtual DbSet<CrmProductModels> CrmProductModels { get; set; }
        public virtual DbSet<CrmProducts> CrmProducts { get; set; }
        public virtual DbSet<CrmSubMenuSettings> CrmSubMenuSettings { get; set; }
        public virtual DbSet<CrmWorkFlow> CrmWorkFlow { get; set; }
        public virtual DbSet<CustomFreeFiledTables> CustomFreeFiledTables { get; set; }
        public virtual DbSet<CustomerAddresses> CustomerAddresses { get; set; }
        public virtual DbSet<CustomerFamilyInfomations> CustomerFamilyInfomations { get; set; }
        public virtual DbSet<CustomerPhysicalInformations> CustomerPhysicalInformations { get; set; }
        public virtual DbSet<DocumentTypes> DocumentTypes { get; set; }
        public virtual DbSet<DropdownManagements> DropdownManagements { get; set; }
        public virtual DbSet<DynamicReports> DynamicReports { get; set; }
        public virtual DbSet<EducationInformations> EducationInformations { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<EnrollmentForm> EnrollmentForm { get; set; }
        public virtual DbSet<FreeFieldDataLinkTables> FreeFieldDataLinkTables { get; set; }
        public virtual DbSet<FreeFieldLinkTables> FreeFieldLinkTables { get; set; }
        public virtual DbSet<InboxMails> InboxMails { get; set; }
        public virtual DbSet<LeadEnquiry> LeadEnquiry { get; set; }
        public virtual DbSet<LeadLastDetail> LeadLastDetail { get; set; }
        public virtual DbSet<LeadProductDetailMasters> LeadProductDetailMasters { get; set; }
        public virtual DbSet<LeadProductDetails> LeadProductDetails { get; set; }
        public virtual DbSet<LeadProductModelDetails> LeadProductModelDetails { get; set; }
        public virtual DbSet<Log> Log { get; set; }
        public virtual DbSet<MailSetups> MailSetups { get; set; }
        public virtual DbSet<Notifications> Notifications { get; set; }
        public virtual DbSet<PreferenceSetups> PreferenceSetups { get; set; }
        public virtual DbSet<Prefixes> Prefixes { get; set; }
        public virtual DbSet<PreviousItcourses> PreviousItcourses { get; set; }
        public virtual DbSet<ProfessionalInformations> ProfessionalInformations { get; set; }
        public virtual DbSet<RatingSetups> RatingSetups { get; set; }
        public virtual DbSet<RoleDetails> RoleDetails { get; set; }
        public virtual DbSet<SentMails> SentMails { get; set; }
        public virtual DbSet<SocialWebRecords> SocialWebRecords { get; set; }
        public virtual DbSet<SocioDemographicInformations> SocioDemographicInformations { get; set; }
        public virtual DbSet<Suffixes> Suffixes { get; set; }
        public virtual DbSet<TaModes> TaModes { get; set; }
        public virtual DbSet<TaskActions> TaskActions { get; set; }
        public virtual DbSet<Tests> Tests { get; set; }
        public virtual DbSet<UserMailCredentials> UserMailCredentials { get; set; }
        public virtual DbSet<DashboardLinkedElements> DashboardLinkedElements { get; set; }
        public virtual DbSet<DashboardsInfo> DashboardsInfo { get; set; }
        public virtual DbSet<Elements> Elements { get; set; }
        public virtual DbSet<Templates> Templates { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.;Database=NeotericCRMNew;User Id = sa; Password = sa;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.2-servicing-10034");

            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.HasIndex(e => e.RoleId);

                entity.Property(e => e.RoleId).IsRequired();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<CallRecords>(entity =>
            {
                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.LeadNo);

                entity.HasIndex(e => e.ModifiedBy);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.CallRecordsCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy);

                entity.HasOne(d => d.LeadNoNavigation)
                    .WithMany(p => p.CallRecords)
                    .HasForeignKey(d => d.LeadNo)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.CallRecordsModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy);
            });

            modelBuilder.Entity<CategorySetups>(entity =>
            {
                entity.HasIndex(e => e.CompanyCode);

                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.ModifiedBy);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CategoryName).IsRequired();

                entity.Property(e => e.Description).IsRequired();

                entity.HasOne(d => d.CompanyCodeNavigation)
                    .WithMany(p => p.CategorySetups)
                    .HasForeignKey(d => d.CompanyCode)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.CategorySetupsCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.CategorySetupsModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy);
            });

            modelBuilder.Entity<CccommunicationInformations>(entity =>
            {
                entity.ToTable("CCCommunicationInformations");

                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.CustomerCompanyId);

                entity.HasIndex(e => e.ModifiedBy);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.CccommunicationInformationsCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy);

                entity.HasOne(d => d.CustomerCompany)
                    .WithMany(p => p.CccommunicationInformations)
                    .HasForeignKey(d => d.CustomerCompanyId);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.CccommunicationInformationsModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy);
            });

            modelBuilder.Entity<Chats>(entity =>
            {
                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.ModifiedBy);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.ChatsCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.ChatsModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy);
            });

            modelBuilder.Entity<ClassEnd>(entity =>
            {
                entity.ToTable("Class_End");

                entity.Property(e => e.CertificateDate)
                    .HasColumnName("Certificate_Date")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CertificateNumber).HasColumnName("Certificate_Number");

                entity.Property(e => e.EndDate)
                    .HasColumnName("End_Date")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ExamDate)
                    .HasColumnName("Exam_Date")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FeedbackForm)
                    .HasColumnName("Feedback_Form")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClassJoin>(entity =>
            {
                entity.ToTable("Class_Join");

                entity.Property(e => e.Date)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SessionId).HasColumnName("Session_ID");
            });

            modelBuilder.Entity<CommentHistoryFacebooks>(entity =>
            {
                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.ModifiedBy);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.CommentHistoryFacebooksCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.CommentHistoryFacebooksModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy);
            });

            modelBuilder.Entity<CommunicationInformations>(entity =>
            {
                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.CustomerId);

                entity.HasIndex(e => e.ModifiedBy);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.CommunicationInformationsCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CommunicationInformations)
                    .HasForeignKey(d => d.CustomerId);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.CommunicationInformationsModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy);
            });

            modelBuilder.Entity<CommunicationModes>(entity =>
            {
                entity.HasIndex(e => e.CompanyCode);

                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.ModifiedBy);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ModeName).IsRequired();

                entity.HasOne(d => d.CompanyCodeNavigation)
                    .WithMany(p => p.CommunicationModes)
                    .HasForeignKey(d => d.CompanyCode)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.CommunicationModesCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.CommunicationModesModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy);
            });

            modelBuilder.Entity<Counseling>(entity =>
            {
                entity.Property(e => e.CourseChosen)
                    .HasColumnName("Course_Chosen")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PersonFromLeadAndCall)
                    .HasColumnName("Person_From_Lead_And_Call")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CrmActions>(entity =>
            {
                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.ModifiedBy);

                entity.HasIndex(e => e.ProcessCode);

                entity.HasIndex(e => e.TaMode);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActionEngDesc)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.CrmActionsCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.CrmActionsModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy);

                entity.HasOne(d => d.ProcessCodeNavigation)
                    .WithMany(p => p.CrmActions)
                    .HasForeignKey(d => d.ProcessCode)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.TaModeNavigation)
                    .WithMany(p => p.CrmActions)
                    .HasForeignKey(d => d.TaMode);
            });

            modelBuilder.Entity<CrmAgentCustomerMapping>(entity =>
            {
                entity.HasIndex(e => e.AgentId);

                entity.HasIndex(e => e.CompanyCode);

                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.CustomerId);

                entity.HasIndex(e => e.ModifiedBy);

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AgentId).HasColumnName("AgentID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Agent)
                    .WithMany(p => p.CrmAgentCustomerMapping)
                    .HasForeignKey(d => d.AgentId);

                entity.HasOne(d => d.CompanyCodeNavigation)
                    .WithMany(p => p.CrmAgentCustomerMapping)
                    .HasForeignKey(d => d.CompanyCode)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.CrmAgentCustomerMappingCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CrmAgentCustomerMapping)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.CrmAgentCustomerMappingModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CrmAgentCustomerMappingUser)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<CrmAgentProduct>(entity =>
            {
                entity.HasIndex(e => e.AgentCode);

                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.ModifiedBy);

                entity.HasIndex(e => e.ProductId);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.HasOne(d => d.AgentCodeNavigation)
                    .WithMany(p => p.CrmAgentProduct)
                    .HasForeignKey(d => d.AgentCode)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.CrmAgentProductCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.CrmAgentProductModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.CrmAgentProduct)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<CrmAgentType>(entity =>
            {
                entity.HasIndex(e => e.CompanyCode);

                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.ModifiedBy);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AgentTypeEngDesc)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.AgentTypeId).HasMaxLength(30);

                entity.Property(e => e.AgentTypeNepDesc)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.CompanyCodeNavigation)
                    .WithMany(p => p.CrmAgentType)
                    .HasForeignKey(d => d.CompanyCode)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.CrmAgentTypeCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.CrmAgentTypeModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy);
            });

            modelBuilder.Entity<CrmAgentes>(entity =>
            {
                entity.HasIndex(e => e.AgentTypeCode);

                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.ModifiedBy);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AgentEngDesc)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.AgentNepDesc)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.EmployeeCode).HasMaxLength(30);

                entity.Property(e => e.MobileNo).HasMaxLength(30);

                entity.Property(e => e.Password).HasMaxLength(30);

                entity.Property(e => e.PhoneNo).HasMaxLength(30);

                entity.Property(e => e.UserName).HasMaxLength(100);

                entity.HasOne(d => d.AgentTypeCodeNavigation)
                    .WithMany(p => p.CrmAgentes)
                    .HasForeignKey(d => d.AgentTypeCode)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.CrmAgentesCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.CrmAgentesModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy);
            });

            modelBuilder.Entity<CrmBranchSetups>(entity =>
            {
                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.ModifiedBy);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AbbrCode)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.BranchEngDesc).IsRequired();

                entity.Property(e => e.BranchNepDesc).IsRequired();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TelephoneNumber)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.CrmBranchSetupsCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.CrmBranchSetupsModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy);
            });

            modelBuilder.Entity<CrmBrandSetups>(entity =>
            {
                entity.HasIndex(e => e.CompanyCode);

                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.ModifiedBy);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BrandName).IsRequired();

                entity.Property(e => e.Description).IsRequired();

                entity.HasOne(d => d.CompanyCodeNavigation)
                    .WithMany(p => p.CrmBrandSetups)
                    .HasForeignKey(d => d.CompanyCode)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.CrmBrandSetupsCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.CrmBrandSetupsModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy);
            });

            modelBuilder.Entity<CrmCampaignFaqs>(entity =>
            {
                entity.HasIndex(e => e.BranchCode);

                entity.HasIndex(e => e.CampaignCode);

                entity.HasIndex(e => e.CompanyCode);

                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.ModifiedBy);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CompaignFaqEngDesc)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.CompaignFaqNepDesc).HasMaxLength(800);

                entity.Property(e => e.FaqAnswer)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.HasOne(d => d.BranchCodeNavigation)
                    .WithMany(p => p.CrmCampaignFaqs)
                    .HasForeignKey(d => d.BranchCode)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.CampaignCodeNavigation)
                    .WithMany(p => p.CrmCampaignFaqs)
                    .HasForeignKey(d => d.CampaignCode)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.CompanyCodeNavigation)
                    .WithMany(p => p.CrmCampaignFaqs)
                    .HasForeignKey(d => d.CompanyCode)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.CrmCampaignFaqsCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.CrmCampaignFaqsModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy);
            });

            modelBuilder.Entity<CrmCampaigns>(entity =>
            {
                entity.HasIndex(e => e.BranchCode);

                entity.HasIndex(e => e.CompanyTypeCode);

                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.CustomerSectorCode);

                entity.HasIndex(e => e.ModifiedBy);

                entity.HasIndex(e => e.ProductCode);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CampaignEngDesc)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CampaignNepDesc).HasMaxLength(100);

                entity.Property(e => e.CampaignType).HasMaxLength(20);

                entity.HasOne(d => d.BranchCodeNavigation)
                    .WithMany(p => p.CrmCampaigns)
                    .HasForeignKey(d => d.BranchCode)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.CompanyTypeCodeNavigation)
                    .WithMany(p => p.CrmCampaigns)
                    .HasForeignKey(d => d.CompanyTypeCode);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.CrmCampaignsCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy);

                entity.HasOne(d => d.CustomerSectorCodeNavigation)
                    .WithMany(p => p.CrmCampaigns)
                    .HasForeignKey(d => d.CustomerSectorCode);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.CrmCampaignsModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy);

                entity.HasOne(d => d.ProductCodeNavigation)
                    .WithMany(p => p.CrmCampaigns)
                    .HasForeignKey(d => d.ProductCode);
            });

            modelBuilder.Entity<CrmCompanySetups>(entity =>
            {
                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.ModifiedBy);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AbbrCode).HasMaxLength(6);

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CompanyEdesc)
                    .IsRequired()
                    .HasColumnName("CompanyEDesc")
                    .HasMaxLength(100);

                entity.Property(e => e.CompanyId).HasMaxLength(30);

                entity.Property(e => e.CompanyNdesc)
                    .IsRequired()
                    .HasColumnName("CompanyNDesc")
                    .HasMaxLength(400);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Fax).HasMaxLength(50);

                entity.Property(e => e.FooterLogoFileName).HasMaxLength(200);

                entity.Property(e => e.LogoFileName).HasMaxLength(200);

                entity.Property(e => e.RegistrationNumber)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.SmtpHost).HasMaxLength(50);

                entity.Property(e => e.Telephone).HasMaxLength(50);

                entity.Property(e => e.TpinVatNo).HasMaxLength(30);

                entity.Property(e => e.Web).HasMaxLength(50);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.CrmCompanySetupsCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.CrmCompanySetupsModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy);
            });

            modelBuilder.Entity<CrmCompanySubTypes>(entity =>
            {
                entity.HasIndex(e => e.CompanyTypeId);

                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.ModifiedBy);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CompanySubTypeEngDesc)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.CompanyType)
                    .WithMany(p => p.CrmCompanySubTypes)
                    .HasForeignKey(d => d.CompanyTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.CrmCompanySubTypesCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.CrmCompanySubTypesModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy);
            });

            modelBuilder.Entity<CrmCompanyTypes>(entity =>
            {
                entity.HasIndex(e => e.CompanyCode);

                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.ModifiedBy);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CompanyTypeEngDesc)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CompanyTypeId).HasMaxLength(30);

                entity.Property(e => e.CompanyTypeNepDesc).HasMaxLength(100);

                entity.HasOne(d => d.CompanyCodeNavigation)
                    .WithMany(p => p.CrmCompanyTypes)
                    .HasForeignKey(d => d.CompanyCode)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.CrmCompanyTypesCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.CrmCompanyTypesModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy);
            });

            modelBuilder.Entity<CrmCustomerCompanies>(entity =>
            {
                entity.HasIndex(e => e.CompanySubTypeId);

                entity.HasIndex(e => e.CompanyTypeId);

                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.ModifiedBy);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address1).HasMaxLength(100);

                entity.Property(e => e.Address2).HasMaxLength(100);

                entity.Property(e => e.Address3).HasMaxLength(100);

                entity.Property(e => e.CcompanyEngDesc)
                    .IsRequired()
                    .HasColumnName("CCompanyEngDesc")
                    .HasMaxLength(100);

                entity.Property(e => e.CcompanyId)
                    .HasColumnName("CCompanyId")
                    .HasMaxLength(30);

                entity.Property(e => e.CcompanyNepDesc)
                    .HasColumnName("CCompanyNepDesc")
                    .HasMaxLength(100);

                entity.Property(e => e.ContactPersonName).HasMaxLength(100);

                entity.Property(e => e.ContactPersonPosition).HasMaxLength(100);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.MobileNo).HasMaxLength(50);

                entity.Property(e => e.TelephoneNo).HasMaxLength(50);

                entity.HasOne(d => d.CompanySubTypeNavigation)
                    .WithMany(p => p.CrmCustomerCompanies)
                    .HasForeignKey(d => d.CompanySubTypeId);

                entity.HasOne(d => d.CompanyType)
                    .WithMany(p => p.CrmCustomerCompanies)
                    .HasForeignKey(d => d.CompanyTypeId);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.CrmCustomerCompaniesCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.CrmCustomerCompaniesModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy);
            });

            modelBuilder.Entity<CrmCustomerSectors>(entity =>
            {
                entity.HasIndex(e => e.CompanyCode);

                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.ModifiedBy);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CustomerSectorEngDesc)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CustomerSectorId).HasMaxLength(30);

                entity.Property(e => e.CustomerSectorNepDesc).HasMaxLength(100);

                entity.HasOne(d => d.CompanyCodeNavigation)
                    .WithMany(p => p.CrmCustomerSectors)
                    .HasForeignKey(d => d.CompanyCode)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.CrmCustomerSectorsCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.CrmCustomerSectorsModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy);
            });

            modelBuilder.Entity<CrmCustomers>(entity =>
            {
                entity.HasIndex(e => e.CcompanyCode);

                entity.HasIndex(e => e.CommunicationInfoId);

                entity.HasIndex(e => e.CompanyCode);

                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.CustomerAddressId)
                    .IsUnique()
                    .HasFilter("([CustomerAddressId] IS NOT NULL)");

                entity.HasIndex(e => e.CustomerPhysicalInfoId);

                entity.HasIndex(e => e.CustomerSectorCode);

                entity.HasIndex(e => e.EducationInfoId);

                entity.HasIndex(e => e.LocationCode);

                entity.HasIndex(e => e.ModifiedBy);

                entity.HasIndex(e => e.ProfessionalInfoId);

                entity.HasIndex(e => e.SocioDemographiInfoId);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address1).HasMaxLength(100);

                entity.Property(e => e.Address2).HasMaxLength(100);

                entity.Property(e => e.Address3).HasMaxLength(100);

                entity.Property(e => e.BirthDateAd).HasColumnName("BirthDateAD");

                entity.Property(e => e.BirthDateBs).HasColumnName("BirthDateBS");

                entity.Property(e => e.CcompanyCode).HasColumnName("CCompanyCode");

                entity.Property(e => e.CompanyName).HasMaxLength(100);

                entity.Property(e => e.CustomerEngDesc).HasMaxLength(100);

                entity.Property(e => e.CustomerId).HasMaxLength(30);

                entity.Property(e => e.CustomerNepDesc).HasMaxLength(100);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.MobileNo).HasMaxLength(50);

                entity.Property(e => e.TelephoneNo).HasMaxLength(50);

                entity.HasOne(d => d.CcompanyCodeNavigation)
                    .WithMany(p => p.CrmCustomers)
                    .HasForeignKey(d => d.CcompanyCode);

                entity.HasOne(d => d.CommunicationInfo)
                    .WithMany(p => p.CrmCustomers)
                    .HasForeignKey(d => d.CommunicationInfoId);

                entity.HasOne(d => d.CompanyCodeNavigation)
                    .WithMany(p => p.CrmCustomers)
                    .HasForeignKey(d => d.CompanyCode)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.CrmCustomersCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy);

                entity.HasOne(d => d.CustomerAddress)
                    .WithOne(p => p.CrmCustomers)
                    .HasForeignKey<CrmCustomers>(d => d.CustomerAddressId);

                entity.HasOne(d => d.CustomerPhysicalInfo)
                    .WithMany(p => p.CrmCustomers)
                    .HasForeignKey(d => d.CustomerPhysicalInfoId);

                entity.HasOne(d => d.CustomerSectorCodeNavigation)
                    .WithMany(p => p.CrmCustomers)
                    .HasForeignKey(d => d.CustomerSectorCode);

                entity.HasOne(d => d.EducationInfo)
                    .WithMany(p => p.CrmCustomers)
                    .HasForeignKey(d => d.EducationInfoId);

                entity.HasOne(d => d.LocationCodeNavigation)
                    .WithMany(p => p.CrmCustomers)
                    .HasForeignKey(d => d.LocationCode);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.CrmCustomersModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy);

                entity.HasOne(d => d.ProfessionalInfo)
                    .WithMany(p => p.CrmCustomers)
                    .HasForeignKey(d => d.ProfessionalInfoId);

                entity.HasOne(d => d.SocioDemographiInfo)
                    .WithMany(p => p.CrmCustomers)
                    .HasForeignKey(d => d.SocioDemographiInfoId);
            });

            modelBuilder.Entity<CrmLeadDetails>(entity =>
            {
                entity.HasIndex(e => e.AgentId);

                entity.HasIndex(e => e.BranchCode);

                entity.HasIndex(e => e.CompanyCode);

                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.LeadNo);

                entity.HasIndex(e => e.ModifiedBy);

                entity.HasIndex(e => e.ProcessTypeId);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.Agent)
                    .WithMany(p => p.CrmLeadDetails)
                    .HasForeignKey(d => d.AgentId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.BranchCodeNavigation)
                    .WithMany(p => p.CrmLeadDetails)
                    .HasForeignKey(d => d.BranchCode);

                entity.HasOne(d => d.CompanyCodeNavigation)
                    .WithMany(p => p.CrmLeadDetails)
                    .HasForeignKey(d => d.CompanyCode)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.CrmLeadDetailsCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy);

                entity.HasOne(d => d.LeadNoNavigation)
                    .WithMany(p => p.CrmLeadDetails)
                    .HasForeignKey(d => d.LeadNo)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.CrmLeadDetailsModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy);

                entity.HasOne(d => d.ProcessType)
                    .WithMany(p => p.CrmLeadDetails)
                    .HasForeignKey(d => d.ProcessTypeId);
            });

            modelBuilder.Entity<CrmLeadTypes>(entity =>
            {
                entity.HasIndex(e => e.CompanyCode);

                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.ModifiedBy);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LeadTypeEngDesc)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.LeadTypeId).HasMaxLength(30);

                entity.Property(e => e.LeadTypeNepDesc)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Nature)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.HasOne(d => d.CompanyCodeNavigation)
                    .WithMany(p => p.CrmLeadTypes)
                    .HasForeignKey(d => d.CompanyCode)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.CrmLeadTypesCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.CrmLeadTypesModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy);
            });

            modelBuilder.Entity<CrmLeads>(entity =>
            {
                entity.HasIndex(e => e.AgentId);

                entity.HasIndex(e => e.BranchCode);

                entity.HasIndex(e => e.CompanyCode);

                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.CustomerCompanyId);

                entity.HasIndex(e => e.CustomerId);

                entity.HasIndex(e => e.ModifiedBy);

                entity.HasIndex(e => e.ProcessTypeId);

                entity.HasIndex(e => e.ProductId);

                entity.HasIndex(e => e.ProductModelId);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Subject).IsRequired();

                entity.HasOne(d => d.Agent)
                    .WithMany(p => p.CrmLeads)
                    .HasForeignKey(d => d.AgentId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.BranchCodeNavigation)
                    .WithMany(p => p.CrmLeads)
                    .HasForeignKey(d => d.BranchCode);

                entity.HasOne(d => d.CompanyCodeNavigation)
                    .WithMany(p => p.CrmLeads)
                    .HasForeignKey(d => d.CompanyCode)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.CrmLeadsCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy);

                entity.HasOne(d => d.CustomerCompany)
                    .WithMany(p => p.CrmLeads)
                    .HasForeignKey(d => d.CustomerCompanyId);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CrmLeads)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.CrmLeadsModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy);

                entity.HasOne(d => d.ProcessType)
                    .WithMany(p => p.CrmLeads)
                    .HasForeignKey(d => d.ProcessTypeId);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.CrmLeads)
                    .HasForeignKey(d => d.ProductId);

                entity.HasOne(d => d.ProductModel)
                    .WithMany(p => p.CrmLeads)
                    .HasForeignKey(d => d.ProductModelId);
            });

            modelBuilder.Entity<CrmLocationTypes>(entity =>
            {
                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.ModifiedBy);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.CrmLocationTypesCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.CrmLocationTypesModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy);
            });

            modelBuilder.Entity<CrmLocations>(entity =>
            {
                entity.HasIndex(e => e.CompanyCode);

                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.ModifiedBy);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LoactionId).HasMaxLength(30);

                entity.Property(e => e.LocationEngDesc)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.LocationNepDesc).HasMaxLength(100);

                entity.Property(e => e.LocationType).IsRequired();

                entity.HasOne(d => d.CompanyCodeNavigation)
                    .WithMany(p => p.CrmLocations)
                    .HasForeignKey(d => d.CompanyCode)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.CrmLocationsCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.CrmLocationsModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy);
            });

            modelBuilder.Entity<CrmMenuSettings>(entity =>
            {
                entity.HasIndex(e => e.CompanyCode);

                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.ModifiedBy);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MenuBadge).HasColumnName("Menu_Badge");

                entity.Property(e => e.MenuComponentName).HasColumnName("Menu_Component_Name");

                entity.Property(e => e.MenuIcon).HasColumnName("Menu_Icon");

                entity.Property(e => e.MenuName).HasColumnName("Menu_Name");

                entity.Property(e => e.MenuUrl).HasColumnName("Menu_Url");

                entity.HasOne(d => d.CompanyCodeNavigation)
                    .WithMany(p => p.CrmMenuSettings)
                    .HasForeignKey(d => d.CompanyCode)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.CrmMenuSettingsCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.CrmMenuSettingsModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy);
            });

            modelBuilder.Entity<CrmPreferenceTable>(entity =>
            {
                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.ModifiedBy);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.CrmPreferenceTableCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.CrmPreferenceTableModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy);
            });

            modelBuilder.Entity<CrmProcessFollowUps>(entity =>
            {
                entity.HasIndex(e => e.ActionId);

                entity.HasIndex(e => e.AgentId);

                entity.HasIndex(e => e.BranchCode);

                entity.HasIndex(e => e.CompanyCode);

                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.LeadNo);

                entity.HasIndex(e => e.ModifiedBy);

                entity.HasIndex(e => e.NextAgentCode);

                entity.HasIndex(e => e.NextProcessCode);

                entity.HasIndex(e => e.ProcessTypeId);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.Action)
                    .WithMany(p => p.CrmProcessFollowUps)
                    .HasForeignKey(d => d.ActionId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Agent)
                    .WithMany(p => p.CrmProcessFollowUpsAgent)
                    .HasForeignKey(d => d.AgentId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.BranchCodeNavigation)
                    .WithMany(p => p.CrmProcessFollowUps)
                    .HasForeignKey(d => d.BranchCode);

                entity.HasOne(d => d.CompanyCodeNavigation)
                    .WithMany(p => p.CrmProcessFollowUps)
                    .HasForeignKey(d => d.CompanyCode)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.CrmProcessFollowUpsCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy);

                entity.HasOne(d => d.LeadNoNavigation)
                    .WithMany(p => p.CrmProcessFollowUps)
                    .HasForeignKey(d => d.LeadNo)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.CrmProcessFollowUpsModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy);

                entity.HasOne(d => d.NextAgentCodeNavigation)
                    .WithMany(p => p.CrmProcessFollowUpsNextAgentCodeNavigation)
                    .HasForeignKey(d => d.NextAgentCode);

                entity.HasOne(d => d.NextProcessCodeNavigation)
                    .WithMany(p => p.CrmProcessFollowUpsNextProcessCodeNavigation)
                    .HasForeignKey(d => d.NextProcessCode);

                entity.HasOne(d => d.ProcessType)
                    .WithMany(p => p.CrmProcessFollowUpsProcessType)
                    .HasForeignKey(d => d.ProcessTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<CrmProcesse>(entity =>
            {
                entity.HasIndex(e => e.CompanyCode);

                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.ModifiedBy);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ProcessEngDesc)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.HasOne(d => d.CompanyCodeNavigation)
                    .WithMany(p => p.CrmProcesse)
                    .HasForeignKey(d => d.CompanyCode)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.CrmProcesseCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.CrmProcesseModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy);
            });

            modelBuilder.Entity<CrmProductModels>(entity =>
            {
                entity.HasIndex(e => e.CompanyCode);

                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.ModifiedBy);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ModelEngDesc)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ModelNepDesc)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ModelNumber).IsRequired();

                entity.HasOne(d => d.CompanyCodeNavigation)
                    .WithMany(p => p.CrmProductModels)
                    .HasForeignKey(d => d.CompanyCode)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.CrmProductModelsCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.CrmProductModelsModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy);
            });

            modelBuilder.Entity<CrmProducts>(entity =>
            {
                entity.HasIndex(e => e.BrandId);

                entity.HasIndex(e => e.CategoryId);

                entity.HasIndex(e => e.CompanyCode);

                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.ModifiedBy);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Brand).HasMaxLength(100);

                entity.Property(e => e.ProductEngDesc)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ProductId).HasMaxLength(30);

                entity.Property(e => e.ProductNepDesc).HasMaxLength(100);

                entity.Property(e => e.ProductType).HasMaxLength(100);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.CrmProducts)
                    .HasForeignKey(d => d.CategoryId);

                entity.HasOne(d => d.CompanyCodeNavigation)
                    .WithMany(p => p.CrmProducts)
                    .HasForeignKey(d => d.CompanyCode)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.CrmProductsCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.CrmProductsModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy);
            });

            modelBuilder.Entity<CrmSubMenuSettings>(entity =>
            {
                entity.HasIndex(e => e.CompanyCode);

                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.MenuId);

                entity.HasIndex(e => e.ModifiedBy);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.SubMenuComponentName).HasColumnName("SubMenu_Component_Name");

                entity.Property(e => e.SubMenuIcon).HasColumnName("SubMenu_Icon");

                entity.Property(e => e.SubMenuName).HasColumnName("SubMenu_Name");

                entity.Property(e => e.SubMenuUrl).HasColumnName("SubMenu_Url");

                entity.HasOne(d => d.CompanyCodeNavigation)
                    .WithMany(p => p.CrmSubMenuSettings)
                    .HasForeignKey(d => d.CompanyCode)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.CrmSubMenuSettingsCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy);

                entity.HasOne(d => d.Menu)
                    .WithMany(p => p.CrmSubMenuSettings)
                    .HasForeignKey(d => d.MenuId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.CrmSubMenuSettingsModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy);
            });

            modelBuilder.Entity<CrmWorkFlow>(entity =>
            {
                entity.HasIndex(e => e.ActionCode);

                entity.HasIndex(e => e.AgentTypeCode);

                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.ModifiedBy);

                entity.HasIndex(e => e.ProcessCode);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.HasOne(d => d.ActionCodeNavigation)
                    .WithMany(p => p.CrmWorkFlow)
                    .HasForeignKey(d => d.ActionCode)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.AgentTypeCodeNavigation)
                    .WithMany(p => p.CrmWorkFlow)
                    .HasForeignKey(d => d.AgentTypeCode)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.CrmWorkFlowCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.CrmWorkFlowModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy);

                entity.HasOne(d => d.ProcessCodeNavigation)
                    .WithMany(p => p.CrmWorkFlow)
                    .HasForeignKey(d => d.ProcessCode)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<CustomFreeFiledTables>(entity =>
            {
                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.DocumentTypeId);

                entity.HasIndex(e => e.ModifiedBy);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.CustomFreeFiledTablesCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy);

                entity.HasOne(d => d.DocumentType)
                    .WithMany(p => p.CustomFreeFiledTables)
                    .HasForeignKey(d => d.DocumentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.CustomFreeFiledTablesModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy);
            });

            modelBuilder.Entity<CustomerAddresses>(entity =>
            {
                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.CustomerId);

                entity.HasIndex(e => e.ModifiedBy);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.CustomerAddressesCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerAddresses)
                    .HasForeignKey(d => d.CustomerId);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.CustomerAddressesModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy);
            });

            modelBuilder.Entity<CustomerFamilyInfomations>(entity =>
            {
                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.CustomerId);

                entity.HasIndex(e => e.IdOfOtherCustomer);

                entity.HasIndex(e => e.ModifiedBy);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddateOfBirthFamily).HasColumnName("ADDateOfBirthFamily");

                entity.Property(e => e.BsdateOfBirthFamily).HasColumnName("BSDateOfBirthFamily");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.CustomerFamilyInfomationsCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerFamilyInfomationsCustomer)
                    .HasForeignKey(d => d.CustomerId);

                entity.HasOne(d => d.IdOfOtherCustomerNavigation)
                    .WithMany(p => p.CustomerFamilyInfomationsIdOfOtherCustomerNavigation)
                    .HasForeignKey(d => d.IdOfOtherCustomer);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.CustomerFamilyInfomationsModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy);
            });

            modelBuilder.Entity<CustomerPhysicalInformations>(entity =>
            {
                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.CustomerId);

                entity.HasIndex(e => e.ModifiedBy);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.CustomerPhysicalInformationsCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerPhysicalInformations)
                    .HasForeignKey(d => d.CustomerId);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.CustomerPhysicalInformationsModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy);
            });

            modelBuilder.Entity<DocumentTypes>(entity =>
            {
                entity.HasIndex(e => e.CompanyCode);

                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.ModifiedBy);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.TableName).IsRequired();

                entity.HasOne(d => d.CompanyCodeNavigation)
                    .WithMany(p => p.DocumentTypes)
                    .HasForeignKey(d => d.CompanyCode)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.DocumentTypesCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.DocumentTypesModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy);
            });

            modelBuilder.Entity<DropdownManagements>(entity =>
            {
                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.ModifiedBy);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.DropdownManagementsCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.DropdownManagementsModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy);
            });

            modelBuilder.Entity<DynamicReports>(entity =>
            {
                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.ModifiedBy);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Query).IsRequired();

                entity.Property(e => e.ReportHeading).IsRequired();

                entity.Property(e => e.ReportName).IsRequired();

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.DynamicReportsCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.DynamicReportsModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy);
            });

            modelBuilder.Entity<EducationInformations>(entity =>
            {
                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.CustomerId);

                entity.HasIndex(e => e.ModifiedBy);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.EducationInformationsCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.EducationInformations)
                    .HasForeignKey(d => d.CustomerId);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.EducationInformationsModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy);
            });

            modelBuilder.Entity<Employees>(entity =>
            {
                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.ModifiedBy);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.EmployeesCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.EmployeesModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy);
            });

            modelBuilder.Entity<EnrollmentForm>(entity =>
            {
                entity.ToTable("Enrollment_Form");

                entity.Property(e => e.CourseCode)
                    .HasColumnName("Course_Code")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CurrentEngagement)
                    .HasColumnName("Current_Engagement")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EmergencyContactNo).HasColumnName("Emergency_Contact_No");

                entity.Property(e => e.EnrollmentCourseName)
                    .HasColumnName("Enrollment_Course_Name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IHaveReadAndAgreedTheTermsAndConditionsOfEnrollmentToTheInstitute).HasColumnName("I_have_read_and_agreed_the_terms_and_conditions_of_enrollment_to_the_institute");

                entity.Property(e => e.OfficialIdNo).HasColumnName("Official_Id_No");

                entity.Property(e => e.OfficialIdType).HasColumnName("Official_Id_Type");

                entity.Property(e => e.ParentsGuardianContactNumber)
                    .HasColumnName("Parents_Guardian_Contact_Number")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentOption)
                    .HasColumnName("Payment_Option")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FreeFieldDataLinkTables>(entity =>
            {
                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.DocumentTemplateId);

                entity.HasIndex(e => e.LeadNo);

                entity.HasIndex(e => e.ModifiedBy);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.FreeFieldDataLinkTablesCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy);

                entity.HasOne(d => d.DocumentTemplate)
                    .WithMany(p => p.FreeFieldDataLinkTables)
                    .HasForeignKey(d => d.DocumentTemplateId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.LeadNoNavigation)
                    .WithMany(p => p.FreeFieldDataLinkTables)
                    .HasForeignKey(d => d.LeadNo)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.FreeFieldDataLinkTablesModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy);
            });

            modelBuilder.Entity<FreeFieldLinkTables>(entity =>
            {
                entity.HasIndex(e => e.ActionId);

                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.DocumentTemplateId);

                entity.HasIndex(e => e.ModifiedBy);

                entity.HasIndex(e => e.ProcessId);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.HasOne(d => d.Action)
                    .WithMany(p => p.FreeFieldLinkTables)
                    .HasForeignKey(d => d.ActionId);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.FreeFieldLinkTablesCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy);

                entity.HasOne(d => d.DocumentTemplate)
                    .WithMany(p => p.FreeFieldLinkTables)
                    .HasForeignKey(d => d.DocumentTemplateId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.FreeFieldLinkTablesModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy);

                entity.HasOne(d => d.Process)
                    .WithMany(p => p.FreeFieldLinkTables)
                    .HasForeignKey(d => d.ProcessId);
            });

            modelBuilder.Entity<InboxMails>(entity =>
            {
                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.CustomerId);

                entity.HasIndex(e => e.LeadNo);

                entity.HasIndex(e => e.ModifiedBy);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.InboxMailsCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.InboxMails)
                    .HasForeignKey(d => d.CustomerId);

                entity.HasOne(d => d.LeadNoNavigation)
                    .WithMany(p => p.InboxMails)
                    .HasForeignKey(d => d.LeadNo);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.InboxMailsModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy);
            });

            modelBuilder.Entity<LeadEnquiry>(entity =>
            {
                entity.ToTable("LEAD_ENQUIRY");

                entity.Property(e => e.CollegeName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.GaurdianName)
                    .HasColumnName("Gaurdian_Name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.HighestQualification).HasColumnName("Highest_Qualification");

                entity.Property(e => e.ReferredBy)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LeadLastDetail>(entity =>
            {
                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.LastDate).HasColumnType("datetime");

                entity.Property(e => e.LastRemarks).HasColumnType("text");

                entity.Property(e => e.LeadCreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Status).HasMaxLength(50);
            });

            modelBuilder.Entity<LeadProductDetailMasters>(entity =>
            {
                entity.ToTable("leadProductDetailMasters");

                entity.HasIndex(e => e.ActionId);

                entity.HasIndex(e => e.AgentId);

                entity.HasIndex(e => e.BrandId);

                entity.HasIndex(e => e.CategoryId);

                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.LeadNo);

                entity.HasIndex(e => e.ModifiedBy);

                entity.HasIndex(e => e.ProcessId);

                entity.HasIndex(e => e.ProductId);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.HasOne(d => d.Action)
                    .WithMany(p => p.LeadProductDetailMasters)
                    .HasForeignKey(d => d.ActionId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Agent)
                    .WithMany(p => p.LeadProductDetailMasters)
                    .HasForeignKey(d => d.AgentId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.LeadProductDetailMasters)
                    .HasForeignKey(d => d.BrandId);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.LeadProductDetailMasters)
                    .HasForeignKey(d => d.CategoryId);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.LeadProductDetailMastersCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy);

                entity.HasOne(d => d.LeadNoNavigation)
                    .WithMany(p => p.LeadProductDetailMasters)
                    .HasForeignKey(d => d.LeadNo)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.LeadProductDetailMastersModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy);

                entity.HasOne(d => d.Process)
                    .WithMany(p => p.LeadProductDetailMasters)
                    .HasForeignKey(d => d.ProcessId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.LeadProductDetailMasters)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<LeadProductDetails>(entity =>
            {
                entity.HasIndex(e => e.BrandId);

                entity.HasIndex(e => e.CategoryId);

                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.LeadNo);

                entity.HasIndex(e => e.ModifiedBy);

                entity.HasIndex(e => e.ProductId);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.LeadProductDetails)
                    .HasForeignKey(d => d.BrandId);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.LeadProductDetails)
                    .HasForeignKey(d => d.CategoryId);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.LeadProductDetailsCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy);

                entity.HasOne(d => d.LeadNoNavigation)
                    .WithMany(p => p.LeadProductDetails)
                    .HasForeignKey(d => d.LeadNo)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.LeadProductDetailsModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.LeadProductDetails)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<LeadProductModelDetails>(entity =>
            {
                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.LeadNo);

                entity.HasIndex(e => e.ModifiedBy);

                entity.HasIndex(e => e.ProductModelId);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.LeadProductModelDetailsCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy);

                entity.HasOne(d => d.LeadNoNavigation)
                    .WithMany(p => p.LeadProductModelDetails)
                    .HasForeignKey(d => d.LeadNo)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.LeadProductModelDetailsModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy);

                entity.HasOne(d => d.ProductModel)
                    .WithMany(p => p.LeadProductModelDetails)
                    .HasForeignKey(d => d.ProductModelId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Log>(entity =>
            {
                entity.Property(e => e.Level).HasMaxLength(128);

                entity.Property(e => e.Properties).HasColumnType("xml");
            });

            modelBuilder.Entity<MailSetups>(entity =>
            {
                entity.HasIndex(e => e.CompanyCode);

                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.ModifiedBy);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IncommingHostName).IsRequired();

                entity.Property(e => e.OutgoingHostName).IsRequired();

                entity.HasOne(d => d.CompanyCodeNavigation)
                    .WithMany(p => p.MailSetups)
                    .HasForeignKey(d => d.CompanyCode)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.MailSetupsCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.MailSetupsModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy);
            });

            modelBuilder.Entity<Notifications>(entity =>
            {
                entity.HasIndex(e => e.AgentId);

                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.FromUserId);

                entity.HasIndex(e => e.ModifiedBy);

                entity.HasIndex(e => e.ToUserId);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.Agent)
                    .WithMany(p => p.Notifications)
                    .HasForeignKey(d => d.AgentId);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.NotificationsCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy);

                entity.HasOne(d => d.FromUser)
                    .WithMany(p => p.NotificationsFromUser)
                    .HasForeignKey(d => d.FromUserId);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.NotificationsModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy);

                entity.HasOne(d => d.ToUser)
                    .WithMany(p => p.NotificationsToUser)
                    .HasForeignKey(d => d.ToUserId);
            });

            modelBuilder.Entity<PreferenceSetups>(entity =>
            {
                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.ModifiedBy);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PreferenceSetupsCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.PreferenceSetupsModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy);
            });

            modelBuilder.Entity<Prefixes>(entity =>
            {
                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.ModifiedBy);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.PrefixesCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.PrefixesModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy);
            });

            modelBuilder.Entity<PreviousItcourses>(entity =>
            {
                entity.ToTable("PreviousITCourses");

                entity.Property(e => e.CourseName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.InstituteName)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProfessionalInformations>(entity =>
            {
                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.CustomerCompanyId);

                entity.HasIndex(e => e.CustomerId);

                entity.HasIndex(e => e.ModifiedBy);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.ProfessionalInformationsCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy);

                entity.HasOne(d => d.CustomerCompany)
                    .WithMany(p => p.ProfessionalInformations)
                    .HasForeignKey(d => d.CustomerCompanyId);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.ProfessionalInformations)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.ProfessionalInformationsModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy);
            });

            modelBuilder.Entity<RatingSetups>(entity =>
            {
                entity.HasIndex(e => e.CompanyCode);

                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.ModifiedBy);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.RatingName).IsRequired();

                entity.HasOne(d => d.CompanyCodeNavigation)
                    .WithMany(p => p.RatingSetups)
                    .HasForeignKey(d => d.CompanyCode)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.RatingSetupsCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.RatingSetupsModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy);
            });

            modelBuilder.Entity<RoleDetails>(entity =>
            {
                entity.HasIndex(e => e.RoleId);

                entity.HasIndex(e => e.TaskActionId);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.RoleDetails)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.TaskAction)
                    .WithMany(p => p.RoleDetails)
                    .HasForeignKey(d => d.TaskActionId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<SentMails>(entity =>
            {
                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.CustomerId);

                entity.HasIndex(e => e.LeadNo);

                entity.HasIndex(e => e.ModifiedBy);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.SentMailsCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.SentMails)
                    .HasForeignKey(d => d.CustomerId);

                entity.HasOne(d => d.LeadNoNavigation)
                    .WithMany(p => p.SentMails)
                    .HasForeignKey(d => d.LeadNo);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.SentMailsModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy);
            });

            modelBuilder.Entity<SocialWebRecords>(entity =>
            {
                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.ModifiedBy);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.SocialWebRecordsCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.SocialWebRecordsModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy);
            });

            modelBuilder.Entity<SocioDemographicInformations>(entity =>
            {
                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.CustomerId);

                entity.HasIndex(e => e.ModifiedBy);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.SocioDemographicInformationsCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.SocioDemographicInformations)
                    .HasForeignKey(d => d.CustomerId);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.SocioDemographicInformationsModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy);
            });

            modelBuilder.Entity<Suffixes>(entity =>
            {
                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.ModifiedBy);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.SuffixesCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.SuffixesModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy);
            });

            modelBuilder.Entity<TaModes>(entity =>
            {
                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.ModifiedBy);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.TaModesCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.TaModesModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy);
            });

            modelBuilder.Entity<TaskActions>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ActionName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<Tests>(entity =>
            {
                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.ModifiedBy);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.TestsCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.TestsModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy);
            });

            modelBuilder.Entity<UserMailCredentials>(entity =>
            {
                entity.HasIndex(e => e.CreatedBy);

                entity.HasIndex(e => e.ModifiedBy);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Email).IsRequired();

                entity.Property(e => e.Password).IsRequired();

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.UserMailCredentialsCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy);

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.UserMailCredentialsModifiedByNavigation)
                    .HasForeignKey(d => d.ModifiedBy);
            });

            modelBuilder.Entity<DashboardLinkedElements>(entity =>
            {
                entity.ToTable("DashboardLinkedElements");

                entity.Property(e => e.Id).HasColumnName("Id");

                entity.Property(e => e.DashboardId).HasColumnName("DashboardId");

                entity.Property(e => e.ElementId).HasColumnName("ElementId");

                entity.Property(e => e.Placement)
                    .IsRequired()
                    .HasMaxLength(55)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DashboardsInfo>(entity =>
            {
                entity.ToTable("Dashboards_Info");

                entity.Property(e => e.Id).HasColumnName("Id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TemplateId).HasColumnName("TemplateId");
            });

            modelBuilder.Entity<Elements>(entity =>
            {
                entity.ToTable("Elements");

                entity.Property(e => e.Id).HasColumnName("Id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Templates>(entity =>
            {
                entity.ToTable("Templates");

                entity.Property(e => e.Id).HasColumnName("Id");

                entity.Property(e => e.ElementsCount).HasColumnName("ElementsCount");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });
        }
    }
}
