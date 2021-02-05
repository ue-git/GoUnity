using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    //キューブの移動速度
    private float speed = -12;
    //消滅位置
    private float deadLine = -10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //キューブを移動させる
        transform.Translate(this.speed * Time.deltaTime, 0, 0);

        //画面外に出たら破棄する
        if(transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }
    }


    //キューブ接触時の効果音再生（課題）
    void OnCollisionEnter2D(Collision2D collision)
    {
        //キューブが衝突したら再生（unityちゃんとの衝突は含まない）
        if(collision.gameObject.tag == "CubeTag" || collision.gameObject.tag == "GroundTag")
        {
            GetComponent<AudioSource>().volume = 1;//音量を1にする
            GetComponent<AudioSource>().Play();//効果音再生
        }
    }
}
