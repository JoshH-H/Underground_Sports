using System.Collections;
using UnityEngine;

public class WCMovement : MonoBehaviour
{
    public float Speed;
    public float WaterSpeed;
    public float SlowerSpeed;

    public GameObject Water;

    public AnimationState idle;
    public bool GroundCheck = true;
    public bool InWater = false;

    private Rigidbody2D rb;
    private Animator animations;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        transform.position = new Vector2(-4.18f, 2.63f);
    }

    private void FixedUpdate()
    {
        Animations();
        CalculateMovement();
        StartCoroutine(GroundCheckRoutine());
    }

    IEnumerator GroundCheckRoutine()
    {
        if (Input.GetKeyDown(KeyCode.W) && GroundCheck == true)
        {
            GroundCheck = false;
            animations.SetBool("Jumping", true);
            float jumpVelocity = 10f;
            rb.velocity = Vector2.up * jumpVelocity;
            yield return new WaitForSeconds(1f);
            animations.SetBool("Jumping", false);
            GroundCheck = true;
        }

        if (Input.GetKeyDown(KeyCode.Space) && InWater == true)
        {
            Speed = WaterSpeed;
        }
        else if (Input.GetKeyUp(KeyCode.Space) && InWater == true)
        {
            Speed = 2;
        }
    }

    void CalculateMovement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * horizontalInput * Speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == Water)
        {
            InWater = true;
            Speed = 2;
        } 
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        InWater = false;
        Speed = 6;
    }

    public void Animations()
    {
        animations = GetComponent<Animator>();

        if (Input.anyKey)
        {
            animations.SetBool("Running", true);
        }

        if (!Input.anyKey)
        {
            animations.SetBool("Running", false);
        }
    }
}

