using System;
using Лаба_5.Classes;

namespace Лаба_5
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            ManCollection MyCollection = new ManCollection();

            Man one = new Man(new Person("Andrew", "Matsuk", new DateTime(2001, 12, 3)), LevelsOfProficiency.A, 1);
            one.AddTOEFL(
                new TOEFL("C#", 100, new DateTime(2020, 02, 02)),
                new TOEFL("PHP", 98, new DateTime(2020, 04, 04))
                );
            MyCollection.AddMans(one);

            Man two = new Man(new Person("Roman", "Serediak", new DateTime(2002, 10, 19)), LevelsOfProficiency.C, 3);
            two.AddTOEFL(
                new TOEFL("C#", 2, new DateTime(2020, 02, 02)),
                new TOEFL("PHP", 2, new DateTime(2020, 04, 04))
                );
            MyCollection.AddMans(two);

            Man three = new Man(new Person("Vadym", "Samsonovych", new DateTime(2001, 10, 07)), LevelsOfProficiency.B, 2);
            three.AddTOEFL(
                new TOEFL("C#", 90, new DateTime(2020, 02, 02)),
                new TOEFL("PHP", 87, new DateTime(2020, 04, 04))
                );
            MyCollection.AddMans(three);

            Man four = new Man(new Person("Kate", "Zelenetska", new DateTime(2002, 05, 06)), LevelsOfProficiency.A, 4);
            four.AddTOEFL(
                new TOEFL("C#", 100, new DateTime(2020, 02, 02)),
                new TOEFL("PHP", 98, new DateTime(2020, 04, 04))
                );
            MyCollection.AddMans(four);

            /*foreach (Man item in MyCollection)
            {
                Console.WriteLine($"{item.ToShortString()};\n");
            }*/

            /*MyCollection.SortBySecondName();
            Console.WriteLine("\n\t\t\t\tSorted by second name\n");
            foreach (Man item in MyCollection)
            {
                Console.WriteLine($"{item.ToShortString()};\n");
            }*/

            /*MyCollection.SortByBirthday();
            Console.WriteLine("\n\t\t\t\tSorted by Birthday\n");
            foreach (Man item in MyCollection)
            {
                Console.WriteLine($"{item.ToShortString()};\n");
            }*/

            /*MyCollection.SortByAverageGrade();
            Console.WriteLine("\n\t\t\t\tSorted by Marks\n");
            foreach (Man item in MyCollection)
            {
                Console.WriteLine($"{item.ToShortString()};\n");
            }*/

            /*Console.WriteLine(MyCollection.MaxAverageMark.ToString());*/

            /*Console.WriteLine($"{MyCollection.AverageMarkGroup(1)}");*/

            /*Console.WriteLine("\n\t\t\tThe student who has qualification A\n");
            foreach (Man item in MyCollection.QualificationA)
            {
                Console.WriteLine($"{item.ToShortString()};\n");
            }*/

            TestCollections p = new TestCollections(100000);

            p.SearchTheElem(100001);
            p.SearchTheElem(100000);
            p.SearchTheElem(50000);
            p.SearchTheElem(1);
        }
    }
}