using UnityEngine;
using UnityEngine.UI;
public static class Score
{
    public static int score_num = 0;

    public static void IncreaseScore(Text Score_num)
    {
        Score.score_num++;
        Score_num.text = Score.score_num.ToString();

        if (Score.score_num > PlayerPrefs.GetInt("Highscore", 0))
        {
            PlayerPrefs.SetInt("Highscore", Score.score_num);
        }
    }
}