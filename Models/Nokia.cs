using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPProject.Models
{
    public class Nokia : Smartphone
    {
        public override void InstallApp(string appName)
        {
            Console.WriteLine($"App {appName} installed successfully on Nokia system!");
        }
    }
}