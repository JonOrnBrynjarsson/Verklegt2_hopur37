namespace Mooshak20.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserCourseRelation")]
    public partial class UserCourseRelation
    {
        public int ID { get; set; }

        public int CourseID { get; set; }

        [Required]
        [StringLength(128)]
        public string UserID { get; set; }

        [Required]
        [StringLength(128)]
        public string RoleID { get; set; }

        public bool IsRemoved { get; set; }

        public virtual AspNetRole AspNetRole { get; set; }

        public virtual AspNetUser AspNetUser { get; set; }

        public virtual Cours Cours { get; set; }
    }
}
