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
    
    public partial class NS_Payments
    {
        public int ID { get; set; }
        public string Transaction_ID { get; set; }
        public Nullable<int> NS_ID { get; set; }
        public Nullable<decimal> Paid_Amount { get; set; }
        public Nullable<int> By_Admin_ID { get; set; }
        public Nullable<int> Payment_Method_ID { get; set; }
        public string Receipt_No { get; set; }
        public Nullable<System.DateTime> Payment_Date { get; set; }
        public Nullable<bool> Is_Closed { get; set; }
        public string Notes { get; set; }
    }
}
