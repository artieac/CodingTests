using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imprivata
{
    public class MergeArraysTask : LoggableTest
    {
        public MergeArraysTask(IOutputLogger outputLogger) : base(outputLogger)
        {

        }
        public void RunMergeArraysTask_Random()
        {
            int[] arrayA = new int[5];
            int[] arrayB = new int[10];

            arrayA[0] = 1;
            arrayA[1] = 3;
            arrayA[2] = 4;
            arrayA[3] = 5;
            arrayA[4] = 7;
        
            arrayB[0] = 2;
            arrayB[1] = 6;
            arrayB[2] = 8;
            arrayB[3] = 9;
            arrayB[4] = 10;

            mergeArray(arrayA, arrayB, 5);
        }

        public void RunMergeArraysTask_AlreadySorted()
        {
            int[] arrayA = new int[5];
            int[] arrayB = new int[10];

            arrayA[0] = 1;
            arrayA[1] = 2;
            arrayA[2] = 3;
            arrayA[3] = 4;
            arrayA[4] = 5;

            arrayB[0] = 6;
            arrayB[1] = 7;
            arrayB[2] = 8;
            arrayB[3] = 9;
            arrayB[4] = 10;

            mergeArray(arrayA, arrayB, 5);
        }

        public void RunMergeArraysTask_RandomSortedTwo()
        {
            int[] arrayA = new int[5];
            int[] arrayB = new int[10];

            arrayA[0] = 1;
            arrayA[1] = 3;
            arrayA[2] = 6;
            arrayA[3] = 8;
            arrayA[4] = 9;

            arrayB[0] = 2;
            arrayB[1] = 4;
            arrayB[2] = 5;
            arrayB[3] = 7;
            arrayB[4] = 10;

            mergeArray(arrayA, arrayB, 5);
        }
        public void RunMergeArraysTask_WorstCase()
        {
            int[] arrayA = new int[5];
            int[] arrayB = new int[10];

            arrayA[0] = 6;
            arrayA[1] = 7;
            arrayA[2] = 8;
            arrayA[3] = 9;
            arrayA[4] = 10;

            arrayB[0] = 1;
            arrayB[1] = 2;
            arrayB[2] = 3;
            arrayB[3] = 4;
            arrayB[4] = 5;

            mergeArray(arrayA, arrayB, 5);
        }

        public void mergeArray(int[] array1, int[] array2, int M)
        {
            this.OutputLogger.WriteMessage("**********************");
            this.OutputLogger.WriteMessage("Starting array a: " + string.Join(",", array1));
            this.OutputLogger.WriteMessage("Starting string b: " + string.Join(",", array2));

            int j = M - 1;
            int insertCounter = (2 * M) - 1;

            // cien the arrays are sorted.  Just cycle over them from back to front
            // and put the larger of the two items into the empty spaces of the second array
            // working from back to front
            while (j > -1)
            {
                int i = M - 1;

                while(i > -1)
                {
                    if(j > -1)
                    {
                        if (array1[i] > array2[j])
                        {
                            array2[insertCounter] = array1[i];
                            this.OutputLogger.WriteMessage("Placing " + array1[i] + " into element " + insertCounter);
                            i--;
                            insertCounter--;
                        }
                        else
                        {
                            array2[insertCounter] = array2[j];
                            this.OutputLogger.WriteMessage("Placing " + array2[j] + " into element " + insertCounter);
                            j--;
                            insertCounter--;
                        }
                    }
                    else
                    {
                        array2[insertCounter] = array1[i];
                        this.OutputLogger.WriteMessage("Placing " + array1[i] + " into element " + insertCounter);
                        i--;
                        insertCounter--;
                    }
                }

                if(i == -1 && j > -1)
                {
                    this.OutputLogger.WriteMessage("All elements from a are sorted, and only sorted elements from b are left so we're done");
                    // all the elements from array A are sorted, and j elements are left
                    // if thats the case, and J is alread sorted also then the
                    // j elements should be fine just where they are
                    // So just set j to -1 to be done;
                    j = -1;
                }
            }

            this.OutputLogger.WriteMessage("Sorted List " + string.Join(",", array2));
        }
    }
}
