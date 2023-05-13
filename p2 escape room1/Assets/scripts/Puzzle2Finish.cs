using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle2Finish : MonoBehaviour
{
    public GameObject lock1;
    public GameObject lock2;
    public GameObject lock3;
    public GameObject lock4;
    public GameObject lock5;
    public GameObject lock6;
    public GameObject Completed;
    public ParticleSystem Particle1;
    public AudioSource torchfire;

    // Start is called before the first frame update
    void Awake()
    {
        Particle1.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        if (lock1.activeSelf & lock2.activeSelf & lock3.activeSelf & lock4.activeSelf & lock5.activeSelf & lock6.activeSelf)
        {
            Completed.SetActive(true);
            Debug.Log("det vierk");
            Particle1.Play();
            torchfire.Play();
        }

    }
}
