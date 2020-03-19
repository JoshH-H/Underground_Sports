using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThrowIt : MonoBehaviour
{

    public Image myImage;
    public float speed = 2.0f;
    public float waiting = 5.0f;
    public bool repeat;

    private void Awake()
    {
        repeat = true;
    }
    
    IEnumerator Start()
    {
        while (repeat)
        {
            yield return ChangeFill(0.0f, 1.0f, waiting);
            yield return ChangeFill(1.0f, 0.0f, waiting);
        }
    }

    public IEnumerator ChangeFill(float start, float end, float time)
    {
        float i = 0.0f;
        float rate = (1.0f / time) * speed;
        while (i< 1.0f)
        {
            i += Time.deltaTime * rate;
            myImage.fillAmount = Mathf.Lerp(start, end, i);
            yield return null;
        }
    }
    
}
