using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Лаба_5.Classes
{
    internal class Man : Person, IDateAndCopy
    {
        private Person Personal;
        public Person PublicPersonal { get => Personal; set => Personal = value; }

        private LevelsOfProficiency Qualification;
        public LevelsOfProficiency PublicQualification { get => Qualification; set => Qualification = value; }

        private int ID;
        public int PublicID { get => ID; set => ID = value; }

        private List<Test> ListOfTest;
        public List<Test> PublicListOfTest { get => ListOfTest; set => ListOfTest = value; }

        private List<TOEFL> ListOfExam;
        public List<TOEFL> PublicListOfExam { get => ListOfExam; set => ListOfExam = value; }

        public Man(Person personInfo, LevelsOfProficiency qualification, int id)
        {
            Personal = personInfo;
            Qualification = qualification;
            ID = id;
            ListOfExam = new List<TOEFL>();
            ListOfTest = new List<Test>();
        }

        public Man()
        {
            Personal = new Person();
            Qualification = LevelsOfProficiency.A;
            ID = 0;
        }

        public int GroupNumber
        {
            get => ID;
            set
            {
                if (value <= 100 || value > 599)
                {
                    throw new ArgumentOutOfRangeException("Error! GroupNumber out of range(100, 599).");
                }

                ID = value;
            }
        }

        public double AverageMark
        {
            get
            {
                int sum = 0;

                if (ListOfExam == null)
                {
                    return 0;
                }

                foreach (TOEFL exam in ListOfExam)
                {
                    sum += exam.Grade;
                }

                return (double)sum / ListOfExam.Count;
            }
        }

        public bool this[LevelsOfProficiency ed] => Qualification == ed;

        public void AddTOEFL(params TOEFL[] exams) => ListOfExam.AddRange(exams);

        public void AddTest(params Test[] tests) => ListOfTest.AddRange(tests);

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat($"{PublicPersonal}, {Qualification}, {ID}");

            foreach (TOEFL exam in ListOfExam)
            {
                sb.AppendLine(exam.ToString());
            }

            foreach (Test test in ListOfTest)
            {
                sb.AppendLine(test.ToString());
            }

            return sb.ToString();
        }

        public new string ToShortString() => $"{PublicPersonal}, {PublicQualification}, ID = {PublicID}, AVG Grade = {AverageMark}";

        public new object DeepCopy()
        {
            Man stud = new Man(Personal, Qualification, ID);

            foreach (TOEFL exam in ListOfExam)
            {
                stud.AddTOEFL(exam);
            }

            foreach (Test test in ListOfTest)
            {
                stud.AddTest(test);
            }

            return stud;
        }

        public IEnumerable GetResults()
        {
            foreach (TOEFL exam in ListOfExam)
            {
                yield return exam;
            }

            foreach (Test test in ListOfTest)
            {
                yield return test;
            }
        }

        public IEnumerable ExamsOver(int minRate)
        {
            foreach (TOEFL exam in ListOfExam)
            {
                TOEFL toefl = exam;

                if (toefl.Grade > minRate)
                {
                    yield return exam;
                }
            }
        }
    }
}