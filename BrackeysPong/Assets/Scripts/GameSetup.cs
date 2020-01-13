using UnityEngine;

public class GameSetup : MonoBehaviour
{
    public Camera cam;
    public BoxCollider2D top, btm, left, right;
    public Transform player1, player2;

    void Start()
    {
        //Dynamically sets the initial locations of walls
        top.size = new Vector2(cam.ScreenToWorldPoint(new Vector3(Screen.width, 0, 0)).x * 2, 1);
        top.offset = new Vector2(0, cam.ScreenToWorldPoint(new Vector3(0, Screen.height, 0)).y + 0.5f);

        btm.size = new Vector2(cam.ScreenToWorldPoint(new Vector3(Screen.width, 0, 0)).x * 2, 1);
        btm.offset = new Vector2(0, cam.ScreenToWorldPoint(new Vector3(0, 0, 0)).y - 0.5f);

        left.size = new Vector2(1, cam.ScreenToWorldPoint(new Vector3(0, Screen.height, 0)).y * 2);
        left.offset = new Vector2(cam.ScreenToWorldPoint(new Vector3(0, 0, 0)).x - 0.5f, 0);

        right.size = new Vector2(1, cam.ScreenToWorldPoint(new Vector3(0, Screen.height, 0)).y * 2);
        right.offset = new Vector2(cam.ScreenToWorldPoint(new Vector3(Screen.width, 0, 0)).x + 0.5f, 0);

        //Set player initial position
        player1.position = new Vector2(cam.ScreenToWorldPoint(new Vector3(75, 0, 0)).x, 0);
        player2.position = new Vector2(cam.ScreenToWorldPoint(new Vector3(Screen.width - 75, 0, 0)).x, 0);
    }
}
