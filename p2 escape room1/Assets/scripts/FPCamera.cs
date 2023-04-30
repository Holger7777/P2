using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPCamera : MonoBehaviour
{
    public float sensitivity = 100f;
    private bool isDragging = false;
    private Vector3 lastMousePosition;

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

        if (isDragging && Input.GetAxis("Mouse X") != 0)
        {
            float mouseX = Input.mousePosition.x - lastMousePosition.x;
            transform.Rotate(Vector3.up, mouseX * sensitivity * Time.deltaTime, Space.World);
            lastMousePosition = Input.mousePosition;
        }
    }
}
