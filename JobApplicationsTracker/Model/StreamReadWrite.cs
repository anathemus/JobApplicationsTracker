using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace JobApplicationsTracker.Model
{
    public static class StreamReadWrite
    {
        public static string ContentFilePath { get; set; }
        public static void InitializeTextReadWrite()
        {
            string filePath = Environment.CurrentDirectory;
            if (!File.Exists(Path.Combine(filePath, "/JobApplicationTracker/Content/ContentFile.txt")))
            {
                if (!Directory.Exists(Path.Combine(filePath, "/JobApplicationTracker/Content")))
                {
                    Directory.CreateDirectory(Path.Combine(filePath, "/JobApplicationTracker/Content"));
                }
                File.CreateText(Path.Combine(filePath, "/JobApplicationTracker/Content/ContentFile.txt"));
            }

            ContentFilePath = Path.Combine(filePath, "/JobApplicationTracker/Content/ContentFile.txt");
        }
    }
}
