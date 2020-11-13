namespace Лаба_5.Classes
{
    internal class Test
    {
        public string SubjectName { get; set; }
        public bool Passed { get; set; }

        public Test(string subjectName, bool passed)
        {
            SubjectName = subjectName;
            Passed = passed;
        }

        public Test() : this("", true)
        {
        }

        public override string ToString() => $"{SubjectName} is {Passed}";
    }
}