using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOPProject.Models
{
    public abstract class Smartphone
    {
        public Smartphone(string number)
        {
            Number = number;
        }
        public Smartphone()
        {

        }
        
        public string Number { get; set; }
        
        protected string Model { get; set; }
        
        protected string IMEI {get; set;}
        
        protected int Memory{ get; set; }

        public void Call(){
            Console.WriteLine("Calling...");
        }
        public void ReceiveCall(){
            Console.WriteLine("Receiving call...");
        }

        public abstract void InstallApp(string appName);
        
    }
}