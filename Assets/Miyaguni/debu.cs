using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class debu : MonoBehaviour {
    public GameObject p;
    void start()
    {

    }
    void Update()
    {

        this.gameObject.transform.Translate(0, 0.05f, 0);

        if (transform.position.y > 30)
        {
            p = GameObject.Find("GameObject d");
            p.GetComponent<manage>().d = true;
            Destroy(gameObject);

        }

    }


}
