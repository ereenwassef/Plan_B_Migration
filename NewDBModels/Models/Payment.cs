namespace NewDBModels.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("Payment")]
    public partial class Payment
    {
        public int Id { get; set; }

        [Required]
        [StringLength(400)]
        public string Name { get; set; }
    }
}
