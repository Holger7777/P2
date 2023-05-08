using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle1Finish : MonoBehaviour
{
    public GameObject lock1;
    public GameObject lock2;
    public GameObject lock3;
    public GameObject lock4;
    public GameObject Completed;
    public ParticleSystem Particle1;

    // Start is called before the first frame update
    void Start()
    {
        Particle1.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        if (lock1.activeSelf & lock2.activeSelf & lock3.activeSelf & lock4.activeSelf)
        {
            Completed.SetActive(true);
            Debug.Log("det vierk");
            Particle1.Play();
        }

    }
}