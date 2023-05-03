using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torch1Control : MonoBehaviour
{
    public ParticleSystem particle1;
    // Start is called before the first frame update
    void Start()
    {
        particle1.Stop();
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Source https://docs.unity3d.com/ScriptReference/MonoBehaviour.OnMouseOver.html
    void OnMouseOver()
    {

        OnParStart();
    }
        void OnMouseExit()
        {

            OnParticleEnd();
        }

        void OnParStart()
        {
            particle1.Play();
            Debug.Log("huh");
        }

        void OnParticleEnd()
        {
            Debug.Log("gone");
            particle1.Stop();
        }
    }

