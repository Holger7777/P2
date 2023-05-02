using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuPop : MonoBehaviour
{
    public GameObject popupPanel;
    public Button closeButton;

    private void Start()
    {
        // Hide the popup panel on start
        popupPanel.SetActive(false);

        closeButton.onClick.AddListener(HidePopup);
    }
    // https://docs.unity3d.com/ScriptReference/MonoBehaviour.OnMouseDown.html

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
 
