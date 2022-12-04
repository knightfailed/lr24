using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreUI : MonoBehaviour
{
    int Score,Diamond;
    public TMPro.TextMeshProUGUI ScoreText;
    public TMPro.TextMeshProUGUI DiamondText;

    public void IncrementScore( int value)
    {
        Score += value;
        UpdateDisplay();
    }

    public void IncrementDiamond(int value)
    {
        Diamond += value;
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        ScoreText.text = Score.ToString();
        DiamondText.text = Diamond.ToString();
    }
}
