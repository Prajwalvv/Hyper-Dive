using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreManager : MonoBehaviour
{
    public float respawnDelay;
    public move gamePlayer;
    public static scoreManager instance;
    public int score;
    public UnityEngine.UI.Text coinText_score;
    // Use this for initialization
    //public scoreManager gameScore;
    private void Awake()
    {
        instance = this;
    }




    void Start()
    {
        gamePlayer = FindObjectOfType<move>();
        coinText_score.text =  "" + score;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Respawn()
    {
        StartCoroutine("RespawnCoroutine");
    }
    public IEnumerator RespawnCoroutine()
    {
        gamePlayer.gameObject.SetActive(false);
        yield return new WaitForSeconds(respawnDelay);
        gamePlayer.gameObject.SetActive(true);
    }
    public void AddCoins(int numberOfCoins)
    {
        score += numberOfCoins;
        coinText_score.text = "" + score;

        highScore_save();
    }
    public void highScore_save()
    {
        if (PlayerPrefs.GetFloat("Highscore") < score)
        
            PlayerPrefs.SetFloat("Highscore", score);
        
    }
    public void ResetScore()
    {
        score = 0;

    }
}