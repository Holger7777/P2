using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    public GameObject WinDoor;
    public ParticleSystem particle1;
    public ParticleSystem particle2;
    public ParticleSystem particle3;
    private bool PPlaying;

    private void Update()
    
    {

        if (particle1.isPlaying && particle2.isPlaying && particle3.isPlaying)
        {
            PPlaying = true;

        }
        else if ((!particle1.isPlaying || !particle2.isPlaying || !particle3.isPlaying) && PPlaying)
        {
            PPlaying=false;
        }
        WinDoor.SetActive(PPlaying);
    }
    
}
