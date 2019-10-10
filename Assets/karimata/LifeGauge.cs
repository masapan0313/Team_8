using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LifeGauge : MonoBehaviour {

    public Text failText;
   // private bool inGame;

    public RawImage[] image;
    int count = 2;

    void Start()
    {
        failText.enabled = false;
        //inGame = true;
    }

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
            // Debug.Log("GAME OVER");
            failText.enabled = true;
            // inGame = false;
            if (Input.GetMouseButtonUp(1))
            {
                Replay();
            }
        }
    }

    public void Replay()
    {
        SceneManager.LoadScene("ka");
    }
}