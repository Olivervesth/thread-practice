using System;
using System.Threading;

namespace øvelse_3
{
    class Program
    {
        static void Main(string[] args)
        {
            øvelse4 ø4 = new øvelse4();
            Thread l = new Thread(new ThreadStart(ø4.ø4));// new thread
            Thread s = new Thread(new ThreadStart(ø4.øø4));// new thread
            s.Start();
            l.Start();
        }
    }
    class øvelse4
    {
        char ch = '*';
        public void øø4()
        {
            ConsoleKeyInfo input;
            input = Console.ReadKey(true);
            while ((input.Modifiers & ConsoleModifiers.Control) == 0)//if the ctrl is pressed it will stop
            {
                Thread.Sleep(90);
                Console.Write(ch);
            }
        }
        public void ø4()//Runs while thread is alive and gets the char the user have pressed to display on enter
        {
            while (Thread.CurrentThread.IsAlive)
            {
                
                string temp = Console.ReadLine();

                
                if (temp != null)
                {
                    try
                    {
                        
                        char[] charArr = temp.ToCharArray();

                        
                        ch = charArr[0];
                    }
                    catch (Exception)
                    {
                    }
                }
            }
        }
    }
}
