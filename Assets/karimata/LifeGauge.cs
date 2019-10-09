using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeGauge : MonoBehaviour {

    public RawImage[] image ;
    int count = 2;

    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
           image[count].enabled = false;
           // Debug.Log(image[count]);
            count--;
        }

        if (count == -1)
        {
            Debug.Log("atatatatatatattata");
        }
    }
}