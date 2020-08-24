namespace NewDBModels.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    public partial class Customer_CustomerRole_Mapping
    {
        public int Customer_Id { get; set; }

        public int CustomerRoleId { get; set; }

        public int Id { get; set; }

        public virtual CustomerAttribute CustomerAttribute { get; set; }
    }
}
