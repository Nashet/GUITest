using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Some game content
/// </summary>
public class Game : MonoBehaviour
{
    [SerializeField] protected Canvas canvas;

    // Use this for initialization
    protected void Start()
    {
        GManager.Instance.ShowModalWindow("Some text!", canvas);
    }
}
