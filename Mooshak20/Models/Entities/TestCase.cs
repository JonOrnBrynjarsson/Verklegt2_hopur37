namespace Mooshak20.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TestCases")]
    public partial class TestCase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TestCase()
        {
            Testruns = new HashSet<Testrun>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public string Inputstring { get; set; }

        public int MilestoneID { get; set; }

        public bool? IsOnlyForTeacher { get; set; }

        public bool IsRemoved { get; set; }

        public virtual Milestone Milestone { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Testrun> Testruns { get; set; }
    }
}
