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
    
    public partial class Distributor_Diploma_Referrer_Gold
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public Nullable<int> Gov_ID { get; set; }
        public Nullable<int> City_ID { get; set; }
        public string National_ID { get; set; }
        public string Distributor_ID { get; set; }
        public string BirthDate { get; set; }
        public string Gender { get; set; }
        public Nullable<bool> Is_Registered_To_Diploma { get; set; }
        public Nullable<int> Diploma_ID { get; set; }
        public Nullable<bool> Is_Confirmed { get; set; }
    }
}
