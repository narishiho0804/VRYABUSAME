using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PingPong : MonoBehaviour
{
    private float nowPosi;
    private bool isClear =false;
    private int score = 0;
    public TextMeshPro scoretext;
    public TextMeshPro ScoreResult;



    public bool IsClear { get => isClear; set => isClear = value; }


    // Start is called before the first frame update
    void Start()
    {
        nowPosi = this.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(isClear);
        if (isClear) return;
        transform.position = new Vector3(transform.position.x, nowPosi + Mathf.PingPong(Time.time, 0.3f), transform.position.z);
    }
    public void scoreUp(int scorehit)
    {
        score += scorehit;
        scoretext.text = string.Format("Score:{0}", score);
        ScoreResult.text = string.Format(score + "ŒÂ“–‚½‚Á‚½");// ‰½ŒÂ’†‰½ŒÂ“–‚½‚Á‚½
    }    
}
