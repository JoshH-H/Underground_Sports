using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoring : MonoBehaviour
{
    public int value = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Caber")
        {
            GlobalData.Scoring += value;
            GameObject.Find("GameBoss").GetComponent<GlobalData>().SetDistance();
        }
    }
}
