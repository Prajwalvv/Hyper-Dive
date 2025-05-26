using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backFromGemsShop : MonoBehaviour
{
    public GameObject gemShop;
    public void backToSkinShop()
    {

        gemShop.SetActive(false);
    }
    public void goToSkinShop()
    {

        gemShop.SetActive(true);
    }
}
