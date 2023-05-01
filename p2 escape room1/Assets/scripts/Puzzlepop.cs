using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puzzlepop : MonoBehaviour
{
    
        public GameObject popupPanel;
        public Button closeButton;

        private void Start()
        {
            // Hide the popup panel on start
            popupPanel.SetActive(false);

            // Add an event listener to the close button
            closeButton.onClick.AddListener(HidePopup);
        }

        private void OnMouseDown()
        {
            // Show the popup panel when the game object is clicked
            popupPanel.SetActive(true);
        }

        private void HidePopup()
        {
            // Hide the popup panel when the close button is clicked
            popupPanel.SetActive(false);
        }
    
}
