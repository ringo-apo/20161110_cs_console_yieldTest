using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1-10まで列挙する
            foreach (var _ in GetList(10))
            {
                Console.WriteLine(_);
            }
            Console.ReadKey();
        }

        // 1から引数までの値を返すイテレータ
        static public IEnumerable<int> GetList(int end)
        {
            for (int i = 1; i <= end; i++)
            {
                yield return i;
            }
        }
    }
}
