using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBamboo : MonoBehaviour {
    [SerializeField, Header("生えるスピード")]
    private float createspeed;//竹の生える速度

	// Use this for initialization

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.position += new Vector3(0, createspeed, 0);
	}
}
