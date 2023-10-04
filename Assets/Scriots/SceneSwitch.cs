using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class SceneSwitch : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "countdown")
        {
            SceneManager.LoadScene("CountDown");
        }
        if (collision.gameObject.tag == "countdown2")
        {
            SceneManager.LoadScene("CountDown2");
        }

        if (collision.gameObject.tag == "countdown3")
        {
            SceneManager.LoadScene("CountDown3");
        }

        if (collision.gameObject.tag == "Title")
        {
            SceneManager.LoadScene("Title");
        }


    }

    IEnumerator arrow()
    {

        yield return new WaitForSeconds(1);
    }

    // もし的に当たったら、１秒まって暗くしてシーンに移動。
    // StartCoroutine("ChangeColor");


}
