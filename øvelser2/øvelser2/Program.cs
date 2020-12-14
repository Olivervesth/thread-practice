using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace øvelser2
{
    class Program
    {
        static void Main(string[] args)
        {
            øvelse3 ø3 = new øvelse3();
            Thread thread = new Thread(new ThreadStart(ø3.ø3));
            thread.Start();
            while (thread.IsAlive)//updates the thread with alive status
            {
                Thread.Sleep(01);
                Console.WriteLine("i am alive");
            }
            Console.WriteLine("Alarm - tråd termineret!");//If not alive it will trigger alarm
            Console.ReadKey();
        }
    }

    class øvelse3
    {
        public void ø3()
        {
            bool systemgood = true;
            int i = 0;
            while (systemgood)
            {
            System.Random ran = new System.Random();
            int temp = ran.Next(-20, 120);//getting random temp
                if(i == 3)//if temp have been over or under the max temp it will return and stop 
                {
                    return;
                }
            Console.WriteLine($"{temp}");
                if (temp <= 0 || temp >= 100)// adds +1 to i
                {
                    i++;
                    Console.WriteLine("Oh no wrong temp");
                }
            }
        }

    }
}
