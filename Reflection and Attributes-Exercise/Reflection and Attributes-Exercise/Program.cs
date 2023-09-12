using Reflection_and_Attributes_Exercise;
using System;
using System.Reflection;

namespace Stealer;

public class StartUp
{
    static void Main(string[] args)
    {
        Spy spy = new Spy();
        string result = spy.StealFieldInfo("Stealer.Hacker", "username", "password");
        Console.WriteLine(result);
        


    }
}