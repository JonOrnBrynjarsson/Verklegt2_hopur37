namespace Mooshak20.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Testrun
    {
        public int ID { get; set; }

        public int TestCaseID { get; set; }

        public int SubmissionID { get; set; }

        public bool IsSuccess { get; set; }

        public string ResultComments { get; set; }

        public bool IsRemoved { get; set; }

        public virtual Submission Submission { get; set; }

        public virtual TestCas TestCas { get; set; }
    }
}
