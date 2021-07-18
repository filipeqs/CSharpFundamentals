using System;
using System.IO;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"c:/somefile.jpg";
            File.Copy(@"c:\temp\myfile.jpg", @"d:\temp\myfile.jpg");
            File.Delete(path);
            if (File.Exists(path))
            {
                // Do something
            }
            var content = File.ReadAllText(path);

            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo(@"d:\temp\myfile.jpg");
            fileInfo.Delete();
            if (fileInfo.Exists)
            {
                // Do something
            }
        }
    }
}
