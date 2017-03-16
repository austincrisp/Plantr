using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Plantr.Models
{
    public class Course
    {
        public int Id { get; set; }

        // Course List
        public string Title { get; set; }
        public string Description { get; set; }
        public string Question { get; set; }
        public string AvgCompTime { get; set; }

        public virtual Soul Soul { get; set; }
    }
}