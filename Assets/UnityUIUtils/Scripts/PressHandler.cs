using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace Nashet.UnityUIUtils
{
    /// <summary>
    /// Allows opening URL
    /// </summary>
    public class PressHandler : MonoBehaviour, IPointerDownHandler
    {
        [SerializeField]
        private string url;

        private readonly UnityEvent OnPress = new UnityEvent();

        private void Start()
        {
            OnPress.AddListener(() => { Application.OpenURL(url); });
        }

        public void OnPointerDown(PointerEventData eventData)
        {
            OnPress.Invoke();
        }
    }
}