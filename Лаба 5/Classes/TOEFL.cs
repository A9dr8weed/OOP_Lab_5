using System;

namespace Лаба_5.Classes
{
    internal class TOEFL : IDateAndCopy
    {
        public string Name { get; set; }
        public int Grade { get; set; }
        public DateTime Occured { get; set; }

        public TOEFL(string name, int grade, DateTime occured)
        {
            Name = name;
            Grade = grade;
            Occured = occured;
        }

        public TOEFL()
        {
            Name = "Defolt";
            Grade = 0;
            Occured = new DateTime(0000, 00, 00);
        }

        public override string ToString() => $"\nStudent passed an exam {Name} for a grade {Grade}.\nOccured = {Occured.ToShortDateString()}";

        public object DeepCopy() => new TOEFL(Name, Grade, Occured);

        DateTime IDateAndCopy.Date
        {
            get => Occured;
            set => Occured = value;
        }
    }
}