using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace GUITest
{
    /// <summary>
    /// Some game content
    /// </summary>
    public class Game : MonoBehaviour
    { 
        // Use this for initialization
        protected void Start()
        {            
            ModalWindow.Show("Some text!");

            // test second call to ModalWindow.Show()
            Invoke("ShowAnotherWindow", 10.0f);
        }

        private void ShowAnotherWindow()
        {
            ModalWindow.Show("Another modal is here");
        }
    }
}