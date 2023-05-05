using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPCamera : MonoBehaviour
{
    public float sensitivity = 100f;
    private bool isDragging = false;
    private Vector3 lastMousePosition;
    public bool inverted = false;

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
    }

        public void Invert()
        {
        if(inverted == false)
        {
            inverted = true;
        }

        else
        {
            inverted = false;
        }
        }
}
