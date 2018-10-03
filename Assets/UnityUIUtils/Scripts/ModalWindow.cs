using Nashet.UnityUIUtils;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

/// <summary>
/// Can be only 1 instance
/// </summary>
public class ModalWindow : Hideable, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField]
    protected Text generalText;

    public static ModalWindow Instance { get; protected set; }
    protected bool isMouseInside;
    
    protected void Start ()
    {    
        Instance = this;        
        //todo add check for multiple objects with that script
    }

    /// <summary>
    /// Overwrites previous modal window if it was open
    /// </summary>    
    internal static void Show(string text)
    {
        Instance.generalText.text = text;
        Instance.Show();
    }

    // Update is called once per frame
    protected void Update ()
    {
        // close if clicked outside
        if (Input.GetMouseButtonUp(0) && !isMouseInside)
            Hide();
    }    

    public void OnPointerEnter(PointerEventData eventData)
    {
        isMouseInside = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        isMouseInside = false;
    }
}
