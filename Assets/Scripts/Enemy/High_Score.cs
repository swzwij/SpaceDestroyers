using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class High_Score : MonoBehaviour
{
    public int currentScore;
    public Text scoreText;
    public Text EndScore;

    void Update()
    {
        scoreText.text = "Score: " + currentScore;
        EndScore.text = "" + currentScore;
    }

}
