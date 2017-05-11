using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {

    public Canvas menu;
    public Button play;
    public Button store;
    public Button exit;

	// Use this for initialization
	void Start () {
        menu = menu.GetComponent<Canvas>();
        play = play.GetComponent<Button>();
        store = store.GetComponent<Button>();
        exit = exit.GetComponent<Button>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

}
