using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBamboo : MonoBehaviour {
    [SerializeField, Header("竹")]
    private GameObject Bamboo;
    private bool CreateBamboos;
    private float createTime;

    // Use this for initialization
    void Start() {
        CreateBamboos = false;
    }

    // Update is called once per frame
    void Update() {
        if(CreateBamboos == false)
        {
            Instantiate(Bamboo, this.transform.position, Quaternion.identity);
            CreateBamboos = true;
        }
        else if(CreateBamboos != false)
        {
            createTime += Time.deltaTime;
            if(createTime > 10)
            {
                CreateBamboos = false;
                createTime = 0;
            }
        }

    }

}

