using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float speed = 10f;

    // Boundaries
    private float minX = -2.55f;
    private float maxX = 2.55f;


    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void MovePlayer() {
        // get keyboard inputs
        float h = Input.GetAxis("Horizontal");
        // 2 axis
        Vector2 currentPosition = transform.position;

        if (h > 0) {
            // going to the right side
            // Time.deltaTime is the time in seconds to complete the last frame
            currentPosition.x += speed * Time.deltaTime;

        } else if (h < 0) {
            // going to the left side
            currentPosition.x -= speed * Time.deltaTime;

        }

        // boundaries
        if (currentPosition.x < minX) {
            currentPosition.x = minX;
        }

        if (currentPosition.x > maxX) {
            currentPosition.x = maxX;
        }

        // assign back to game object to move the position
        transform.position = currentPosition;
    }

    void OnTriggerEnter2D(Collider2D target) {
        if (target.tag == "Bomb") {
            // when time is set to 0, everything is stopped
            // pause game
            Time.timeScale = 0f;
        }
    }
} // class
