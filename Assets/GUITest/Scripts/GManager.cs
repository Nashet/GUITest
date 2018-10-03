using UnityEngine;

public class GManager : MonoBehaviour
{
    public GameObject modalWindowPrefab;
    protected ModalWindow modalWindow;

    private static GManager thatObject;
    public static GManager Instance { get { return thatObject; } }

    public void ShowModalWindow(string text, Canvas canvas)
    {
        if (!ModalWindow.IsInstanciated)
        {
            modalWindow= Instantiate(modalWindowPrefab, canvas.transform).GetComponent<ModalWindow>();
        }
        modalWindow.Set(text);
    }

    private void Awake()
    {
        thatObject = this;
    }
}
