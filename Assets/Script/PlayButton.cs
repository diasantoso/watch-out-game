using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButton : MonoBehaviour {
	public AudioSource audio;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
	}
	void OnMouseDown(){
		Debug.Log("Sprite Clicked");
		audio.Play ();
		Invoke("changescene", 1f);

	}
	void changescene()
	{
		Application.LoadLevel ("kepalaSekolah");

	}
}
