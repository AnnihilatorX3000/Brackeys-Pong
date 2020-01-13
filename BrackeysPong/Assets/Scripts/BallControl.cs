using UnityEngine;

public class BallControl : MonoBehaviour
{
    public Rigidbody2D ball;

    void Start()
    {
        //Decides which side to shoot ball towards to start
        float rand = Random.Range(0f,2f);
        if (rand < 1)
        {
            //Shoot left
            ball.AddForce(new Vector2(-80, 0));
        }
        else
        {
            //Shoot right
            ball.AddForce(new Vector2(80, 0));
        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.tag == "Player")
        {
            ball.AddForce(new Vector2(0, col.rigidbody.velocity.y/3));
        }
    }
}
