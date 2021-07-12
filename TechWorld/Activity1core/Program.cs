using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using classBL;

namespace activity1
{
    class Program
    {
        static void Main(string[] args)
        {
            Instructor obj = new Instructor();
            Console.WriteLine(obj.ValidateEligibility());

        }
    }
}
