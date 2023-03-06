using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CLASS_METHODS
{ //EDNA LYNN LAXA 
  //CSI PROGRAMMING II 
  //FEBRUARY 27, 2023 
  //CLASS METHODS 

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    { 
        List<Student> students = new List<Student>();
        Course csi122 = new Course("CSI 122", "Will Cram");

        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void BtnAddStudent_Click(object sender, RoutedEventArgs e)
        {
            //DisplayStudent();
            AddStudent();

           
            int lastStudentEntered = students.Count - 1;
            Student lastStudent = students[lastStudentEntered];

            csi122.EnrollStudent(lastStudent);

            runDisplay.Text = ""; 
            runDisplay.Text = csi122.CourseName + " " + csi122.Teacher ;
            MessageBox.Show(csi122.RosterAverage().ToString());
            
            

            foreach (Student student in csi122.CourseRoster)
            {
                runDisplay.Text += student + "\n"; 
            }
            


            //runDisplay.Text = student.FirstName; 



            //Student s = students[0];

            // How do I display my student FROM my list 
            //runDisplay.Text = students[0].FirstName;

            //runDisplay.Text = s.FirstName + " " + s.LastName + " " + "CSI GRADE: " + s.CsiGrade + " ," + "GenEd Grade: " + s.GenEdGrade; 




        }
        public void AddStudent()
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            double csiGrade = double.Parse(txtCSIGrade.Text);
            double genEdGrade = double.Parse(txtGenEd.Text);

            Student student = new Student(firstName, lastName, csiGrade, genEdGrade);

            // Add student to my list of students 
            //students.Add(student);
            students.Add(new Student(firstName, lastName, csiGrade, genEdGrade));
        }
        public void DisplayStudent()
        {
            //Clears our display 
            runDisplay.Text = " "; 

            //Displays all our student 
            for (int i = 0; i < students.Count; i++)
            {
                runDisplay.Text += students[i] + "\n";
            }
        }

      
    }
}


//What is a method ?
 //ANSWER: A block of code that is given a name that you can run when called. 

//What is the purpose of a method?
 //ANSWER: The purpose of a method is to make code easy to code, read, refactor and reuse. 

//What is a class method?
 //ANSWER: A class method directly interacts with the members of a class 

//Review: What’s the name for any field, constructor, property or method that is part of a class?
  //ANSWER: MEMBER 

//Review: What are the 4 parts of declaring a method?
 //Access Modifier , Return Type , Name , Parameters 
 

//What keyword allows you to access members related to the specific instance?

//A method build inside a class has access to what, even it’s access modifier is set to private?

//What does “override .ToString()” allow us to do?
  //ANSWER: Override. ToString allows us to customize our string instead of the default? 
  //Override.ToString is structured in it's own method. 


//You use the *---- operator* do you use to access members inside of an instanced class?
  // USE DOT OPERATOR 


//Optional: 

//What is method overloading ?
  //ANSWER: Method overloading consist of multiple methods in a class with the same name but contains different parameters. 

//What needs to be different to overload a method?
  //ANSWER: The thing that needs to be different in overload method is the data type w/in the parameters or the order of those data types. 
  
