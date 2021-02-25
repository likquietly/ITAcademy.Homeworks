using System;
using System.Collections.Generic;

namespace HW._07.Task2
{
    class StringComparer : IComparer<String>
    {
        /// <summary>
        /// Сomparator for comparing strings by length
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public int Compare(String p1, String p2)
        {
            if (p1.Length > p2.Length)
                return -1;
            else if (p1.Length < p2.Length)
                return 1;
            else
                return 0;
        }
    }
}