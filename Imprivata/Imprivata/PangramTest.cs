using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imprivata
{
    public class PangramTest : LoggableTest
    {
        public PangramTest(IOutputLogger outputLogger) : base(outputLogger) { }
       
        public bool IsPangram(string testString)
        {
            bool retVal = false;

            this.OutputLogger.WriteMessage("*****************");
            this.OutputLogger.WriteMessage("Input string: " + testString);

            if(testString.Length > 103)
            {
                this.OutputLogger.WriteMessage("String is > 103 characters, truncating it to run the test.");
                // instructions were unclear if > 103 what to do, so for now just truncate
                // could just return false instead
                testString = testString.Substring(0, 103);
            }

            if(testString.Length > 0)
            {
                // just loop over the sentence, upshift the letters
                // and dump them into a hashtable
                // if the hashtable has 26 letters in it, its a pangram
                Hashtable foundLetters = new Hashtable();

                for(int i = 0; i  < testString.Length; i++)
                {
                    char current = testString.ElementAt(i);

                    if(current != ' ')
                    {
                        char upperCase = char.ToUpper(current);

                        if (foundLetters[upperCase] == null)
                        {
                            foundLetters.Add(upperCase, 1);
                            this.OutputLogger.WriteMessage("Found " + upperCase);
                        }
                    }
                }

                if(foundLetters.Keys.Count == 26)
                {
                    retVal = true;
                    this.OutputLogger.WriteMessage("All 26 letters found in string '" + testString + "'.  The sentence is a Pangram");
                }
                else
                {
                    this.OutputLogger.WriteMessage("Only " + foundLetters.Keys.Count + " letters found in string '" + testString + "'.  The sentence is a Pangram");
                }
            }
            else
            {
                this.OutputLogger.WriteMessage("THe string is empty");
            }

            return retVal;
        }
    }
}
