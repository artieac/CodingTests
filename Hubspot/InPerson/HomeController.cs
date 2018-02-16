using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult MergeArrays()
        {
            //int[] list1 = { -3, 1, 7, 12 };
            //int[] list2 = { 1, 4, 15 };
            //int limit = 4;

            int[] list1 = { 1, 2, 3, 4 };
            int[] list2 = { 5, 6, 7 };
            int limit = 10; // 7;

            int[] limitedSort = ExecuteMergeArrays(list1, list2, limit);

            return View();
        }

        private int[] ExecuteMergeArrays(int[] array1, int[]array2,int limit)
        {
            int[] retVal = new int[limit];

            int arraySize1 = array1.Length;
            int arraySize2 = array2.Length;

            int i = 0;
            int j = 0;
            int k = 0;

            while (i < arraySize1 && j < arraySize2 && k < limit)
            {
                if (array1[i] < array2[j])
                {
                    retVal[k] = array1[i];
                    i++;
                }
                else
                {
                    retVal[k] = array2[j];
                    j++;
                }

                k++;
            }

            for(int x = i; x < arraySize1 && k < limit; x++)
            {
                retVal[k] = array1[x];
                k++;
            }

            for (int y = j; y < arraySize2 && k < limit; y++)
            {
                retVal[k] = array2[y];
                k++;
            }

            return retVal;
        }
    }
}