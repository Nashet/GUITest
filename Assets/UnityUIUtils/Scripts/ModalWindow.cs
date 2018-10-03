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

    protected bool isMouseInside;
    public static bool IsInstanciated { get; protected set; }
    
    
    protected void Start ()
    {
        IsInstanciated = true;
    }

    internal void Set(string text)
    {
        generalText.text = text;
    }

    // Update is called once per frame
    protected void Update ()
    {
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
