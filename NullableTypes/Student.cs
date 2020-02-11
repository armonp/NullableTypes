using System;
using System.Collections.Generic;
using System.Text;

namespace NullableTypes {
    class Student {
        public int Id { get; set; }
        public string Name { get; set; }
        public double GPA { get; set; }
        public int? SAT { get; set; }
        //foriegn key from majors, nullable
        public int? MajorId { get; set; }
        public Major? Major { get; set; }

        private static int nextID = 0;
        public Student() {
            this.Id = nextID += 1;
        }
            public void Print() {
                Console.WriteLine($"[{Id} {Name} {GPA} {SAT} {Major}]");
   
            }



    }
}
