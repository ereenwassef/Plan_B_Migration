namespace NewDBModels.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("Log")]
    public partial class Log
    {
        public int Id { get; set; }

        public int LogLevelId { get; set; }

        [Required]
        public string ShortMessage { get; set; }

        public string FullMessage { get; set; }

        [StringLength(200)]
        public string IpAddress { get; set; }

        public int? CustomerId { get; set; }

        public string PageUrl { get; set; }

        public DateTime CreatedOnUtc { get; set; }

        public virtual CustomerAttribute CustomerAttribute { get; set; }
    }
}
