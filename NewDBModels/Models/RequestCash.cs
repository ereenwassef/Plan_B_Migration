namespace NewDBModels.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("RequestCash")]
    public partial class RequestCash
    {
        public int Id { get; set; }

        public int RequestTypeId { get; set; }

        public int CustomerId { get; set; }

        public bool Active { get; set; }

        public virtual CustomerAttribute CustomerAttribute { get; set; }

        public virtual RequestType RequestType { get; set; }
    }
}
