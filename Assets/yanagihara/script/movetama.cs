using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movetama : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.position += new Vector3(0.01f, 0, 0);
        if (transform.position.x > 300) Destroy(this.gameObject);
	}
}
