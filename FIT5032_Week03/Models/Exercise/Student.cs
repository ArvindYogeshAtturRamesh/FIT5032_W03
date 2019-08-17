using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FIT5032_Week03.Models.Exercise
{
    public class Student
    {
        public String Name { get; set; }
        public String PhoneNumber { get; set; }

        public Student(String name, String phoneNumber)
        {
            Name = name;
            PhoneNumber = phoneNumber;
        }
    }

    public class ExampleDictionary
    {
        public void Example()
        {
            Dictionary<int, Student> studentDictionary = new Dictionary<int, Student>();
            Student studentOne = new Student("Arvind", "0415974649");
            Student studentTwo = new Student("Sundar", "0412568789");
            studentDictionary.Add(1, studentOne);
            studentDictionary.Add(2, studentTwo);

            Student result = new Student("","");
            studentDictionary.TryGetValue(1, out result);

        }
    }
}