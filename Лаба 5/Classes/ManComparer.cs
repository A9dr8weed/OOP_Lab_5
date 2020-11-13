using System.Collections.Generic;

namespace Лаба_5.Classes
{
    internal class ManComparer : IComparer<Man>
    {
        public int Compare(Man x, Man y) => x.AverageMark.CompareTo(y.AverageMark);
    }
}