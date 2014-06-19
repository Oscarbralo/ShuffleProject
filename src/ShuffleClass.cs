using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShuffleLibrary
{
    public class ShuffleClass<T>
    {
        public List<T> Shuffle(List<T> objects, int totalElements)
        {
            Random random = new Random();
            List<T> resultList = new List<T>();
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
