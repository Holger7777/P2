using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// https://www.youtube.com/watch?v=mYmgBRdWPr4&ab_channel=Rs_Comp

public class Popup : MonoBehaviour
{
   public Canvas canvas;
   public FPCamera Camera;

    private void Start()
    {
        // Hide the popup panel on start
        canvas.enabled = false;
    }

    public void popup()
    {
        if (canvas.enabled == false)
        {
            
            canvas.enabled = true;
        }else if (canvas.enabled == true)
        {
           
            canvas.enabled = false;
        }
    }
    public void cameraLock()
    {
        if (Camera.sensitivity != 0)
        {
            Camera.sensitivity = 0;
        }
    }

    public void cameraUnlock()
    {
        if (Camera.sensitivity == 0)
        {
            Camera.sensitivity = 20;
        }
    }
}

