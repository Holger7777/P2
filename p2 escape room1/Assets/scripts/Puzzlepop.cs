using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class Puzzlepop : MonoBehaviour
{
    
        public GameObject popupPanel;
        public Button closeButton;
        public FPCamera Camera;



    private void Start()
        {
            // Hide the popup panel on start
            popupPanel.SetActive(false);
            
        

        // Add an event listener to the close button
        closeButton.onClick.AddListener(HidePopup);
        
        }
        // https://docs.unity3d.com/ScriptReference/MonoBehaviour.OnMouseDown.html

        private void OnMouseDown()
        {
            if (!EventSystem.current.IsPointerOverGameObject())
            {
            // Show the popup panel when the game object is clicked
            popupPanel.SetActive(true);

            Camera.sensitivity = 0f;
            }
    }

        private void HidePopup()
        {
            // Hide the popup panel when the close button is clicked
            popupPanel.SetActive(false);

            Camera.sensitivity = Camera.sensitivitySetting;

    }

   

}
