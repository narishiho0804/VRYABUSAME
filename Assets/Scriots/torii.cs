using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class torii : MonoBehaviour
{
    public AudioSource SE;

    private void Start()
    {
        SE = GetComponent<AudioSource>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            SE.Play();
        }
        
    }
}
