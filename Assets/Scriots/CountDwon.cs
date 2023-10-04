using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class CountDwon : MonoBehaviour
{
    public TextMeshPro countText;
    //public AudioClip sound1;
    public AudioSource audioSource;

    public GameObject size;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        countText.text = "";
        StartCoroutine(CountDown());
    }

    IEnumerator CountDown()
    {

        yield return new WaitForSeconds(2);
        audioSource.Play();

        countText.text = "3";
        size.transform.DOScale(new Vector3(2, 2, 2), 1f).SetAutoKill(false);
        yield return new WaitForSeconds(1);
        size.transform.DORestart();

        countText.text = "2";
        size.transform.DOScale(new Vector3(2, 2, 2), 1f).SetAutoKill(false);
        yield return new WaitForSeconds(1);
        size.transform.DORestart();

        countText.text = "1";
        size.transform.DOScale(new Vector3(2, 2, 2), 1f).SetAutoKill(false);
        yield return new WaitForSeconds(1);
        size.transform.DORestart();

        size.transform.DOScale(new Vector3(2, 2, 2), 1f);
        countText.text = "GO!";
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Main");
    }

}
