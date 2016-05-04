namespace Mooshak20.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Submission
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Submission()
        {
            ErrorReports = new HashSet<ErrorReport>();
            Testruns = new HashSet<Testrun>();
        }

        public int ID { get; set; }

        public int MilestoneID { get; set; }

        [Required]
        public byte[] Code { get; set; }

        public int TestCasePassed { get; set; }

        public bool IsRemoved { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ErrorReport> ErrorReports { get; set; }

        public virtual Milestone Milestone { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Testrun> Testruns { get; set; }
    }
}
