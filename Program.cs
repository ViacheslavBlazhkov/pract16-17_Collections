using System;

namespace пр16_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Group cs_group = new Group();

            Student[] students = new Student[10];
            Random random = new Random();

            for (int i = 0; i < students.Length; i++)
                students[i] = new Student("Student#" + random.Next(25));

            // Заповнення колекцій
            for (int i = 0; i < students.Length; i++)
                cs_group.addToList(students[i]);
            for (int i = 0; i < students.Length; i++)
                cs_group.addToQueue(students[i]);
            for (int i = 0; i < students.Length; i++)
                cs_group.addToStack(students[i]);

            //Вивід на екран елементу з кожної колекції:
            Console.WriteLine("List:" + cs_group.getListElement(0));     //зі списку
            Console.WriteLine();
            Console.WriteLine("Queue:" + cs_group.getQueueElement(6));   //з черги
            Console.WriteLine();
            Console.WriteLine("Stack:" + cs_group.getStackElement(4));   //зі стеку
            Console.WriteLine();

            //Вивід на екран списку елементів кожної колекції
            Console.WriteLine("List:");
            cs_group.printStudentsList(); Console.WriteLine();

            Console.WriteLine("Queue:");
            cs_group.printStudentsQueue(); Console.WriteLine();

            Console.WriteLine("Stack:");
            cs_group.printStudentsStack(); Console.WriteLine();
        }
    }
}
