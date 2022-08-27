using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDayOne.Models
{
    public class studentdept
    {
        public List<Student> students { get; set; }
        public List<Department> departments { get; set; }

    }
}