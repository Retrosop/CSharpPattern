using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Education
    {
        public abstract void Enter();
        public abstract void Study();
        public virtual void PassExams()
        {
            Console.WriteLine("Сдаем выпускные экзамены");
        }
        public abstract void GetDocument();

        public void Learn()
        {
            Enter();
            Study();
            PassExams();
            GetDocument();
        }
    }

    class School : Education
    {
        public override void Enter()
        {
            Console.WriteLine("Идем в первый класс");
        }
        public override void Study()
        {
            Console.WriteLine("Посещаем уроки, делаем задания"); 
        }
        public override void GetDocument()
        {
            Console.WriteLine("Получаем аттестат об образовании");
        }

    }

    class University : Education
    {
        public override void Enter()
        {
            Console.WriteLine("Сдаем вступительные экзамены в вуз");
        }
        public override void Study()
        {
            Console.WriteLine("Посещаем лекции");
            Console.WriteLine("Проходим практику");
        }
        public override void PassExams()
        {
            Console.WriteLine("Сдаем экзамены по специальности");
        }

        public override void GetDocument()
        {
            Console.WriteLine("Получаем диплом");
        }

    }

}
