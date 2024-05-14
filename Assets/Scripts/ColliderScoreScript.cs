using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderScoreScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bird"))
        {
            ScoreSystemScript.instance.AddScore();
        }
    }
}
