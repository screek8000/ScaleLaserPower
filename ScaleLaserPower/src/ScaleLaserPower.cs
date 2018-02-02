using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScaleLaserPower
{
    public class ScaleLaserPower
    {
        private char[] whiteSpaceChars = {' ', '\t'};
        private const float scaleFactorTo100 = 255f / 100;
        private FileHandler fileHandler;

        public ScaleLaserPower(FileHandler fileHandler)
        {
            this.fileHandler = fileHandler;
        }

        public void ScaleTo100()
        {
            fileHandler.OutputPath = CreateOutputName(fileHandler.InputPath);
            fileHandler.ReadAndWriteLineByLine((line) =>
            {
                string scaledLine = ScaleLineTo100(line);
                return scaledLine;
            });
        }

        public string CreateOutputName(string inputName)
        {
            string outputName = inputName;
            var dotIndex = inputName.LastIndexOf('.');
            if (dotIndex != -1)
            {
                outputName = inputName.Substring(0, dotIndex) + "_scaledTo100" + inputName.Substring(dotIndex);
            }
            return outputName;
        }

        public string ScaleLineTo100(string line)
        {
            if (line == null)
            {
                return string.Empty;
            }
            var cleanedLine = line.Trim();
             if (cleanedLine == "")
            {
                return string.Empty;
            }

            string scaledLine = cleanedLine;
            var startCode = DetermineStartCode(cleanedLine);
            if (startCode == "M3" || startCode == "M03")
            {
                scaledLine = ScaleM3(line);
            }
            return scaledLine;
        }

        private string DetermineStartCode(string line)
        {
            string startCode;
            var whitespaceIndex = line.IndexOfAny(whiteSpaceChars);
            if (whitespaceIndex != -1)
            {
                startCode = line.Substring(0, whitespaceIndex);
            } else
            {
                startCode = line;
            }
            return startCode;
        }

        private string ScaleM3(string line)
        {
            string scaledLine;
            var sIndex = line.IndexOf('S');
            if (sIndex == -1)
            {
                scaledLine = FullPower();
            }
            else
            {
                var powerString = line.Substring(sIndex + 1);
                var scaledPower = int.Parse(powerString) / scaleFactorTo100;
                scaledLine = "M03 S" + Math.Round(scaledPower);
            }
            return scaledLine;
        }

        private string FullPower()
        {
            return "M03 S100";
        }
    }
}
