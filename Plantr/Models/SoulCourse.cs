using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Plantr.Models
{
    public class SoulCourse
    {
        public IEnumerable<Soul> Souls { get; set; }
        public IEnumerable<Course> Courses { get; set; }
    }
}