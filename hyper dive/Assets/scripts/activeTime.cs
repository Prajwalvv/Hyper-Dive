using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activeTime : MonoBehaviour
{
    public GameObject spawner;
    public float sec = 14f;
    void Start()
    {
        if (spawner.activeInHierarchy)
            spawner.SetActive(false);

        StartCoroutine(LateCall());
    }

    IEnumerator LateCall()
    {

        yield return new WaitForSeconds(sec);

        spawner.SetActive(true);
        //Do Function here...
    }
}
