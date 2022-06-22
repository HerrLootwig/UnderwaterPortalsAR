using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreHandler : MonoBehaviour
{
    public int score = 0;
    [SerializeField] private TMP_Text text;

    public void ShowScore()
    {
        score += 1;
        text.text = score.ToString();

    }
}
