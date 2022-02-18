using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.UI.Screen
{
    public class ScreenBase : MonoBehaviour
    {
        public ScreenType type;
        public float timeBetweenButtonsShow;
        public List<GameObject> objects;

        private Coroutine _currentRoutine;

        public void ForceHide() => objects.ForEach(i => i.SetActive(false));

        public void Active(bool val)
        {
            if (_currentRoutine != null) StopCoroutine(_currentRoutine);
            _currentRoutine = StartCoroutine(ToggleButtons(val));
        }


        IEnumerator ToggleButtons (bool val)
        {
            foreach (GameObject go in objects)
            {
                go.SetActive(val);
                yield return new WaitForSeconds(timeBetweenButtonsShow) ;
            }
        }
    }
}