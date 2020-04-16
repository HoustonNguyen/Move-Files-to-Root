using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MoveFilesToRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo baseDirectory = new DirectoryInfo(@"G:\TestBed");
            List<FileInfo> files = baseDirectory.GetFiles("*.*", SearchOption.AllDirectories).ToList();

            foreach(FileInfo file in files)
            {
                file.MoveTo(baseDirectory.FullName + "\\" + Guid.NewGuid().ToString() + file.Extension);
            }
        }
    }
}
