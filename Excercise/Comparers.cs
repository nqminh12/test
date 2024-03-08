﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise
{
    internal class IdComparers : IComparer<Course>
    {
        public int Compare(Course c1, Course c2)
        {
            return c1.Id.CompareTo(c2.Id);
        }
    }

    internal class StartDateComparers : IComparer<Course>
    {
        public int Compare(Course c1, Course c2)
        {
            return c1.StartDate.CompareTo(c2.StartDate);
        }
    }
}
