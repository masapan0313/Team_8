using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController1 : MonoBehaviour
{
   
    public GameObject player;
    public GameObject ber;
    Slider hpSlider;

    public Transform Pacon;
    float playerpos;
    void Start()
    {
        playerpos = player.transform.position.x;
    }

    void Update()
    {

        Pacon.position += new Vector3(0.1f, 0);
       
        if(playerpos +10f < player.transform.position.x)
        {
            ber.GetComponent<Slider>().value -= 0.01f;
            playerpos = player.transform.position.x;
        }
    }
}
   