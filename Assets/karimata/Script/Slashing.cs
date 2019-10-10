using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slashing : MonoBehaviour {
    [SerializeField, Header("竹")]
    private GameObject Bamboo; // 竹に当たると斬撃が消える
    float acceleration; // 斬撃の加速度
    GameObject test;

    public GameObject bashu;
    public GameObject dokan;
    GameObject takeM;

    void Start () {
        acceleration = 0;
        //test = new GameObject();
        // test = Bamboo;
        takeM = GameObject.Find("GameObject d");
    }
	
	void Update () {
        acceleration += 0.4f;
        transform.Translate(acceleration, 0f, 0f);
        if(transform.position.x >= 3000)
        {
            Destroy(this.gameObject);
        }
    }

    void OnTriggerEnter(Collider Target)//Tube=硬いところ Section=節
    {
        //Debug.Log("aaa");
        //if (Target.gameObject.name == "line_bamboo_take" || Target.gameObject.name == "Cube")
        //{
        //    Destroy(Target.gameObject);
        //    Destroy(this.gameObject);
        //}
        test = Target.gameObject.transform.root.gameObject;

        if (Target.gameObject.tag == "Section")
        {
            GameObject Box = Instantiate(dokan, new Vector3(Target.transform.position.x, this.transform.position.y + 1f), Quaternion.identity);
            GameObject.Destroy(test.gameObject);
            //Destroy(this.gameObject);
            if(Target.gameObject.transform.root.gameObject.tag == "zako")
            takeM.GetComponent<manage>().z = true;
            takeM.GetComponent<manage>().moveFlg = true;

            Debug.Log("節");

        }
        if (Target.gameObject.tag == "Tube")
        {
            GameObject Box  = Instantiate(bashu,new Vector3(Target.transform.position.x,this.transform.position.y + 1f),Quaternion.identity);
            Destroy(test.gameObject);
            if (Target.gameObject.transform.root.gameObject.tag == "zako")
                takeM.GetComponent<manage>().z = true;
            Destroy(this.gameObject);
            
            Debug.Log("硬い");
        }
    }
    
}
