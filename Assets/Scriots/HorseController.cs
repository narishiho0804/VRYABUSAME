using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class HorseController : MonoBehaviour
{
    public AudioSource sound1;
    AudioSource audioSource;
    [SerializeField] PingPong pingPong;
    

    void  Start()
    {
        // AudioSourceを取得する
        audioSource = GetComponent<AudioSource>();
        // x方向に向かう
        
        this.transform.DOMove(new Vector3(100f, 0f, 0f), 50f);

        audioSource.Play();
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Goal")
        {
            audioSource.Stop();
        }
    }

    public void GameClear()
    {
        pingPong.IsClear = true;
    }
    
}
