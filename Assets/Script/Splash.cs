using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Splash : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Invoke("changescene", 3f);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
  
    void changescene()
    {
        
        Application.LoadLevel("menu");

    }

}
