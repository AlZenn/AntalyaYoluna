using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class birdMovement : MonoBehaviour
{

    public GameManager gm;
    public Rigidbody2D RB_bird;
    public float Bird_jump;
    
    public GameObject Panel_GameOver;

    public SC_ScoreContoller scoreSc;
    void Start()
    {
        RB_bird = GetComponent<Rigidbody2D>();
        scoreSc = GameObject.Find("ScoreController").GetComponent<SC_ScoreContoller>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && gm.gamePaused == false)
        {
            //RB_bird.velocity = new Vector2(0,0);
            RB_bird.velocity = Vector2.zero;
            
            RB_bird.velocity = new Vector2(RB_bird.velocity.x, Bird_jump);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Time.timeScale = 0f;
        Panel_GameOver.SetActive(true);
    }
    
    

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Wall"))
        {
            Time.timeScale = 0f;
            Panel_GameOver.SetActive(true);
        }

        if (other.gameObject.CompareTag("Star"))
        {
            Destroy(other.gameObject);
            scoreSc.score += 5;
            PlayerPrefs.SetInt("score",scoreSc.score);
            
            if (scoreSc.score > scoreSc.highscore)
            {
                scoreSc.highscore = scoreSc.score;
                PlayerPrefs.SetInt("highscore",scoreSc.highscore);
            }
        }
    }

    public void gameRestart()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
        PlayerPrefs.DeleteKey("score");

    }
}
