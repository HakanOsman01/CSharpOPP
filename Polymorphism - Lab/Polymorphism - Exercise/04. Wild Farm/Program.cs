using _04._Wild_Farm.Core;
using _04._Wild_Farm.Core.Interfaces;
using _04._Wild_Farm.Models;
using System;
namespace _04._Wild_Farm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEngine engine = new Engine();
            engine.Run();   


        }
    }
   
}