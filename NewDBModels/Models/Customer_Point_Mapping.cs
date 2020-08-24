namespace NewDBModels.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    public partial class Customer_Point_Mapping
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public int PointProcessId { get; set; }

        public bool IsBooker { get; set; }

        public virtual CustomerInfo CustomerInfo { get; set; }

        public virtual PointProcess PointProcess { get; set; }
    }
}
