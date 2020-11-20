using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class DateModifier
    {
        private int difference;
        public int Difference
        {
            get
            { return difference; }
            set
            { difference = value; }
        }
        //1992 05 31
        public int GetDifference(string date1, string date2)
        {
            int[] dateElements1 = date1.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] dateElements2 = date2.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            DateTime dt1 = new DateTime(dateElements1[0], dateElements1[1], dateElements1[2]);
            DateTime dt2 = new DateTime(dateElements2[0], dateElements2[1], dateElements2[2]);
            return Math.Abs((int)((dt1 - dt2).TotalDays));
        }
    }
}
