namespace NewDBModels.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    public partial class Course_Category_Mapping
    {
        public int Id { get; set; }

        public int CourseId { get; set; }

        public int CategoryId { get; set; }

        public int DisplayOrder { get; set; }

        public virtual Category Category { get; set; }

        public virtual Course Course { get; set; }
    }
}
