using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGlobalData : MonoBehaviour
{
    public GameObject Scotland;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && gameObject.tag == "scotland")
        {
            Scotland.SetActive(true);
            print("scotland");
        }
    }
}
