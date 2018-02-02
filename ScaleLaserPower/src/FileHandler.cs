using System;
using System.IO;

namespace ScaleLaserPower
{
    public class FileHandler
    {
        private string inputPath;

        public FileHandler(string filePath)
        {
            this.inputPath = filePath;
        }
        
        public string InputPath { get { return inputPath; } }

        public string InputFileName
        {
            get
            {
                return InputPath ?? Path.GetFileName(InputPath);
            }
        }

        public string OutputPath { get; set; }

        public string OutputFileName {
            get
            {
                return OutputPath??Path.GetFileName(OutputPath);
            }
        }

        public bool IsReady { get { return InputPath != null && File.Exists(InputPath); } }

        public string ReadAllLines()
        {
            if (File.Exists(InputPath))
            {
                return File.ReadAllText(InputPath);
            }
            return null;
        }

        public void ReadAndWriteLineByLine(Func<string, string> lineTransformer)
        {
            if (File.Exists(InputPath))
            {
                using (StreamReader reader = new StreamReader(InputPath))
                {
                    using(StreamWriter writer = new StreamWriter(OutputPath, false))
                    {
                        while (reader.Peek() >= 0)
                        {
                            var transformedLine = lineTransformer(reader.ReadLine());
                            writer.WriteLine(transformedLine);
                        }
                    }
                }
            }
        }
    }
}
