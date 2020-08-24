namespace NewDBModels.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("OfflineAttendance")]
    public partial class OfflineAttendance
    {
        public int Id { get; set; }

        public int OpenCourseHistoryId { get; set; }

        public int CustomerId { get; set; }

        public virtual CustomerAttribute CustomerAttribute { get; set; }

        public virtual Open_Course_history Open_Course_history { get; set; }
    }
}
