using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;
using Game.UI.Screen;

namespace Game.UI.Buttons
{
    public class Buttonbase : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
    {
        public ScreenType goToScreen;
        [Space]
        public float animationsDuration;
        public float animatoinScale;

        private Vector3 _initialScale;

        private void Awake()
        {
            _initialScale = transform.localScale;
        }

        private void OnEnable()
        {
            transform.DOScale(0, animationsDuration).From();
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            ScreenManager.ShowByType(goToScreen);
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            transform.DOScale(_initialScale * animatoinScale, animationsDuration);
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            transform.DOScale(_initialScale, animationsDuration);
        }
    }
}
