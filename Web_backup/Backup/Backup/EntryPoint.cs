using Backup.File.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backup
{
    internal class EntryPoint
    {
        public static void Main(string[] args)
        {
            FileService fileService = new FileService();
            fileService.directoryContent("H:\\backup", "H:\\tod"); //откуда куда копируется
        }
    }
}
