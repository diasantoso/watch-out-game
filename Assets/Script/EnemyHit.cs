using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHit : MonoBehaviour {
   
    public GameController gameController;
    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }
    void OnCollisionEnter(Collision other)
    {
        // End the game if an enemy not in the dying state hits us.
        if (other.gameObject.name == "GameLogic"||other.gameObject.tag == "Enemy")
        {
            Debug.Log("Hit");
            MoveEnemy en = other.gameObject.GetComponent<MoveEnemy>(); animator.SetBool("isDead", true);
            Destroy(other.gameObject);
          /*  if (!en.IsDying())
            {

                // Character.GetComponent<Animation>().wrapMode = dead.Wrap;
                //Character.GetComponent<Animation>().CrossFade(dead.Clips.name);

                gameController.GameOver(false);
            }
            else
            {

                
            }
            */
        }
    }
   
}
  

