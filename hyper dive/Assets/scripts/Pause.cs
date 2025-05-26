using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Pause : MonoBehaviour
{

    public static bool isPaused = false;
    public GameObject PauseMenuUI;
    public GameObject GameOverMenuUI;
    public GameObject player2ndLife;
    //public levelManager level;
    //public move gamePlayer;
    //public spawner spawn;
    public GameObject disableContinue;
    public GameObject start_after_adpanal;
    public GameObject pleaseWaitpanal;
    public GameObject player;
    public void Update()
    {

    }

    public void Resume()
    {
        //SceneManager.LoadScene("SampleScene");
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        player.SetActive(true);
        isPaused = false;
    }
    public void pause()
    {
        //SceneManager.LoadScene("pause");
        PauseMenuUI.SetActive(true);
        player.SetActive(false);
        Time.timeScale = 0f;
        isPaused = true;
    }
    public void continueBySeeingAds()
    {
        //GameOverMenuUI.SetActive(false);
        //Time.timeScale = 1f;
        //pleaseWaitpanal.SetActive(true);
        disableContinue.SetActive(false);
        //start_after_adpanal.SetActive(true);
        //GameObject.Find("Player").SetActive(true);
    }

    public void afterExtraLife()
    {
        player2ndLife.SetActive(true);
        Time.timeScale = 1f;
        start_after_adpanal.SetActive(false);
       // GameObject.Find("Player").SetActive(true);
        
        
    }
    public void quitGame()
    {
        SceneManager.LoadScene("start");
        Time.timeScale = 1f;
    }
    public void RestartGame()
    {

        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1f;
        //this is to reset the score..
        //gamePlayer.gameOver.SetActive(false);

    }
    public void store()
    {
        PlayerPrefs.SetInt("Is2500Sold", 0);
        PlayerPrefs.SetInt("Is5000Sold", 0);
        PlayerPrefs.SetInt("Is7500Sold", 0);
        PlayerPrefs.SetInt("Is15000Sold", 0);
        PlayerPrefs.SetInt("Is50000Sold", 0);
        PlayerPrefs.SetInt("Is75000Sold", 0);
        PlayerPrefs.SetInt("Is100000Sold", 0);
        PlayerPrefs.SetInt("Is150000Sold", 0);
        SceneManager.LoadScene("skinShop");
    }

}