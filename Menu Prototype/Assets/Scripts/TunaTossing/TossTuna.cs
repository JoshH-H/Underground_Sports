using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TossTuna : MonoBehaviour
{
    private SpriteRenderer rend;
    private Rigidbody2D _tunaRb;
    public int speed;
    public float friction;
    public float lerpSpeed;
    public float torque;
    private float _xDegrees;
    private float _yDegrees;
    private Quaternion _fromRotation;
    private Quaternion _toRotation;
    private Animator Animation;
    private Animator Animation1;

    //public float rotateSpeed;
    public GameObject Char;
    public GameObject tuna;
    public float throwforce;
    public int powerMultiplier = 100;
    public Image fillImage;
    public GameObject meterBar;
    public GameObject holder;
    public GameObject barActivator;
    public GameObject gameOver;

    void Start()
    {
        Animation = Char.GetComponent<Animator>();
        Animation1 = meterBar.GetComponent<Animator>();
        _tunaRb = GetComponent<Rigidbody2D>();
        rend = this.gameObject.GetComponent<SpriteRenderer>();
        rend.enabled = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Animation.SetBool("Spin", true);
            StartCoroutine("spin");
        }

        if (!Input.anyKey)
        {
            Animation.SetBool("Spin", false);
            Animation1.SetInteger("Begin", 2);
        }
    }

    IEnumerator spin()
    {
        yield return new WaitForSeconds(2);
        Animation1.SetInteger("Begin", 1);
    }

    public void Launch()
    {
        rend.enabled = true;
        throwforce = fillImage.fillAmount * powerMultiplier;
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(transform.localScale.x, 1) * throwforce;

        _tunaRb.AddForce(new Vector3(15, 15, 0));
        _fromRotation = transform.rotation;
        _toRotation = Quaternion.Euler(_xDegrees, _yDegrees, 0);
        transform.rotation = Quaternion.Lerp(_fromRotation, _toRotation, Time.deltaTime * lerpSpeed);
        barActivator.SetActive(false);
        meterBar.SetActive(false);
        holder.SetActive(false);
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == ("Seagull"))
        {
            gameOver.SetActive(true);
            Time.timeScale = 0f;
            
        }
    }
}