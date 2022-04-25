using System;

namespace пр16_17
{
    public class Student
    {
        private String name;
        public Student(String name)
        { this.name = name; }

        public override String ToString()
        {
            return name;
        }
    }
}
