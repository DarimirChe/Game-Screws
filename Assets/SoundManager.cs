using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayerPrefs = Assets.Scripts.PlayerPrefsWrapper;

public class SoundManager : MonoBehaviour
{
    // Start is called before the first frame update
    public bool sound;
	private void Update()
	{
		//Debug.Log(sound);
	}
	private void Start()
	{
		if (UnityEngine.PlayerPrefs.HasKey("sound"))
		{
			saveSettings();
		}
		else
		{
			ChangedValue();
		}
	}
	public void ChangedValue()
	{
		sound = !sound;
		PlayerPrefs.SetBool("sound", sound);
	}
	public void saveSettings()
	{
		sound = PlayerPrefs.GetBool("sound");
	}
}
