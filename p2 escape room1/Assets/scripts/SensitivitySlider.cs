using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SensitivitySlider : MonoBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] private TextMeshProUGUI slidertext;
    public FPCamera Camera;

    void Start()
    {
        slider.onValueChanged.AddListener((v) =>{
            slidertext.text = v.ToString("0");
        });

        if(!PlayerPrefs.HasKey("cameraSensitivity"))
        {
            PlayerPrefs.SetFloat("cameraSensitivity", 20);
            Load();
        }

        else
        {
            Load();
        }

    }
          public void ChangeSensitivity()
        {
            Camera.sensitivitySetting = slider.value;
            Save();
        }

        private void Load()
        {
            slider.value = PlayerPrefs.GetFloat("cameraSensitivity");
        }

        private void Save()
        {
            PlayerPrefs.SetFloat("cameraSensitivity", slider.value);
        }
}
