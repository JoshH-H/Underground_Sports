using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WCAI : MonoBehaviour
{
    public float Speed = 6;
    public float SlowerSpeed;

    public GameObject Water;
    public GameObject Goal;
    public GameObject Obstacle;
    public GameObject Obstacle2;
    public GameObject Player;

    Vector2 direction = new Vector2(1f, 0f);
    Rigidbody2D rb;
    Animator Animation;

    private void Start()
    {
        Animation = GetComponent<Animator>();
        Animation.SetBool("Running", true);
    }

    private void FixedUpdate()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = direction * Speed;  
        
        if (Speed == 0)
        {
            Animation.SetBool("Running", false);
        }
    }

    private IEnumerator OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == Water)
        {
            Speed = SlowerSpeed;
            yield return new WaitForSeconds(5);
            Speed = 6;
        }

        if (collision.gameObject == Goal)
        {
            Animation = GetComponent<Animator>();
            Animation.SetBool("Running", false);
            Player.GetComponent<WCMovement>().enabled = false;
            Player.GetComponent<Animator>().enabled = false;
            Speed = 0;
        }

        if (collision.gameObject == Obstacle)
        {
            Animation = GetComponent<Animator>();
            Animation.SetBool("Jumping", true);
            yield return new WaitForSeconds(0.3f);
            Animation.SetBool("Jumping", false);
            
        }

        if (collision.gameObject == Obstacle2)
        {
            Animation = GetComponent<Animator>();
            Animation.SetBool("Jumping", true);
            yield return new WaitForSeconds(0.3f);
            Animation.SetBool("Jumping", false);

        }
    }
}
