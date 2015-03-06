using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerEarth
{
    class BestInternetBrowser
    {
        static void main(string[] args)
        {
            List<string> ratio = new List<string>();
            int x = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < x; i++)
            {
                string s = Console.ReadLine();
                int l = 0;
                string vowels = "aeiou";
                l = new string(s.Split('.')[1].Where(c => !vowels.Contains(c)).ToArray()).Length;

                l += s.Split('.')[2].Length + 1;

                ratio.Add("" + l + "/" + s.Length);
            }

            foreach(string s in ratio)
            {
                Console.WriteLine(s);
            }

            Console.ReadLine();
        }
    }
}
