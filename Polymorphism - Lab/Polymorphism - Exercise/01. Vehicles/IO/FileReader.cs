
using _01._Vehicles.IO.Interfaces;

namespace _01._Vehicles.IO
{
    public class FileReader : IReader
    {
        private string[] lines;
        
        public FileReader(string pathToRead)
        {
           lines=File.ReadAllLines(pathToRead);
        }
        public string ReadLine()
        {
            if(CurrentRow==lines.Length)
            {
                throw new InvalidOperationException("File is empty");
            }
            return lines[CurrentRow++];
            
            
        }
        private int CurrentRow = 0;
    }
}
