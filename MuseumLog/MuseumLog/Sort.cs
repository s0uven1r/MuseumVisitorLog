using System;
using System.Collections.Generic;
using System.Globalization;

namespace MuseumLog
{
    public class Sort
    {
        /// <summary>
        /// ascending quick sort by intime using recusrion
        /// </summary>
        /// <param name = "list" ></ param >
        /// < returns ></ returns >
        public List<VisitorInfo> QuickSortByInTime(List<VisitorInfo> list)
        {
            if (list.Count <= 1)
            {
                return list;
            }

            Random random = new Random();
            List<VisitorInfo> less = new List<VisitorInfo>();
            List<VisitorInfo> greater = new List<VisitorInfo>();

            int pos = random.Next(list.Count);
            VisitorInfo pivot = list[pos];

            list.RemoveAt(pos);

            foreach (VisitorInfo item in list)
            {
                DateTime inTimeItem = DateTime.Parse(item.InTime);
                DateTime inTimePivot = DateTime.Parse(pivot.InTime);
                if (inTimeItem < inTimePivot)
                {
                    less.Add(item);
                }
                else
                {
                    greater.Add(item);
                }
            }
            return Concat(QuickSortByInTime(less), pivot, QuickSortByInTime(greater));
        }

        public List<VisitorInfo> Concat(List<VisitorInfo> less, VisitorInfo pivot, List<VisitorInfo> greater)
        {

            List<VisitorInfo> sorted = new List<VisitorInfo>(less);

            sorted.Add(pivot);

            foreach (VisitorInfo i in greater)
            {
                sorted.Add(i);

            }

            return sorted;
        }

        /// <summary>
        /// descending quick sort by total visitor using recusrion
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public List<WeeklyReport> QuickSortByTotalVisitor(List<WeeklyReport> list)
        {
            if (list.Count <= 1)
            {
                return list;
            }

            Random random = new Random();
            List<WeeklyReport> less = new List<WeeklyReport>();
            List<WeeklyReport> greater = new List<WeeklyReport>();

            int pos = random.Next(list.Count);
            WeeklyReport pivot = list[pos];

            list.RemoveAt(pos);

            foreach (WeeklyReport item in list)
            {
                int totalVisitor = item.TotalVisitor;
                int totalVisitorPivot = pivot.TotalVisitor;
                if (totalVisitor < totalVisitorPivot)
                {
                    less.Add(item);
                }
                else
                {
                    greater.Add(item);
                }
            }
            return ConcatWeekly(QuickSortByTotalVisitor(less), pivot, QuickSortByTotalVisitor(greater));
        }

        public List<WeeklyReport> ConcatWeekly(List<WeeklyReport> less, WeeklyReport pivot, List<WeeklyReport> greater)
        {

            List<WeeklyReport> sorted = new List<WeeklyReport>(greater);

            sorted.Add(pivot);

            foreach (WeeklyReport i in less)
            {
                sorted.Add(i);

            }

            return sorted;
        }

    }
}