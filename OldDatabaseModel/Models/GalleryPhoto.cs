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
    
    public partial class GalleryPhoto
    {
        public int ID { get; set; }
        public string Photo_Path { get; set; }
        public Nullable<int> GalleryListID { get; set; }
        public string Photo_Text { get; set; }
        public string Title { get; set; }
        public string Photo_Path_Small { get; set; }
    }
}
