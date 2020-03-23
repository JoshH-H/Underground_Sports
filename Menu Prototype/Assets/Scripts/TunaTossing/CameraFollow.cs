using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Vector2 _velocity;

    public float smoothTimeY;
    public float smoothTimeX;
    public GameObject obj;

    void Start()
    {
        obj = GameObject.FindGameObjectWithTag("Fish");
    }
    
    void FixedUpdate()
    {
        float posX = Mathf.SmoothDamp(transform.position.x, obj.transform.position.x, ref _velocity.x, smoothTimeX);
        float posy = Mathf.SmoothDamp(transform.position.y, obj.transform.position.y, ref _velocity.y, smoothTimeY);
        
        transform.position = new Vector3(posX, posy, transform.position.z);
    }
    
    
}
