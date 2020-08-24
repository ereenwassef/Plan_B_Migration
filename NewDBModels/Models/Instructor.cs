namespace NewDBModels.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("Instructor")]
    public partial class Instructor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Instructor()
        {
            Open_Course_history = new HashSet<Open_Course_history>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(400)]
        public string Name { get; set; }

        [StringLength(400)]
        public string Email { get; set; }

        public string Description { get; set; }

        public bool Active { get; set; }

        public bool Deleted { get; set; }

        public int DisplayOrder { get; set; }

        [StringLength(400)]
        public string Picture { get; set; }

        [StringLength(1000)]
        public string address { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Open_Course_history> Open_Course_history { get; set; }
    }
}
