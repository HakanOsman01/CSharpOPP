



namespace _01._Vehicles.IO
{
    using Interfaces;
    public class FileWriter : IWriter
    {
        private string[] lines;
        private string pathToWrite;


        public FileWriter(string pathToWrite, string[]lines)
        {
            this.pathToWrite=pathToWrite;
            this.lines=lines;
        }
        public void WriteLine()

        {
            if(lines.Length==CurrentRow)
            {
                throw new InvalidOperationException("Nothing To Write!!!");
            }
            string currentLine=lines[CurrentRow++];
            File.WriteAllText(this.pathToWrite, currentLine);
            
        }
        private int CurrentRow = 0;
    }
}
