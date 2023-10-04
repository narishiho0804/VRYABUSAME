using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TargetPoint : MonoBehaviour
{
    
    private int score = 0;
    
    public AudioSource sound;
    private Animator anim = null;
    PingPong pingPong;

    void Start()
    {
        var XROrigin = GameObject.Find("XR Origin");
        //GameObject.Find("XR Origin");
        pingPong = XROrigin.GetComponent<PingPong>();
        sound = GetComponent<AudioSource>();
        anim = GetComponent<Animator>();

    }

    private void OnCollisionEnter(Collision collision)
    {
        
        sound.Play();
        if (collision.gameObject.tag == "Arrow")
        {
            Debug.Log("hit" + score);

            sound.Play();
            pingPong.scoreUp(1);

            //// アニメーション
            //anim.SetBool("move", true);

            this.gameObject.SetActive(false);
        }



    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
