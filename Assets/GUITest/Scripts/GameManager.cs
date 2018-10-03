using UnityEngine;
namespace GUITest
{
    /// <summary>
    /// Loads prefabs
    /// </summary>
    public class GameManager : MonoBehaviour
    {
        [Header("You can use another prefab with another style")]
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