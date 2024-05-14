using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    [SerializeField] float timeInterval = 1.5f;
    [SerializeField] float heightPos;
    [SerializeField] GameObject pipe;

    private float timer;

    private void Update()
    {
        if (timer > timeInterval)
        {
            PipeSpawner();
            timer = 0;
        }

        timer += Time.deltaTime;
    }

    private void PipeSpawner()
    {
        Vector3 spawnPos = transform.position + new Vector3(0, Random.Range(-heightPos, heightPos));
        GameObject newPipe = Instantiate(pipe, spawnPos, Quaternion.identity);

        Destroy(newPipe, 10f);
    }
}
