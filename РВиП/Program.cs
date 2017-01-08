using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net;

namespace РВиП
{
    class Program
    {
        int number = 0;
        SMTP serv = new SMTP();

        static void Main(string[] args)
        {
            Program p = new Program();
            //потоки
            for (int i = 0; i < 5; i++)
            {
                Thread myThread = new Thread(p.letter);
                myThread.Start();
            }
            Console.Read();
        }

        public void letter()
        {
            number++;
            Console.WriteLine(number);
            Letter let = new Letter(number);

            for (int i = 0; i < 5; i++)
            {
                let.generate();
                while (serv.Enable() < 80)
                {
                    let.Send(serv, let.text);
                }
                Console.WriteLine("Письмо ожиает освобождение сервера");
                Thread.Sleep(1);
            }
        }
    }
}
