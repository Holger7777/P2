using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FPC : MonoBehaviour
{

    // Camera sensitivity
    public float sensitivity = 100f;

    // Minimum and maximum vertical camera angle
    public float minVerticalAngle = -90f;
    public float maxVerticalAngle = 90f;

    // Mouse drag variables
    private bool isDragging = false;
    private Vector3 lastMousePosition;


    // Update is called once per frame
    void Update()
    {
        // Check if the player is clicking and dragging the mouse
        if (Input.GetMouseButtonDown(0))
        {
            isDragging = true;
            lastMousePosition = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            isDragging = false;
        }

        // Rotate the camera if the player is dragging the mouse
        if (isDragging)
        {
            // Get the mouse movement since the last frame
            float mouseX = Input.mousePosition.x - lastMousePosition.x;
            float mouseY = Input.mousePosition.y - lastMousePosition.y;

            // Rotate the camera horizontally around the y-axis
            transform.Rotate(Vector3.up, mouseX * sensitivity * Time.deltaTime);

            // Rotate the camera vertically around the x-axis
            float verticalRotation = transform.localEulerAngles.x;
            verticalRotation -= mouseY * sensitivity * Time.deltaTime;
            verticalRotation = Mathf.Clamp(verticalRotation, minVerticalAngle, maxVerticalAngle);
            transform.localEulerAngles = new Vector3(verticalRotation, transform.localEulerAngles.y, 0f);

            // Update the last mouse position
            lastMousePosition = Input.mousePosition;
        }

        // Move the camera horizontally if the player is holding down the left mouse button and moving the mouse horizontally
        if (isDragging && Input.GetAxis("Mouse X") != 0)
        {
            float mouseX = Input.GetAxis("Mouse X");
            transform.Translate(Vector3.right * mouseX * sensitivity * Time.deltaTime, Space.Self);
        }
    }
}
