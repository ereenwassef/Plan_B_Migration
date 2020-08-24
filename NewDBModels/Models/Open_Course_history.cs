namespace NewDBModels.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    public partial class Open_Course_history
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Open_Course_history()
        {
            OfflineAttendances = new HashSet<OfflineAttendance>();
        }

        public int Id { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int InstructorId { get; set; }

        public int CourseId { get; set; }

        public int DisplayOrder { get; set; }

        public virtual Course Course { get; set; }

        public virtual Instructor Instructor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OfflineAttendance> OfflineAttendances { get; set; }
    }
}
