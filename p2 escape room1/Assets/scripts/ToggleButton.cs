using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleButton : MonoBehaviour
{
	public Sprite OnButton;
	public Sprite OffButton;
	public Button button;
	public FPCamera Camera;

   void Update()
	{
		if(Camera.inverted == true)
		{
			button.image.sprite = OnButton;
		}	
		else
		{
			button.image.sprite = OffButton;
		}
		

	}
}
