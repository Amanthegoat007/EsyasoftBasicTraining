namespace DataStructureBasicPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //List Example
            List<Student> students = new List<Student>();

            // Add Student objects to the list
            Student first = new Student(1, "Alice", 10);
            Student second = new Student(2, "Bob", 90);
            Student third = new Student(3, "Charlie", 78);
            students.Add(first);
            students.Add(second);
            students.Add(third);


            // Access and display each student using foreach
            Console.WriteLine("\nList:-->");
            foreach (Student s in students)
            {
                Console.WriteLine($"ID: {s.id}, Name: {s.name}, Marks: {s.marks}");
            }

            // Access a specific object by index
            Console.WriteLine($"\nSecond student is: {students[1].name}");


            //Dictionay Example
            Dictionary<string, Student> students_dict = new Dictionary<string, Student>();
            students_dict.Add("firstStudent", first);
            students_dict.Add("seondStudent", second);
            students_dict.Add("thirdStudent", third);


            foreach (KeyValuePair<string, Student> student in students_dict)
            {
                Console.WriteLine(student.Value.id);
            }


            //Hashset Example
            Console.WriteLine("Hashset demo");
            HashSet<Student> students_hashset = new HashSet<Student>();
            students_hashset.Add(first);
            students_hashset.Add(second);
            students_hashset.Add(first);
            students_hashset.Add(third);

            foreach (Student student in students_hashset)
            {
                Console.WriteLine(student.id);
            }


            //StackDemo


            Stack<Student> students_stack = new Stack<Student>();
            students_stack.Push(first);
            students_stack.Push(second);
            students_stack.Push(third);

            Student pop_stack = students_stack.Pop();
            Console.WriteLine(pop_stack.name);
            //Printing this Stack
            Stack<Student> dummy= students_stack;
            Console.WriteLine("\nStack Demo:->");
            foreach (Student s in dummy)
            {
                Console.WriteLine($"ID: {s.id}, Name: {s.name}, Marks: {s.marks}");
            }

            //Queue demo
            Console.WriteLine("\nQueue demo");
            Queue<Student> students_queue = new Queue<Student>();
            students_queue.Enqueue(first);
            students_queue.Enqueue(second);
            students_queue.Enqueue(third);

            Console.WriteLine("\nQueue Demo:->");
            foreach (Student s in students_queue)
            {
                Console.WriteLine($"ID: {s.id}, Name: {s.name}, Marks: {s.marks}");
            }


            //LinkedList Demo
            LinkedList<Student> students_list = new LinkedList<Student>();
            students_list.AddLast(first);
            students_list.AddLast(second);
            students_list.AddLast(third);
            //Console.WriteLine("First Node->",students_list.First);
            //Console.WriteLine("Last Node->",students_list.Last);
            Console.WriteLine("\nLinkedList Demo:->");
            foreach (Student s in students_list)
            {
                Console.WriteLine($"ID: {s.id}, Name: {s.name}, Marks: {s.marks}");
            }

            //TupleList Demo

            var studentTuple = Tuple.Create(first, second, third);
            //Printing Student Tuple 
            Console.WriteLine("\nTuple:-->");
            Console.WriteLine($"Student 1: {studentTuple.Item1.id} {studentTuple.Item1.name} {studentTuple.Item1.marks}");
            Console.WriteLine($"Student 2: {studentTuple.Item2.id} {studentTuple.Item2.name} {studentTuple.Item2.marks}");
            Console.WriteLine($"Student 3: {studentTuple.Item3.id} {studentTuple.Item3.name} {studentTuple.Item3.marks}");

        }
    }
}
