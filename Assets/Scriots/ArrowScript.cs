using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ArrowScript : MonoBehaviour
{
    //public TextMeshPro Scoretext; // Text

    //private int Score = 0;�@

    public AudioSource sound;
    private Animator anim = null;
    // Start is called before the first frame update
    void Start()
    {
        sound = GetComponent<AudioSource>();
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
      
    }
    private void OnCollisionEnter(Collision collision)
    {
        //if(collision.gameObject.tag == "Target")
        //{
        //    Debug.Log("�I�ɓ�������!!");
        //    sound.Play();
        //}
        //Score += 1;
        //Scoretext.text = string.Format("Score:{0}", Score);


        
        
    }
}
