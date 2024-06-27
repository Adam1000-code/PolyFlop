using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{
    public AudioSource scoreSound;
    private void Start()
    {
        scoreSound.mute = false;
    }

    private void Update()
    {
        /*if(Time.timeScale == 1)
        {
            scoreSound.mute = false;
        }
        else
        {
            scoreSound.mute = true;
        }*/

        switch(Time.timeScale)
        {
            case 1:
                scoreSound.mute = false;
                break;
            case 0:
                scoreSound.mute = true;
                break;
            default:
                //scoreSound.mute = false;
                break;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Score.score++;
        if(Score.score > Score.highScore)
        {
            Score.highScore = Score.score;
            PlayerPrefs.SetInt("HighScore", Score.highScore);
        }
        scoreSound.Play();
    }
}
