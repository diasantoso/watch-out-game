using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
    public bool isGameOver;
    public int isMenu;
    public Text scoreTxt;
    public Text gameOverTxt;
  //  public Text cd;
    public Canvas gameOverCanvas;
    public Canvas menuCanvas;
   
    public Canvas countDown;
    public Button playAgain;
   
    //public EnemySpawner _enemySpawner;

    private int _currScore;
    private int _scoreToWin = 2;
    private bool _didIWin;
    /// <summary>
    /// Start a new game.
    /// </summary>
    void NewGame()
    {
        ResetGame();
    }
    

    /// <summary>
    /// Got an enemy! Increment the score and see if we win.
    /// </summary>
    public void GotOne()
    {
        _currScore++;
        scoreTxt.text = "" + _currScore;
        if (_currScore >= _scoreToWin)
        {
            GameOver(true);
        }
    }

    /// <summary>
    /// Game's over. 
    /// </summary>
    /// <param name="didIWin">Did the playeer win?</param>	
    public void GameOver(bool didIWin)
    {
        isGameOver = true;
        // We'll be using this more later. I know this looks pointless now.
        _didIWin = didIWin;
        if (_didIWin == false)
        {
            playAgain.interactable = true;
           
            gameOverTxt.text = "You Lose";
        }
        //gameOverTxt.text = (_didIWin) ? "You won!" : "Too bad";
        gameOverCanvas.enabled = true;
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        //    GameObject[] enemies2 = GameObject.FindGameObjectsWithTag("DontShootThis");
        foreach (GameObject enemy in enemies)
        {
            Destroy(enemy);
        }

        GameObject[] kepalasekolah = GameObject.FindGameObjectsWithTag("player");
        foreach (GameObject kepala_sekolah2 in kepalasekolah)
        {
            Destroy(kepala_sekolah2);
        }
    }


    /// <summary>
    /// Resets the interface, removes remaining game objects. Basically gets us to a point
    /// where we're ready to play again.
    /// </summary>
    public void ResetGame()
    {
        // Reset the interface
        gameOverCanvas.enabled = false;
        countDown.enabled = false;
        isGameOver = false;
        _currScore = 0;
        scoreTxt.text = "--";
        // Remove any remaining game objects
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        //GameObject[] enemies2 = GameObject.FindGameObjectsWithTag("DontShootThis");
        foreach (GameObject enemy in enemies)
        {
            Destroy(enemy);
        }

        GameObject[] kepala_sekolah = GameObject.FindGameObjectsWithTag("KepalaSekolah");
        foreach (GameObject KepalaSekolah in kepala_sekolah)
        {
            Destroy(KepalaSekolah);
        }
    }

    public void ResetGameAgain()
    {
        gameOverCanvas.enabled = false;
       
        countDown.enabled = false;
        isGameOver = false;
        _currScore = 0;
        scoreTxt.text = "--";
        isMenu = 0;
      // cd.text = "";
        // Remove any remaining game objects
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        // GameObject[] enemies2 = GameObject.FindGameObjectsWithTag("DontShootThis");
        foreach (GameObject enemy in enemies)
        {
            Destroy(enemy);
        }
        /*  foreach (GameObject enemy2 in enemies2)
          {
              Destroy(enemy2);
          }*/
        GameObject[] kepala_sekolah2 = GameObject.FindGameObjectsWithTag("player");
        foreach (GameObject KepalaSekolah in kepala_sekolah2)
        {
            Destroy(KepalaSekolah);
        }

    }

    public void MenuGame()
    {
        // Reset the interface
        menuCanvas.enabled = false;
      //  stageI.enabled = true;
    }


  /*  IEnumerator LoseTime()
    {
        int timeCount = 4;
        while (true)
        {
            yield return new WaitForSeconds(1);
            timeCount--;
            cd.text = timeCount.ToString();
            if (timeCount <= 0)
            {
                StopCoroutine("LoseTime");
                isMenu = 1;
                countDown.enabled = false;
            }
        }
    }
    */

    void Start()
    {
        NewGame();
    }
}
