using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeProg
{
    class Program
    {
        static void Main(string[] args)
        {
            Time now = new Time();
            now.hour = 11;
            now.minute = 59; 
            Console.WriteLine("The time now is "+now.hour+":"+ now.minute);
            
        }
    }
}
