using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatform : MonoBehaviour
{
    public float speed;
    public GameObject platformPoint;
    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, platformPoint.transform.position, speed * Time.deltaTime);
    }
}
