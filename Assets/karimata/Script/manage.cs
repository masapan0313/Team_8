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
    public GameObject boss;
    public GameObject points;

    public GameObject[] zako;
    public Vector3[] GeneratPoint;
    GameObject[] teki = new GameObject[3];
    bool flg ;
    public bool bossFlg;
    public int killcount;

    

    void Start()
    {
        flg = true;
        bossFlg = false;
        killcount = 0;
        
        //Debug.Log("11");
    }

    // Update is called once per frame
    void Update()
    {
        if(killcount == 30)
        {
            
            for (int i = 0; i < 3; i++)
            {
                Destroy(teki[i]);
            }
            teki[0] = GameObject.Instantiate(zako[2], GeneratPoint[4] , Quaternion.identity);
            teki[1] = GameObject.Instantiate(boss, GeneratPoint[1], Quaternion.identity);
            teki[1] = GameObject.Instantiate(zako[2], GeneratPoint[5] , Quaternion.identity);
            killcount++;
        }
        if(killcount == 31)
        {
            if (this.transform.position.y > -3.4f)
                bossFlg = true;
        }

        if (bossFlg == false)
        {
            if (flg == true)
            {
                for (int i = 0; i < 3; i++)
                {
                    //Debug.Log("ok");
                    teki[i] = GameObject.Instantiate(zako[0], GeneratPoint[i], Quaternion.identity);
                }
                flg = false;
            }

            Tekides();

            if (z == true)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (teki[i] == null)
                    {
                        int num = 0;
                        if (killcount > 10)
                        {
                            num = Random.Range(0, 2);

                        }
                        if (num == 0)
                            teki[i] = GameObject.Instantiate(zako[num], GeneratPoint[i], Quaternion.identity);
                        else
                            teki[i] = GameObject.Instantiate(zako[num], GeneratPoint[i] + new Vector3(1f, 0), Quaternion.identity);
                    }
                }

                z = false;

            }
        }
    }

    void Tekides()
    {
        if(teki[0] != null && teki[0].transform.position.y > 5f)
        {
            teki[0].transform.position = GeneratPoint[0];
            Destroy(teki[0].gameObject);
            killcount++;
            z = true;
        }
        if (teki[1] != null && teki[1].transform.position.y > 5f)
        {
            teki[1].transform.position = GeneratPoint[1];
            Destroy(teki[1].gameObject);
            z = true;
            killcount++;

        }
        if (teki[2] != null && teki[2].transform.position.y > 5f)
        {
            teki[2].transform.position = GeneratPoint[2]; 
            Destroy(teki[2].gameObject);
            killcount++;
            z = true;

        }


    }
}