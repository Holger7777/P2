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
    private float inputX;

    //When we start the game we load the saved sensitivtySetting
    void Start()
        {
            sensitivity = sensitivitySetting;
            Load();
        }

    void Update()
    {
        //The Update checks whether our invert int = 1. If it is we invert our camera
        if(invert == 1)
        {
            inverted = true;
        }

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
            float mouseX = Input.mousePosition.x - lastMousePosition.x; // Calculate the distance the mouse moved horizontally
            transform.Rotate(Vector3.up, mouseX * sensitivity * Time.deltaTime, Space.World);  // Rotate the camera

            lastMousePosition = Input.mousePosition; // Update the last mouse position
        }

        if (isDragging && Input.GetAxis("Mouse X") != 0 && inverted == true)
        {
            float mouseX = 0 - Input.mousePosition.x + lastMousePosition.x;
            transform.Rotate(Vector3.up, mouseX * sensitivity * Time.deltaTime, Space.World);
            lastMousePosition = Input.mousePosition;
        }

        inputX = Input.GetAxis("Horizontal");

        if(inputX != 0)
        {
            rotate();
        }

    }
      //Loads if we had changed the invert integer
      private void Load()
        {
            invert = PlayerPrefs.GetInt("cameraInvert");
        }

        //Saves if we had changed the invert integer
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

        private void rotate()
        {
            transform.Rotate(new Vector3(0f, inputX * Time.deltaTime * sensitivity * 5, 0f));
        }
}
