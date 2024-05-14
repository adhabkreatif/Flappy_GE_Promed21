using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    [SerializeField] float moveSpeed = 1;

    private float timer;

    private void OnEnable()
    {
        timer = 0;
    }

    private void OnDisable()
    {
        timer = 0;
    }

    void Update()
    {
        transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);

        if (timer > 5f)
        {
            gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Pipe"))
        {
            Destroy(other.gameObject);
            timer = 0;
            gameObject.SetActive(false);
        }
    }
}
