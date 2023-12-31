﻿

namespace Telephony.IO
{
    using Interfaces;
    public class FileReader : IReader
    {
        private string filePath;
        private string[] fileAllLines;

        public FileReader(string filePath)
        {
            this.FilePath = filePath;
            this.fileAllLines = File.ReadAllLines(filePath);
            RowNumber = 0;

        }
        public string FilePath 
        {
            get
            {
                return filePath;    
            }
            private set
            {
                if(Directory.Exists(value)) 
                {
                    throw new ArgumentException("Invalid file Path!");
                }
                filePath = value;
            }
        }
        public int RowNumber { get;private set; }
        public string ReadLine()
        {
            if (this.RowNumber >= this.fileAllLines.Length)
            {
                throw new InvalidOperationException("No more content in the file!!!");
            }
           return this.fileAllLines[RowNumber++];
        }
        
    }
}
