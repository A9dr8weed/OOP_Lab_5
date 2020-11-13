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

            Man two = new Man(new Person("Roman", "Serediak", new DateTime(2002, 10, 19)), LevelsOfProficiency.C, 2);
            two.AddTOEFL(
                new TOEFL("C#", 2, new DateTime(2020, 02, 02)),
                new TOEFL("PHP", 2, new DateTime(2020, 04, 04))
                );
            MyCollection.AddMans(two);

            Man three = new Man(new Person("Vadym", "Samsonovych", new DateTime(2001, 10, 07)), LevelsOfProficiency.B, 3);
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

            string key;
            do
            {
                Console.WriteLine("1 - Show Collection");
                Console.WriteLine("2 - Sort By Second Name");
                Console.WriteLine("3 - Sort By Birthday");
                Console.WriteLine("4 - Sort By Average Grade");
                Console.WriteLine("5 - Max Average Mark");
                Console.WriteLine("6 - Average Mark Of Group");
                Console.WriteLine("7 - Student With Qualification A");
                Console.WriteLine("8 - Show Time Of Searching Elements In The Collections");
                Console.WriteLine("9 - Exit");

                key = Console.ReadLine();
                Console.Clear();

                switch (key)
                {
                    case "1":
                        {
                            foreach (Man item in MyCollection)
                            {
                                Console.WriteLine($"{item.ToShortString()};\n");
                            }

                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                    case "2":
                        {
                            MyCollection.SortBySecondName();
                            Console.WriteLine("\t\t\t\tSorted by second name\n");
                            foreach (Man item in MyCollection)
                            {
                                Console.WriteLine($"{item.ToShortString()};\n");
                            }

                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                    case "3":
                        {
                            MyCollection.SortByBirthday();
                            Console.WriteLine("\t\t\t\tSorted by Birthday\n");
                            foreach (Man item in MyCollection)
                            {
                                Console.WriteLine($"{item.ToShortString()};\n");
                            }

                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                    case "4":
                        {
                            MyCollection.SortByAverageGrade();
                            Console.WriteLine("\t\t\t\tSorted by Marks\n");
                            foreach (Man item in MyCollection)
                            {
                                Console.WriteLine($"{item.ToShortString()};\n");
                            }

                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                    case "5":
                        {
                            Console.WriteLine($"Max average mark is: {MyCollection.MaxAverageMark}");

                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                    case "6":
                        {
                            Console.WriteLine($"{MyCollection.AverageMarkGroup(9)}");

                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                    case "7":
                        {
                            Console.WriteLine("\t\t\tThe student who has qualification A\n");
                            foreach (Man item in MyCollection.QualificationA)
                            {
                                Console.WriteLine($"{item.ToShortString()};\n");
                            }

                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                    case "8":
                        {
                            string key1;
                            do
                            {
                                TestCollections testCollection = new TestCollections(20);
                                Console.WriteLine("1 - Search time for an item that is not part of the collection");
                                Console.WriteLine("2 - Search time for the last item in the collection");
                                Console.WriteLine("3 - search time of the middle element of the collection");
                                Console.WriteLine("4 - Search time for the first item in the collection");
                                Console.WriteLine("5 - Show all elements");
                                Console.WriteLine("6 - Exit");

                                key1 = Console.ReadLine();
                                Console.Clear();

                                switch (key1)
                                {
                                    case "1":
                                        {
                                            Console.WriteLine("\t\t\tThe item is not included in the collection.\n");
                                            testCollection.SearchTheElem(21);

                                            Console.ReadLine();
                                            Console.Clear();
                                            break;
                                        }
                                    case "2":
                                        {
                                            Console.WriteLine("\t\t\tThe last element of the collection.\n");
                                            testCollection.SearchTheElem(20);

                                            Console.ReadLine();
                                            Console.Clear();
                                            break;
                                        }
                                    case "3":
                                        {
                                            Console.WriteLine("\t\t\tThe item is in the middle of the collection.\n");
                                            testCollection.SearchTheElem(10);

                                            Console.ReadLine();
                                            Console.Clear();
                                            break;
                                        }
                                    case "4":
                                        {
                                            Console.WriteLine("\t\t\tThe first element of the collection.\n");
                                            testCollection.SearchTheElem(1);

                                            Console.ReadLine();
                                            Console.Clear();
                                            break;
                                        }
                                    case "5":
                                        {
                                            foreach (var item in testCollection)
                                            {
                                                Console.WriteLine(item);
                                            }

                                            Console.ReadLine();
                                            Console.Clear();
                                            break;
                                        }
                                    default:
                                        {
                                            Console.WriteLine("Something went wrong");

                                            Console.ReadLine();
                                            Console.Clear();
                                            break;
                                        }
                                }
                            } while (key1 != "6");
                            
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Something went wrong");

                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                }
            } while (key != "9");
        }
    }
}