namespace NewDBModels.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("CustomerInfo")]
    public partial class CustomerInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CustomerInfo()
        {
            Customer_Point_Mapping = new HashSet<Customer_Point_Mapping>();
            CustomerAttributes = new HashSet<CustomerAttribute>();
            CustomerTransactions = new HashSet<CustomerTransaction>();
            CustomerTransactions1 = new HashSet<CustomerTransaction>();
            PointProcesses = new HashSet<PointProcess>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(1000)]
        public string Username { get; set; }

        [StringLength(1000)]
        public string Email { get; set; }

        [StringLength(400)]
        public string NameEN { get; set; }
        [StringLength(400)]
        public string NameAR { get; set; }

       
        public string Mobile { get; set; }

       
        public string NationalId { get; set; }

        public int CustomerRoleId { get; set; }

        public string address { get; set; }

        public decimal balance { get; set; }

        public int? WorkZone { get; set; }

        [StringLength(200)]
        public string Gendar { get; set; }

        public int? CityId { get; set; }

        public DateTime CreatedOnUtc { get; set; }

        public DateTime UpdatedOnUtc { get; set; }

        public DateTime? LastLoginDateUtc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Customer_Point_Mapping> Customer_Point_Mapping { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerAttribute> CustomerAttributes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerTransaction> CustomerTransactions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerTransaction> CustomerTransactions1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PointProcess> PointProcesses { get; set; }
    }
}
