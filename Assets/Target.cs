using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Target : MonoBehaviour
{
    public TMP_Text score;
    int scoreCount = 0;

    void OnMouseDown()
    {
        score.text = scoreCount.ToString();
        scoreCount++;
    }
}
