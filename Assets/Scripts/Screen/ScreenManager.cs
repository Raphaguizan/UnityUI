using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Util;

namespace Game.UI.Screen
{
    public class ScreenManager : Singleton<ScreenManager>
    {
        public List<ScreenBase> screens;
        public ScreenType initialScreen;

        private ScreenBase _currentScreen = null;

        private void HideAll() => screens.ForEach(s => s.ForceHide());

        private void Start()
        {
            HideAll();
            ShowByType(initialScreen);
        }

        public static void ShowByType(ScreenType type)
        {
            var screenToOpen = Instance.screens.Find(s => s.type == type);

            if (screenToOpen == null) return;

            if (Instance._currentScreen) Instance._currentScreen.Active(false);

            Instance._currentScreen = screenToOpen;
            Instance._currentScreen.Active(true);
        }


    }
}


