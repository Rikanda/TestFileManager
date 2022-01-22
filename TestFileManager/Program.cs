using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TestFileManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DiscList l1 = new DiscList();
            int n = l1.list.Count;
            Console.WriteLine(n);
            l1.prntDiscList();
            Console.WriteLine("Укажите порядковый номер диска для раскрытия списка каталогов и файлов:");
            int t = int.Parse(Console.ReadLine());
            l1.prntDirectory(t-1);

        }
    }
}
