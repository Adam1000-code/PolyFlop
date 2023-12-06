using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject GameOverCanvas;
    public GameObject ScoreCanvas;
    public PipeSpawner spawner;
    public float waitTimer;
    public void Start()
    {
        waitTimer = 0;
        GameOverCanvas.SetActive(false);
        ScoreCanvas.SetActive(true);
        Time.timeScale = 1;
        if(!PlayerPrefs.HasKey("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", 0);
        }
    }

    public void GameOver()
    {
        GameOverCanvas.SetActive(true);
        ScoreCanvas.SetActive(false);
        Time.timeScale = 0;
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Replay()
    {
        SceneManager.LoadScene(1);
    }

    private void Update()
    {
        if(Score.score == 1000 && spawner.endingChance >= 95)
        {
            waitTimer += Time.deltaTime;

            if(waitTimer >= 4.5f)
            {
                SceneManager.LoadScene("Ending");
            }
        }
    }
}
