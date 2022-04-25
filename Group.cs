using System;
using System.Collections.Generic;

namespace пр16_17
{
    public class Group
    {
        private List<Student> list;
        private Queue<Student> queue;
        private Stack<Student> stack;

        public Group()
        {
            list = new List<Student>();
            queue = new Queue<Student>();
            stack = new Stack<Student>();
        }

        // СПИСОК
        public void addToList(Student student)
        {
            list.Add(student);
        }
        public void printStudentsList()
        {
            foreach (Student st in list)
                Console.WriteLine(st);
        }
        public Student getListElement(int index)
        {
            return list[index];
        }

        // ЧЕРГА
        public void addToQueue(Student student)
        {
            queue.Enqueue(student);
        }
        public void printStudentsQueue()
        {
            foreach (Student st in queue)
                Console.WriteLine(st);
        }
        public Student getQueueElement(int index) // add code 
        {
            return queue.ToArray()[index];
        }

        // СТОПКА (СТЕК)
        public void addToStack(Student student)
        {
            stack.Push(student);
        }
        public void printStudentsStack() // додати код
        {
            foreach (Student st in stack)
                Console.WriteLine(st);
        }
        public Student getStackElement(int index) // додати код
        {
            return stack.ToArray()[index];
        }
    }
}
