namespace NewDBModels.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    public partial class CustomerAttribute
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CustomerAttribute()
        {
            ActivityLogs = new HashSet<ActivityLog>();
            Balance_Action_History = new HashSet<Balance_Action_History>();
            Course_Customer_Mapping = new HashSet<Course_Customer_Mapping>();
            Customer_CustomerRole_Mapping = new HashSet<Customer_CustomerRole_Mapping>();
            OfflineAttendances = new HashSet<OfflineAttendance>();
            CustomerNetworks = new HashSet<CustomerNetwork>();
            CustomerPasswords = new HashSet<CustomerPassword>();
            RequestCashes = new HashSet<RequestCash>();
            Logs = new HashSet<Log>();
            OnlineAttendances = new HashSet<OnlineAttendance>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public bool Active { get; set; }

        public bool Deleted { get; set; }

        public DateTime CreatedOnUtc { get; set; }

        public DateTime? LastLoginDateUtc { get; set; }
        public DateTime? RenewalDateUtc { get; set; }
        public DateTime? ActualRenewalDateUtc { get; set; }

        [StringLength(20)]
        public string NationalId { get; set; }

        [StringLength(50)]
        public string ReferId { get; set; }

        public int? NumberChild { get; set; }

        public int? ChildAvalible { get; set; }

        public int? CustomerInfoId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActivityLog> ActivityLogs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Balance_Action_History> Balance_Action_History { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Course_Customer_Mapping> Course_Customer_Mapping { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Customer_CustomerRole_Mapping> Customer_CustomerRole_Mapping { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OfflineAttendance> OfflineAttendances { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerNetwork> CustomerNetworks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerPassword> CustomerPasswords { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RequestCash> RequestCashes { get; set; }

        public virtual CustomerInfo CustomerInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Log> Logs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OnlineAttendance> OnlineAttendances { get; set; }
    }
}
