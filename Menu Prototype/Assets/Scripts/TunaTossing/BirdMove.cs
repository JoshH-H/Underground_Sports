using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMove : MonoBehaviour
{
    public int Spood;
    
    void Update()
    {
        transform.position += transform.right * Time.deltaTime * Spood;
    }
}
