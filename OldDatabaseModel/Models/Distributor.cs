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
    
    public partial class Distributor
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string National_ID { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Photo { get; set; }
        public Nullable<int> ProductID { get; set; }
        public string Level_Status { get; set; }
        public Nullable<int> Upline_ID { get; set; }
        public string Upline_Join_Level { get; set; }
        public string Upline_History_ID { get; set; }
        public string Upline_History_Names { get; set; }
        public string Upline_Branch_Join_Level { get; set; }
        public Nullable<bool> Is_Active { get; set; }
        public Nullable<System.DateTime> Activation_Date { get; set; }
        public Nullable<int> Gov_ID { get; set; }
        public Nullable<int> City_ID { get; set; }
        public Nullable<int> Work_Zone { get; set; }
        public string Gender { get; set; }
        public string Referrer_ID { get; set; }
        public Nullable<int> Membership_Status_ID { get; set; }
        public Nullable<int> Country_ID { get; set; }
        public string Registration_Method { get; set; }
        public Nullable<bool> CanTransferAmount { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public string Guide_ID { get; set; }
        public string Street_Name { get; set; }
        public string Building_No { get; set; }
        public string Floor_No { get; set; }
        public string Flat_No { get; set; }
        public Nullable<int> Delegated_Dist_ID { get; set; }
        public string Master_Level { get; set; }
        public Nullable<int> Line_Number { get; set; }
        public string Hand_Side { get; set; }
        public string National_ID_Photo { get; set; }
        public Nullable<int> Account_Type { get; set; }
        public string Name_AR { get; set; }
        public string Renewal { get; set; }
    }
}
