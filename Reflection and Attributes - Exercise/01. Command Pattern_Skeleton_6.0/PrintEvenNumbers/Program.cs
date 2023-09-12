using System.Security.Cryptography.X509Certificates;
using System.IO;
namespace PrintEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"E:\C# OOP\Reflection and Attributes - Exercise\01. Command Pattern_Skeleton_6.0\PrintEvenNumbers\Text.txt";
            FileStream reader = new FileStream(path, FileMode.Open);
            FileStream writer = new FileStream(@"\..\..Output.txt", FileMode.Create);
            using (reader)
            {
                using(writer)
                {
                    byte[] buffer = new byte[8];
                    while (reader.Position<reader.Length)
                    {
                        reader.Read(buffer, 0, buffer.Length);
                        for (int i = 0; i < buffer.Length; i++)
                        {
                            Console.Write($"{(char)buffer[i]}");
                          
                        }
                        writer.Write(buffer,0,buffer.Length);
                    }
                    
                  

                }
               
                
            }
        }
      
    }
}