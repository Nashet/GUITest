using Nashet.UnityUIUtils;
using UnityEngine;
namespace GUITest
{
    /// <summary>
    /// Stores and loads prefabs
    /// </summary>
    public class GameManager : MonoBehaviour
    {
        [Header("You can select prefab with another style (before scene running)")]
        [SerializeField] protected GameObject modalWindowPrefab;
        [SerializeField] protected Canvas canvas;

        protected void Awake()
        {
            if (ModalWindow.Instance == null)
            {
                Instantiate(modalWindowPrefab, canvas.transform);
            }
        }
    }
}
