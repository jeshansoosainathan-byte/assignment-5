using UnityEngine;

public class ScoreArea : MonoBehaviour
{
    public int scoreValue = 100;
    public Score score;



    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
        score.addScore(scoreValue);

    }










}
