using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternObserver
{
    class Program
    {
        static void Main()
        {
            GroupsCollection as47 = new GroupsCollection();
            AS_47 stud1 = new AS_47();
            as47.AddStudent(stud1);
            as47.NotifyStudent();
            Console.ReadLine();

            GroupsCollection ptm47 = new GroupsCollection();
            PTM_47 stud2 = new PTM_47();
            ptm47.AddStudent(stud2);
            ptm47.NotifyStudent();
            Console.ReadLine();

        }
        interface ISubscribeManager
        {
            void AddStudent(IStudent o);
            void RemoveStudent(IStudent o);
            void NotifyStudent();
        }
        class GroupsCollection : ISubscribeManager
        {
            private readonly List<IStudent> students;
            public GroupsCollection()
            {
                students = new List<IStudent>();
            }
            public void AddStudent(IStudent o)
            {
                students.Add(o);
            }
            public void RemoveStudent(IStudent o)
            {
                students.Remove(o);
            }
            public void NotifyStudent()
            {
                foreach (IStudent student in students)
                    student.Update();
            }
        }
        interface IStudent
        {
            void Update();
        }
        class AS_47 : IStudent
        {
            public void Update()
            {
                Console.WriteLine("Уведомление о событии для АС-47!");
            }
        }
        class PTM_47 : IStudent
        {
            public void Update()
            {
                Console.WriteLine("Уведомление о событии для ПТМ-47!");
            }
        }
    }
}
