using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hayai : MonoBehaviour {
    public GameObject p;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.Translate(0, 0.08f, 0);

        if (transform.position.y > 30)
        {
            p = GameObject.Find("GameObject d");
            p.GetComponent<manage>().h = true;
            Destroy(gameObject);
        }
    }
}
