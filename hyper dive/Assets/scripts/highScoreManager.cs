using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class highScoreManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Text highscoreText;
    void Start()
    {
        highscoreText.text = "" + PlayerPrefs.GetFloat("Highscore");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
