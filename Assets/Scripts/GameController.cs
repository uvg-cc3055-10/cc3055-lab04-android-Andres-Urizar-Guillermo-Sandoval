using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public bool gameOver = false;
    public static GameController instance;
    public float time = 0;
    public float highscore = 0;
    public Text score;
    AudioSource audio;

    // Use this for initialization
    void Start()
    {
        instance = this;
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver == false)
        {
            time += Time.deltaTime;
            score.text = "Score: " + time.ToString("n0");
        }
        else
        {
            audio.Play();
            HighScore();
        }
    }
   public void HighScore()
    {
        gameOver = false;
        if (highscore < time)
        {
            highscore = time;
            PlayerPrefs.SetFloat("Highscore", highscore);
        }
    }
}
