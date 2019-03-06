using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2.SelfAssessmentLab
{
    class Program
    {
        static void Main(string[] args)
        {
            int numLines = 8;
            int numCharsPerLine = 8;

            string currentLine = "";

            for (int i = 0; i < numLines; i++)
            {
                currentLine = "";

                for (int j = 0; j < numCharsPerLine; j++)
                {
                    // even line num starts with "XOXO..."
                    if (i % 2 == 0) // even
                    {
                        if (j % 2 == 0 ) // char column is even
                        {
                            currentLine += "X";
                        }
                        else
                        {
                            currentLine += "O";
                        }
                        
                    }
                    else
                    {
                        // reverse for odd lines "OXOXO...."
                        if (j % 2 == 0)
                        {
                            currentLine += "O";
                        }
                        else
                        {
                            currentLine += "X";
                        }
                    }
                    
                }

                Console.WriteLine(currentLine);
            }
        }
    }
}
