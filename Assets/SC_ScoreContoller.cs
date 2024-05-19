using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SC_ScoreContoller : MonoBehaviour
{

    public Text ScoreText;
    public int score = 0;
    public int highscore = 0;

    public GameObject panelgameover;
    public Text[] Text_GameOver;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
            score++;
            PlayerPrefs.SetInt("score",score);

            if (score > highscore)
            {
                highscore = score;
                PlayerPrefs.SetInt("highscore",highscore);
            }
        }
        
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = score.ToString();

        if (panelgameover.activeInHierarchy)
        {
            Text_GameOver[0].text = "High Score: "+PlayerPrefs.GetInt("highscore").ToString();
            Text_GameOver[1].text = "Score: "+PlayerPrefs.GetInt("score").ToString();
        }
    }
}
