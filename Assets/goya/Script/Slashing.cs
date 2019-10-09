using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slashing : MonoBehaviour {
    [SerializeField, Header("竹")]
    private GameObject Bamboo; // 竹に当たると斬撃が消える
    float acceleration; // 斬撃の加速度
    GameObject test;

    void Start () {
        acceleration = 0;
        //test = new GameObject();
          // test = Bamboo;
    }
	
	void Update () {
        acceleration += 0.4f;
        transform.Translate(acceleration, 0f, 0f);
        if(transform.position.x >= 3000)
        {
            Destroy(this.gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D Tube , Collision2D Section)//Tube=硬いところ Section=節
    {
        Debug.Log("aaa");
        //if (Target.gameObject.name == "line_bamboo_take" || Target.gameObject.name == "Cube")
        //{
        //    Destroy(Target.gameObject);
        //    Destroy(this.gameObject);
        //}
        //test = Target.gameObject.transform.root.gameObject;

        if (Section.gameObject.tag == "Section")
        {
            GameObject.Destroy(test.gameObject);
            //Destroy(this.gameObject);
            
            Debug.Log("sss");
        }
        if (Tube.gameObject.tag == "Tube")
        {
            Destroy(test.gameObject);
            Destroy(this.gameObject);
            Debug.Log("aaa");
        }
    }
    
}
