using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToriiScript : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            // �S�[�������甏��̉����o��
            // �S�[��������G�t�F�N�g���o��
        }
    }
}
