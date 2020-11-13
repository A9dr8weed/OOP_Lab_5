using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Лаба_5.Classes
{
    internal class ManCollection : IEnumerable
    {
        private readonly List<Man> ListOfMan = new List<Man>();

        public void AddDefaults()
        {
            for (int i = 0; i < 3; i++)
            {
                ListOfMan.Add(new Man());
            }
        }

        public void AddMans(params Man[] additionalMan) => ListOfMan.AddRange(additionalMan);

        public override string ToString()
        {
            string manString = "";
            foreach (Man man in ListOfMan)
            {
                manString += man.ToString();
            }

            return manString;
        }

        public string ToShortString()
        {
            string manString = "";
            foreach (Man man in ListOfMan)
            {
                manString += man.ToShortString();
            }

            return manString;
        }

        public void SortBySecondName() => ListOfMan.Sort((x, y) => x.PublicPersonal.PublicSecondName.CompareTo(y.PublicPersonal.PublicSecondName));

        public void SortByBirthday() => ListOfMan.Sort((x, y) => new Person().Compare(x.PublicPersonal, y.PublicPersonal));

        public void SortByAverageGrade()
        {
            ListOfMan.Sort(new ManComparer());
        }

        public double MaxAverageMark => ListOfMan.Count == 0 ? 0 : ListOfMan.Max(marks => marks.AverageMark);

        public IEnumerable<Man> QualificationA => ListOfMan.Where(x => x.PublicQualification == LevelsOfProficiency.A);

        public List<Man> AverageMarkGroup(double value)
        {
            foreach (Man mark in ListOfMan.GroupBy(x => x.AverageMark).Where(x => x.Key == value).ToList().SelectMany(marks => marks))
            {
                Console.WriteLine($"{mark.ToShortString()};\n");
            }

            return null;
        }

        public IEnumerator GetEnumerator()
        {
            foreach (Man item in ListOfMan)
            {
                yield return item;
            }
        }
    }
}