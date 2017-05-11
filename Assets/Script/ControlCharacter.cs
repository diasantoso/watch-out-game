using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCharacter : MonoBehaviour {
   [System.Serializable]

    public class CAnimationClips
    {
        public AnimationClip Clips;
        public WrapMode Wrap;
        public KeyCode PressedKey;
    }

    public GameObject Character;
    public AnimationClip Idle;
    public KeyCode Jump = KeyCode.UpArrow;
    public KeyCode Jongkok = KeyCode.DownArrow;

    public CAnimationClips lompat;
    public CAnimationClips jongkok;
    public CAnimationClips berdiri;

    public float Speed = 1;
    int charStatus ;
    Vector3 MoveDirection;
    CharacterController myController;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        charStatus = 0;
        MoveDirection = Vector3.zero;

        if(Input.GetKey(lompat.PressedKey) ||   Input.GetKey(KeyCode.UpArrow))
        {
            charStatus = 1;

            Character.GetComponent<Animation>().wrapMode = lompat.Wrap;
            Character.GetComponent<Animation>().CrossFade(lompat.Clips.name);
        }
        if(Input.GetKey(jongkok.PressedKey) || Input.GetKey(jongkok.PressedKey))
        {
            charStatus = 2;

            Character.GetComponent<Animation>().wrapMode = jongkok.Wrap;
            Character.GetComponent<Animation>().CrossFade(jongkok.Clips.name);
        }
        if (charStatus == 1)
        {
            myController = GetComponent<CharacterController>();

            if (Input.GetKey(Jump))
            {
                MoveDirection = Vector3.up * Speed;
            }
            else if (Input.GetKey(Jongkok))
            {
                MoveDirection = Vector3.down * Speed;
            }

           
        }
        if (charStatus == 0)
        {
            Character.GetComponent<Animation>().wrapMode = WrapMode.Loop;
            Character.GetComponent<Animation>().CrossFade(berdiri.Clips.name);

        }

    }
}
