using UnityEngine;
using System.Collections;

public class ShowTexture : MonoBehaviour 
{
	/// <summary>
	/// Create texture2D variables
	/// </summary>
	private Texture2D oneTexture = null;
	private Object[]  allTextures = null;
	
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	
	void OnGUI()
	{
		// Draw two button
		if(GUI.Button(new Rect(20, 120, 160, 40), "Load One Texture"))
		{
			if(null == oneTexture)
			{
				//
				//	Pls Note, do not need the file extension.
				//
				oneTexture = Resources.Load("OneTexture/1") as Texture2D;
			}
		}
		
		// Draw the oneTexture
		if(null != oneTexture)
		{
			GUI.DrawTexture(new Rect(200, 20, 240, 240), oneTexture, ScaleMode.StretchToFill, true, 0);
		}
				
				
		if(GUI.Button(new Rect(20, 400, 160, 40), "Load All Textures"))
		{
			if(null == allTextures)
			{
				allTextures = Resources.LoadAll("AllTextures");
			}
		}
		
		// Draw allTexture
		if(null != allTextures)
		{
			for (int i = 0; i < allTextures.Length; i++)
			{
				GUI.DrawTexture(new Rect(200 + i * (240 + 20), 300, 240, 240), (Texture2D)allTextures[i],
					ScaleMode.StretchToFill, true, 0);
			}
		}
	}
}
