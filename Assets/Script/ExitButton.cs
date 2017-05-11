using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitButton : MonoBehaviour {
	public AudioSource audio;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnMouseDown(){
		audio.Play ();
		Invoke("changescene",1f);
		dialog ();
	}
	void dialog()
	{
		if (UnityEditor.EditorUtility.DisplayDialog ("Konfirmasi", "Apakah Anda Yakin Ingin Keluar ? ", "Ya", "Tidak")) {
			Application.Quit();
			Debug.Log("Sprite Clicked");
			audio.Play ();
			Invoke("changescene", 1f);
		}
	}
}
