using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manage : MonoBehaviour
{
    public bool d = false;
    public bool z = false;
    public bool h = false;
    public GameObject debu;
    public GameObject Zako;
    public GameObject point;
    public GameObject hayai;
    public GameObject points;

    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if (d == true)
        {
            GameObject o = new GameObject();
            o = GameObject.Instantiate(debu, this.transform);
            d = false;

        }
        if (z == true)
        {
            GameObject t = new GameObject();
            t = GameObject.Instantiate(Zako, point.transform);
            z = false;
        }
        if (h == true)
        {
            GameObject r = new GameObject();
            r = GameObject.Instantiate(hayai, points.transform);
            h = false;
        }

    }
}