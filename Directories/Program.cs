using System;
using System.IO;

namespace Directories
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"c:/temp/folder");
            var files = Directory.GetFiles(@"c:/projects/CSharpfundamentals",
                "*.*", SearchOption.AllDirectories);
            foreach (var file in files)
                Console.WriteLine(file);

            var directories = Directory.GetDirectories(@"c:/projects/CSharpfundamentals",
                "*.*", SearchOption.AllDirectories);
            foreach (var directory in directories)
                Console.WriteLine(directory);

            if (Directory.Exists(@"c:/projects/CSharpfundamentals"))
            {
                // Do something
            }

            var directoryInfo = new DirectoryInfo(@"c:/projects/CSharpfundamentals");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();
        }
    }
}
