using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte a = 5;
            byte b = 10;
            int c = a + b;
            int cc = a - b;
            Console.WriteLine(c+" "+cc);
            long z = (int)c;
            Console.WriteLine(z);
            char ch = 'a';
            char ch1 = 'b';
            int o = ch + ch1;
            int i = ch * ch1;
            Console.WriteLine(o+" "+i);
            float f = 10 / 3f;
            double d = 10 / 6d;
            int df = (int)f;
            decimal l = (long)d;
            Console.WriteLine(df + " " + l);
            short v = 5;
            double fl = (short)v;
            int t = o + c;
            bool bb = false;
            Console.WriteLine(!bb);
            string str1 = "Hello world ";
            string str2 = "Hello people";
            string str = str1 + str2;
            Console.WriteLine(str);
            int num = 10;
            string numStr=num.ToString();
            Console.WriteLine(numStr);
            //  Decimal ddd = Decimal.Parse(str1);   exception
            //  Console.WriteLine(ddd); 
            //  int k = int.Parse(str1);             exception
            // Console.WriteLine(k);

            string st = "be the one";
            string sttUp = st.ToUpper();
            Console.WriteLine(sttUp);
            string[] sttLow = st.Split(' ');
            foreach (var s in sttLow)
            {
                Console.Write(s);
            }
            Console.WriteLine();

            string zz =str1.Substring(1,3);
            Console.WriteLine(zz);
            string sss = str.Replace('l', 'a');
            Console.WriteLine(sss);
            string[] words = { "I ", "want to ", "London" };
            string u=string.Concat(words);
            Console.WriteLine(u);
           string h = st.Remove(0,3);
            Console.WriteLine(h);

            int w = st.CompareTo(sss);
            Console.WriteLine(w);
            string dd = "Life ";
            string oo = "Li";
            string pp = "be";
            Console.WriteLine(dd.Contains(oo));
            Console.WriteLine(dd.Contains(pp));







        }
    }
}
