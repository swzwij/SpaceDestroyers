using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    GameObject ScoreManager;


    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Bullet"))
        {
            Destroy(col.gameObject);
            Destroy(gameObject);

            GameObject ScoreManager = GameObject.Find("ScoreManager");
            High_Score score = ScoreManager.GetComponent<High_Score>();
            score.currentScore++;

           

        }
    }

}
