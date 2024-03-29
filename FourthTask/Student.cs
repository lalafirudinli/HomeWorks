using System;
namespace StudentUtil
{
    public class Student

    {

        public string Name;
        public string SurName;
        public string Group;
        public double Point;
        public bool IsGraduated;

        public Student(string Name, string Surname, string Group, double Point, bool IsGraduated)
        {
            this.Name = Name;
            this.SurName = Surname;
            this.Group = Group;
            this.Point = Point;
            this.IsGraduated = IsGraduated;
        }

        public string GetFullName()
        {
            string student_info = this.Name + " " + this.SurName;
            return student_info;
        }

        public string GetFullInfo()
        {
            string is_graduated;

            if (IsGraduated)
            {
                is_graduated = " : Graduated";

            }
            else
            {
                is_graduated = " : Not graduated";
            }


            return GetFullName() + is_graduated;

        }
        public string Check_Point()
        {
            string exam;


            if (Point > 80)
            {
                exam = " : Can enter to exam ";
            }
            else
            {
                exam = " : Can not enter to exam";
            }
            return GetFullName() + exam;
        }



    }

}

