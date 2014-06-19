using System;
using System.Collections.Generic;
using System.Linq;

namespace ShuffleLibrary
{
    public static class ExtensionShuffle
    {
        //Lists
        public static List<string> Shuffle(this List<string> list, List<string> objects, int totalElements)
        {
            Random random = new Random();
            List<string> resultList = new List<string>();
            for (int i = 0; i < totalElements; i++)
            {
                int maxElements = objects.Count - 1;
                int randomElement = random.Next(0, maxElements);
                resultList.Add(objects[randomElement]);
                objects.RemoveAt(randomElement);
            }
            return resultList;
        }

        public static List<int> Shuffle(this List<int> list, List<int> objects, int totalElements)
        {
            Random random = new Random();
            List<int> resultList = new List<int>();
            for (int i = 0; i < totalElements; i++)
            {
                int maxElements = objects.Count - 1;
                int randomElement = random.Next(0, maxElements);
                resultList.Add(objects[randomElement]);
                objects.RemoveAt(randomElement);
            }
            return resultList;
        }

        public static List<double> Shuffle(this List<double> list, List<double> objects, int totalElements)
        {
            Random random = new Random();
            List<double> resultList = new List<double>();
            for (int i = 0; i < totalElements; i++)
            {
                int maxElements = objects.Count - 1;
                int randomElement = random.Next(0, maxElements);
                resultList.Add(objects[randomElement]);
                objects.RemoveAt(randomElement);
            }
            return resultList;
        }

        public static List<long> Shuffle(this List<long> list, List<long> objects, int totalElements)
        {
            Random random = new Random();
            List<long> resultList = new List<long>();
            for (int i = 0; i < totalElements; i++)
            {
                int maxElements = objects.Count - 1;
                int randomElement = random.Next(0, maxElements);
                resultList.Add(objects[randomElement]);
                objects.RemoveAt(randomElement);
            }
            return resultList;
        }

        //Arrays
        public static string[] Shuffle(this string[] list, string[] objects, int totalElements)
        {
            Random random = new Random();
            List<string> resultList = new List<string>();
            List<string> objectsNew = objects.ToList();
            for (int i = 0; i < totalElements; i++)
            {
                int maxElements = objectsNew.Count - 1;
                int randomElement = random.Next(0, maxElements);
                resultList.Add(objectsNew[randomElement]);
                objectsNew.RemoveAt(randomElement);
            }
            return resultList.ToArray<string>();
        }

        public static int[] Shuffle(this int[] list, int[] objects, int totalElements)
        {
            Random random = new Random();
            List<int> resultList = new List<int>();
            List<int> objectsNew = objects.ToList();
            for (int i = 0; i < totalElements; i++)
            {
                int maxElements = objectsNew.Count - 1;
                int randomElement = random.Next(0, maxElements);
                resultList.Add(objectsNew[randomElement]);
                objectsNew.RemoveAt(randomElement);
            }
            return resultList.ToArray<int>();
        }

        public static double[] Shuffle(this double[] list, double[] objects, int totalElements)
        {
            Random random = new Random();
            List<double> resultList = new List<double>();
            List<double> objectsNew = objects.ToList();
            for (int i = 0; i < totalElements; i++)
            {
                int maxElements = objectsNew.Count - 1;
                int randomElement = random.Next(0, maxElements);
                resultList.Add(objectsNew[randomElement]);
                objectsNew.RemoveAt(randomElement);
            }
            return resultList.ToArray<double>();
        }

        public static long[] Shuffle(this long[] list, long[] objects, int totalElements)
        {
            Random random = new Random();
            List<long> resultList = new List<long>();
            List<long> objectsNew = objects.ToList();
            for (int i = 0; i < totalElements; i++)
            {
                int maxElements = objectsNew.Count - 1;
                int randomElement = random.Next(0, maxElements);
                resultList.Add(objectsNew[randomElement]);
                objectsNew.RemoveAt(randomElement);
            }
            return resultList.ToArray<long>();
        }
    }
}
