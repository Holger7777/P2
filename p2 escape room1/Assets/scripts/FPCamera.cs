using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPCamera : MonoBehaviour
{
    //sensitivity is the sensitivity the camera is currently using
    public float sensitivity = 100f;
    //sensitivitySetting is the variable the sensitivity slider in the settings changes
    //and is used to change the sensitivity to the chosen setting. It's also the float
    //value we use with PlayerPrefs to save the sensitivity between scenes and playthroughs
    public float sensitivitySetting = 100f;
    private bool isDragging = false;
    private Vector3 lastMousePosition;
    //The inverted bool is used to check whether the camera has been inverted or not 
    public bool inverted = false;
    //invert is an integer we use with PlayerPrefs to save whether the player
    //wants the camera inverted between scenes and playthroughs
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

        //If our mouse button is held down, the isDragging bool is set to true
        //and we define the position where we clicked on the screen
        if (Input.GetMouseButtonDown(0))
        {
            isDragging = true;
            lastMousePosition = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            isDragging = false;
        }

        //Then if we move the mouse along the X-axis our camera will move in that direction
        //The speed of the movement is defined by where we originally clicked on the screen and
        //where our mouse currently is, with the sensitivity variable as a modifier
        if (isDragging && Input.GetAxis("Mouse X") != 0 && inverted == false)
        {
            float mouseX = Input.mousePosition.x - lastMousePosition.x;
            transform.Rotate(Vector3.up, mouseX * sensitivity * Time.deltaTime, Space.World);
            lastMousePosition = Input.mousePosition;
        }

        //But if the inverted bool is true, the camera moves in the opposite direction instead
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

        //The invert function checks whether the camera is inverted.
        //If it isn't, we invert it, else we un-invert it
        //This function is called by our invert camera button on the settings panel
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

    //This function uses the A and D buttons to rotate the camera instead of the mouse
    //This uses Unity's input manager
    private void rotate()
    {
   transform.Rotate(new Vector3(0f, inputX * Time.deltaTime * sensitivity * 5, 0f));
    }
}
