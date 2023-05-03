using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.ParticleSystem;

public class Destroyer : MonoBehaviour
{
    public ParticleSystem Particle1;
    public ParticleSystem Particle2;
    public ParticleSystem Particle3;
    // Start is called before the first frame update
    void Start()
    {
        Particle1.Stop();
       Particle2.Stop();
         Particle3.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        GameObject puzzle1 = GameObject.FindGameObjectWithTag("puzzle1");
        GameObject puzzle2 = GameObject.FindGameObjectWithTag("puzzle2");
        GameObject puzzle3 = GameObject.FindGameObjectWithTag("puzzle3");

        if (puzzle1== null)
        {
           
            Particle1.Play();
        }
        else if(puzzle2 = null)
        {
            Particle2.Play();
        }
       else if (puzzle3 == null)
        {
            Particle3.Play();
        }
    }


    void ParStart()
    {
        Particle1.Play();
        Particle2.Play();
        Particle3.Play();
    }
}
