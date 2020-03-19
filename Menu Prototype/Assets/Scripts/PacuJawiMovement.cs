using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacuJawiMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float HorizontalMoveSpeed = 1f;
    public float VerticalMoveSpeed = 0.1f;
    
    Vector2 direction = new Vector2(1f, 0f);
    public bool activateMovement = true;

    private Rigidbody2D rb;


    private void Awake()
    {
        activateMovement = true;
    }
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //transform.position += Vector3.right * HorizontalMoveSpeed;
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKey(KeyCode.UpArrow))
       {
            transform.position += Vector3.up * VerticalMoveSpeed;
       }

       if (Input.GetKey(KeyCode.DownArrow))
       {
            transform.position += Vector3.down * VerticalMoveSpeed;
       }
    }

    void FixedUpdate()
    {
        if (activateMovement == true)
        {
            Movement();
        }
    }
    void Movement()
    {
        Vector2 movement = (direction).normalized * HorizontalMoveSpeed;
        rb.AddForce(movement);
    }

    IEnumerator OnTriggerEnter2D(Collider2D collision)
    {
            if (collision.gameObject.tag == ("Obstacle"))
            {
            activateMovement = false;
            yield return new WaitForSeconds(5);
            activateMovement = true;
            }
    }
    
    
}