using System;
using System.IO;

namespace Paths
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"c:/projects/CSharpfundamentals";
            var extension = Path.GetExtension(path);
            var fileName = Path.GetFileName(path);
            var fileNameNoExtension = Path.GetFileNameWithoutExtension(path);
            var directory = Path.GetDirectoryName(path);
        }
    }
}
