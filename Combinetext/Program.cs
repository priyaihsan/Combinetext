using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combinetext
{
    /// <summary>
    /// returntext class
    /// </summary>
    /// <remarks>class returntext dapat menggabungkan dua kata menjadi satu</remarks>
    class returntext
    {
        /// <summary>
        /// operasi penggabungan kata
        /// </summary>
        /// <param name="a">kata pertama</param>
        /// <param name="b">kata kedua</param>
        /// <returns>hasil dari penggabungan antara kedua kata a dan b</returns>
        public string text(string a, string b)
        {
            string x = a + " combine with " + b;
            return x;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            returntext r = new returntext();
            string output = r.text("banana", "apple");
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
