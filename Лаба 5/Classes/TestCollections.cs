using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Лаба_5.Classes
{
    internal class TestCollections : IEnumerable
    {
        private List<Person> PersonList { get; } = new List<Person>();
        private List<string> StringList { get; } = new List<string>();
        private Dictionary<Person, Man> PersonManDictionary { get; } = new Dictionary<Person, Man>();
        private Dictionary<string, Man> StringManDictionary { get; } = new Dictionary<string, Man>();

        public static Man GenerateElement(int value)
        {
            return new Man(new Person($"\nPerson {value},", $"Person {value}", DateTime.Now), LevelsOfProficiency.A, value);
        }

        public TestCollections(int count)
        {
            Console.WriteLine($"\t\t\tCollection has {count} elements\n");
            
            for (int i = 1; i <= count; i++)
            {
                Man man = GenerateElement(i);
                PersonList.Add(new Person($"PersonList {i},", $"PersonList {i}", DateTime.Today));
                StringList.Add($"String {i}");
                PersonManDictionary.Add(new Person($"\nPersonManDictionary {i},", $"PersonManDictionary {i}", DateTime.Today), man);
                StringManDictionary.Add($"\nStringManDictionary {i}", man);
            }
        }

        public IEnumerator GetEnumerator()
        {
            Console.WriteLine("\t\t\t\tPerson List\n");
            foreach (Person item in PersonList)
            {
                yield return $"{item}\n";
            }

            Console.WriteLine("\t\t\t\tString List\n");
            foreach (string item in StringList)
            {
                yield return $"{item}\n";
            }

            Console.WriteLine("\t\t\t\tPerson Man Dictionary\n");
            foreach (KeyValuePair<Person, Man> item in PersonManDictionary)
            {
                yield return $"{item}\n";
            }

            Console.WriteLine("\t\t\t\tString Man Dictionary\n");
            foreach (KeyValuePair<string, Man> item in StringManDictionary)
            {
                yield return $"{item}\n";
            }
        }

        public void SearchTheElem(int position)
        {
            Stopwatch time = new Stopwatch();
            Stopwatch time1 = new Stopwatch();
            Stopwatch time2 = new Stopwatch();
            Stopwatch time3 = new Stopwatch();
            Stopwatch time4 = new Stopwatch();
            Stopwatch time5 = new Stopwatch();

            if (position > PersonList.Count || position > StringList.Count || position > PersonManDictionary.Count || position > StringManDictionary.Count)
            {
                time.Start();
                PersonList.Contains(new Person($"PersonList {position},", $"PersonList {position}", DateTime.Today));
                Console.WriteLine($"The item is not included in the collection.\nIn PersonList is {position} element, time: {time.Elapsed}\n");
                time.Stop();

                time1.Start();
                StringList.Contains($"String {position}");
                Console.WriteLine($"The item is not included in the collection.\nIn StringList is {position} element, time: {time1.Elapsed}\n");
                time1.Stop();

                time2.Start();
                PersonManDictionary.ContainsKey(new Person($"PersonManDictionary {position},", $"PersonManDictionary {position}", DateTime.Today));
                Console.WriteLine($"The item is not included in the collection.\nIn PersonManDictionary is {position} element, time: {time2.Elapsed}\n");
                time2.Stop();

                time3.Start();
                PersonManDictionary.ContainsValue(new Man(new Person($"\nPerson {position},", $"Person {position}", DateTime.Now), LevelsOfProficiency.A, position));
                Console.WriteLine($"The item is not included in the collection.\nIn PersonManDictionary is {position} element, time: {time3.Elapsed}\n");
                time3.Stop();

                time4.Start();
                StringManDictionary.ContainsKey($"StringManDictionary {position}");
                Console.WriteLine($"The item is not included in the collection.\nIn StringManDictionary is {position} element, time: {time4.Elapsed}\n");
                time4.Stop();

                time5.Start();
                StringManDictionary.ContainsValue(new Man(new Person($"\nPerson {position},", $"Person {position}", DateTime.Now), LevelsOfProficiency.A, position));
                Console.WriteLine($"The item is not included in the collection.\nIn StringManDictionary is {position} element, time: {time5.Elapsed}\n");
                time5.Stop();
            }
            else if (position == PersonList.Count || position == StringList.Count || position == PersonManDictionary.Count || position == StringManDictionary.Count)
            {
                time.Start();
                PersonList.Contains(new Person($"PersonList {position},", $"PersonList {position}", DateTime.Today));
                Console.WriteLine($"The last element of the collection.\nIn PersonList is {position} element, time: {time.Elapsed}\n");
                time.Stop();

                time1.Start();
                StringList.Contains($"String {position}");
                Console.WriteLine($"The last element of the collection.\nIn StringList is {position} element, time: {time1.Elapsed}\n");
                time1.Stop();

                time2.Start();
                PersonManDictionary.ContainsKey(new Person($"PersonManDictionary {position},", $"PersonManDictionary {position}", DateTime.Today));
                Console.WriteLine($"The last element of the collection.\nIn PersonManDictionary is {position} element, time: {time2.Elapsed}\n");
                time2.Stop();

                time3.Start();
                PersonManDictionary.ContainsValue(new Man(new Person($"\nPerson {position},", $"Person {position}", DateTime.Now), LevelsOfProficiency.A, position));
                Console.WriteLine($"The last element of the collection.\nIn PersonManDictionary is {position} element, time: {time3.Elapsed}\n");
                time3.Stop();

                time4.Start();
                StringManDictionary.ContainsKey($"StringManDictionary {position}");
                Console.WriteLine($"The last element of the collection.\nIn StringManDictionary is {position} element, time: {time4.Elapsed}\n");
                time4.Stop();

                time5.Start();
                StringManDictionary.ContainsValue(new Man(new Person($"\nPerson {position},", $"Person {position}", DateTime.Now), LevelsOfProficiency.A, position));
                Console.WriteLine($"The last element of the collection.\nIn StringManDictionary is {position} element, time: {time5.Elapsed}\n");
                time5.Stop();
            }
            else if (position == PersonList.Count / 2 || position == StringList.Count / 2 || position == PersonManDictionary.Count / 2 || position == StringManDictionary.Count / 2)
            {
                time.Start();
                PersonList.Contains(new Person($"PersonList {position},", $"PersonList {position}", DateTime.Today));
                Console.WriteLine($"The item is in the middle of the collection.\nIn PersonList is {position} element, time: {time.Elapsed}\n");
                time.Stop();

                time1.Start();
                StringList.Contains($"String {position}");
                Console.WriteLine($"The item is in the middle of the collection.\nIn StringList is {position} element, time: {time1.Elapsed}\n");
                time1.Stop();

                time2.Start();
                PersonManDictionary.ContainsKey(new Person($"PersonManDictionary {position},", $"PersonManDictionary {position}", DateTime.Today));
                Console.WriteLine($"The item is in the middle of the collection.\nIn PersonManDictionary is {position} element, time: {time2.Elapsed}\n");
                time2.Stop();

                time3.Start();
                PersonManDictionary.ContainsValue(new Man(new Person($"\nPerson {position},", $"Person {position}", DateTime.Now), LevelsOfProficiency.A, position));
                Console.WriteLine($"The item is in the middle of the collection.\nIn PersonManDictionary is {position} element, time: {time3.Elapsed}\n");
                time3.Stop();

                time4.Start();
                StringManDictionary.ContainsKey($"StringManDictionary {position}");
                Console.WriteLine($"The item is in the middle of the collection.\nIn StringManDictionary is {position} element, time: {time4.Elapsed}\n");
                time4.Stop();

                time5.Start();
                StringManDictionary.ContainsValue(new Man(new Person($"\nPerson {position},", $"Person {position}", DateTime.Now), LevelsOfProficiency.A, position));
                Console.WriteLine($"The item is in the middle of the collection.\nIn StringManDictionary is {position} element, time: {time5.Elapsed}\n");
                time5.Stop();
            }
            else
            {
                time.Start();
                PersonList.Contains(new Person($"PersonList {position},", $"PersonList {position}", DateTime.Today));
                Console.WriteLine($"The first element of the collection.\nIn PersonList is {position} element, time: {time.Elapsed}\n");
                time.Stop();

                time1.Start();
                StringList.Contains($"String {position}");
                Console.WriteLine($"The first element of the collection.\nIn StringList is {position} element, time: {time1.Elapsed}\n");
                time1.Stop();

                time2.Start();
                PersonManDictionary.ContainsKey(new Person($"PersonManDictionary {position},", $"PersonManDictionary {position}", DateTime.Today));
                Console.WriteLine($"The first element of the collection.\nIn PersonManDictionary is {position} element, time: {time2.Elapsed}\n");
                time2.Stop();

                time3.Start();
                PersonManDictionary.ContainsValue(new Man(new Person($"\nPerson {position},", $"Person {position}", DateTime.Now), LevelsOfProficiency.A, position));
                Console.WriteLine($"The first element of the collection.\nIn PersonManDictionary is {position} element, time: {time3.Elapsed}\n");
                time3.Stop();

                time4.Start();
                StringManDictionary.ContainsKey($"StringManDictionary {position}");
                Console.WriteLine($"The first element of the collection.\nIn StringManDictionary is {position} element, time: {time4.Elapsed}\n");
                time4.Stop();

                time5.Start();
                StringManDictionary.ContainsValue(new Man(new Person($"\nPerson {position},", $"Person {position}", DateTime.Now), LevelsOfProficiency.A, position));
                Console.WriteLine($"The first element of the collection.\nIn StringManDictionary is {position} element, time: {time5.Elapsed}\n");
                time5.Stop();
            }
        }
    }
}