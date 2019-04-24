using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)

        {   
            //Group object create
            Group grp = new Group();

            Console.WriteLine("Enter your group name:");
            //name property add
            grp.name = Console.ReadLine();




            //Student object create
            Student student = new Student();

            Console.WriteLine("Enter your name:");
            //name property add
            student.name = Console.ReadLine();

            Console.WriteLine("Enter your surname:");
            //surname property add
            student.surname = Console.ReadLine();

            //add  name property
            student.group = grp;

            Console.WriteLine($"Salam {student.name} {student.surname}. Sizin grupunuz: {student.group.name}");

            Console.Read();



        }

        //Group class create
        class Group
        {
            public string name { get; set; }
        }
        //Student class create
        class Student
        {
            public string name { get; set; }
            public string surname { get; set; }
            public Group group { get; set; }
        }
    }
}
