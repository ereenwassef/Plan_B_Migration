namespace NewDBModels.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("ActivityLog")]
    public partial class ActivityLog
    {
        public int Id { get; set; }

        public int ActivityLogTypeId { get; set; }

        public int CustomerId { get; set; }

        [Required]
        public string Comment { get; set; }

        public DateTime CreatedOnUtc { get; set; }

        [StringLength(200)]
        public string IpAddress { get; set; }

        public virtual ActivityLogType ActivityLogType { get; set; }

        public virtual CustomerAttribute CustomerAttribute { get; set; }
    }
}
