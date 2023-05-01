using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzlefinish : MonoBehaviour
{
   

    private void OnMouseDown()
    {
      
        Destroy(GameObject.FindGameObjectWithTag("puzzle"));
    }

    void Update()
    {
        
        {

        }
    }
}
