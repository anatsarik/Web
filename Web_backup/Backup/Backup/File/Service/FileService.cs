using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backup.File.Service
{
    internal class FileService
    {
        public void copyTo(string source, string target, string fileName)
        {
            FileInfo fileInfo = new FileInfo(@source + "\\" + fileName);
            copySingle(fileInfo, target, "0");
        }

        public void directoryContent(string source, string target)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(@source);
            Console.WriteLine("DIR:{0}\n", directoryInfo.FullName.ToString());
            foreach (FileInfo fileInfo in directoryInfo.GetFiles()) {
                Console.WriteLine("Filename: {0}", fileInfo.FullName);
                copySingle(fileInfo, target, "1");
            }
            foreach (DirectoryInfo directory in directoryInfo.GetDirectories()) {

                string currentDirTarget = target + "\\" + directory.Name;
                string currentDirSource = source + "\\" + directory.Name;

                foreach (FileInfo file in directory.GetFiles()) {
                    Console.WriteLine("Filename: {0}", file.FullName);
                    copySingle(file, currentDirTarget, "2");
                }

                foreach (DirectoryInfo subdirectory in directory.GetDirectories()) {
                    directoryContent(currentDirSource, currentDirTarget);
                }
            }
        }

        public void copySingle(FileInfo file, string target, string message)
        {

            if (!directoryExist(target)) {
                DirectoryInfo directoryInfo = new DirectoryInfo(target);
                directoryInfo.Create();
            }

            try {
                file.CopyTo(target + "\\" + file.Name, true);
            } catch (Exception e) {
                Console.WriteLine(e);
            }
        }

        private bool directoryExist(string source)
        {
            DirectoryInfo directory = new DirectoryInfo(source);

            if (directory.Exists) {
                return true;
            } else {
                return false;
            }
        }
    }
}
