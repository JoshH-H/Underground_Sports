using System.Collections;
using UnityEngine;

public class PacuJawiMovement : MonoBehaviour
{
    public bool activateMovement = true;
    public float Speed = 1;
    public float VerticalMoveSpeed = 0.1f;
    public float SpeedIncrease = 0.5f;

    public GameObject Boost;
    public GameObject Driver;
    public GameObject Player;

    private Rigidbody2D rb;
    private Animator Animation;
    Vector2 direction = new Vector2(1f, 0f);

    private void Awake()
    {
        activateMovement = false;
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Animation = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        Animation.SetBool("Moving", true);
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = direction * Speed;
        Speed += Time.deltaTime * SpeedIncrease;
        activateMovement = true;

        StartCoroutine(BoostRoutine());
        StartCoroutine(DriverHurtAnim());
    }

    void Update()
    {
       if (Input.GetKey(KeyCode.UpArrow) && activateMovement == true)
       {
            transform.position += Vector3.up * VerticalMoveSpeed;
       }

       if (Input.GetKey(KeyCode.DownArrow) && activateMovement == true)
       {
            transform.position += Vector3.down * VerticalMoveSpeed;
       }
    }

    private IEnumerator BoostRoutine()
    {
        Animation = Driver.GetComponent<Animator>();

        if (activateMovement == true)
        {
            yield return new WaitForSeconds(10);
            Boost.SetActive(true);
            Destroy(Boost, 3);
        }

        if (Input.GetKeyDown(KeyCode.Space) && Boost == true)
        {
            SpeedIncrease = 2;
            Animation.SetBool("BiteTail", true);
            yield return new WaitForSeconds(2);
            Animation.SetBool("BiteTail", false);
        }
    }


    IEnumerator DriverHurtAnim()
    {
        Animation = Driver.GetComponent<Animator>();

        if (Speed < 5)
        {
            Animation.SetBool("Hurting", true);
            yield return new WaitForSeconds(5);
            Animation.SetBool("Hurting", false);
        }

/*        else
        {
            Animation.SetBool("Moving", true);
        }*/
    }
}