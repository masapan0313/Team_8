using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gauge : MonoBehaviour {

    public Transform idou;

    Slider hpSlider;

    // Use this for initialization
    void Start()
    {

        hpSlider = GetComponent<Slider>();

        float maxHp = 100f;
        float nowHp = 100f;


        //スライダーの最大値の設定
        hpSlider.maxValue = maxHp;

        //スライダーの現在値の設定
        hpSlider.value = nowHp;


    }

    // Update is called once per frame
    void Update () {

        //Transform idou = this.transform;
        
        //idou.position += new Vector3(0.1f, 0);
    }
}
