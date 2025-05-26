using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class startButton : MonoBehaviour
{

    public Text highScoreText;
    float HighSoreAmount;
    public void Start()
    {
        HighSoreAmount = PlayerPrefs.GetFloat("Highscore");
    }

    public void Update()
    {
        highScoreText.text = HighSoreAmount.ToString();
    }

    public void start()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("SampleScene");
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
