using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS3343_Assignment2_Velazquez.John
{
    class Grade
    {
        private string grade;

        public string thisGrade
        {
            get{ return grade; }
            set{ grade = value; }
        }

        public string ConvertToLetter(int grade)
        {
            string letterGrade = "";

            if(grade >= 90)
            {
                letterGrade = "A";
            }
            else if(grade >= 80)
            {
                letterGrade = "B";
            }
            else if(grade >= 70)
            {
                letterGrade = "C";
            }
            else if(grade >= 60)
            {
                letterGrade = "D";
            }
            else
            {
                letterGrade = "F";
            }

            return letterGrade;
        }
    }
}
