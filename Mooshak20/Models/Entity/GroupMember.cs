namespace Mooshak20.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GroupMember
    {
        public int ID { get; set; }

        public int AssignmentID { get; set; }

        [Required]
        [StringLength(128)]
        public string UserID { get; set; }

        public bool IsRemoved { get; set; }

        public virtual AspNetUser AspNetUser { get; set; }

        public virtual Assignment Assignment { get; set; }
    }
}
