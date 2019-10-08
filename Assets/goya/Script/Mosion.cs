using System.Collections;
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

    void Start () {
        Cooltime = true;

	}
	
	void Update () {
        if (Input.GetKey("space"))
        {
            Attack.transform.position = new Vector3(0, 0, 0);
            Normal.transform.position = new Vector3(0, 10, 0);

            //Destroy(Target);
            GameObject obj = (GameObject)Resources.Load("beam_pink");
            Instantiate(obj, new Vector3(0.0f, 2.0f, 0.0f), Quaternion.identity);
        }
        else
        {
            Normal.transform.position = new Vector3(0, 0, 0);
            Attack.transform.position = new Vector3(0, 10, 0);
        }
    }
}
