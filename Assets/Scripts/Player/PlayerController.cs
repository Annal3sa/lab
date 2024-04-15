using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float speed = 3.5f;
    private Rigidbody2D playerRb;
    private SpriteRenderer sprite;

    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
    }

    

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float upInput = Input.GetAxis("Vertical");

        if (horizontalInput < 0)
        {
            sprite.flipX = true;
        }
        else if (horizontalInput > 0)
        {
            sprite.flipX = false;
        }

        transform.Translate(Vector3.up * speed * upInput * Time.deltaTime);
        transform.Translate(Vector3.right * speed * horizontalInput * Time.deltaTime);
    }

  
}
