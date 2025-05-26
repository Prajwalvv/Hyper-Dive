using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class infoOUT_IN : MonoBehaviour
{
    public GameObject open;
    


    public void openPanal()
    {
        open.SetActive(true);
    }
    public void backPanal()
    {
        open.SetActive(false);
    }
}
