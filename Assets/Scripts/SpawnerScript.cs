using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject bombPrefab;
    // Boundaries
    private float minX = -2.55f;
    private float maxX = 2.55f;

    // Start is called before the first frame update
    void Start()
    {
        // start IEnumerator delay action
        StartCoroutine (SpawnBombs());
    }

    IEnumerator SpawnBombs() {
        // random wait to spawn between 0 and 1 seconds
        yield return new WaitForSeconds (Random.Range(0f, 1f));

        // make a copy of bombPrefab, at position, at rotation (Quanternion.identity - 0 for every angle(x,y,z))
        Instantiate (bombPrefab, new Vector2(Random.Range(minX, maxX), transform.position.y),
            Quaternion.identity);

        // make it infinite coroutine
        StartCoroutine (SpawnBombs());
    }
}
