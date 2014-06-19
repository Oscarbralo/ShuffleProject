using System;
using System.Collections.Generic;
using System.Linq;

namespace ShuffleLibrary
{
    public static class ExtensionShuffle
    {
        //Lists
        public static List<string> Shuffle(this List<string> list, List<string> objects)
        {
            Random random = new Random();
            List<string> resultList = new List<string>();
            int totalElements = objects.Count;
            for (int i = 0; i < totalElements; i++)
            {
                int maxElements = objects.Count - 1;
                int randomElement = random.Next(0, maxElements);
                resultList.Add(objects[randomElement]);
                objects.RemoveAt(randomElement);
            }
            return resultList;
        }

        public static List<int> Shuffle(this List<int> list, List<int> objects)
        {
            Random random = new Random();
            List<int> resultList = new List<int>();
            int totalElements = objects.Count;
            for (int i = 0; i < totalElements; i++)
            {
                int maxElements = objects.Count - 1;
                int randomElement = random.Next(0, maxElements);
                resultList.Add(objects[randomElement]);
                objects.RemoveAt(randomElement);
            }
            return resultList;
        }

        public static List<double> Shuffle(this List<double> list, List<double> objects)
        {
            Random random = new Random();
            List<double> resultList = new List<double>();
            int totalElements = objects.Count;
            for (int i = 0; i < totalElements; i++)
            {
                int maxElements = objects.Count - 1;
                int randomElement = random.Next(0, maxElements);
                resultList.Add(objects[randomElement]);
                objects.RemoveAt(randomElement);
            }
            return resultList;
        }

        public static List<long> Shuffle(this List<long> list, List<long> objects)
        {
            Random random = new Random();
            List<long> resultList = new List<long>();
            int totalElements = objects.Count;
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
        public static string[] Shuffle(this string[] list, string[] objects)
        {
            Random random = new Random();
            List<string> resultList = new List<string>();
            int totalElements = objects.Length;
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

        public static int[] Shuffle(this int[] list, int[] objects)
        {
            Random random = new Random();
            List<int> resultList = new List<int>();
            int totalElements = objects.Length;
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

        public static double[] Shuffle(this double[] list, double[] objects)
        {
            Random random = new Random();
            List<double> resultList = new List<double>();
            int totalElements = objects.Length;
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

        public static long[] Shuffle(this long[] list, long[] objects)
        {
            Random random = new Random();
            List<long> resultList = new List<long>();
            int totalElements = objects.Length;
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
