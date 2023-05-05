using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleButton : MonoBehaviour
{
	public Sprite OnButton;
	public Sprite OffButton;
	public Button button;

   public void Toggle()
	{
		if(button.image.sprite == OffButton)
		{
			button.image.sprite = OnButton;
		}	
		else
		{
			button.image.sprite = OffButton;
		}
		

	}
}
