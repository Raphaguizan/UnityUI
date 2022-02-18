using System.Collections.Generic;
using UnityEditor;
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

#if UNITY_EDITOR

        [MenuItem("Guizan/Create Button %#t")]
        public static void CriateButtonWindow()
        {
            var newObj = Resources.Load("PFB_Button");
            var instantiatedObj = (GameObject)MonoBehaviour.Instantiate(newObj);
            instantiatedObj.transform.position = new Vector3(0, 0, 8);
        }

        [MenuItem("GameObject/Guizan/Create Button", false, -1)]
        public static void CriateButton()
        {
            var newObj = Resources.Load("PFB_Button");
            var instantiatedObj = (GameObject)MonoBehaviour.Instantiate(newObj, Selection.activeTransform);
            instantiatedObj.transform.localPosition = new Vector3(0, 0, 0);
        }
#endif
    }
}
