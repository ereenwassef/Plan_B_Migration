namespace NewDBModels.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    public partial class Course_Package_Mapping
    {
        public int Id { get; set; }

        public int CourseId { get; set; }

        public int PackageId { get; set; }

        public int DisplayOrder { get; set; }

        public virtual Course Course { get; set; }

        public virtual Package Package { get; set; }
    }
}
