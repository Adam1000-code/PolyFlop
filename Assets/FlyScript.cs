using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyScript : MonoBehaviour
{
    public GameManager gameManager;
    public float velocity = 1;
    public float rotationSpeed;
    private Rigidbody2D rb;
    public AudioSource jump;
    public AudioSource die;
    // Start is called before the first frame update
    void Start()
    {
        jump.mute = false;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) || Input.GetButtonDown("Jump"))
        {
            rb.velocity = Vector2.up * velocity;
            jump.Play();
        }

        transform.rotation = Quaternion.Euler(0, 0, rb.velocity.y * rotationSpeed);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("pipes"))
        {
            die.Play();
            jump.mute = true;
            gameManager.GameOver();
        }
        else if(other.gameObject.CompareTag("boundary"))
        {
            die.Play();
            jump.mute = true;
            gameManager.GameOver();
        }
    }
}
