using System.Collections.Generic;
using UnityEngine;

namespace Guizan.Util
{
    public static class Extension 
    {
        public static T GetRandom<T>(this List<T> list)
        {
            return list[Random.Range(0, list.Count)];
        }

        public static T GetRandomExcept<T>(this List<T> list, T unique)
        {
            if (list.Count == 1)
                return unique;

            T result = list[Random.Range(0, list.Count)];
            if (result.Equals(unique))
            {
                result = GetRandomExcept(list, unique);
            }
            return result;
        }
    }
}
