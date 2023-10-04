using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrialScript : MonoBehaviour
{
    public AudioClip sound1;
    AudioSource audioSource;

    private void Start()
    {
        // Component���擾
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        // ����(sound1)�炷
        audioSource.PlayOneShot(sound1);
        Debug.Log("��������");
    }
}
