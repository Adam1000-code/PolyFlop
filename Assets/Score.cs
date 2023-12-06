using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Score : MonoBehaviour
{
    public static int score = 0;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;
    public static int highScore;
    // Start is called before the first frame update
    void Start()
    {
        highScore = PlayerPrefs.GetInt("HighScore");
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
        highScoreText.text = highScore.ToString();
        if(Input.GetKeyDown(KeyCode.C))
        {
            score += 50;
        }

        if(Input.GetKeyDown(KeyCode.S))
        {
            score = 990;
        }
    }
}
