using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopGround : MonoBehaviour
{
    [SerializeField] float moveSpeed = 1f;
    [SerializeField] float width = 6f;

    private SpriteRenderer sr;

    private Vector2 startSize;

    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();

        startSize = new Vector2(sr.size.x, sr.size.y);
    }

    private void Update()
    {
        sr.size = new Vector2(sr.size.x + moveSpeed * Time.deltaTime, sr.size.y);

        if (sr.size.x > width)
        {
            sr.size = startSize;
        }
    }
}
