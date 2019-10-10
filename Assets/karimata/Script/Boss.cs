using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour {
    private float speed;
    // Use this for initialization
    void Start () {
        speed = 5 * Time.deltaTime;
    }
	
	// Update is called once per frame
	void Update () {
        if(this.transform.position.y < -3.4f)
        this.gameObject.transform.Translate(0, speed, 0);
    }
}
