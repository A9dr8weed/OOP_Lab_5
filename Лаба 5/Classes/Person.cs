using System;
using System.Collections.Generic;

namespace Лаба_5.Classes
{
    internal class Person : IDateAndCopy, IComparable, IComparer<Person>
    {
        protected string Name;
        protected string SecondName;
        protected DateTime BDate;

        public string PublicName
        {
            get => Name;
            set => Name = value;
        }

        public string PublicSecondName
        {
            get => SecondName;
            set => SecondName = value;
        }

        public DateTime PublicBDate
        {
            get => BDate;
            set => BDate = value;
        }

        public Person(string name, string secondName, DateTime bDate)
        {
            Name = name;
            SecondName = secondName;
            BDate = bDate;
        }

        public Person()
        {
            Name = "Name";
            SecondName = "Second Name";
            BDate = DateTime.Now;
        }

        public int GetSetBDate
        {
            get => BDate.Year;
            set => BDate = new DateTime(value, BDate.Month, BDate.Day);
        }

        public override string ToString() => $"{PublicName} {PublicSecondName}\nDate of birth: {BDate.ToShortDateString()}";

        public string ToShortString() => $"\nName: {PublicName}\nSurname: {PublicSecondName}\n";

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            Person person = obj as Person; // повертає null якщо об'єкт не можна привести до типу Person

            return obj is Person && person.Name == Name && person.SecondName == SecondName && person.BDate == BDate;
        }

        public override int GetHashCode()
        {
            int hashcode = 0;

            foreach (char ch in Name)
            {
                hashcode += Convert.ToInt32(ch);
            }

            foreach (char ch in SecondName)
            {
                hashcode += Convert.ToInt32(ch);
            }
            hashcode += BDate.Year * BDate.Month;

            return hashcode;
        }

        public static bool operator ==(Person leftObj, Person rightObj) => ReferenceEquals(leftObj, rightObj) || (!(leftObj is null) && !(rightObj is null) && leftObj.Name == rightObj.Name && leftObj.BDate == rightObj.BDate && leftObj.SecondName == rightObj.SecondName);

        public static bool operator !=(Person leftObj, Person rightObj) => !(leftObj == rightObj);

        public virtual object DeepCopy() => new Person(Name, SecondName, BDate);

        public int CompareTo(object obj) => !(obj is Person tmp) ? throw new ArgumentException("Wrong type!") : SecondName.CompareTo(tmp.SecondName);

        public int Compare(Person x, Person y) => x.BDate.CompareTo(y.BDate);

        DateTime IDateAndCopy.Date { get; set; }
    }

    internal enum LevelsOfProficiency { A, B, C }
}