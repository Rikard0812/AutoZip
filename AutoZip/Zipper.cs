using System;
using System.IO.Compression;

namespace AutoZip
{
    public class Zipper
    {
        static void Main(string[] args)
        {
            string startPath = @".\start";
            string zipPath = @".\result.zip";
            string extractPath = @".\extract";

            ZipFile.CreateFromDirectory(startPath, zipPath);

            ZipFile.ExtractToDirectory(zipPath, extractPath);
        }

    }
}