namespace NewDBModels.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("City")]
    public partial class City
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [StringLength(255)]
        public string NameAr { get; set; }

        [StringLength(255)]
        public string NameEn { get; set; }

        public int GovernorateId { get; set; }

        public virtual Governorate Governorate { get; set; }
    }
}
