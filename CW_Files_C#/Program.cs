using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CW_Files_C_
{
    public class Document
    {
        string _name;
        int _symbols;
        public string Name 
        { 
            get 
            { 
                return _name;
            } 
            set
            {
                _name = value;
            }
        }
        public int Symbols
        {
            get
            {
                return _symbols;
            }
            set
            {
                _symbols = value;
            }
        }

        public Document(string name)
        {
            if (name != null) 
            { 
                Name = name;
                Symbols = name.Length;
            }
            else
            {
                Name = "Standart";
                Symbols = Name.Length;
            }
        }
}
    internal class Program
    {
        static void Main(string[] args)
        {
            Document Test = new Document("Testing");
            string pathToDir = @"D:\TEST";
            if(Directory.Exists(pathToDir))
            {
                Directory.Delete(pathToDir, true);
            }
            if(!Directory.Exists(pathToDir))
            {
                Directory.CreateDirectory(pathToDir);
                string pathToFile = pathToDir + @"\TestFile.txt";
                File.Create(pathToFile).Close();
                File.WriteAllText(pathToFile, Test.Name + Test.Symbols);
            }

        }
    }
}
