namespace NewDBModels.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    public partial class CourseDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CourseDetail()
        {
            OnlineAttendances = new HashSet<OnlineAttendance>();
        }

        public int Id { get; set; }

        public int Course_Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [StringLength(200)]
        public string Duration { get; set; }

        [Required]
        [StringLength(200)]
        public string URL { get; set; }

        [StringLength(200)]
        public string Picture { get; set; }
        public string OnlineId { get; set; }

        public DateTime CreatedOnUtc { get; set; }

        public virtual Course Course { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OnlineAttendance> OnlineAttendances { get; set; }
    }
}
