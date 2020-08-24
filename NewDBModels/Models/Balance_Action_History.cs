namespace NewDBModels.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    public partial class Balance_Action_History
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public int CourseId { get; set; }

        public int Amount { get; set; }

        public int ActionTypeId { get; set; }

        public int BalanceBefore { get; set; }

        public int BalanceAfter { get; set; }

        public int CustomerLoginId { get; set; }

        public virtual ActionType ActionType { get; set; }

        public virtual Course Course { get; set; }

        public virtual CustomerAttribute CustomerAttribute { get; set; }
    }
}
