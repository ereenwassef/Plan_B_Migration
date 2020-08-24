namespace NewDBModels.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("CustomerPassword")]
    public partial class CustomerPassword
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public string Password { get; set; }

        public DateTime CreatedOnUtc { get; set; }

        public virtual CustomerAttribute CustomerAttribute { get; set; }
    }
}
