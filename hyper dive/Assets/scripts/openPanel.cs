using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openPanel : MonoBehaviour
{
    public GameObject open;

    // Start is called before the first frame update
   public void OpenPanel()
    {
        if (open != null)
        {
            open.SetActive(true);
        }
    }

}
