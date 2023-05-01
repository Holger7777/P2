using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzlefinish : MonoBehaviour
{
  
    public ParticleSystem particles;

    private void Start()
    {
        particles.Stop();
    }

    private void OnMouseDown()
    {
        Debug.Log("Button clicked!");

        particles.Play();
    }
}