using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Goal : MonoBehaviour
{
    public TextMeshPro GameClearText;
    public GameObject MainTargetGenerate;
    public GameObject TitleTargetGenerate;
    public TextMeshPro ScoreText;

    private void OnCollisionEnter(Collision collision)
    {
            //Debug.Log(collision.gameObject.name);
        if(collision.gameObject.tag == "Player")
        {
            //Debug.Log("“–‚½‚Á‚½");
            collision.gameObject.GetComponent<HorseController>().GameClear();
            
            StartCoroutine(GoalCler());
            
        }
        
    }

    


    IEnumerator GoalCler()
    {
        
        GameClearText.gameObject.SetActive(true);
        MainTargetGenerate.gameObject.SetActive(true);
        TitleTargetGenerate.gameObject.SetActive(true);
        ScoreText.gameObject.SetActive(false);
        yield return new WaitForSeconds(5f);
        Destroy(GameClearText.gameObject);
    }
}