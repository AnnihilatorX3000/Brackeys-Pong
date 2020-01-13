using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public KeyCode moveUp, moveDown;
    public float speed = 10;
    public Rigidbody2D rb;

    void Update()
    {
        if (Input.GetKey(moveUp))
        {
            rb.velocity = new Vector2(0, speed);
        }
        else if (Input.GetKey(moveDown))
        {
            rb.velocity = new Vector2(0, -speed);
        }
        else
        {
            rb.velocity = new Vector2(0, 0);
        }
    }
}
