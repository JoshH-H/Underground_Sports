using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaberRun : MonoBehaviour
{

    public float HorizontalMoveSpeed = 0.01f;
    public bool canMove = true;
    
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
    
    /*private void OnTriggerEnter2D(Collider2D other)
    {
        Freezer();
        Debug.Log("slowed");
    }

    void Freezer()
    {
        HorizontalMoveSpeed = 0.00000000f;
        //sets character movement to 0
    }*/
}
