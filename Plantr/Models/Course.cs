using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Plantr.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Sent { get; set; }
        public string Received { get; set; }
    }
}