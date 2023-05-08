using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPCamera : MonoBehaviour
{
    public float sensitivity = 100f;
    public float sensitivitySetting = 100f;
    private bool isDragging = false;
    private Vector3 lastMousePosition;
    public bool inverted = false;
    public int invert = 0;

    void Start()
        {
            sensitivity = sensitivitySetting;
            Load();
 
        }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isDragging = true;
            lastMousePosition = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            isDragging = false;
        }

        if (isDragging && Input.GetAxis("Mouse X") != 0 && inverted == false)
        {
            float mouseX = Input.mousePosition.x - lastMousePosition.x;
            transform.Rotate(Vector3.up, mouseX * sensitivity * Time.deltaTime, Space.World);
            lastMousePosition = Input.mousePosition;
        }

        if (isDragging && Input.GetAxis("Mouse X") != 0 && inverted == true)
        {
            float mouseX = 0 - Input.mousePosition.x + lastMousePosition.x;
            transform.Rotate(Vector3.up, mouseX * sensitivity * Time.deltaTime, Space.World);
            lastMousePosition = Input.mousePosition;
        }

            if(invert == 1)
            {
                inverted = true;
            }
    }
     private void Load()
        {
            invert = PlayerPrefs.GetInt("cameraInvert");
        }

        private void Save()
        {
            PlayerPrefs.SetInt("cameraInvert", invert);
        }

        public void Invert()
        {
        if(inverted == false)
        {
            inverted = true;
            invert = 1;
            Save();
        }

        else
        {
            inverted = false;
            invert = 0;
            Save();
        }
        }
}
