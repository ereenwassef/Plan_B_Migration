//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OldDatabaseModel.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Profit
    {
        public int ID { get; set; }
        public Nullable<int> Distributor_ID { get; set; }
        public Nullable<decimal> Profit1 { get; set; }
        public Nullable<decimal> Percentage { get; set; }
        public Nullable<System.DateTime> Profit_Date { get; set; }
        public Nullable<int> From_Distributor_ID { get; set; }
        public Nullable<bool> Is_Paid { get; set; }
        public Nullable<int> Paid_By { get; set; }
        public Nullable<bool> Is_Offer { get; set; }
        public Nullable<System.DateTime> Payment_Date { get; set; }
        public Nullable<bool> Is_Upgrade { get; set; }
        public string Point_Type { get; set; }
    }
}
