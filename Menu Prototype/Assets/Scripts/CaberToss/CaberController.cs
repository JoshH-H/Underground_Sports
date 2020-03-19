using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CaberController : MonoBehaviour
{

    public int speed;
    public float friction;
    public float lerpSpeed;
    public float torque;
    private float _xDegrees;
    private float _yDegrees;
    private Quaternion _fromRotation;
    private Quaternion _toRotation;

    //public float rotateSpeed;
    public GameObject caber;
    private Rigidbody2D _caberRb;
    public float throwforce;
    public int powerMultiplier = 100;
    public Image fillImage;
    public GameObject MeterBar;
    public GameObject Holder;
    public GameObject BarActivator;

    void Start()
    {
        _caberRb = GetComponent<Rigidbody2D>();
        MeterBar.SetActive(false);
    }

    /*
    void FixedUpdate()
    {
        float turn = Input.GetAxis("Horizontal");
        _caberRb.AddTorque(transform.up * torque * turn);
    }*/

    public void Launch()
    {
        throwforce = fillImage.fillAmount * powerMultiplier;
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(transform.localScale.x, 1) * throwforce;

        _caberRb.AddForce (new Vector3(15, 15, 0));
        _fromRotation = transform.rotation;
        _toRotation = Quaternion.Euler(_xDegrees,_yDegrees, 0);
        transform.rotation = Quaternion.Lerp(_fromRotation, _toRotation, Time.deltaTime*lerpSpeed);
       // transform.Rotate (rotateSpeed,0,0);
       MeterBar.SetActive(false);
       BarActivator.SetActive(false);
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == ("StopMoving"))
        {
            MeterBar.SetActive(true);
            Holder.SetActive(false);
            Debug.Log("wehit");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == ("StopMoving"))
        {
            MeterBar.SetActive(false);
        }
    }
}

