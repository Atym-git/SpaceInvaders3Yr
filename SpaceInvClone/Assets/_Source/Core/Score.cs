using TMPro;
using UnityEngine;

public class Score
{
    private int _currScore;

    private TextMeshProUGUI _scoreTMP;

    public Score(TextMeshProUGUI scoreTMP)
    {
        _scoreTMP = scoreTMP;
        DrawScore();
    }

    public void TakeScore(int score)
    {
        _currScore += score;
        DrawScore();
    }

    private void DrawScore()
    {
        _scoreTMP.text = "Score: " + _currScore.ToString();
    }
}
