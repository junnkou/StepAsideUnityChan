using UnityEngine;
using System.Collections;

public class UnityChanController : MonoBehaviour
{
    //アニメーションするためのコンポーネントを入れる
    private Animator myAnimator;

    
    //Unityちゃんを移動させるコンポーネントを入れる（追加）
    private Rigidbody myRigidbody;
    //前進するための力（追加）
    private float forwardForce = 800.0f;
    void Start()
    {

        //Animatorコンポーネントを取得
        this.myAnimator = GetComponent<Animator>();

        //走るアニメーションを開始
        this.myAnimator.SetFloat("Speed", 1);
        this.myRigidbody = GetComponent<Rigidbody>();
    }
    void Update()
    {
        this.myRigidbody.AddForce(this.transform.forward * this.forwardForce);
    }
}