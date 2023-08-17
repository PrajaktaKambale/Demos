using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Second.Maths m  = new Second.Maths();
            Console.WriteLine(m.Add(10, 20));

            Second.Test t = new Second.Test();
            Console.WriteLine(t.Sample());

            Second.Third.DB dbobj = new Second.Third.DB();
            dbobj.Insert();
        }
    }
}
namespace Second
{
    public class Maths
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("This is main method in Maths class");
        }
    }

    public class Test
    {
        public string Sample()
        {
            return "This is Test";
        }

    }
    namespace Third
    {
        public class DB
        {
            public void Insert()
            {
                Console.WriteLine("data inserted successfully");
            }

            static void Main(string[] args)
            {
                Console.WriteLine("This is main method in Maths class");
            }
        }
    }
}