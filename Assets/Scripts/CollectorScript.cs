using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectorScript : MonoBehaviour
{
    // add a text object from UI - Drag text to Score Text in Collector Script
    public Text scoreText;
    private int score;

    void IncreaseScore() {
        score++;

        scoreText.text = "Score: " + score;
    }

    // Trigger Behavior inherited by MonoBehavior when the is Trigger is checked
    // Bomb has a circle collider on it, once it touches the collector, this OnTrigger will fire
    void OnTriggerEnter2D(Collider2D target) {
        if (target.tag == "Bomb") {

            // increase score when the bomb hits the collector
            IncreaseScore();
            // deactivate the bomb to save memory
            target.gameObject.SetActive(false);
        }
    }
}
