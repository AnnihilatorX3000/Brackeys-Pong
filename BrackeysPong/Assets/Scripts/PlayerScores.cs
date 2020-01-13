using UnityEngine;

public class PlayerScores : MonoBehaviour
{
    void OnTriggerEnter2D (Collider2D colliderInfo)
    {
        if (colliderInfo.tag == "Ball")
        {
            GameManager.IncrementScore(transform.name);
        } 
    }
}
