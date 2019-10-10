using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class debu : MonoBehaviour {
   
    private float speed;
    void Start()
    {
        speed = Random.Range(0.05f, 0.08f);
    }
    void Update()
    {
        this.gameObject.transform.Translate(0, speed, 0);
        
    }


}
