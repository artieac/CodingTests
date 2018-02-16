using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imprivata
{
    public class TopmostStepTest : LoggableTest
    {
        public TopmostStepTest(IOutputLogger outputLogger) : base(outputLogger) { }
        public int FindTopmostStep(int n, int k)
        {
            this.OutputLogger.WriteMessage("***********************");
            this.OutputLogger.WriteMessage("Number of actions: " + n);
            this.OutputLogger.WriteMessage("Missing Step: " + k);

            int currentStep = 0;

            if((n > 0 && n <= 2000) && (k > 0 && k <= 40000))
            {
                currentStep = 0;

                for (int i = 1; i < n + 1; i++)
                {
                    this.OutputLogger.WriteMessage("Current Step is " + currentStep);

                    if ((currentStep + i) != k)
                    {
                        this.OutputLogger.WriteMessage("Next step of " + i + " will work, go ahead and jump");
                        // you won't land on the missing step to go ahead and jump
                        currentStep += i;
                    }
                    else
                    {
                        this.OutputLogger.WriteMessage("The next step will end up on the missing on, wait this turn and do nothing.");
                        // do nothing, wait on the step
                    }
                }
            }

            this.OutputLogger.WriteMessage("The highest step reached is " + currentStep);

            return currentStep;
        }
    }
}
