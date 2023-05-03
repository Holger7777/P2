using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class VolumeSlider : MonoBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] private TextMeshProUGUI slidertext;

    void Start()
    {
        slider.onValueChanged.AddListener((v) =>{
            slidertext.text = v.ToString("0.00");
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
