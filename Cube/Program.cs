using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Math;

namespace Cube
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Enter area");
            int S = int.Parse(ReadLine());
            Write("Enter Hight");
            int H = int.Parse(ReadLine());
            int V = S * H;
            WriteLine("Volume = " + V);
        }
    }
}
