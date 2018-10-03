using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Nashet.UnityUIUtils;
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
            StartCoroutine(RespawnModalWindow());
        }

        public void ShowAnotherWindow()
        {
            ModalWindow.Show("Another modal is here");
        }

        private IEnumerator RespawnModalWindow()
        {
            for (int i = 0; i < 100; i++)
            {
                yield return new WaitForSeconds(5);
                ShowAnotherWindow();
            }
        }
    }
}