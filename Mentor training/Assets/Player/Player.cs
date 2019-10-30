using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    public Text goalText;

    void Start()
    {
        goalText.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        //移動
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(0, 0, 5);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(0, 0, -5);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(5, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-5, 0, 0);
        }

        //落ちたらスタート地点に戻る
        if(transform.position.y < -10)
        {
            transform.position = new Vector3(0, 0.6f, -2.3f);
        }
    }

    private void OnCollisionStay(Collision hit)
    {
        //敵に当たったら元の位置にもどる
        if(hit.gameObject.tag == "Enemy")
        {
            transform.position = new Vector3(0, 0.6f, -2.3f);
        }

        //ゴールしたら「ゴールと表示
        if(hit.gameObject.tag == "Goal")
        {
            goalText.enabled = true;
        }
    }
}
