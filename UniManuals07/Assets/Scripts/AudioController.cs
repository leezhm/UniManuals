using UnityEngine;
using System.Collections;

//
//	Must contain AudioSource component.
//
[RequireComponent(typeof(AudioSource))]
public class AudioController : MonoBehaviour 
{
	public AudioClip GunClip = null; 

	// Use this for initialization
	void Start () 
	{
		audio.loop = true;
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	
	void OnGUI()
	{
		if(GUILayout.Button("Play/Continue"))
		{
			if(!audio.isPlaying)
			{
				audio.Play();
			}
		}
		
		if(GUILayout.Button("Pause"))
		{
			audio.Pause();
		}
		
		if(GUILayout.Button("Stop"))
		{
			audio.Stop();
		}
		
		if(GUILayout.Button("PlayOneShot"))
		{
			audio.PlayOneShot(GunClip, 0.8f);		
		}
	}
}
