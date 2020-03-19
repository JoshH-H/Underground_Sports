using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WCGroundCheck : MonoBehaviour
{
    public GameObject Ground;
    public GameObject Player;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject == Ground)
        {
            transform.parent.GetComponent<WCMovement>().GroundCheck = true;
        }
        else
        {
            transform.parent.GetComponent<WCMovement>().GroundCheck = false;
        }
    }
}
