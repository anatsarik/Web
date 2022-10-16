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
            FileController fileController = new FileController();
            fileController.backupAll("H:\\backup", "H:\\tod");
        }
    }
}
