using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class DisplayScore : MonoBehaviour
{
    public TMP_Text scoreText;

    private void Update()
    {
        scoreText.text = "Score: " + ScoreManager.Score.ToString();
    }
}
