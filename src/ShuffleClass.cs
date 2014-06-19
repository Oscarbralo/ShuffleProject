using System;
using System.Collections.Generic;

namespace ShuffleLibrary
{
    public class ShuffleClass<T>
    {
        public List<T> Shuffle(List<T> objects)
        {
            Random random = new Random();
            List<T> resultList = new List<T>();
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
    }
}
