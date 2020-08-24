namespace NewDBModels.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("CustomerNetwork")]
    public partial class CustomerNetwork
    {
        public int Id { get; set; }

        public int ParentId { get; set; }

        public int ChildId { get; set; }

        public int Profit { get; set; }

        public int Sponsor { get; set; }

        public bool Virtual { get; set; }

        [Required]
        [StringLength(100)]
        public string HandSide { get; set; }

        public DateTime Renewal { get; set; }

        public virtual CustomerAttribute CustomerAttribute { get; set; }
    }
}
