namespace NewDBModels.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    public partial class Course_CourseTag_Mapping
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Course_Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseTag_Id { get; set; }

        [Key]
        [Column(Order = 2)]
        public int Id { get; set; }

        public virtual Course Course { get; set; }

        public virtual CourseTag CourseTag { get; set; }
    }
}
