using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    public GameObject WinDoor;

    private void FixedUpdate()
    
    {
        GameObject puzzle1 = GameObject.FindGameObjectWithTag("puzzle1");
        GameObject puzzle2 = GameObject.FindGameObjectWithTag("puzzle2");
        GameObject puzzle3 = GameObject.FindGameObjectWithTag("puzzle3");
        if (puzzle1 == null && puzzle2 == null && puzzle3 == null && SceneManager.GetActiveScene().name == "BlueRoom")
        {
            WinDoor.SetActive(true);
        }
    }
}
