using System.Collections.Generic;
using UnityEngine;

namespace Guizan.Util
{
    public static class Extension 
    {
        public static T GetRandomt<T>(this List<T> list)
        {
            return list[Random.Range(0, list.Count)];
        }
    }
}
