using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Target : MonoBehaviour
{
    public TMP_Text score;
    int scoreCount = 0;
    Vector2 pos;

    void Start()
    {
        pos = new Vector2(0, 0);
        //pos.z = 0;

        //transform.position = pos;
    }

    void OnMouseDown()
    {
        score.text = scoreCount.ToString();
        scoreCount++;
        float randomX = Random.Range(-8f, 8f);
        float randomY = Random.Range(-4.2f, 4.2f);
        pos = new Vector2(randomX, randomY);
        transform.position = pos;
    }
}
