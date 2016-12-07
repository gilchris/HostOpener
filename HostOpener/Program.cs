using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostOpener
{
    class Program
    {
        static void Main(string[] args)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = @"c:\Windows\System32\notepad.exe";
            startInfo.Arguments = @"c:\Windows\System32\drivers\etc\hosts";
            Process.Start(startInfo);
        }
    }
}
