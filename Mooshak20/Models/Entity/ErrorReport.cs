namespace Mooshak20.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ErrorReport
    {
        public int ID { get; set; }

        public DateTime DateOccurred { get; set; }

        [Required]
        [StringLength(128)]
        public string UserID { get; set; }

        public int? CourseID { get; set; }

        public int? AssignmentID { get; set; }

        public int? MilestoneID { get; set; }

        public int? SubmissionID { get; set; }

        public bool IsRemoved { get; set; }

        public virtual AspNetUser AspNetUser { get; set; }

        public virtual Assignment Assignment { get; set; }

        public virtual Cours Cours { get; set; }

        public virtual Submission Submission { get; set; }
    }
}
