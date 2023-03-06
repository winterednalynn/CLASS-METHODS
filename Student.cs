using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace CLASS_METHODS
{
    //INTERNAL 
    //PUBLIC 
    //PRIVATE ; AUTO GENERATED IF NO ACCESS MODIFIER PROMPTS WHEN GENERATING A CLASS.
    //PROTECTED 
    public class Student
    {
        //FIELD, CONSTRUCTOR, PROPERTIES, METHOD 
        
        //FIELD 
        string _firstName;
        string _lastName;
        double _csiGrade;
        double _genEdGrade;

        //CONSTRUCTOR 
        public Student(string firstName, string lastName, double csiGrade, double genEdGrade)
        {
            _firstName = firstName;
            _lastName = lastName;
            _csiGrade = csiGrade;
            _genEdGrade = genEdGrade;
        }
        //PROPERTIES 
        public string FirstName
        {
            //GET & SET
            //GET = READ VALUE
            //SET = WRITE VALUE / CHANGE VALUE

            get
            { 
                return _firstName;
            }
            set
            {
                _firstName = value;
            }

        }
        public override string ToString()
        {
            return $"{this._firstName} {this._lastName} - CSI Grade: {this._csiGrade} - GenEd Grade: {this._genEdGrade} - student Average:  {studentAverage()}"; 
        }

        public double studentAverage()
        {
            return (_csiGrade + _genEdGrade) /2; 
        }

        public string LastName { get => _lastName; set => _lastName = value; }
        public double CsiGrade { get => _csiGrade; set => _csiGrade = value; }
        public double GenEdGrade { get => _genEdGrade; set => _genEdGrade = value; }
    }
 

    //runDisplay.Text = s.FirstName + " " + s.LastName + " " + "CSI GRADE: " + s.CsiGrade + " ," + "GenEd Grade: " + s.GenEdGrade; 
}
