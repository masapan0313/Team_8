﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mosion : MonoBehaviour {

    [SerializeField,Header("待機状態")]
    private GameObject Normal;
    [SerializeField, Header("攻撃モーション")]
    private GameObject Attack;
    [SerializeField, Header("竹")]
    private GameObject Target;
    bool Cooltime;  //攻撃できるかの状態（TRUE：できる、FALSE：できない）

    bool slashingflg;
    public GameObject slashing;
    public GameObject director;
    float waitTime;
    bool waitflg;

    void Start () {
        Cooltime = true;
        slashingflg = true;
        waitflg = false;
    }
	
	void Update () {

        if (waitflg == true)
        {
            waitTime += Time.deltaTime;
            if (waitTime > 1f)
            {
                waitflg = false;
                waitTime = 0;
            }
        }
        if (waitflg == false &&  Input.GetKey("space"))
        {
            waitflg = true;
            Attack.transform.position = new Vector3(-7, -2.5f, 0);
            Vector3 pointer = Attack.GetComponentInChildren<Transform>().transform.position;
            Normal.transform.position = new Vector3(0, 50, 0);

            //Destroy(Target);
            if (slashingflg == true)
            {
                Instantiate(slashing, pointer, Quaternion.identity);
                slashingflg = false;
            }
        }
        else
        {
            Normal.transform.position = new Vector3(-7, -2.5f, 0);
            Attack.transform.position = new Vector3(0, -50, 0);
            slashingflg = true;
        }
    }
}
