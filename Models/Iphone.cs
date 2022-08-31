using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPProject.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string number)
        {
            Number = number;
        }
        public override void InstallApp(string appName)
        { 
            Console.WriteLine($"App {appName} installed successfully on Iphone system!");
        }
    }
}