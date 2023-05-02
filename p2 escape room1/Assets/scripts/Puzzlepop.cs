using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Puzzlepop : MonoBehaviour
{
    
        public GameObject popupPanel;
        public Button closeButton;
        public ParticleSystem particles;
        public Button win;
        public FPCamera camera;



    private void Start()
        {
            // Hide the popup panel on start
            popupPanel.SetActive(false);
            particles.Stop();
        

        // Add an event listener to the close button
        closeButton.onClick.AddListener(HidePopup);
        win.onClick.AddListener(ParStart);
        }
        // https://docs.unity3d.com/ScriptReference/MonoBehaviour.OnMouseDown.html

        private void OnMouseDown()
        {
            
            // Show the popup panel when the game object is clicked
            popupPanel.SetActive(true);

            camera.sensitivity = 0f;

    }

        private void HidePopup()
        {
            // Hide the popup panel when the close button is clicked
            popupPanel.SetActive(false);

            camera.sensitivity = 100f;

    }

    private void ParStart()
    {
        particles.Play();
    }

}
