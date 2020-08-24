namespace NewDBModels.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class NewDBModel : DbContext
    {
        public NewDBModel()
            : base("name=NewDBModel")
        {
        }

        public virtual DbSet<ActionType> ActionTypes { get; set; }
        public virtual DbSet<ActivityLog> ActivityLogs { get; set; }
        public virtual DbSet<ActivityLogType> ActivityLogTypes { get; set; }
        public virtual DbSet<Balance_Action_History> Balance_Action_History { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Course_Category_Mapping> Course_Category_Mapping { get; set; }
        public virtual DbSet<Course_Customer_Mapping> Course_Customer_Mapping { get; set; }
        public virtual DbSet<Course_Instructor_Mapping> Course_Instructor_Mapping { get; set; }
        public virtual DbSet<Course_Package_Mapping> Course_Package_Mapping { get; set; }
        public virtual DbSet<CourseDetail> CourseDetails { get; set; }
        public virtual DbSet<CourseLevel> CourseLevels { get; set; }
        public virtual DbSet<CourseTag> CourseTags { get; set; }
        public virtual DbSet<CourseType> CourseTypes { get; set; }
        public virtual DbSet<Customer_CustomerRole_Mapping> Customer_CustomerRole_Mapping { get; set; }
        public virtual DbSet<Customer_Point_Mapping> Customer_Point_Mapping { get; set; }
        public virtual DbSet<CustomerAttribute> CustomerAttributes { get; set; }
        public virtual DbSet<CustomerInfo> CustomerInfoes { get; set; }
        public virtual DbSet<CustomerNetwork> CustomerNetworks { get; set; }
        public virtual DbSet<CustomerPassword> CustomerPasswords { get; set; }
        public virtual DbSet<CustomerTransaction> CustomerTransactions { get; set; }
        public virtual DbSet<Governorate> Governorates { get; set; }
        public virtual DbSet<Instructor> Instructors { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<Log> Logs { get; set; }
        public virtual DbSet<OfflineAttendance> OfflineAttendances { get; set; }
        public virtual DbSet<OnlineAttendance> OnlineAttendances { get; set; }
        public virtual DbSet<Open_Course_history> Open_Course_history { get; set; }
        public virtual DbSet<Package> Packages { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<PointProcess> PointProcesses { get; set; }
        public virtual DbSet<RequestCash> RequestCashes { get; set; }
        public virtual DbSet<RequestType> RequestTypes { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TransactionType> TransactionTypes { get; set; }
        public virtual DbSet<Course_CourseTag_Mapping> Course_CourseTag_Mapping { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>()
                .Property(e => e.Price)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Course>()
                .Property(e => e.OldPrice)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Course>()
                .Property(e => e.CourseCost)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Course>()
                .Property(e => e.Requirement)
                .IsFixedLength();

            modelBuilder.Entity<Course>()
                .HasMany(e => e.CourseDetails)
                .WithRequired(e => e.Course)
                .HasForeignKey(e => e.Course_Id);

            modelBuilder.Entity<Course>()
                .HasMany(e => e.Course_CourseTag_Mapping)
                .WithRequired(e => e.Course)
                .HasForeignKey(e => e.Course_Id);

            modelBuilder.Entity<CourseDetail>()
                .HasMany(e => e.OnlineAttendances)
                .WithRequired(e => e.CourseDetail)
                .HasForeignKey(e => e.CourseDetailsId);

            modelBuilder.Entity<CourseLevel>()
                .HasMany(e => e.Courses)
                .WithOptional(e => e.CourseLevel)
                .HasForeignKey(e => e.LevelId)
                .WillCascadeOnDelete();

            modelBuilder.Entity<CourseTag>()
                .HasMany(e => e.Course_CourseTag_Mapping)
                .WithRequired(e => e.CourseTag)
                .HasForeignKey(e => e.CourseTag_Id);

            modelBuilder.Entity<CustomerAttribute>()
                .HasMany(e => e.ActivityLogs)
                .WithRequired(e => e.CustomerAttribute)
                .HasForeignKey(e => e.CustomerId);

            modelBuilder.Entity<CustomerAttribute>()
                .HasMany(e => e.Balance_Action_History)
                .WithRequired(e => e.CustomerAttribute)
                .HasForeignKey(e => e.CustomerId);

            modelBuilder.Entity<CustomerAttribute>()
                .HasMany(e => e.Course_Customer_Mapping)
                .WithRequired(e => e.CustomerAttribute)
                .HasForeignKey(e => e.CustomerId);

            modelBuilder.Entity<CustomerAttribute>()
                .HasMany(e => e.Customer_CustomerRole_Mapping)
                .WithRequired(e => e.CustomerAttribute)
                .HasForeignKey(e => e.Customer_Id);

            modelBuilder.Entity<CustomerAttribute>()
                .HasMany(e => e.OfflineAttendances)
                .WithRequired(e => e.CustomerAttribute)
                .HasForeignKey(e => e.CustomerId);

            modelBuilder.Entity<CustomerAttribute>()
                .HasMany(e => e.CustomerNetworks)
                .WithRequired(e => e.CustomerAttribute)
                .HasForeignKey(e => e.ParentId);

            modelBuilder.Entity<CustomerAttribute>()
                .HasMany(e => e.CustomerPasswords)
                .WithRequired(e => e.CustomerAttribute)
                .HasForeignKey(e => e.CustomerId);

            modelBuilder.Entity<CustomerAttribute>()
                .HasMany(e => e.RequestCashes)
                .WithRequired(e => e.CustomerAttribute)
                .HasForeignKey(e => e.CustomerId);

            modelBuilder.Entity<CustomerAttribute>()
                .HasMany(e => e.Logs)
                .WithOptional(e => e.CustomerAttribute)
                .HasForeignKey(e => e.CustomerId)
                .WillCascadeOnDelete();

            modelBuilder.Entity<CustomerAttribute>()
                .HasMany(e => e.OnlineAttendances)
                .WithRequired(e => e.CustomerAttribute)
                .HasForeignKey(e => e.CustomerId);

            modelBuilder.Entity<CustomerInfo>()
                .HasMany(e => e.Customer_Point_Mapping)
                .WithRequired(e => e.CustomerInfo)
                .HasForeignKey(e => e.CustomerId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CustomerInfo>()
                
                .HasMany(e => e.CustomerTransactions)
                .WithRequired(e => e.CustomerInfo)
                .HasForeignKey(e => e.CustomerId);

            modelBuilder.Entity<CustomerInfo>()
                .HasMany(e => e.CustomerTransactions1)
                .WithRequired(e => e.CustomerInfo1)
                .HasForeignKey(e => e.ActionBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CustomerInfo>()
                .HasMany(e => e.PointProcesses)
                .WithRequired(e => e.CustomerInfo)
                .HasForeignKey(e => e.ForCustomerId);

            modelBuilder.Entity<CustomerTransaction>()
                .Property(e => e.Amount)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CustomerTransaction>()
                .Property(e => e.BalanceBefore)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CustomerTransaction>()
                .Property(e => e.BalanceAfter)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Language>()
                .HasMany(e => e.Courses)
                .WithOptional(e => e.Language)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Open_Course_history>()
                .HasMany(e => e.OfflineAttendances)
                .WithRequired(e => e.Open_Course_history)
                .HasForeignKey(e => e.OpenCourseHistoryId);

            modelBuilder.Entity<Package>()
                .Property(e => e.Price)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Package>()
                .Property(e => e.OldPrice)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Package>()
                .Property(e => e.CourseCost)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Package>()
                .HasMany(e => e.Course_Instructor_Mapping)
                .WithRequired(e => e.Package)
                .HasForeignKey(e => e.InstructorId);

            modelBuilder.Entity<TransactionType>()
                .HasMany(e => e.CustomerTransactions)
                .WithRequired(e => e.TransactionType)
                .HasForeignKey(e => e.TractionTypeId);
        }
    }
}
