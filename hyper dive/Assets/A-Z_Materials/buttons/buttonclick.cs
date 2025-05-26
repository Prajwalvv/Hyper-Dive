using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonclick : MonoBehaviour

{
    public GameObject soundcontrolButton;
    public Sprite audiooffSprite;
    public Sprite audioOnSprite;
    // Start is called before the first frame update
    void Start()
    {
        if (AudioListener.pause == true)
        {
            soundcontrolButton.GetComponent<Image>().sprite = audiooffSprite;
        }
        else
        {
            soundcontrolButton.GetComponent<Image>().sprite = audioOnSprite;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void SoundControl()
    {
        if (AudioListener.pause == true)
        {
           //AudioListener.pause = false;  
            soundcontrolButton.GetComponent<Image>().sprite = audioOnSprite;

        }
        else
        {
            //sAudioListener.pause = true;
            soundcontrolButton.GetComponent<Image>().sprite = audiooffSprite;


        }
    }
}