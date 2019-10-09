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

    public GameObject[] zako;
    public Vector3[] GeneratPoint;
    GameObject[] teki = new GameObject[3];
    bool flg ;
    void Start()
    {
        flg = true;
        Debug.Log("11");
    }

    // Update is called once per frame
    void Update()
    {
        
        if(flg == true)
        {
            Debug.Log("12");
            

            for (int i = 0; i < 3; i++)
            {
                Debug.Log("ok");
                teki[i] = GameObject.Instantiate(zako[0], GeneratPoint[i], Quaternion.identity);
            }
            flg = false;
        }
        tekides();
        if (d == true)
        {
            GameObject o;
            o = GameObject.Instantiate(debu, this.transform);
            d = false;

        }
        if (z == true)
        {
            
            for(int i=0; i < 3; i++)
            {
                if(teki[i] == null)
                {
                    teki[i] = GameObject.Instantiate(Zako, GeneratPoint[i], Quaternion.identity);
                    z = false;
                    break;
                }
            }
            
            
        }
        if (h == true)
        {
            GameObject r ;
            r = GameObject.Instantiate(hayai, points.transform);
            h = false;
        }

    }

    void tekides()
    {
        if(teki[0] != null && teki[0].transform.position.y > 10f)
        {
            teki[0].transform.position = GeneratPoint[0];
            Destroy(teki[0].gameObject);
            z = true;
        }
        if (teki[1] != null && teki[1].transform.position.y > 10f)
        {
            teki[1].transform.position = GeneratPoint[1];
            Destroy(teki[1].gameObject);
            z = true;
        }
        if (teki[2] != null && teki[2].transform.position.y > 10f)
        {
            teki[2].transform.position = GeneratPoint[2]; 
            Destroy(teki[2].gameObject);
            z = true;
        }


    }
}