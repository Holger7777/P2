using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// https://www.youtube.com/watch?v=mYmgBRdWPr4&ab_channel=Rs_Comp

public class Popup : MonoBehaviour
{
    public Canvas canvas;
    public bool a = false;
    public void popup()
    {
        if (a == false)
        {
            a = true;
            canvas.enabled = true;
        }else if (a == true)
        {
            a = false;
            canvas.enabled = false;
        }
    }
}
