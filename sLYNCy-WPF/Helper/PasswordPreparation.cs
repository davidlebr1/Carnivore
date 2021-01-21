using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sLYNCy_WPF.Helper
{
    class PasswordPreparation
    {

        public static List<string> LoadPasswords(string path, MainWindow UI)
        {
            List<string> passwordsToReturn = new List<string>();

            var lines = File.ReadLines(path);
            foreach (var line in lines)
            {
                passwordsToReturn.Add(line);
            }
            return passwordsToReturn;
         }
    }
}
