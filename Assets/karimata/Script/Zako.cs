using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zako : MonoBehaviour {
    

    private float speed;
    // Use this for initialization
    void Start()
    {
        speed = Random.Range(0.05f, 0.15f);
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.Translate(0,speed, 0);
    }
}