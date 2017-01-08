using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace РВиП
{
    class SMTP
    {
        int busy;
                
        ConcurrentBag<string> queue_letter = new ConcurrentBag<string>();

        public void Get(int text)
        {            
            Console.WriteLine("Сервер принимает письмо: " + text.ToString());
            queue_letter.Add(text.ToString());
            Thread.Sleep(1);
        }

        public int Enable()
        {
            Random r = new Random();
            busy = r.Next(1,100);
            Console.WriteLine("Сервер занят");
            return busy;
        }


    }
}
