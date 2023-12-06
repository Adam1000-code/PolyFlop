using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public float maxTime = 1;
    private float timer = 0;
    public GameObject pipes;
    public float height;
    // Start is called before the first frame update
    void Start()
    {
        GameObject newPipe = Instantiate(pipes);
        newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
        Destroy(newPipe, 15);
        maxTime = 1.3f;
        height = 1f;
        PipeMove.speed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > maxTime)
        {
            GameObject newPipe = Instantiate(pipes);
            newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newPipe, 15);
            timer = 0;
        }
        timer += Time.deltaTime;

        if(Score.score == 50)
        {
            maxTime = 1.2f;
            height = 1.1f;
            PipeMove.speed = 5.3f;
        }

        if(Score.score == 100)
        {
            maxTime = 1.1f;
            height = 1.3f;
            PipeMove.speed = 5.4f;
        }

        if(Score.score == 250)
        {
            maxTime = 1f;
            height = 1.3f;
            PipeMove.speed = 5.5f;
        }

        if(Score.score == 500)
        {
            maxTime = 1f;
            height = 1.35f;
            PipeMove.speed = 5.5f;
        }

        if(Score.score >= 700)
        {
            maxTime = 0.9f;
            height = 1.37f;
            PipeMove.speed = 5.7f;
        }

        if(Score.score == 997)
        {
            gameObject.SetActive(false);
        }
    }
}