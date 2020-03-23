using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TossTuna : MonoBehaviour
{
    private SpriteRenderer rend;
    public int speed;
    public float friction;
    public float lerpSpeed;
    public float torque;
    private float _xDegrees;
    private float _yDegrees;
    private Quaternion _fromRotation;
    private Quaternion _toRotation;

    //public float rotateSpeed;
    public GameObject tuna;
    private Rigidbody2D _tunaRb;
    public float throwforce;
    public int powerMultiplier = 100;
    public Image fillImage;
    public GameObject meterBar;
    public GameObject holder;
    public GameObject barActivator;

    void Start()
    {
        meterBar.SetActive(false);
        _tunaRb = GetComponent<Rigidbody2D>();
        rend = this.gameObject.GetComponent<SpriteRenderer>();
        rend.enabled = false;
        
        //StartCoroutine("showBar");
    }
    /*IEnumerator showBar()
    {
        yield return new WaitForSeconds(3);
        meterBar.SetActive(true);
        
    }*/

    public void Launch()
    {
        tuna.SetActive(true);
        throwforce = fillImage.fillAmount * powerMultiplier;
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(transform.localScale.x, 1) * throwforce;

        _tunaRb.AddForce (new Vector3(15, 15, 0));
        _fromRotation = transform.rotation;
        _toRotation = Quaternion.Euler(_xDegrees,_yDegrees, 0);
        transform.rotation = Quaternion.Lerp(_fromRotation, _toRotation, Time.deltaTime*lerpSpeed);
        // transform.Rotate (rotateSpeed,0,0);
        meterBar.SetActive(false);
        barActivator.SetActive(false);
        holder.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == ("StopMoving"))
        {
            meterBar.SetActive(true);

            Debug.Log("wehit");
        }
    }

    /*private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == ("StopMoving"))
        {
            meterBar.SetActive(false);
        }
    }*/
}
