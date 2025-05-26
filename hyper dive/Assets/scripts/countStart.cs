using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class countStart : MonoBehaviour
{
    public Text countDownText;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CountDown());
       
    }

    IEnumerator CountDown()
    {
        
        countDownText.text = "5";
        yield return new WaitForSeconds(0.5f);
        countDownText.text = "2";
        yield return new WaitForSeconds(0.5f);
        countDownText.text = "1";
        yield return new WaitForSeconds(0.5f);
        countDownText.text = "GO";
        yield return new WaitForSeconds(0.5f);

        countDownText.gameObject.SetActive(false);
        

    }

}
