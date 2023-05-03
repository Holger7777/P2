using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Torch1Control : MonoBehaviour
{
    public ParticleSystem particle1;
    // Start is called before the first frame update
    void Start()
    {
        particle1.Stop();
    }


    // Source https://docs.unity3d.com/ScriptReference/MonoBehaviour.OnMouseOver.html
    void OnMouseOver()
    {

        if (!particle1.isPlaying)
        {
            particle1.Play();
            Debug.Log("huh");
        }
    }
        void OnMouseExit()
        {

        
            Debug.Log("gone");
            particle1.Stop();
        
    }

      

       
       
    }

