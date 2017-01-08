using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace РВиП
{
    class Letter
    {
        public int name;
        public int text;
        public int s;

        public Letter(int _name)
        {
            name = _name;
        }

        public int generate()
        {
            Random r = new Random();
            Thread.Sleep(1);
            text = r.Next(9999,99999);
            return text;
        }

        public void Send(SMTP sv, int t)
        {
            Random r = new Random();
            s = r.Next(1, 999);
            Thread.Sleep(s);
            sv.Get(t);
        }
    }
}
