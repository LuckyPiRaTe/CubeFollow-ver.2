using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class UIController : MonoBehaviour
{
    [SerializeField] private GameObject goScreen;
    [SerializeField] private GameObject pauseScreen;
    [SerializeField] Text score;

    private void GameOn(){
        Time.timeScale = 1;
    }
    private void GameOff(){
        Time.timeScale = 0;
    }
    public void StartNewGameButton(){
        GameOn();
        SceneManager.LoadScene(1);
    }
    public void PauseButtonOn(){
        pauseScreen.SetActive(true);
        GameOff();
    }
    public void PauseButtonOff(){
        pauseScreen.SetActive(false);
        GameOn();
    }
    public void GameOverScreenOn(){
        GameOff();
        goScreen.SetActive(true);
    }

    public void Score(int coint){
        score.text = "Score " + coint;
    }
}
