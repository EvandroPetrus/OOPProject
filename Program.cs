using OOPProject.Models;

Smartphone ip1 = new Iphone("1238712");
ip1.Call();
ip1.ReceiveCall();
ip1.InstallApp("Facebook");
Console.WriteLine(ip1.Number);