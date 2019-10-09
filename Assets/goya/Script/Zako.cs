using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zako : MonoBehaviour {
    public GameObject p;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.Translate(0, 0.005f, 0);

        if (transform.position.y > 10)
        {
            p = GameObject.Find("GameObject d");
            p.GetComponent<manage>().z = true;
            Destroy(gameObject);
        }
    }
}