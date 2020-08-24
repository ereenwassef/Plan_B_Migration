namespace NewDBModels.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    [Table("Course")]
    public partial class Course
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Course()
        {
            Balance_Action_History = new HashSet<Balance_Action_History>();
            Course_Customer_Mapping = new HashSet<Course_Customer_Mapping>();
            CourseDetails = new HashSet<CourseDetail>();
            Course_CourseTag_Mapping = new HashSet<Course_CourseTag_Mapping>();
            Course_Category_Mapping = new HashSet<Course_Category_Mapping>();
            Course_Instructor_Mapping = new HashSet<Course_Instructor_Mapping>();
            Open_Course_history = new HashSet<Open_Course_history>();
            Course_Package_Mapping = new HashSet<Course_Package_Mapping>();
            PointProcesses = new HashSet<PointProcess>();
        }

        public int Id { get; set; }

        public int CourseTypeId { get; set; }

        [Required]
        [StringLength(400)]
        public string Name { get; set; }

        public string ShortDescription { get; set; }

        public string FullDescription { get; set; }

        public bool AllowCustomerReviews { get; set; }

        public bool DisableEnrollButton { get; set; }

        public bool DisableWishlistButton { get; set; }

        public decimal Price { get; set; }

        public decimal OldPrice { get; set; }

        public decimal CourseCost { get; set; }

        public int DisplayOrder { get; set; }

        public bool Published { get; set; }

        public bool Deleted { get; set; }

        public DateTime CreatedOnUtc { get; set; }

        public DateTime UpdatedOnUtc { get; set; }

        public int? CostPoint { get; set; }

        public int? ProfitPoint { get; set; }

        public int? SponsorPoint { get; set; }

        public int? ManagementPoint { get; set; }

        public int? ContractCost { get; set; }

        public int? TotalCost { get; set; }

        public int? SummitCoin { get; set; }

        public int? SummitPoint { get; set; }

        public int? NumberLecture { get; set; }

        public int? TotalHour { get; set; }

        [StringLength(400)]
        public string Requirement { get; set; }

        public int? LanguageId { get; set; }

        public int? LevelId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Balance_Action_History> Balance_Action_History { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Course_Customer_Mapping> Course_Customer_Mapping { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CourseDetail> CourseDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Course_CourseTag_Mapping> Course_CourseTag_Mapping { get; set; }

        public virtual Language Language { get; set; }

        public virtual CourseLevel CourseLevel { get; set; }

        public virtual CourseType CourseType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Course_Category_Mapping> Course_Category_Mapping { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Course_Instructor_Mapping> Course_Instructor_Mapping { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Open_Course_history> Open_Course_history { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Course_Package_Mapping> Course_Package_Mapping { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PointProcess> PointProcesses { get; set; }
    }
}
