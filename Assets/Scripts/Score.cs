using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    private int score = 0;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag != "Hit") {
            score++;
            Debug.Log("You Bumped to Obstacle " + score + " times");
        }
    }
}
