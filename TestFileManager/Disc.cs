using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace TestFileManager
{
    public class Disc
    {
        
        public string name { get; set; }
        public int index { get; set; }

        public Disc(string name_, int index_)
        {
            
            this.name = name_;
            this.index = index_;
        }

        public void DiscIntro()
        {
            Console.WriteLine("Список каталогов:");
            string[] intro = System.IO.Directory.GetDirectories(name);
            foreach(string str in intro)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine("Список файлов:");
            string[] introFile = System.IO.Directory.GetFiles(name);
            foreach(var str in introFile)
            {
                Console.WriteLine(str);
            }

        }
    }

    public class DiscList
    {
        public List<Disc> list { get; set; }

        public DiscList()
        {
            
            DriveInfo[] drv = DriveInfo.GetDrives();

            this.list = new List<Disc>();
            string i;
            int n = 0;
            foreach (DriveInfo drv_ in drv)
            {
                i = drv_.Name;
                Disc d = new Disc(i,n);
                list.Add(d);
                n++;
            }
 
        }

        public void prntDiscList()
        {
            foreach (Disc d in list)
            {
                Console.WriteLine(d.name);
            }
        }

        public void prntDirectory(int index)
        {
            foreach(Disc d in list)
            {
                if (d.index == index)
                {
                    d.DiscIntro();
                    break;
                }
            }
        }
    }
}
