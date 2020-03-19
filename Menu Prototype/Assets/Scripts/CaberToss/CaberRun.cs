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
    
    /*private void Awake()
    {
        startPosition = transform.position;
    }*/
    void Update()
    {
        if (canMove == true)
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.position += Vector3.right * HorizontalMoveSpeed;
                //character movement
            }
        }
    }

    void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.tag == ("StopMoving")){
            canMove = false;
            Debug.Log("hti");
        }
    }
    
    public void Retry()
    {
        Scene loadedLevel = SceneManager.GetActiveScene ();
        SceneManager.LoadScene (loadedLevel.buildIndex);
        /*transform.position = startPosition;*/
    }
    

}
