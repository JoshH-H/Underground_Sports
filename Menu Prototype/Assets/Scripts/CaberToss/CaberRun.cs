using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CaberRun : MonoBehaviour
{

    public float HorizontalMoveSpeed = 0.01f;
    public bool canMove = true;
    public Vector3 startPosition;

    private Animator Animation;
    
    /*private void Awake()
    {
        startPosition = transform.position;
    }*/
    void Update()
    {
        if (canMove == true)
        {
            if (Input.GetKey(KeyCode.D))
            {
                transform.position += Vector3.right * HorizontalMoveSpeed;
                //character movement
            }
        }

        StartCoroutine (Animations());
    }

    void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.tag == ("StopMoving"))
        {
            HorizontalMoveSpeed = 0f;
            Debug.Log("hti");
        }
    }
    
    public void Retry()
    {
        Scene loadedLevel = SceneManager.GetActiveScene ();
        SceneManager.LoadScene (loadedLevel.buildIndex);
        /*transform.position = startPosition;*/
    }

    public IEnumerator Animations()
    {
        Animation = GetComponent<Animator>();

        if (Input.anyKey)
        {
            Animation.SetBool("Moving", true);
        }

        if (Input.GetMouseButtonDown(0))
        {
            Animation.SetBool("Tossed", true);
            yield return new WaitForSeconds(2);
            Animation.SetBool("Relax", true);
        }

        if (!Input.anyKey)
        {
            Animation.SetBool("Moving", false);
        }
    }


}