using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.Rendering.DebugUI;

public class PlayerController : MonoBehaviour
{

    private float speed = 3.5f;
    float horizontalInput;
    float upInput;
    private Rigidbody2D playerRb;
    private SpriteRenderer sprite;

    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
    }

    

    void Update()
    {
        Debug.Log(speed);
        if (horizontalInput < 0)
        {
            sprite.flipX = true;
        }
        else if (horizontalInput > 0)
        {
            sprite.flipX = false;
        }
        Vector3 vertical = (Vector3.up * speed * upInput * Time.deltaTime);
        Vector3 horizontal = Vector3.right * speed * horizontalInput * Time.deltaTime;

        transform.Translate(vertical);
        transform.Translate(horizontal);
        Debug.Log(vertical.magnitude + "  " + horizontal.magnitude);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.magenta;
        Gizmos.DrawLine(transform.position, new Vector3(horizontalInput, upInput, 0));
    }

    public void OnMove(InputValue value)
    {
        horizontalInput = value.Get<Vector2>().x;
        upInput = value.Get<Vector2>().y;
    }

    public void MoveInput(Vector2 newvalue)
    {
        Vector2 value = newvalue.normalized;
        horizontalInput = value.x;
        upInput = value.y;
    }
}
