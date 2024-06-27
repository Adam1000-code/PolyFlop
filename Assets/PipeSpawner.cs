using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public float maxTime = 1;
    private float timer = 0;
    public GameObject pipes;
    public float height;
    public int endingChance;
    // Start is called before the first frame update
    void Start()
    {
        GameObject newPipe = Instantiate(pipes);
        newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
        Destroy(newPipe, 15);
        maxTime = 1.3f;
        endingChance = Random.Range(0, 100);
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

        /*if(Score.score == 50)
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

        if(Score.score == 997 && endingChance >= 95)
        {
            gameObject.SetActive(false);
        }*/

        switch(Score.score)
        {
            case 0:
                maxTime = 1.3f;
                height = 1f;
                PipeMove.speed = 5f;
                break;
            case 50:
                maxTime = 1.2f;
                height = 1.1f;
                PipeMove.speed = 5.3f;
                break;
            case 100:
                maxTime = 1.1f;
                height = 1.3f;
                PipeMove.speed = 5.4f;
                break;
            case 250:
                maxTime = 1f;
                height = 1.3f;
                PipeMove.speed = 5.5f;
                break;
            case 500:
                maxTime = 1f;
                height = 1.35f;
                PipeMove.speed = 5.5f;
                break;
            case 700:
                maxTime = 0.9f;
                height = 1.37f;
                PipeMove.speed = 5.7f;
                break;
            case 997:
                if(endingChance >= 95)
                {
                    gameObject.SetActive(false);
                }
                break;
            /*default:
                maxTime = 1.3f;
                height = 1f;
                PipeMove.speed = 5f;
                break;*/
        }
    }
}
