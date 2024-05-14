using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FlyScript : MonoBehaviour
{
    [SerializeField]
    float velocity = 1.5f;
    [SerializeField]
    float rotatSpeed = 10f;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Mouse.current.leftButton.isPressed)
        {
            rb.velocity = Vector2.up * velocity;
        }
    }

    private void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0, 0, rb.velocity.y * rotatSpeed);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        GameManager.gameManager.GameOver();
    }
}
