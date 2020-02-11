using System;
using System.Collections.Generic;
using System.Text;

namespace NullableTypes {
    class Program {
        static void Main(string[] args) {
            var General_Studies = new Major { Description = "General Studies", MinSAT = 900 };
            var Computer_Science = new Major { Description = "Computer Science", MinSAT = 1350 };
            var English = new Major { Description = "English", MinSAT = 1100 };

            var student1 = new Student { Name = "Dave", GPA = 3.6, SAT = null, MajorId = null }; //not required to explicitly say 'null'
            var student2 = new Student { Name = "Steve", GPA = 3.0, SAT = null, MajorId = null };
            var student3 = new Student { Name = "Susie", GPA = 3.4, SAT = 1370, Major = English};
            var student4 = new Student { Name = "Brit", GPA = 3.1, SAT = 1500 , Major = English};

            student1.Print();
            student2.Print();
            student3.Print();
            student4.Print();
        }
        
        
    }


}
