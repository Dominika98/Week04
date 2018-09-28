using System;
using System.Threading;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Reader r1 = new Reader("text1.txt");
            Reader r2 = new Reader("text2.txt");

            Parallel.Invoke(()=> r1.Read(), ()=>r2.Read());

            if(r1.Data.Equals(r2.Data))
            System.Console.WriteLine("Files are the same.");
            else
            System.Console.WriteLine("Files are NOT the same.");

            
        }
    }
}
