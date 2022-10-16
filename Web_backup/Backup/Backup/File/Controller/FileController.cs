using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backup.File.Service;

namespace Backup.File.Controller
{
    internal class FileController
    {
        FileService fileService = new FileService();
        public void copyTo(string source, string target, string fileName)
        {
            fileService.copyTo(source, target, fileName);
        }

        public void backupAll(string source, string target)
        {
            fileService.directoryContent(source, target);
        }
    }
}
