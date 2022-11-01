using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_LoginPassword
{
    internal class WorkWithFiles
    {
        public static string SomeData { get; set; }

        public static (string[] data, bool isSuccess) ReadTxtFile(string filePath)
        {
            try
            {
                if (!File.Exists(filePath))
                    return (null, false);

                string[] data = File.ReadAllLines(filePath);
                return (data, true);
            }
            catch (Exception ex)
            {
                //Logs..
                return (null, false);
            }
        }
    }
}
