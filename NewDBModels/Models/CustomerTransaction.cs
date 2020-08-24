namespace NewDBModels.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("CustomerTransaction")]
    public partial class CustomerTransaction
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public decimal? Amount { get; set; }

        public decimal? BalanceBefore { get; set; }

        public decimal? BalanceAfter { get; set; }

        public int TractionTypeId { get; set; }

        public int ActionBy { get; set; }

        public DateTime CreatedOnUtc { get; set; }

        public virtual CustomerInfo CustomerInfo { get; set; }

        public virtual CustomerInfo CustomerInfo1 { get; set; }

        public virtual TransactionType TransactionType { get; set; }
    }
}
