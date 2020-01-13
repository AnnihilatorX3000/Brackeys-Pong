using UnityEngine;

public class GameManager : MonoBehaviour
{
    static int player1Score = 0;
    static int player2Score = 0;

    public GUISkin skinScore; 

    public static void IncrementScore(string wallName)
    {
        if (wallName == "Left Wall")
        {
            player2Score++;
            Debug.Log("Player 2 scored");
        }
        else if (wallName == "Right Wall")
        {
            player1Score++;
            Debug.Log("Player 1 scored");
        }
        Debug.Log("Current score: " + player1Score + " - " + player2Score) ;
    }

    void OnGUI()
    {
        GUI.skin = skinScore;
        GUI.Label(new Rect(Screen.width / 2 - 150, 20, 100, 100), "" + player1Score);
        GUI.Label(new Rect(Screen.width / 2 + 150, 20, 100, 100), "" + player2Score);
    }
}
