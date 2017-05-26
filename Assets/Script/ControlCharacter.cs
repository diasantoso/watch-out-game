using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCharacter : MonoBehaviour {

    public GameObject Character;
  
    public KeyCode Jump = KeyCode.UpArrow;
    public KeyCode Jongkok = KeyCode.DownArrow;

    public float Speed = 1;
    int charStatus ;
    Vector3 MoveDirection;
    CharacterController myController;

	// Use this for initialization
	void Start () {
        Character.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        charStatus = 0;
        MoveDirection = Vector3.zero;

        if(Input.GetKey(KeyCode.UpArrow))
        {
            charStatus = 1;

            Character.GetComponent<Animator>().SetBool("isJump", true);
        }
        if(Input.GetKey(KeyCode.DownArrow))
        {
            charStatus = 2;
            Character.GetComponent<Animator>().SetBool("isNunduk", true);
        }
        if (charStatus == 1)
        {
            myController = GetComponent<CharacterController>();

            if (Input.GetKey(Jump))
            {
                MoveDirection = Vector3.up * Speed;
            }

        }
        else if (charStatus == 2)
        {
            if (Input.GetKey(Jongkok))
            {
                MoveDirection = Vector3.down * Speed;
            }
        }
           
        else if(charStatus == 0)
        {
            Character.GetComponent<Animator>().SetBool("isIdle", true);
        }

    }
}
