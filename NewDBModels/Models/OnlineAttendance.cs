namespace NewDBModels.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("OnlineAttendance")]
    public partial class OnlineAttendance
    {
        public int Id { get; set; }

        public int CourseDetailsId { get; set; }

        public int CustomerId { get; set; }

        public virtual CourseDetail CourseDetail { get; set; }

        public virtual CustomerAttribute CustomerAttribute { get; set; }
    }
}
