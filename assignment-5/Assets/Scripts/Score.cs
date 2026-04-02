using UnityEngine;
using TMPro;
public class Score : MonoBehaviour
{

    private int totalScore = 0;
    public TMPro.TMP_Text text;
    public void addScore(int score)
    {
        totalScore += score;
        Debug.Log("Total Score: " + totalScore);
        text.text = "Score: " + totalScore; 
    }

    public int getScore()
    {
        return totalScore;
    }

}
