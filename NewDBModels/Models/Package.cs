namespace NewDBModels.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("Package")]
    public partial class Package
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Package()
        {
            Course_Customer_Mapping = new HashSet<Course_Customer_Mapping>();
            Course_Instructor_Mapping = new HashSet<Course_Instructor_Mapping>();
            Course_Package_Mapping = new HashSet<Course_Package_Mapping>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(400)]
        public string Name { get; set; }

        public string ShortDescription { get; set; }

        public string FullDescription { get; set; }

        public bool ShowOnHomePage { get; set; }

        public bool DisableEnrollButton { get; set; }

        public bool DisableWishlistButton { get; set; }

        public decimal Price { get; set; }

        public decimal OldPrice { get; set; }

        public decimal CourseCost { get; set; }

        public int DisplayOrder { get; set; }

        public bool Published { get; set; }

        public bool Deleted { get; set; }

        public DateTime CreatedOnUtc { get; set; }

        public DateTime UpdatedOnUtc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Course_Customer_Mapping> Course_Customer_Mapping { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Course_Instructor_Mapping> Course_Instructor_Mapping { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Course_Package_Mapping> Course_Package_Mapping { get; set; }
    }
}
