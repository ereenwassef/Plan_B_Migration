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
    
    public partial class Event_Distributor_Relatives
    {
        public int ID { get; set; }
        public Nullable<int> Distributor_ID { get; set; }
        public string Relative_Name { get; set; }
        public string Relative_Rank { get; set; }
        public Nullable<System.DateTime> Request_Date { get; set; }
    }
}
