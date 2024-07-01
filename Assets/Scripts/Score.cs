using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    private int score = 0;
    [SerializeField] private TextMeshProUGUI scoreText;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag != "Hit") {
            score++;
            scoreText.SetText("Collision : " + score);
        }
    }
}
