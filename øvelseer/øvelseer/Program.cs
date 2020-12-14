using System;
using System.Threading;

namespace øvelseer
{
    class Program
    {
        static void Main(string[] args)
        {
            øvelse1 ø1 = new øvelse1();
            øvelse2 ø2 = new øvelse2();
            Thread thread1 = new Thread(new ThreadStart(ø1.ø1));//new thread
            Thread thread2 = new Thread(new ThreadStart(ø2.ø2));//new thread
            thread1.Start();//starting thread
            thread2.Start();//starting thread
            Console.Read();// waiting when done
        }
    }
}
class øvelse1
{
    public void ø1()//prints ands sleeps :D
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("C#-trådning er nemt!");
            Thread.Sleep(01);
        }
    }
}
class øvelse2
{
    public void ø2()//prints
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Også med flere tråde...");
        }
    }
}
