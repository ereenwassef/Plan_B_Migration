namespace NewDBModels.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("PointProcess")]
    public partial class PointProcess
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PointProcess()
        {
            Customer_Point_Mapping = new HashSet<Customer_Point_Mapping>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int CourseId { get; set; }

        public int ForCustomerId { get; set; }

        public int SponserPoint { get; set; }

        public int BVPoint { get; set; }

        public DateTime CreatedOnUtc { get; set; }

        public virtual Course Course { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Customer_Point_Mapping> Customer_Point_Mapping { get; set; }

        public virtual CustomerInfo CustomerInfo { get; set; }
    }
}
