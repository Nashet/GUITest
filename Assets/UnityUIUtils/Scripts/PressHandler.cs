using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Nashet.UnityUIUtils
{
    /// <summary>
    /// Allows opening URL
    /// </summary>
    [RequireComponent(typeof(Button))]
    public class PressHandler : MonoBehaviour
    {
        [SerializeField]
        private string url;

        private void Start()
        {            
            var button = GetComponent<Button>();
            button.onClick.AddListener(() => { Application.OpenURL(url); });
        }
    }
}